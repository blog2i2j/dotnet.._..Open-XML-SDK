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
    /// Defines the CustomXmlPart
    /// </summary>
    public partial class CustomXmlPart : OpenXmlPart
    {
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml";

        /// <summary>
        /// Creates an instance of the CustomXmlPart OpenXmlType
        /// </summary>
        internal CustomXmlPart()
        {
        }

        /// <summary>
        /// Gets the CustomXmlPropertiesPart of the CustomXmlPart
        /// </summary>
        public CustomXmlPropertiesPart? CustomXmlPropertiesPart => GetSubPartOfType<CustomXmlPropertiesPart>();

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "item";
            string ITargetFeature.Path => "../customXml";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXmlProps", "application/vnd.openxmlformats-officedocument.customXmlProperties+xml", false, false, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
        }
    
    }
}
