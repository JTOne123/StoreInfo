﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.StoreInfo
{
    internal class AppStoreLookupRoot
    {
        [JsonProperty("resultCount")]
        public long ResultCount { get; set; }

        [JsonProperty("results")]
        public List<AppStoreLookupResult> LookupResults { get; set; }
    }

    internal class AppStoreLookupResult
    {
        [JsonProperty("currentVersionReleaseDate")]
        public DateTimeOffset CurrentVersionReleaseDate { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("trackViewUrl")]
        public Uri TrackViewUrl { get; set; }
    }
}
