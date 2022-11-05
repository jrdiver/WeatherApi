using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherApi.Objects.SubObjects;

public class Properties
{
    [JsonProperty("@id")]
    public string AlertId { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("areaDesc")]
    public string AreaDesc { get; set; }

    [JsonProperty("geocode")]
    public Geocode Geocode { get; set; }

    [JsonProperty("affectedZones")]
    public List<string> AffectedZones { get; set; }

    [JsonProperty("references")]
    public List<Reference> References { get; set; }

    [JsonProperty("sent")]
    public DateTime Sent { get; set; }

    [JsonProperty("effective")]
    public DateTime Effective { get; set; }

    [JsonProperty("onset")]
    public DateTime Onset { get; set; }

    [JsonProperty("expires")]
    public DateTime Expires { get; set; }

    [JsonProperty("ends")]
    public DateTime? Ends { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("messageType")]
    public string MessageType { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("severity")]
    public string Severity { get; set; }

    [JsonProperty("certainty")]
    public string Certainty { get; set; }

    [JsonProperty("urgency")]
    public string Urgency { get; set; }

    [JsonProperty("event")]
    public string Event { get; set; }

    [JsonProperty("sender")]
    public string Sender { get; set; }

    [JsonProperty("senderName")]
    public string SenderName { get; set; }

    [JsonProperty("headline")]
    public string Headline { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("instruction")]
    public string Instruction { get; set; }

    [JsonProperty("response")]
    public string Response { get; set; }

    [JsonProperty("parameters")]
    public Parameters Parameters { get; set; }
}