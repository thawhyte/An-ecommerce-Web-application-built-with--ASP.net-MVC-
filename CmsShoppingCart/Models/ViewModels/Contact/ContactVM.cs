using CmsShoppingCart.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CmsShoppingCart.Models.ViewModels.Contact
{
    public class ContactVM
    {
        public ContactVM()
        {

        }

        public ContactVM(ContactDTO row)
        {
            Id = row.Id;
            Email = row.Email;
            Message = row.Message;
        }

        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}