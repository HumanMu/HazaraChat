using System;

namespace Domain
{
    public class User
    {
        public string FirstName {get; set;} 
        public string LastName {get; set;} 
        public int Age {get; set;}
        public string Gender {get; set;}
        public Boolean status {get; set;} // status om online/offline
    }
}
