﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing.Slicer
{
    /// <summary>
    /// <para>Defines the Slicer Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is sle:slicer.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList" /> <c>&lt;sle:extLst></c></description></item>
    /// </list>
    /// </remarks>
    public partial class Slicer : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/drawing/2010/slicer", "slicer");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/drawing/2010/slicer", "CT_Slicer");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the Slicer class.
        /// </summary>
        public Slicer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Slicer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slicer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Slicer(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild(DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList.ElementType, static () => new DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList());
            builder.AddElement<Slicer>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList.ElementType, 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: sle:extLst.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:sle = http://schemas.microsoft.com/office/drawing/2010/slicer
        /// </remarks>
        public DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement(DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList.ElementType) as DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList;
            set => SetElement(value, DocumentFormat.OpenXml.Office2010.Drawing.Slicer.OfficeArtExtensionList.ElementType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicer>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is sle:extLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remarks>
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/drawing/2010/slicer", "extLst");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/drawingml/2006/main", "CT_OfficeArtExtensionList");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild(DocumentFormat.OpenXml.Drawing.Extension.ElementType, static () => new DocumentFormat.OpenXml.Drawing.Extension());
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(DocumentFormat.OpenXml.Drawing.Extension.ElementType, 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }
}