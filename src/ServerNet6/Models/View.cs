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
    public partial class View : Referable, IEquatable<View>
    { 
        /// <summary>
        /// Gets or Sets EmbeddedDataSpecifications
        /// </summary>

        [DataMember(Name="embeddedDataSpecifications")]
        public List<EmbeddedDataSpecification> EmbeddedDataSpecifications { get; set; }

        /// <summary>
        /// Gets or Sets SemanticId
        /// </summary>

        [DataMember(Name="semanticId")]
        public Reference SemanticId { get; set; }

        /// <summary>
        /// Gets or Sets ContainedElements
        /// </summary>

        [DataMember(Name="containedElements")]
        public List<Reference> ContainedElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class View {\n");
            sb.Append("  EmbeddedDataSpecifications: ").Append(EmbeddedDataSpecifications).Append("\n");
            sb.Append("  SemanticId: ").Append(SemanticId).Append("\n");
            sb.Append("  ContainedElements: ").Append(ContainedElements).Append("\n");
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
            return obj.GetType() == GetType() && Equals((View)obj);
        }

        /// <summary>
        /// Returns true if View instances are equal
        /// </summary>
        /// <param name="other">Instance of View to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(View other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EmbeddedDataSpecifications == other.EmbeddedDataSpecifications ||
                    EmbeddedDataSpecifications != null &&
                    EmbeddedDataSpecifications.SequenceEqual(other.EmbeddedDataSpecifications)
                ) && 
                (
                    SemanticId == other.SemanticId ||
                    SemanticId != null &&
                    SemanticId.Equals(other.SemanticId)
                ) && 
                (
                    ContainedElements == other.ContainedElements ||
                    ContainedElements != null &&
                    ContainedElements.SequenceEqual(other.ContainedElements)
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
                    if (EmbeddedDataSpecifications != null)
                    hashCode = hashCode * 59 + EmbeddedDataSpecifications.GetHashCode();
                    if (SemanticId != null)
                    hashCode = hashCode * 59 + SemanticId.GetHashCode();
                    if (ContainedElements != null)
                    hashCode = hashCode * 59 + ContainedElements.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(View left, View right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(View left, View right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
