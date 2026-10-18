using System;
public class person
{
    private string name;
    private string address;
    private double salary;

    public person (string name, string address, double salary)
    {
        this.name = name;
        this.address = address;
        this.salary = salary;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }

    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

}
