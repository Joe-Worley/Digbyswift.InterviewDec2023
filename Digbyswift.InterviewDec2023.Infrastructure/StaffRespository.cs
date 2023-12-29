namespace Digbyswift.InterviewDec2023.Infrastructure;

public interface IStaffRepository
{
    Staff? Get(int id);
    IEnumerable<Staff> AllStaff();
}

public class StaffRepository : IStaffRepository
{
    private List<Staff> _staffMembers = new(); //Store members in list, allows for easy aditions, edits etc while maintaining the data throughout app
    public StaffRepository()
    {
        LoadStaff();
    }

    private void LoadStaff() //Method to initially load staff (eg from Db in more real world context)
    {
        _staffMembers.Add(new Staff()
        {
            Id = 123,
            FullName = "Kieron McIntyre",
            Email = "kieron@digbyswift.com",
            JobTitle = "Owner/Lead Developer",
            Likes = new List<string> { "Code", "Karate" }
        });

        _staffMembers.Add(new Staff()
        {
            Id = 556,
            FullName = "Joe Earnshaw",
            Email = "joe@digbyswift.com",
            JobTitle = "Senior Developer"
        });

        _staffMembers.Add(new Staff()
        {
            Id = 838,
            FullName = "Owen Manby",
            Email = "owen@digbyswift.com",
            Likes = new List<string> { "Tintin", "Asterix" }
        });
    }

    public Staff? Get(int id)
    {
        return AllStaff().FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Staff> AllStaff() //made public to access via interface
    {
        return _staffMembers;
    }
}

public class Staff
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string? JobTitle { get; set; } //Nullable as not always provided 
    public List<string> Likes { get; set; } = new();   //Change to list, allows likes to be changed in future easier (add/remove etc). Also predefine as empty list in case of zero likes / not being set yet
}