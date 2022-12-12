using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training;

public class Employee
{
    private string Name { get; set; }
    private string SurName { get; set; }
    private string _workPlace;
    private int _age = 18;

    public Employee(string name, string surName, string workPlace)
    {
        Name = name;
        SurName = surName;
        this._workPlace = workPlace;
        
    }
    public Employee()
    {

    }

    public override bool Equals(object? obj)
    {
        var employee = obj as Employee;
        if (obj == null || employee == null)
        {
            return false;
        }
        else if (Name == employee.Name && SurName == employee.SurName && _workPlace == employee._workPlace)
        {
            return true;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return _age.GetHashCode();
    }
}
