/* 
 * DotAAS Part 2 | HTTP/REST | Asset Administration Shell Repository
 *
 * An exemplary interface combination for the use case of an Asset Administration Shell Repository
 *
 * OpenAPI spec version: Final-Draft
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Defines ModelTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ModelTypes
    {
        /// <summary>
        /// Enum AssetAdministrationShell for value: AssetAdministrationShell
        /// </summary>
        [EnumMember(Value = "AssetAdministrationShell")]
        AssetAdministrationShell = 1,
        /// <summary>
        /// Enum ConceptDescription for value: ConceptDescription
        /// </summary>
        [EnumMember(Value = "ConceptDescription")]
        ConceptDescription = 2,
        /// <summary>
        /// Enum Submodel for value: Submodel
        /// </summary>
        [EnumMember(Value = "Submodel")]
        Submodel = 3,
        /// <summary>
        /// Enum AnnotatedRelationshipElement for value: AnnotatedRelationshipElement
        /// </summary>
        [EnumMember(Value = "AnnotatedRelationshipElement")]
        AnnotatedRelationshipElement = 4,
        /// <summary>
        /// Enum BasicEvent for value: BasicEvent
        /// </summary>
        [EnumMember(Value = "BasicEvent")]
        BasicEvent = 5,
        /// <summary>
        /// Enum Blob for value: Blob
        /// </summary>
        [EnumMember(Value = "Blob")]
        Blob = 6,
        /// <summary>
        /// Enum Capability for value: Capability
        /// </summary>
        [EnumMember(Value = "Capability")]
        Capability = 7,
        /// <summary>
        /// Enum DataElement for value: DataElement
        /// </summary>
        [EnumMember(Value = "DataElement")]
        DataElement = 8,
        /// <summary>
        /// Enum File for value: File
        /// </summary>
        [EnumMember(Value = "File")]
        File = 9,
        /// <summary>
        /// Enum Entity for value: Entity
        /// </summary>
        [EnumMember(Value = "Entity")]
        Entity = 10,
        /// <summary>
        /// Enum Event for value: Event
        /// </summary>
        [EnumMember(Value = "Event")]
        Event = 11,
        /// <summary>
        /// Enum ModelReference for value: ModelReference
        /// </summary>
        [EnumMember(Value = "ModelReference")]
        ModelReference = 12,
        /// <summary>
        /// Enum MultiLanguageProperty for value: MultiLanguageProperty
        /// </summary>
        [EnumMember(Value = "MultiLanguageProperty")]
        MultiLanguageProperty = 13,
        /// <summary>
        /// Enum Operation for value: Operation
        /// </summary>
        [EnumMember(Value = "Operation")]
        Operation = 14,
        /// <summary>
        /// Enum Property for value: Property
        /// </summary>
        [EnumMember(Value = "Property")]
        Property = 15,
        /// <summary>
        /// Enum Range for value: Range
        /// </summary>
        [EnumMember(Value = "Range")]
        Range = 16,
        /// <summary>
        /// Enum ReferenceElement for value: ReferenceElement
        /// </summary>
        [EnumMember(Value = "ReferenceElement")]
        ReferenceElement = 17,
        /// <summary>
        /// Enum RelationshipElement for value: RelationshipElement
        /// </summary>
        [EnumMember(Value = "RelationshipElement")]
        RelationshipElement = 18,
        /// <summary>
        /// Enum SubmodelElement for value: SubmodelElement
        /// </summary>
        [EnumMember(Value = "SubmodelElement")]
        SubmodelElement = 19,
        /// <summary>
        /// Enum SubmodelElementList for value: SubmodelElementList
        /// </summary>
        [EnumMember(Value = "SubmodelElementList")]
        SubmodelElementList = 20,
        /// <summary>
        /// Enum SubmodelElementStruct for value: SubmodelElementStruct
        /// </summary>
        [EnumMember(Value = "SubmodelElementStruct")]
        SubmodelElementStruct = 21,
        /// <summary>
        /// Enum View for value: View
        /// </summary>
        [EnumMember(Value = "View")]
        View = 22,
        /// <summary>
        /// Enum GlobalReference for value: GlobalReference
        /// </summary>
        [EnumMember(Value = "GlobalReference")]
        GlobalReference = 23,
        /// <summary>
        /// Enum FragmentReference for value: FragmentReference
        /// </summary>
        [EnumMember(Value = "FragmentReference")]
        FragmentReference = 24,
        /// <summary>
        /// Enum Constraint for value: Constraint
        /// </summary>
        [EnumMember(Value = "Constraint")]
        Constraint = 25,
        /// <summary>
        /// Enum Formula for value: Formula
        /// </summary>
        [EnumMember(Value = "Formula")]
        Formula = 26,
        /// <summary>
        /// Enum Qualifier for value: Qualifier
        /// </summary>
        [EnumMember(Value = "Qualifier")]
        Qualifier = 27    }
}
