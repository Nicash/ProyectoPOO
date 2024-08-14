using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AccesoDatos
{
    public class EscribirJSON
    {
        private readonly string _directoryPath;

        public EscribirJSON()
        {
            _directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void Guardar<T>(string nombreArchivo, T objeto)
        {
            string filePath = Path.Combine(_directoryPath, $"{nombreArchivo}.json");
            string jsonData = JsonConvert.SerializeObject(objeto, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
    }
}

