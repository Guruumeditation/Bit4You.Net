﻿using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class OrderInfoResponse
    {
        [JsonPropertyName("txid")]
        public string Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("isOpen")]
        public bool IsOpen { get; set; }
        [JsonPropertyName("requested_rate")]
        public float? RequestedRate { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("base_quantity")]
        public float BaseQuantity { get; set; }
        [JsonPropertyName("blocked_quantity")]
        public int BlockedQuantity { get; set; }
        [JsonPropertyName("remaining")]
        public RemainingResponse Remaining { get; set; }
        [JsonPropertyName("fee")]
        public FeeResponse Fee { get; set; }
        [JsonPropertyName("position")]
        public PositionResponse Position { get; set; }
        [JsonPropertyName("open_time")]
        public int OpenTime { get; set; }
        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }
    }

    public class RemainingResponse
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
    }

    public class FeeResponse
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
    }

    public class PositionResponse
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("iso")]
        public object HistoryId { get; set; }
    }
}


