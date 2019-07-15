using CmsShoppingCart.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.ViewModels.Blog
{
    public class BlogVM
    {
        public BlogVM()
        {

        }

        public BlogVM(BlogDTO row)
        {
            id = row.id;
            Name = row.Name;
            Email = row.Email;
            Comment = row.Comment;
            
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}