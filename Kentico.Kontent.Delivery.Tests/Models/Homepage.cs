using System.Collections.Generic;
using Kentico.Kontent.Delivery.Models;
using Kentico.Kontent.Delivery.Models.Item;

namespace Kentico.Kontent.Delivery.Tests.Models
{
    public class Homepage
    {
        public string CallToAction { get; set; }
        public string Subtitle { get; set; }
        public IEnumerable<Asset> Image { get; set; }
        public IEnumerable<TaxonomyTerm> UntitledTaxonomyGroup { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}