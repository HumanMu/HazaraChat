using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Key]
        public int Id {get; set;} 
        public string FirstName {get; set;} 
        public string LastName {get; set;} 
        public int Age {get; set;}
        public string Gender {get; set;}

    }
}
