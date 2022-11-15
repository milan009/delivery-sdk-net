// <auto-generated>
// This code was generated by a kontent-generators-net tool
// (see https://github.com/kontent-ai/model-generator-net).
//
// Changes to this file will not be lost if the code is regenerated.
// It will maintain an up-to-date list of the Content types available
// </auto-generated>

using System;
using System.Collections.Generic;
using System.Linq;
using Kontent.Ai.Delivery.Abstractions;

namespace KontentAiModels
{
    public class CustomTypeProvider : ITypeProvider
    {
        protected static readonly Dictionary<Type, string> Codenames = new Dictionary<Type, string>
        {
            {typeof(Adwawed), "adwawed"},
            {typeof(Asset), "asset"},
            {typeof(DatetimeType), "datetime"},
            {typeof(Linked), "linked"},
            {typeof(Tobechangedafter), "tobechangedafter"},
            {typeof(UntitledContentType), "untitled_content_type"},
            {typeof(Withgroups), "withgroups"}
        };

        public virtual Type GetType(string contentType)
        {
            return Codenames.Keys.FirstOrDefault(type => GetCodename(type).Equals(contentType));
        }

        public virtual string GetCodename(Type contentType)
        {
            return Codenames.TryGetValue(contentType, out var codename) ? codename : null;
        }
    }
}