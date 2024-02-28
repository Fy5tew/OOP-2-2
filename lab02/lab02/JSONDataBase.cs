using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    internal class JSONDataBase<T> {
        public string DBFilePath { get; private set; }

        public JSONDataBase(string dbFilePath) {
            SetDBFilePath(dbFilePath);
        }

        public void Append(T item) {
            List<T> items = DeserializeDB();
            items.Add(item);
            SerializeDB(items);
        }

        public List<T> ReadAll() {
            return DeserializeDB();
        }

        private void SetDBFilePath(string dbFilePath) {
            if (!File.Exists(dbFilePath)) {
                File.Create(dbFilePath).Close();
            }
            DBFilePath = dbFilePath;
        }

        private string ReadFromDBFile() {
            return File.ReadAllText(DBFilePath);
        } 

        private void WriteToDBFile(string data) {
            File.WriteAllText(DBFilePath, data);
        }

        private string SerializeDBData(List<T> items) {
            return JsonConvert.SerializeObject(items, Formatting.Indented);
        }

        private List<T> DeserializeDBData(string data) {
            List<T> items = JsonConvert.DeserializeObject<List<T>>(data);
            if (items is null) {
                return new List<T>();
            }
            return items;
        }

        private void SerializeDB(List<T> items) {
            string serializedItems = SerializeDBData(items);
            WriteToDBFile(serializedItems);
        }

        private List<T> DeserializeDB() {
            string serializedItems = ReadFromDBFile();
            return DeserializeDBData(serializedItems);
        }
    }
}
