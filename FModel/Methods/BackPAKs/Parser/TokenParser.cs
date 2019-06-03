﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using FModel.Methods.BackupPAKs.Parser.ExchangeTokenParser;
//
//    var TokenParser = ExchangeTokenParser.FromJson(jsonString);

namespace FModel.Methods.BackupPAKs.Parser.TokenParser
{
    using System;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class TokenParser
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty("expires_at")]
        public DateTimeOffset ExpiresAt { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("refresh_expires")]
        public long RefreshExpires { get; set; }

        [JsonProperty("refresh_expires_at")]
        public DateTimeOffset RefreshExpiresAt { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("internal_client")]
        public bool InternalClient { get; set; }

        [JsonProperty("client_service")]
        public string ClientService { get; set; }

        [JsonProperty("perms")]
        public Perm[] Perms { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("in_app_id")]
        public string InAppId { get; set; }
    }

    public partial class Perm
    {
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("action")]
        public long Action { get; set; }
    }

    public partial class TokenParser
    {
        public static TokenParser FromJson(string json) => JsonConvert.DeserializeObject<TokenParser>(json, FModel.Methods.BackupPAKs.Parser.TokenParser.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TokenParser self) => JsonConvert.SerializeObject(self, FModel.Methods.BackupPAKs.Parser.TokenParser.Converter.Settings);
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