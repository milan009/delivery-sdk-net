// This code was generated by a kontent-generators-net tool 
// (see https://github.com/kontent-ai/model-generator-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace Kontent.Ai.Delivery.Tests.Models.ContentTypes
{
    public class ArticleWithImplementedTypes
    {
        public const string Codename = "article";
        public const string PersonasCodename = "personas";
        public const string TitleCodename = "title";
        public const string TeaserImageCodename = "teaser_image";
        public const string PostDateCodename = "post_date";
        public const string SummaryCodename = "summary";
        public const string BodyCopyCodename = "body_copy";
        public const string RelatedArticlesCodename = "related_articles";
        public const string MetaKeywordsCodename = "meta_keywords";
        public const string MetaDescriptionCodename = "meta_description";
        public const string UrlPatternCodename = "url_pattern";

        public IEnumerable<ITaxonomyTerm> Personas { get; set; }
        public string Title { get; set; }
        public IEnumerable<IAsset> TeaserImage { get; set; }
        public DateTime? PostDate { get; set; }
        public string Summary { get; set; }
        public IRichTextContent BodyCopy { get; set; }
        public IEnumerable<object> RelatedArticles { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string UrlPattern { get; set; }
        public IContentItemSystemAttributes System { get; set; }
    }
}