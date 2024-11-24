using Newtonsoft.Json;

namespace Patreon.Net.Models
{
    /// <summary>
    /// Mapping from user's connected app names to external user ID on the respective app.<para/>
    /// This type lacks official documentation so most unknown types have been defaulted to <see cref="object"/>.
    /// </summary>
    public class SocialConnections
    {
        /// <summary>
        /// Might be unsupported / obsolete meanwhile?
        /// </summary>
        [JsonProperty("deviantart")]
        public object DeviantArt { get; set; }

        public class DiscordConnection
        {
            [JsonProperty("scopes")]
            public string[] Scopes { get; set; }
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("user_id")]
            public ulong UserId { get; set; }
        }
        [JsonProperty("discord")]
        public DiscordConnection Discord { get; set; }
        [JsonProperty("facebook")]
        public object Facebook { get; set; }
        [JsonProperty("google")]
        public object Google { get; set; }
        [JsonProperty("instagram")]
        public object Instagram { get; set; }
        [JsonProperty("reddit")]
        public object Reddit { get; set; }
        [JsonProperty("spotify")]
        public object Spotify { get; set; }
        [JsonProperty("spotify_open_access")]
        public object SpotifyOpenAccess { get; set; }
        [JsonProperty("tiktok")]
        public object TikTok { get; set; }
        [JsonProperty("twitch")]
        public object Twitch { get; set; }
        [JsonProperty("twitter")]
        public object Twitter { get; set; }
        [JsonProperty("twitter2")]
        public object Twitter2 { get; set; }
        [JsonProperty("vimeo")]
        public object Vimeo { get; set; }
        [JsonProperty("youtube")]
        public object YouTube { get; set; }
    }
}
