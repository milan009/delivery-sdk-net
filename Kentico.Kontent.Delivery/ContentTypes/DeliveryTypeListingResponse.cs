﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.SharedModels;
using Newtonsoft.Json.Linq;

namespace Kentico.Kontent.Delivery.ContentTypes
{
    /// <inheritdoc cref="IDeliveryTypeListingResponse" />
    public sealed class DeliveryTypeListingResponse : AbstractResponse, IDeliveryTypeListingResponse
    {
        private readonly Lazy<Pagination> _pagination;
        private readonly Lazy<IReadOnlyList<ContentType>> _types;

        /// <inheritdoc/>
        public IPagination Pagination => _pagination.Value;

        /// <inheritdoc/>
        public IReadOnlyList<IContentType> Types => _types.Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryTypeListingResponse"/> class.
        /// </summary>
        /// <param name="response">The response from Kentico Kontent Delivery API that contains a list of content types.</param>
        internal DeliveryTypeListingResponse(ApiResponse response) : base(response)
        {
            _pagination = new Lazy<Pagination>(() => response.JsonContent["pagination"].ToObject<Pagination>(), LazyThreadSafetyMode.PublicationOnly);
            _types = new Lazy<IReadOnlyList<ContentType>>(() => ((JArray)response.JsonContent["types"]).Select(source => new ContentType(source)).ToList().AsReadOnly(), LazyThreadSafetyMode.PublicationOnly);
        }
    }
}