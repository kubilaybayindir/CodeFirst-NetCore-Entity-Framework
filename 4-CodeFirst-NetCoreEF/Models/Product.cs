using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace _4_CodeFirst_NetCoreEF.Models
{
    [Table("Products")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("Price")]
        public decimal? UnitPrice { get; set; }

        [StringLength(30)]
        public string Description { get; set; }
        public int Stock { get; set; }
        public bool IsContinued { get; set; }
        
        //Navigation Property
        public virtual Category Category { get; set; }
    }
}
