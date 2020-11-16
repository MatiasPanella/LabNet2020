using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Lab.Capas.Models
{
    public class CategoriesView
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength (30)]
        public string CategoryName { get; set; }

        [StringLength(30)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        [DataMember]
        public byte[] Picture { get; set; }
    }
}