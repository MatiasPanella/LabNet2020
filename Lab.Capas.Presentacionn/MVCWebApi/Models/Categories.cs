namespace MVCWebApi.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract(IsReference =true)]
    public partial class Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        [JsonProperty("categoryid")]
        [DataMember]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        [DataMember]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        [DataMember]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        [DataMember]
        public byte[] Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products> Products { get; set; }
    }
}
