﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Valutavalto;
//
//    var valuta = Valuta.FromJson(jsonString);
 using System;
 using System.Collections.Generic;
 using System.Globalization;
 using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Valutavalto
{
    public partial class Valuta
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }
    }

    public partial class Valuta
    {
        public static Valuta FromJson(string json) => JsonConvert.DeserializeObject<Valuta>(json, Valutavalto.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Valuta self) => JsonConvert.SerializeObject(self, Valutavalto.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
