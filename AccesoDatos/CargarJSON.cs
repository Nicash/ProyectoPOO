using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AccesoDatos
{
    public class CargarJSON
    {
        private readonly string _directoryPath;

        public CargarJSON()
        {
            _directoryPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public T Cargar<T>(string nombreArchivo) where T : new()
        {
            string filePath = Path.Combine(_directoryPath, $"{nombreArchivo}.json");

            if (!File.Exists(filePath))
            {
                // Crear el archivo y devolver un objeto vacío
                File.WriteAllText(filePath, JsonConvert.SerializeObject(new T()));
                return new T();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }
}

