// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// For further modifications of the class, create a separate file with the partial class.
// </auto-generated>

using System;
using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    public partial class Asset
    {
        public const string Codename = "asset";
        public const string UntitledAssetCodename = "untitled_asset";

        public IContentItemSystemAttributes System { get; set; }
        public IEnumerable<IAsset> UntitledAsset { get; set; }
    }
}