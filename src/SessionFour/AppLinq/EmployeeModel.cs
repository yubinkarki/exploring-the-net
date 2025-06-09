namespace ExploringTheNet.src.SessionFour.AppLinq;

public class EmployeeModel {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public EmployeeModel(int id, string name, decimal salary) {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }
}
