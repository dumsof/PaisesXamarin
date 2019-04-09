namespace Paises
{
    using Newtonsoft.Json;  

    public static class Extensiones
    {
        public static T DeserializeEntity<T>(this string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
