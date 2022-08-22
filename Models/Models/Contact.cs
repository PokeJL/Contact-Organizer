using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models.Models
{
    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        public int Id { get; set; }
        [Column("FName")]
        [StringLength(255)]
        [Unicode(false)]
        public string Fname { get; set; } = null!;
        [Column("LName")]
        [StringLength(255)]
        [Unicode(false)]
        public string Lname { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Nickname { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Organization { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Address { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? City { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Province { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PostalCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Column(TypeName = "datetime")]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;


        [XmlIgnore]     // Don't include this property in XML serialization 
        [JsonIgnore]    // Don't include this property in JSON serialization
        public string Combo
        {
            get
            {
                return Fname + " " + Lname;
            }
        }

        [XmlIgnore]     // Don't include this property in XML serialization 
        [JsonIgnore]    // Don't include this property in JSON serialization
        public string Info
        {
            get
            {
                return string.Format("Name: {1} {2}{0}Nickname: {3}{0}" +
                        "Organization: {4}{0}" +
                        "Address: {5} {6}, {7}{0}" +
                        "Postal Code: {10}{0}" +
                        "Phone: {8}{0}" +
                        "Email:{9}",
                        Environment.NewLine,
                        Fname,
                        Lname,
                        Nickname,
                        Organization,
                        Address,
                        City,
                        Province,
                        Phone,
                        Email,
                        PostalCode);
            }
        }
    }
}
