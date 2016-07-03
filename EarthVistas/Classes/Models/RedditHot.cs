using System.Collections.Generic;
using Newtonsoft.Json;

namespace EarthVistas
{

    public class MediaEmbed
    {
        [JsonProperty("content")]
        public string content { get; set; }
        [JsonProperty("width")]
        public int? width { get; set; }
        [JsonProperty("scrolling")]
        public bool? scrolling { get; set; }
        [JsonProperty("height")]
        public int? height { get; set; }
    }

    public class Oembed
    {
        [JsonProperty("provider_url")]
        public string provider_url { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("thumbnail_width")]
        public int thumbnail_width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("html")]
        public string html { get; set; }
        [JsonProperty("version")]
        public string version { get; set; }
        [JsonProperty("provider_name")]
        public string provider_name { get; set; }
        [JsonProperty("thumbnail_url")]
        public string thumbnail_url { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("thumbnail_height")]
        public int thumbnail_height { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("author_name")]
        public string author_name { get; set; }
        [JsonProperty("author_url")]
        public string author_url { get; set; }
    }

    public class SecureMedia
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("oembed")]
        public Oembed oembed { get; set; }
    }

    public class Oembed2
    {
        [JsonProperty("provider_url")]
        public string provider_url { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("thumbnail_width")]
        public int thumbnail_width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("html")]
        public string html { get; set; }
        [JsonProperty("version")]
        public string version { get; set; }
        [JsonProperty("provider_name")]
        public string provider_name { get; set; }
        [JsonProperty("thumbnail_url")]
        public string thumbnail_url { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("thumbnail_height")]
        public int thumbnail_height { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("author_name")]
        public string author_name { get; set; }
        [JsonProperty("author_url")]
        public string author_url { get; set; }
    }

    public class Media
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("oembed")]
        public Oembed2 oembed { get; set; }
    }

    public class Source
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Resolution
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Source2
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Resolution2
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Gif
    {
        [JsonProperty("source")]
        public Source2 source { get; set; }
        [JsonProperty("resolutions")]
        public List<Resolution2> resolutions { get; set; }
    }

    public class Source3
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Resolution3
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height { get; set; }
    }

    public class Mp4
    {
        [JsonProperty("source")]
        public Source3 source { get; set; }
        [JsonProperty("resolutions")]
        public List<Resolution3> resolutions { get; set; }
    }

    public class Variants
    {
        [JsonProperty("gif")]
        public Gif gif { get; set; }
        [JsonProperty("mp4")]
        public Mp4 mp4 { get; set; }
    }

    public class Image
    {
        [JsonProperty("source")]
        public Source source { get; set; }
        [JsonProperty("resolutions")]
        public List<Resolution> resolutions { get; set; }
        [JsonProperty("variants")]
        public Variants variants { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
    }

    public class Preview
    {
        [JsonProperty("images")]
        public List<Image> images { get; set; }
    }

    public class SecureMediaEmbed
    {
        [JsonProperty("content")]
        public string content { get; set; }
        [JsonProperty("width")]
        public int? width { get; set; }
        [JsonProperty("scrolling")]
        public bool? scrolling { get; set; }
        [JsonProperty("height")]
        public int? height { get; set; }
    }

    public class Data2
    {
        [JsonProperty("domain")]
        public string domain { get; set; }
        [JsonProperty("banned_by")]
        public object banned_by { get; set; }
        [JsonProperty("media_embed")]
        public MediaEmbed media_embed { get; set; }
        [JsonProperty("subreddit")]
        public string subreddit { get; set; }
        [JsonProperty("selftext_html")]
        public string selftext_html { get; set; }
        [JsonProperty("selftext")]
        public string selftext { get; set; }
        [JsonProperty("likes")]
        public object likes { get; set; }
        [JsonProperty("suggested_sort")]
        public string suggested_sort { get; set; }
        [JsonProperty("user_reports")]
        public List<object> user_reports { get; set; }
        [JsonProperty("secure_media")]
        public SecureMedia secure_media { get; set; }
        [JsonProperty("link_flair_text")]
        public string link_flair_text { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("from_kind")]
        public object from_kind { get; set; }
        [JsonProperty("glided")]
        public int gilded { get; set; }
        [JsonProperty("archived")]
        public bool archived { get; set; }
        [JsonProperty("clicked")]
        public bool clicked { get; set; }
        [JsonProperty("report_reasons")]
        public object report_reasons { get; set; }
        [JsonProperty("author")]
        public string author { get; set; }
        [JsonProperty("media")]
        public Media media { get; set; }
        [JsonProperty("score")]
        public int score { get; set; }
        [JsonProperty("approved_by")]
        public object approved_by { get; set; }
        [JsonProperty("over_18")]
        public bool over_18 { get; set; }
        [JsonProperty("hidden")]
        public bool hidden { get; set; }
        [JsonProperty("preview")]
        public Preview preview { get; set; }
        [JsonProperty("num_comments")]
        public int num_comments { get; set; }
        [JsonProperty("thumbnail")]
        public string thumbnail { get; set; }
        [JsonProperty("subreddit_id")]
        public string subreddit_id { get; set; }
        [JsonProperty("hide_score")]
        public bool hide_score { get; set; }
        [JsonProperty("edited")]
        public bool edited { get; set; }
        [JsonProperty("link_flair_css_class")]
        public string link_flair_css_class { get; set; }
        [JsonProperty("author_flair_css_class")]
        public string author_flair_css_class { get; set; }
        [JsonProperty("downs")]
        public int downs { get; set; }
        [JsonProperty("secure_media_embed")]
        public SecureMediaEmbed secure_media_embed { get; set; }
        [JsonProperty("saved")]
        public bool saved { get; set; }
        [JsonProperty("removal_reason")]
        public object removal_reason { get; set; }
        [JsonProperty("post_hint")]
        public string post_hint { get; set; }
        [JsonProperty("stickied")]
        public bool stickied { get; set; }
        [JsonProperty("from")]
        public object from { get; set; }
        [JsonProperty("is_self")]
        public bool is_self { get; set; }
        [JsonProperty("from_id")]
        public object from_id { get; set; }
        [JsonProperty("permalink")]
        public string permalink { get; set; }
        [JsonProperty("locked")]
        public bool locked { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("created")]
        public double created { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("author_flair_text")]
        public string author_flair_text { get; set; }
        [JsonProperty("quarantine")]
        public bool quarantine { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("created_utc")]
        public double created_utc { get; set; }
        [JsonProperty("distinguished")]
        public object distinguished { get; set; }
        [JsonProperty("mod_reports")]
        public List<object> mod_reports { get; set; }
        [JsonProperty("visited")]
        public bool visited { get; set; }
        [JsonProperty("num_reports")]
        public object num_reports { get; set; }
        [JsonProperty("ups")]
        public int ups { get; set; }
    }

    public class Child
    {
        [JsonProperty("kind")]
        public string kind { get; set; }
        [JsonProperty("data")]
        public Data2 data { get; set; }
    }

    public class Data
    {
        [JsonProperty("modhash")]
        public string modhash { get; set; }
        public List<Child> children { get; set; }
        [JsonProperty("after")]
        public string after { get; set; }
        [JsonProperty("before")]
        public object before { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("kind")]
        public string kind { get; set; }
        [JsonProperty("data")]
        public Data data { get; set; }
    }

}