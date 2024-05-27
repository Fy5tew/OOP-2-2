using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfPCLab {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private SqlConnection dbConenction = new SqlConnection(
                ConfigurationManager.ConnectionStrings["PCInfoDB"].ConnectionString
        );

        public MainWindow() {
            InitializeComponent();
            TabsTabControl.SelectionChanged += TabsTabControl_SelectionChanged;
        }

        private byte[] ConvertImageToBytes(ImageSource imageSource) {
            if (imageSource == null) {
                return null;
            }

            BitmapImage bitmapImage = (BitmapImage)imageSource;

            using (MemoryStream memoryStream = new MemoryStream()) {
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            dbConenction.Open();
        }

        private void Window_Closed(object sender, EventArgs e) {
            dbConenction.Close();
        }

        private void ViewDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e) {
            e.Column.Header = e.PropertyName.Replace("_", "__");

            if (e.PropertyType == typeof(byte[])) {
                // Создаем новый DataGridTemplateColumn вместо DataGridTextColumn
                DataGridTemplateColumn templateColumn = new DataGridTemplateColumn {
                    Header = e.Column.Header,
                    CellTemplate = new DataTemplate()
                };

                // Создаем DataTemplate
                var factory = new FrameworkElementFactory(typeof(Image));
                Binding binding = new Binding(e.PropertyName) {
                    Converter = new ByteArrayToImageConverter() // Используем конвертер для преобразования byte[] в ImageSource
                };
                factory.SetBinding(Image.SourceProperty, binding);
                templateColumn.CellTemplate.VisualTree = factory;
                templateColumn.Width = ViewDataGrid.MinColumnWidth;

                // Заменяем автоматически созданную колонку на нашу кастомную
                e.Column = templateColumn;
            }
        }

        private void TabsTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            UpdateView();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if (TabsTabControl.SelectedIndex == 0) {
                TabsTabControl.SelectedIndex = TabsTabControl.Items.Count - 1;
            }
            else {
                TabsTabControl.SelectedIndex--;
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e) {
            if (TabsTabControl.SelectedIndex == TabsTabControl.Items.Count - 1) {
                TabsTabControl.SelectedIndex = 0;
            }
            else {
                TabsTabControl.SelectedIndex++;
            }
        }

        private void ViewCommandResult(SqlCommand command) {
            ViewDataGrid.ItemsSource = null;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            ViewDataGrid.ItemsSource = dt.DefaultView;
        }

        private void UpdateView() {
            string tableName = (TabsTabControl.SelectedItem as TabItem).Header.ToString();
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM {tableName} ORDER BY ID; COMMIT TRAN;", dbConenction);
            try {
                ViewCommandResult(command);
            }
            catch {

            }
        }

        private void ShowError(string text) {
            MessageBox.Show(text, "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void OnlyInt_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!e.Text.All(char.IsDigit)) {
                e.Handled = true;
                return;
            }
        }

        private void OnlyFloat_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!(e.Text.All(char.IsDigit) || ",".Contains(e.Text))) {
                e.Handled = true;
                return;
            }
        }

        private void RamCreateButton_Click(object sender, RoutedEventArgs e) {
            if (RamCreateTypeComboBox.SelectedIndex == -1) {
                ShowError("RAM type is not specified");
                return;
            }
            if (!decimal.TryParse(RamCreateVolumeTextBox.Text, out _)) {
                ShowError("Incorerct RAM volume");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("INSERT INTO RAM(TYPE, VOLUME) VALUES (@Type, @Volume);", dbConenction);
                command.Parameters.AddWithValue("@Type", RamCreateTypeComboBox.Text);
                command.Parameters.AddWithValue("@Volume", decimal.Parse(RamCreateVolumeTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RamCreateTypeComboBox.SelectedIndex = -1;
            RamCreateVolumeTextBox.Clear();

            UpdateView();
        }

        private void RamUpdateButton_Click(object sender, RoutedEventArgs e) {
            object ramUpdType, ramUpdVolume;

            if (!int.TryParse(RamUpdateIdTextBox.Text, out _)) {
                ShowError("Incorrect RAM id");
                return;
            }
            if (RamUpdateTypeComboBox.SelectedIndex == -1) {
                ramUpdType = DBNull.Value;
            }
            else {
                ramUpdType = RamUpdateTypeComboBox.Text;
            }
            if (!decimal.TryParse(RamUpdateVolumeTextBox.Text, out _)) {
                ramUpdVolume = DBNull.Value;
            }
            else {
                ramUpdVolume = decimal.Parse(RamUpdateVolumeTextBox.Text);
            }

            try {
                SqlCommand command = new SqlCommand("UPDATE_RAM", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(RamUpdateIdTextBox.Text));
                command.Parameters.AddWithValue("@Type", ramUpdType);
                command.Parameters.AddWithValue("@Volume", ramUpdVolume);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RamUpdateIdTextBox.Clear();
            RamUpdateTypeComboBox.SelectedIndex = -1;
            RamUpdateVolumeTextBox.Clear();

            UpdateView();
        }

        private void RamDeleteButton_Click(object sender, RoutedEventArgs e) {
            if (!int.TryParse(RamDeleteIdTextBox.Text, out _)) {
                ShowError("Incorrect RAM id");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("DELETE_RAM", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(RamDeleteIdTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RamDeleteIdTextBox.Clear();

            UpdateView();
        }

        private void RomCreateButton_Click(object sender, RoutedEventArgs e) {
            if (RomCreateTypeComboBox.SelectedIndex == -1) {
                ShowError("ROM type is not specified");
                return;
            }
            if (!decimal.TryParse(RomCreateVolumeTextBox.Text, out _)) {
                ShowError("Incorerct ROM volume");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("CREATE_ROM", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Type", RomCreateTypeComboBox.Text);
                command.Parameters.AddWithValue("@Volume", decimal.Parse(RomCreateVolumeTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RomCreateTypeComboBox.SelectedIndex = -1;
            RomCreateVolumeTextBox.Clear();

            UpdateView();
        }

        private void RomUpdateButton_Click(object sender, RoutedEventArgs e) {
            object romUpdType, romUpdVolume;

            if (!int.TryParse(RomUpdateIdTextBox.Text, out _)) {
                ShowError("Incorrect ROM id");
                return;
            }
            if (RomUpdateTypeComboBox.SelectedIndex == -1) {
                romUpdType = DBNull.Value;
            }
            else {
                romUpdType = RomUpdateTypeComboBox.Text;
            }
            if (!decimal.TryParse(RomUpdateVolumeTextBox.Text, out _)) {
                romUpdVolume = DBNull.Value;
            }
            else {
                romUpdVolume = decimal.Parse(RomUpdateVolumeTextBox.Text);
            }

            try {
                SqlCommand command = new SqlCommand("UPDATE_ROM", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(RomUpdateIdTextBox.Text));
                command.Parameters.AddWithValue("@Type", romUpdType);
                command.Parameters.AddWithValue("@Volume", romUpdVolume);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RomUpdateIdTextBox.Clear();
            RomUpdateTypeComboBox.SelectedIndex = -1;
            RomUpdateVolumeTextBox.Clear();

            UpdateView();
        }

        private void RomDeleteButton_Click(object sender, RoutedEventArgs e) {
            if (!int.TryParse(RomDeleteIdTextBox.Text, out _)) {
                ShowError("Incorrect ROM id");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("DELETE_ROM", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(RomDeleteIdTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            RomDeleteIdTextBox.Clear();

            UpdateView();
        }

        private void CpuCreateButton_Click(object sender, RoutedEventArgs e) {
            if (CpuCreateManufacturerTextBox.Text.Length == 0) {
                ShowError("CPU manufacturer is not specified");
                return;
            }
            if (CpuCreateSeriesTextBox.Text.Length == 0) {
                ShowError("CPU series is not specified");
                return;
            }
            if (CpuCreateModelTextBox.Text.Length == 0) {
                ShowError("CPU model is not specified");
                return;
            }
            if (!int.TryParse(CpuCreateCoresTextBox.Text, out _)) {
                ShowError("Incorrect CPU cores count format");
                return;
            }
            if (!decimal.TryParse(CpuCreateMaxFriequencyTextBox.Text, out _)) {
                ShowError("Incorrect CPU max frequency format");
                return;
            }
            if (!decimal.TryParse(CpuCreateWorkingFriequencyTextBox.Text, out _)) {
                ShowError("Incorrect CPU working frequency format");
                return;
            }
            if (decimal.Parse(CpuCreateMaxFriequencyTextBox.Text) < decimal.Parse(CpuCreateWorkingFriequencyTextBox.Text)) {
                ShowError("CPU max frequency cannot be less than working frequency");
                return;
            }
            if (CpuCreateArchitectureTextBox.Text.Length == 0) {
                ShowError("CPU architecture is not defined");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("CREATE_CPU", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Manufacturer", CpuCreateManufacturerTextBox.Text);
                command.Parameters.AddWithValue("@Series", CpuCreateSeriesTextBox.Text);
                command.Parameters.AddWithValue("@Model", CpuCreateModelTextBox.Text);
                command.Parameters.AddWithValue("@Cores", int.Parse(CpuCreateCoresTextBox.Text));
                command.Parameters.AddWithValue("@MaxFrequency", decimal.Parse(CpuCreateMaxFriequencyTextBox.Text));
                command.Parameters.AddWithValue("@WorkingFrequency", decimal.Parse(CpuCreateWorkingFriequencyTextBox.Text));
                command.Parameters.AddWithValue("@Architecture", CpuCreateArchitectureTextBox.Text);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            CpuCreateManufacturerTextBox.Clear();
            CpuCreateSeriesTextBox.Clear();
            CpuCreateModelTextBox.Clear();
            CpuCreateCoresTextBox.Clear();
            CpuCreateMaxFriequencyTextBox.Clear();
            CpuCreateWorkingFriequencyTextBox.Clear();
            CpuCreateArchitectureTextBox.Clear();

            UpdateView();
        }

        private void CpuUpdateButton_Click(object sender, RoutedEventArgs e) {
            object cpuUpdManufacturer, cpuUpdSeries, cpuUpdModel, cpuUpdCores, cpuUpdMaxFr, cpuUpdWorkingFr, cpuUpdArchitecture;

            if (!int.TryParse(CpuUpdateIdTextBox.Text, out _)) {
                ShowError("Incorrect CPU id");
                return;
            }
            if (CpuUpdateManufacturerTextBox.Text.Length == 0) {
                cpuUpdManufacturer = DBNull.Value;
            }
            else {
                cpuUpdManufacturer = CpuUpdateManufacturerTextBox.Text;
            }
            if (CpuUpdateSeriesTextBox.Text.Length == 0) {
                cpuUpdSeries = DBNull.Value;
            }
            else {
                cpuUpdSeries= CpuUpdateSeriesTextBox.Text;
            }
            if (CpuUpdateModelTextBox.Text.Length == 0) {
                cpuUpdModel = DBNull.Value;
            }
            else {
                cpuUpdModel = CpuUpdateModelTextBox.Text;
            }
            if (!int.TryParse(CpuUpdateCoresTextBox.Text, out _)) {
                cpuUpdCores = DBNull.Value;
            }
            else {
                cpuUpdCores = int.Parse(CpuUpdateCoresTextBox.Text);
            }
            if (!decimal.TryParse(CpuUpdateMaxFriequencyTextBox.Text, out _)) {
                cpuUpdMaxFr = DBNull.Value;
            }
            else {
                cpuUpdMaxFr = decimal.Parse(CpuUpdateMaxFriequencyTextBox.Text);
            }
            if (!decimal.TryParse(CpuUpdateWorkingFriequencyTextBox.Text, out _)) {
                cpuUpdWorkingFr = DBNull.Value;
            }
            else {
                cpuUpdWorkingFr = decimal.Parse(CpuUpdateWorkingFriequencyTextBox.Text);
            }
            if (CpuUpdateArchitectureTextBox.Text.Length == 0) {
                cpuUpdArchitecture = DBNull.Value;
            }
            else {
                cpuUpdArchitecture = CpuUpdateArchitectureTextBox.Text;
            }

            try {
                SqlCommand command = new SqlCommand("UPDATE_CPU", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(CpuUpdateIdTextBox.Text));
                command.Parameters.AddWithValue("@Manufacturer", cpuUpdManufacturer);
                command.Parameters.AddWithValue("@Series", cpuUpdSeries);
                command.Parameters.AddWithValue("@Model", cpuUpdModel);
                command.Parameters.AddWithValue("@Cores", cpuUpdCores);
                command.Parameters.AddWithValue("@MaxFrequency", cpuUpdMaxFr);
                command.Parameters.AddWithValue("@WorkingFrequency", cpuUpdWorkingFr);
                command.Parameters.AddWithValue("@Architecture", cpuUpdArchitecture);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            CpuUpdateIdTextBox.Clear();
            CpuUpdateManufacturerTextBox.Clear();
            CpuUpdateSeriesTextBox.Clear();
            CpuUpdateModelTextBox.Clear();
            CpuUpdateCoresTextBox.Clear();
            CpuUpdateMaxFriequencyTextBox.Clear();
            CpuUpdateWorkingFriequencyTextBox.Clear();
            CpuUpdateArchitectureTextBox.Clear();

            UpdateView();
        }

        private void CpuDeleteButton_Click(object sender, RoutedEventArgs e) {
            if (!int.TryParse(CpuDeleteIdTextBox.Text, out _)) {
                ShowError("Incorrect CPU id");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("DELETE_CPU", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(CpuDeleteIdTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            CpuDeleteIdTextBox.Clear();

            UpdateView();
        }

        private void PcCreatePickPhotoButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            try {
                PcCreatePhotoPreview.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
            }
            catch {
                ShowError("Incorrect file format");
            }
        }

        private void PcCreateButton_Click(object sender, RoutedEventArgs e) {
            if (PcCreateNameTextBox.Text.Length == 0) {
                ShowError("PC name is not specified");
                return;
            }
            if (PcCreatePhotoPreview.Source == null) {
                ShowError("PC photo is not specified");
                return;
            }
            if (PcCreateTypeComboBox.SelectedIndex == -1) {
                ShowError("PC type is not specified");
                return;
            }
            if (!int.TryParse(PcCreateRamIdTextBox.Text, out _)) {
                ShowError("PC RAM id is not specified");
                return;
            }
            if (!int.TryParse(PcCreateRomIdTextBox.Text, out _)) {
                ShowError("PC ROM id is not specified");
                return;
            }
            if (!int.TryParse(PcCreateCpuIdTextBox.Text, out _)) {
                ShowError("PC CPU id is not specified");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("CREATE_PC", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", PcCreateNameTextBox.Text);
                command.Parameters.AddWithValue("@Photo", ConvertImageToBytes(PcCreatePhotoPreview.Source));
                command.Parameters.AddWithValue("@Type", PcCreateTypeComboBox.Text);
                command.Parameters.AddWithValue("@RamId", int.Parse(PcCreateRamIdTextBox.Text));
                command.Parameters.AddWithValue("@RomId", int.Parse(PcCreateRomIdTextBox.Text));
                command.Parameters.AddWithValue("@CpuId", int.Parse(PcCreateCpuIdTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            PcCreateNameTextBox.Clear();
            PcCreatePhotoPreview.Source = null;
            PcCreateTypeComboBox.SelectedIndex = -1;
            PcCreateRamIdTextBox.Clear();
            PcCreateRomIdTextBox.Clear();
            PcCreateCpuIdTextBox.Clear();

            UpdateView();
        }

        private void PcUpdatePickPhotoButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            try {
                PcUpdatePhotoPreview.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));
            }
            catch {
                ShowError("Incorrect file format");
            }
        }

        private void PcUpdateButton_Click(object sender, RoutedEventArgs e) {
            object pcUpdName, pcUpdPhoto, pcUpdType, pcUpdRamId, pcUpdRomId, pcUpdCpuId;

            if (!int.TryParse(PcUpdateIdTextBox.Text, out _)) {
                ShowError("Incorrect PC id");
                return;
            }
            if (PcUpdateNameTextBox.Text.Length == 0) {
                pcUpdName = DBNull.Value;
            }
            else {
                pcUpdName = PcUpdateNameTextBox.Text;
            }
            if (PcUpdatePhotoPreview.Source == null) {
                SqlCommand command = new SqlCommand($"SELECT PHOTO FROM PC WHERE ID = {int.Parse(PcUpdateIdTextBox.Text)};", dbConenction);
                using (SqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        pcUpdPhoto = reader["PHOTO"] as byte[];
                    }
                    else {
                        pcUpdPhoto = new byte[0];
                    }
                }
            }
            else {
                pcUpdPhoto = ConvertImageToBytes(PcUpdatePhotoPreview.Source);
            }
            if (PcUpdateTypeComboBox.SelectedIndex == -1) {
                pcUpdType = DBNull.Value;
            }
            else {
                pcUpdType = PcUpdateTypeComboBox.Text;
            }
            if (!int.TryParse(PcUpdateRamIdTextBox.Text, out _)) {
                pcUpdRamId = DBNull.Value;
            }
            else {
                pcUpdRamId = int.Parse(PcUpdateRamIdTextBox.Text);
            }
            if (!int.TryParse(PcUpdateRomIdTextBox.Text, out _)) {
                pcUpdRomId = DBNull.Value;
            }
            else {
                pcUpdRomId = int.Parse(PcUpdateRomIdTextBox.Text);
            }
            if (!int.TryParse(PcUpdateCpuIdTextBox.Text, out _)) {
                pcUpdCpuId = DBNull.Value;
            }
            else {
                pcUpdCpuId = int.Parse(PcUpdateCpuIdTextBox.Text);
            }

            try {
                SqlCommand command = new SqlCommand("UPDATE_PC", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(PcUpdateIdTextBox.Text));
                command.Parameters.AddWithValue("@Name", pcUpdName);
                command.Parameters.AddWithValue("@Photo", pcUpdPhoto);
                command.Parameters.AddWithValue("@Type", pcUpdType);
                command.Parameters.AddWithValue("@RamId", pcUpdRamId);
                command.Parameters.AddWithValue("@RomId", pcUpdRomId);
                command.Parameters.AddWithValue("@CpuId", pcUpdCpuId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            PcUpdateIdTextBox.Clear();
            PcUpdateNameTextBox.Clear();
            PcUpdatePhotoPreview.Source = null;
            PcUpdateTypeComboBox.SelectedIndex = -1;
            PcUpdateRamIdTextBox.Clear();
            PcUpdateRomIdTextBox.Clear();
            PcUpdateCpuIdTextBox.Clear();

            UpdateView();
        }

        private void PcDeleteButton_Click(object sender, RoutedEventArgs e) {
            if (!int.TryParse(PcDeleteIdTextBox.Text, out _)) {
                ShowError("Incorrect PC id");
                return;
            }

            try {
                SqlCommand command = new SqlCommand("DELETE_PC", dbConenction);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", int.Parse(PcDeleteIdTextBox.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex) {
                ShowError(ex.Message);
                return;
            }

            PcDeleteIdTextBox.Clear();

            UpdateView();
        }

        private void PcByNameAscBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM PC ORDER BY NAME ASC; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }

        private void PcByNameDescBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM PC ORDER BY NAME DESC; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }

        private void PcByCpuIdBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM PC ORDER BY CPU_ID; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }

        private void CpuByManufacturerBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM CPU ORDER BY MANUFACTURER; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }

        private void CpuBySeriesBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM CPU ORDER BY SERIES; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }

        private void CpuByModelBytton_Click(object sender, RoutedEventArgs e) {
            SqlCommand command = new SqlCommand($"BEGIN TRAN; SELECT * FROM CPU ORDER BY MODEL; COMMIT TRAN;", dbConenction);
            ViewCommandResult(command);
        }
    }
}
