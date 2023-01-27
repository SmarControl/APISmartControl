using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISmartControl.Database
{
    // StruConfig myDeserializedClass = JsonConvert.DeserializeObject<StruConfig>(myJsonResponse);
    public class ConnectionStrings
    {
        public string? MYSQL_DBHOST { get; set; }
        public string? MYSQL_DBPORT { get; set; }
        public string? MYSQL_PASSWORD { get; set; }
        public string? MYSQL_USER { get; set; }
        public string? MYSQL_DATABASE { get; set; }
    }

    public class ConnectionStringsMySqlLocal
    {
        public string? DefaultConnection { get; set; }
    }

    public class Logging
    {
        public LogLevel? LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string? Default { get; set; }
        public string? Microsoft { get; set; }

        [JsonProperty("Microsoft.Hosting.Lifetime")]
        public string? MicrosoftHostingLifetime { get; set; }
    }

    public class StruConfig
    {
        public ConnectionStrings? ConnectionStrings { get; set; }
        public ConnectionStringsMySqlLocal? ConnectionStringsMySqlLocal { get; set; }
        public Logging? Logging { get; set; }
        public string? AllowedHosts { get; set; }
    }
}
