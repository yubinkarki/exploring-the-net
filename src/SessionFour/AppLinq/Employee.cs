namespace ExploringTheNet.src.SessionFour.AppLinq;

public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, string address, decimal salary) {
        this.Id = id;
        this.Name = name;
        this.Address = address;
        this.Salary = salary;
    }
}
