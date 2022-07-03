using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryDataAccess.Model
{
    public class SignUpModel
    {
        [Required(ErrorMessage = "Please fill Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill Email")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string RoleId { get; set; }
    }
}
