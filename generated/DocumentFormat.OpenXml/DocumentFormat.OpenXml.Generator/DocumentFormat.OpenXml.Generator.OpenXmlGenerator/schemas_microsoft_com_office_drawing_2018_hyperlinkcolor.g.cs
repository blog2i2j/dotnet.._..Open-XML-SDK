﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor
{
    /// <summary>
    /// <para>Defines the HyperlinkColor Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ahyp:hlinkClr.</para>
    /// </summary>
    public partial class HyperlinkColor : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/drawing/2018/hyperlinkcolor", "hlinkClr");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/drawing/2018/hyperlinkcolor", "CT_HyperlinkColor");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the HyperlinkColor class.
        /// </summary>
        public HyperlinkColor() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<HyperlinkColor>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkColor>(deep);
    }

    /// <summary>
    /// Defines the HyperlinkColorEnum enumeration.
    /// </summary>
    public readonly record struct HyperlinkColorEnum : IEnumValue, IEnumValueFactory<HyperlinkColorEnum>
    {
        private readonly string? _value;
        /// <summary>
        /// Creates a new HyperlinkColorEnum enum instance
        /// </summary>
        public HyperlinkColorEnum(string value) => _value = value;
        HyperlinkColorEnum IEnumValueFactory<HyperlinkColorEnum>.Create(string name) => new(name);
        bool IEnumValue.IsValid => InternalValue switch
        {
            "hlink" => true,
            "tx" => true,
            _ => false
        };
        string IEnumValue.Value => InternalValue;
        private string InternalValue => _value ?? "hlink";
        FileFormatVersions IEnumValue.Version => FileFormatVersions.Office2019;
        /// <summary>
        /// hlink.
        /// <para>When the item is serialized out as xml, its value is "hlink".</para>
        /// </summary>
        public static HyperlinkColorEnum HLink => new("hlink");
        /// <summary>
        /// tx.
        /// <para>When the item is serialized out as xml, its value is "tx".</para>
        /// </summary>
        public static HyperlinkColorEnum Tx => new("tx");
    
    }
}