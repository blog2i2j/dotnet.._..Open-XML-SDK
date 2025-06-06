﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the XmlSignaturePart
    /// </summary>
    public partial class XmlSignaturePart : OpenXmlPart,
        IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/package/2006/relationships/digital-signature/signature";

        /// <summary>
        /// Creates an instance of the XmlSignaturePart OpenXmlType
        /// </summary>
        internal XmlSignaturePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "sig";
            string ITargetFeature.Path => "_xmlsignatures";
        }
    
    }
}
