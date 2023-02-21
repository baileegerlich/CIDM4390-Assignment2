using System;
using System.ComponentModel.DataAnnotations;

namespace CIDM4390_Assignment2.Models{
    public class Restaurant{
        public int restaurantID {get; set;} //PK
        public string restaurantName {get; set;} = string.Empty;
        
    }
}