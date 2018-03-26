using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Web.Mvc.Html;


namespace Game_Web_App.Models
{
    public class GameModel
    {
       
            [Required]
            public string User_name { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
        
            [DataType(DataType.Password)]
           
            public string Password { get; set; }
        public string Age { get; set; }
        [Required]
        public string House_type { get; set; }
        public Genders Gender { get; set; }


    }

    public enum Genders
    {
        Female,
        Male,
        others
    }
}
