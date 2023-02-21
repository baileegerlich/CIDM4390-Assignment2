using System.ComponentModel.DataAnnotations;    // Required for Data Validation

namespace CIDM4390_Assignment2.Models{
    public class Customer{
        public int customerID {get; set;} //PK

        public string firstName {get; set;} = string.Empty;
        public string lastName {get; set;} = string.Empty;
        public string customerEmail {get; set;} = string.Empty;
        public int phoneNumber {get; set;}
        
    }
}