using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfShop.UserControls {
    /// <summary>
    /// Логика взаимодействия для UserRE.xaml
    /// </summary>
    public partial class UserRE : UserControl {
        public static readonly RoutedEvent MouseEvent = EventManager.RegisterRoutedEvent(
            "MouseDown",
            RoutingStrategy.Bubble,
            typeof(RoutedEventHandler),
            typeof(UserRE)
        );

        public static readonly RoutedEvent MouseEvent2 = EventManager.RegisterRoutedEvent(
            "PrevieMouseMove",
            RoutingStrategy.Tunnel,
            typeof(RoutedEventHandler),
            typeof(UserRE)
        );

        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
            "Click",
            RoutingStrategy.Direct,
            typeof(RoutedEventHandler),
            typeof(UserRE)
        );

        public static readonly DependencyProperty ButtonProperty = DependencyProperty.Register(
            "AuthorInfo",
            typeof(string),
            typeof(UserRE),
            new FrameworkPropertyMetadata(
                "Турчинович Никита",
                FrameworkPropertyMetadataOptions.AffectsRender,
                null,
                new CoerceValueCallback(CoerceText)
                ),
            new ValidateValueCallback(IsValid)
        );

        public UserRE() {
            InitializeComponent();
        }

        private static object CoerceText(DependencyObject d, object value) {
            string val = (string)value;
            if (val.Length > 100) val.Substring(0, 10);
            return val.ToString();
        }

        public event RoutedEventHandler PreviewMouseMove {
            add { base.AddHandler(UserRE.MouseEvent2, value); }
            remove { base.RemoveHandler(UserRE.MouseEvent2, value); }
        }

        public event RoutedEventHandler MouseDown {
            add { base.AddHandler(UserRE.MouseEvent, value); }
            remove { base.RemoveHandler(UserRE.MouseEvent, value); }
        }

        public event RoutedEventHandler Click {
            add { base.AddHandler(UserRE.ClickEvent, value); }
            remove { base.RemoveHandler(UserRE.ClickEvent, value); }
        }

        public string AuthorInfo {
            get { return (string)GetValue(ButtonProperty); }
            set { SetValue(ButtonProperty, value); }
        }

        private static bool IsValid(object value) {
            string val = (string)value;
            return !string.IsNullOrEmpty(val);
        }

        private void button1_Click(object sender, RoutedEventArgs e) {
            if (directRad.IsChecked == true) {
                MessageBox.Show(AuthorInfo + '\n' + sender.ToString() + '\n' + e.Source.ToString() + "\n\n", "Информация об авторе-Direct");
            }
        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e) {
            if (bubbleRad.IsChecked == true) {
                MessageBox.Show(AuthorInfo + '\n' + sender.ToString() + '\n' + e.Source.ToString() + "\n\n", "Информация об авторе-Bubble");
            }
        }

        private void Control_PreviewMouseMove(object sender, MouseEventArgs e) {
            if (tunnleRad.IsChecked == true) {
                MessageBox.Show(AuthorInfo + '\n' + sender.ToString() + '\n' + e.Source.ToString() + "\n\n", "Информация об авторе-Tunnle");
            }
        }
    }
}
