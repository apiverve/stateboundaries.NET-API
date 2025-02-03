using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class geometry
{
    [JsonProperty("coordinates")]
    public double[][][][] coordinates { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class geopoint2d
{
    [JsonProperty("lon")]
    public double lon { get; set; }

    [JsonProperty("lat")]
    public double lat { get; set; }

}

public class properties
{
    [JsonProperty("gid")]
    public int gid { get; set; }

    [JsonProperty("arealand")]
    public string arealand { get; set; }

    [JsonProperty("division")]
    public int division { get; set; }

    [JsonProperty("intptlat")]
    public double intptlat { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("objectid")]
    public int objectid { get; set; }

    [JsonProperty("areawater")]
    public string areawater { get; set; }

    [JsonProperty("intptlon")]
    public double intptlon { get; set; }

    [JsonProperty("oid")]
    public string oid { get; set; }

    [JsonProperty("funcstat")]
    public string funcstat { get; set; }

    [JsonProperty("centlon")]
    public double centlon { get; set; }

    [JsonProperty("stusab")]
    public string stusab { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("statens")]
    public string statens { get; set; }

    [JsonProperty("centlat")]
    public double centlat { get; set; }

    [JsonProperty("basename")]
    public string basename { get; set; }

    [JsonProperty("mtfcc")]
    public string mtfcc { get; set; }

    [JsonProperty("region")]
    public int region { get; set; }

    [JsonProperty("lsadc")]
    public string lsadc { get; set; }

    [JsonProperty("geoid")]
    public string geoid { get; set; }

    [JsonProperty("geo_point_2d")]
    public geopoint2d geopoint2d { get; set; }

}

public class features
{
    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("geometry")]
    public geometry geometry { get; set; }

    [JsonProperty("properties")]
    public properties properties { get; set; }

}

public class data
{
    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("features")]
    public features[] features { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
