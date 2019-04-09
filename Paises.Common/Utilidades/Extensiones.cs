using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Paises
{
    public static class Extensiones
    {
        //public static DeserializeEntity<T>(string json){
        //    }

      

        public static T Deserialize<T>(this string jsonString)
        {

            using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                return (T)serializer.ReadObject(ms);
            }
        }
    }
}
