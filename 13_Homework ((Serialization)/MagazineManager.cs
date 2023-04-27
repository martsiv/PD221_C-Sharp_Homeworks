using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
#pragma warning disable SYSLIB0011
namespace _13_Homework___Serialization_
{
    [Serializable]
    internal class MagazineManager : IEnumerable
    {
        private List<Magazine> _magazines = new List<Magazine>();

        public void AddMagazine(Magazine magazine)
        {
            _magazines.Add(magazine);
        }
        public void DisplayMagazines()
        {
            foreach (var magazine in _magazines)
            {
                magazine.DisplayInfo();
                Console.WriteLine();
            }
        }
        public void SirializeMagazine(string filename)
        {
            //string json = JsonSerializer.Serialize(_magazines);
            //File.WriteAllText(filename, json);
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fs = File.Create(filename))
            {
                formatter.Serialize(fs, _magazines);
            }
        }
        public void DeserializeMagazine(string filename)
        {
            //string jsonResult = File.ReadAllText(filename);
            //_magazines = JsonSerializer.Deserialize<List<Magazine>>(jsonResult);
            //if (_magazines == null)
            //    Console.WriteLine("Magazine == null after deserialization");
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fs = File.OpenRead(filename))
            {
                _magazines = (List<Magazine>)formatter.Deserialize(fs);
            }
        }
        public void ClearMagazine()
        {
            _magazines.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_magazines).GetEnumerator();
        }
    }
}
