﻿using System.ComponentModel.DataAnnotations;

namespace MadisonCountyCollaborationApplication.Pages.DataClasses
{
    public class Users
    {

        public int userID { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public String? userName { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        public String? firstName { get; set; }
        [Required(ErrorMessage = "last Name is Required")]
        public String? lastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public String? email { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        public String? phone { get; set; }
        [Required(ErrorMessage = "User Type is Required")]
        public String? userType { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public String? userPassword { get; set; }

    }
}
