using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Geometry data
    /// </summary>
    public class Geometry
    {
        [JsonProperty("coordinates")]
        public double[][][][] Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Geopoint2d data
    /// </summary>
    public class Geopoint2d
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

    }
    /// <summary>
    /// Properties data
    /// </summary>
    public class Properties
    {
        [JsonProperty("gid")]
        public int Gid { get; set; }

        [JsonProperty("arealand")]
        public string Arealand { get; set; }

        [JsonProperty("division")]
        public int Division { get; set; }

        [JsonProperty("intptlat")]
        public double Intptlat { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectid")]
        public int Objectid { get; set; }

        [JsonProperty("areawater")]
        public string Areawater { get; set; }

        [JsonProperty("intptlon")]
        public double Intptlon { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("funcstat")]
        public string Funcstat { get; set; }

        [JsonProperty("centlon")]
        public double Centlon { get; set; }

        [JsonProperty("stusab")]
        public string Stusab { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("statens")]
        public string Statens { get; set; }

        [JsonProperty("centlat")]
        public double Centlat { get; set; }

        [JsonProperty("basename")]
        public string Basename { get; set; }

        [JsonProperty("mtfcc")]
        public string Mtfcc { get; set; }

        [JsonProperty("region")]
        public int Region { get; set; }

        [JsonProperty("lsadc")]
        public string Lsadc { get; set; }

        [JsonProperty("geoid")]
        public string Geoid { get; set; }

        [JsonProperty("geo_point_2d")]
        public Geopoint2d Geopoint2d { get; set; }

    }
    /// <summary>
    /// Features data
    /// </summary>
    public class Features
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public Features[] Features { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
