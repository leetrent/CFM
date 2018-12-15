namespace CFM.Models 
{
  public enum AddressType
  {
    RESIDENCE, BUSINESS, VACATION
  }
  public class Address
  {
    /////////////////////////////////
    // Primary Key
    /////////////////////////////////   
    public int AddressID { get; set; }
    
    /////////////////////////////////
    // Foreign Key
    /////////////////////////////////
    public int PersonID {get; set;}
    
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City {get; set;}
    public string State {get; set;}
    public string PostalCode {get; set;}
    
    /////////////////////////////////
    // Navigation Propery
    /////////////////////////////////
    public Person Person {get; set;}

  }
}