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
    [Table("Categories")]
    public  class Category
    {
        public Category()
        {
            Products=new List<Product>();
        }

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }

        //Navigation Property
        public virtual List<Product> Products { get; set; } 
    }
}
