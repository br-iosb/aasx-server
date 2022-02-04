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
    public partial class Operation : SubmodelElement, IEquatable<Operation>
    { 
        /// <summary>
        /// Gets or Sets InoutputVariable
        /// </summary>

        [DataMember(Name="inoutputVariable")]
        public List<OperationVariable> InoutputVariable { get; set; }

        /// <summary>
        /// Gets or Sets InputVariable
        /// </summary>

        [DataMember(Name="inputVariable")]
        public List<OperationVariable> InputVariable { get; set; }

        /// <summary>
        /// Gets or Sets OutputVariable
        /// </summary>

        [DataMember(Name="outputVariable")]
        public List<OperationVariable> OutputVariable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Operation {\n");
            sb.Append("  InoutputVariable: ").Append(InoutputVariable).Append("\n");
            sb.Append("  InputVariable: ").Append(InputVariable).Append("\n");
            sb.Append("  OutputVariable: ").Append(OutputVariable).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Operation)obj);
        }

        /// <summary>
        /// Returns true if Operation instances are equal
        /// </summary>
        /// <param name="other">Instance of Operation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Operation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InoutputVariable == other.InoutputVariable ||
                    InoutputVariable != null &&
                    InoutputVariable.SequenceEqual(other.InoutputVariable)
                ) && 
                (
                    InputVariable == other.InputVariable ||
                    InputVariable != null &&
                    InputVariable.SequenceEqual(other.InputVariable)
                ) && 
                (
                    OutputVariable == other.OutputVariable ||
                    OutputVariable != null &&
                    OutputVariable.SequenceEqual(other.OutputVariable)
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
                    if (InoutputVariable != null)
                    hashCode = hashCode * 59 + InoutputVariable.GetHashCode();
                    if (InputVariable != null)
                    hashCode = hashCode * 59 + InputVariable.GetHashCode();
                    if (OutputVariable != null)
                    hashCode = hashCode * 59 + OutputVariable.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Operation left, Operation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Operation left, Operation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
