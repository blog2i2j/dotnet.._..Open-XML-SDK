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
    /// Defines the NotesMasterPart
    /// </summary>
    public partial class NotesMasterPart : OpenXmlPart,
        IFixedContentTypePart,
        ISupportedRelationship<CustomXmlPart>,
        ISupportedRelationship<EmbeddedControlPersistenceBinaryDataPart>,
        ISupportedRelationship<EmbeddedObjectPart>,
        ISupportedRelationship<EmbeddedPackagePart>,
        ISupportedRelationship<ImagePart>
    {
        internal const string ContentTypeConstant = "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml";
        internal const string RelationshipTypeConstant = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/notesMaster";
        private DocumentFormat.OpenXml.Presentation.NotesMaster? _rootElement;

        /// <summary>
        /// Creates an instance of the NotesMasterPart OpenXmlType
        /// </summary>
        internal NotesMasterPart()
        {
        }

        /// <summary>
        /// Gets the ChartParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<ChartPart> ChartParts => GetPartsOfType<ChartPart>();

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <summary>
        /// Gets the CustomXmlParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<CustomXmlPart> CustomXmlParts => GetPartsOfType<CustomXmlPart>();

        /// <summary>
        /// Gets the DiagramColorsParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<DiagramColorsPart> DiagramColorsParts => GetPartsOfType<DiagramColorsPart>();

        /// <summary>
        /// Gets the DiagramDataParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<DiagramDataPart> DiagramDataParts => GetPartsOfType<DiagramDataPart>();

        /// <summary>
        /// Gets the DiagramLayoutDefinitionParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<DiagramLayoutDefinitionPart> DiagramLayoutDefinitionParts => GetPartsOfType<DiagramLayoutDefinitionPart>();

        /// <summary>
        /// Gets the DiagramPersistLayoutParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<DiagramPersistLayoutPart> DiagramPersistLayoutParts => GetPartsOfType<DiagramPersistLayoutPart>();

        /// <summary>
        /// Gets the DiagramStyleParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<DiagramStylePart> DiagramStyleParts => GetPartsOfType<DiagramStylePart>();

        /// <summary>
        /// Gets the EmbeddedControlPersistenceBinaryDataParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<EmbeddedControlPersistenceBinaryDataPart> EmbeddedControlPersistenceBinaryDataParts => GetPartsOfType<EmbeddedControlPersistenceBinaryDataPart>();

        /// <summary>
        /// Gets the EmbeddedObjectParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<EmbeddedObjectPart> EmbeddedObjectParts => GetPartsOfType<EmbeddedObjectPart>();

        /// <summary>
        /// Gets the EmbeddedPackageParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<EmbeddedPackagePart> EmbeddedPackageParts => GetPartsOfType<EmbeddedPackagePart>();

        /// <summary>
        /// Gets the ExtendedChartParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<ExtendedChartPart> ExtendedChartParts => GetPartsOfType<ExtendedChartPart>();

        /// <summary>
        /// Gets the ImageParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<ImagePart> ImageParts => GetPartsOfType<ImagePart>();

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Presentation.NotesMaster;
            }
        }

        /// <summary>
        /// Gets the Model3DReferenceRelationshipParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<Model3DReferenceRelationshipPart> Model3DReferenceRelationshipParts => GetPartsOfType<Model3DReferenceRelationshipPart>();

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Presentation.NotesMaster? NotesMaster
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Presentation.NotesMaster>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => NotesMaster;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <summary>
        /// Gets the SlidePart of the NotesMasterPart
        /// </summary>
        public SlidePart? SlidePart => GetSubPartOfType<SlidePart>();

        /// <summary>
        /// Gets the ThemePart of the NotesMasterPart
        /// </summary>
        public ThemePart? ThemePart => GetSubPartOfType<ThemePart>();

        /// <summary>
        /// Gets the UserDefinedTagsParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<UserDefinedTagsPart> UserDefinedTagsParts => GetPartsOfType<UserDefinedTagsPart>();

        /// <summary>
        /// Gets the VmlDrawingParts of the NotesMasterPart
        /// </summary>
        public IEnumerable<VmlDrawingPart> VmlDrawingParts => GetPartsOfType<VmlDrawingPart>();

        /// <summary>
        /// Adds a AudioReferenceRelationship to the NotesMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart)
        {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a AudioReferenceRelationship to the NotesMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the AudioReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public AudioReferenceRelationship AddAudioReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {
            return AddDataPartReferenceRelationship<AudioReferenceRelationship>(mediaDataPart, id);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the NotesMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart)
        {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart);
        }

        /// <summary>
        /// Adds a VideoReferenceRelationship to the NotesMasterPart
        /// </summary>
        /// <param name="mediaDataPart">The part type of the VideoReferenceRelationship</param>
        /// <param name="id">The relationship id</param>
        /// <return>The newly added part</return>
        public VideoReferenceRelationship AddVideoReferenceRelationship(MediaDataPart mediaDataPart, string id)
        {
            return AddDataPartReferenceRelationship<VideoReferenceRelationship>(mediaDataPart, id);
        }
        
        /// <inheritdoc/>
        public override IFeatureCollection Features => _features ??= new GeneratedFeatures(this);
        
        private sealed class GeneratedFeatures : TypedPartFeatureCollection, ITargetFeature, IPartConstraintFeature, IKnownDataPartFeature
        {
            public GeneratedFeatures(OpenXmlPart part) : base(part) { }
            string ITargetFeature.Name => "notesMaster";
            string ITargetFeature.Path => "notesMasters";
            private static readonly PartConstraints _partConstraints = new ()
            {
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/customXml", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/chart", "application/vnd.openxmlformats-officedocument.drawingml.chart+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2014/relationships/chartEx", "application/vnd.ms-office.chartex+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors", "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData", "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2007/relationships/diagramDrawing", "application/vnd.ms-office.drawingml.diagramDrawing+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout", "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle", "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/oleObject", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/package", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/vmlDrawing", "application/vnd.openxmlformats-officedocument.vmlDrawing", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary", null, false, true, FileFormatVersions.Office2007 },
                { "http://schemas.microsoft.com/office/2017/06/relationships/model3d", "model/gltf-binary", false, true, FileFormatVersions.Office2019 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme", "application/vnd.openxmlformats-officedocument.theme+xml", false, false, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/tags", "application/vnd.openxmlformats-officedocument.presentationml.tags+xml", false, true, FileFormatVersions.Office2007 },
                { "http://schemas.openxmlformats.org/officeDocument/2006/relationships/slide", "application/vnd.openxmlformats-officedocument.presentationml.slide+xml", false, false, FileFormatVersions.Office2007 },
            };
            bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule) => _partConstraints.TryGetRule(relationshipId, out rule);
            IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => _partConstraints.Rules;
            bool IKnownDataPartFeature.IsKnown(string relationshipId) => relationshipId is AudioReferenceRelationship.RelationshipTypeConst or VideoReferenceRelationship.RelationshipTypeConst;
        }
    
    }
}
