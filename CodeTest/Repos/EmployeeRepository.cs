using System;
using System.Collections.Generic;

public class EmployeeRepository : IEmployeeRepository  {
    
    // DO NOT CHANGE THIS
    public List<Employee> LoadAllEmployees() =>
      new List<Employee>() {
        new Employee("Joan", new DateTime(1980,11,1)),
        new Employee("Bill", new DateTime(1970,2,1)),
        new Employee("Arron", new DateTime(1991,8,1)),
        new Employee("Jack", new DateTime(1964,2,1)),
        new Employee("Robyn", new DateTime(1954,12,1)),
        new Employee("Todd", new DateTime(1998,2,1)),
        new Employee("Katie", DateTime.Now.AddYears(-30).AddDays(-1)),
        new Employee("Bharti", DateTime.Now.AddYears(-30).AddDays(1)),
        new Employee("Sam", new DateTime(2001,2,1)),
        new Employee("Sally", new DateTime(2019,2,1)),
      };
      
}