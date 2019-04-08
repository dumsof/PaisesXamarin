

namespace Paises.Common.Config
{
    using Paises.Common.Config.Resources;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;

    public class GlobalConfig
    {
        /// <summary>
        /// Variable que contiene la URL del api.
        /// </summary>
        private static Uri _base_Url = new Uri(ConfigResources.Url);

        /// <summary>
        /// Variable con el SubscritionKey para consumir el api.
        /// </summary>
        private static string _subscription_Key = ConfigResources.Key;

        /// <summary>
        /// Variable que contiene el timeout.
        /// </summary>
        private static TimeSpan _timeOut = TimeSpan.FromSeconds(60);

        private static HttpClient httpClienConfig = new HttpClient { BaseAddress = Base_Url, Timeout = TimeOut };

        public static string Subscription_Key { get => _subscription_Key; set => _subscription_Key = value; }
        public static Uri Base_Url { get => _base_Url; set => _base_Url = value; }
        public static TimeSpan TimeOut { get => _timeOut; set => _timeOut = value; }
        public static HttpClient HttpClienConfig { get => httpClienConfig; set => httpClienConfig = value; }
    }
}
