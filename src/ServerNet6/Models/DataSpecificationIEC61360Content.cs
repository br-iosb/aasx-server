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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DataSpecificationIEC61360Content : ValueObject, IEquatable<DataSpecificationIEC61360Content>
    { 
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>

        [DataMember(Name="dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>

        [DataMember(Name="definition")]
        public List<LangString> Definition { get; set; }

        /// <summary>
        /// Gets or Sets LevelType
        /// </summary>

        [DataMember(Name="levelType")]
        public List<LevelType> LevelType { get; set; }

        /// <summary>
        /// Gets or Sets PreferredName
        /// </summary>
        [Required]

        [DataMember(Name="preferredName")]
        public List<LangString> PreferredName { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>

        [DataMember(Name="shortName")]
        public List<LangString> ShortName { get; set; }

        /// <summary>
        /// Gets or Sets SourceOfDefinition
        /// </summary>

        [DataMember(Name="sourceOfDefinition")]
        public string SourceOfDefinition { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>

        [DataMember(Name="symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>

        [DataMember(Name="unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets UnitId
        /// </summary>

        [DataMember(Name="unitId")]
        public Reference UnitId { get; set; }

        /// <summary>
        /// Gets or Sets ValueFormat
        /// </summary>

        [DataMember(Name="valueFormat")]
        public string ValueFormat { get; set; }

        /// <summary>
        /// Gets or Sets ValueList
        /// </summary>

        [DataMember(Name="valueList")]
        public ValueList ValueList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSpecificationIEC61360Content {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
            sb.Append("  LevelType: ").Append(LevelType).Append("\n");
            sb.Append("  PreferredName: ").Append(PreferredName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  SourceOfDefinition: ").Append(SourceOfDefinition).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitId: ").Append(UnitId).Append("\n");
            sb.Append("  ValueFormat: ").Append(ValueFormat).Append("\n");
            sb.Append("  ValueList: ").Append(ValueList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((DataSpecificationIEC61360Content)obj);
        }

        /// <summary>
        /// Returns true if DataSpecificationIEC61360Content instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSpecificationIEC61360Content to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSpecificationIEC61360Content other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DataType == other.DataType ||
                    DataType != null &&
                    DataType.Equals(other.DataType)
                ) && 
                (
                    Definition == other.Definition ||
                    Definition != null &&
                    Definition.SequenceEqual(other.Definition)
                ) && 
                (
                    LevelType == other.LevelType ||
                    LevelType != null &&
                    LevelType.SequenceEqual(other.LevelType)
                ) && 
                (
                    PreferredName == other.PreferredName ||
                    PreferredName != null &&
                    PreferredName.SequenceEqual(other.PreferredName)
                ) && 
                (
                    ShortName == other.ShortName ||
                    ShortName != null &&
                    ShortName.SequenceEqual(other.ShortName)
                ) && 
                (
                    SourceOfDefinition == other.SourceOfDefinition ||
                    SourceOfDefinition != null &&
                    SourceOfDefinition.Equals(other.SourceOfDefinition)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
                ) && 
                (
                    Unit == other.Unit ||
                    Unit != null &&
                    Unit.Equals(other.Unit)
                ) && 
                (
                    UnitId == other.UnitId ||
                    UnitId != null &&
                    UnitId.Equals(other.UnitId)
                ) && 
                (
                    ValueFormat == other.ValueFormat ||
                    ValueFormat != null &&
                    ValueFormat.Equals(other.ValueFormat)
                ) && 
                (
                    ValueList == other.ValueList ||
                    ValueList != null &&
                    ValueList.Equals(other.ValueList)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (DataType != null)
                    hashCode = hashCode * 59 + DataType.GetHashCode();
                    if (Definition != null)
                    hashCode = hashCode * 59 + Definition.GetHashCode();
                    if (LevelType != null)
                    hashCode = hashCode * 59 + LevelType.GetHashCode();
                    if (PreferredName != null)
                    hashCode = hashCode * 59 + PreferredName.GetHashCode();
                    if (ShortName != null)
                    hashCode = hashCode * 59 + ShortName.GetHashCode();
                    if (SourceOfDefinition != null)
                    hashCode = hashCode * 59 + SourceOfDefinition.GetHashCode();
                    if (Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                    if (Unit != null)
                    hashCode = hashCode * 59 + Unit.GetHashCode();
                    if (UnitId != null)
                    hashCode = hashCode * 59 + UnitId.GetHashCode();
                    if (ValueFormat != null)
                    hashCode = hashCode * 59 + ValueFormat.GetHashCode();
                    if (ValueList != null)
                    hashCode = hashCode * 59 + ValueList.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DataSpecificationIEC61360Content left, DataSpecificationIEC61360Content right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DataSpecificationIEC61360Content left, DataSpecificationIEC61360Content right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
