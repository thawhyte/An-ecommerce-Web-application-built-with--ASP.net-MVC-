using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.Data
{
    [Table("Blog")]
    public class BlogDTO
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}