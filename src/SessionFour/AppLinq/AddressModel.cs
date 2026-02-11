namespace ExploringTheNet.SessionFour.AppLinq;

public class AddressModel {
    public int Id { get; set; }
    public string City { get; set; }
    public int EmployeeId { get; set; }
    public string StreetName { get; set; }

    public AddressModel(int id, string city, int employeeId, string streetName) {
        this.Id = id;
        this.City = city;
        this.EmployeeId = employeeId;
        this.StreetName = streetName;
    }
}
