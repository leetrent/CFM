using System;
using System.Collections.Generic;

namespace CFM.Models 
{
  public class Person
  {
    /////////////////////////////////
    // Primary Key
    ///////////////////////////////// 
    public int PersonID {get; set;}
    public string FirstName {get; set;}
    public string MiddleName {get; set;}
    public string LastName {get; set;}
    public DateTime DOB {get; set;}
    public string SSN {get; set;}
    public ICollection<Address> Address { get; set; }    
  }
}