using System;

//namespace TestProject.Entities {
  public class Employee {
      
    public string Name;    
    public DateTime Birthday;
  
    public Employee() {
    }  

    public Employee(string name, DateTime birthday) {
      Name = name;
      Birthday = birthday;
    }  

    
public double Age   // property
  {
    get { 
      return System.DateTime.Now.Year - Birthday.Year;
    
    }   // get method
  
  }
}
public class GroupedEmployeeResult {
      
    public string Name;    
    public int Age;

     public string Key;    
    public int Count;

     public int Min;    
    public int Max;
  
  

  }



//}