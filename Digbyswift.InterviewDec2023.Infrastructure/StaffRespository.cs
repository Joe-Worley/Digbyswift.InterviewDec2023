namespace Digbyswift.InterviewDec2023.Infrastructure;

public interface IStaffRepository
{
    Staff Get(int id);
}

public class StaffRepository : IStaffRepository
{
    public Staff Get(int id)
    {
        return AllStaff().First(x => x.Id == id);
    }

    private IEnumerable<Staff> AllStaff()
    {
        return new Staff[]
        {
            new Staff()
            {
                Id = 123,
                FullName = "Kieron McIntyre",
                Email = "kieron@digbyswift.com",
                JobTitle = "Owner/Lead Developer",
                Likes = new [] {"Code", "Karate"}
            },
            new Staff()
            {
                Id = 556,
                FullName = "Joe Earnshaw",
                Email = "joe@digbyswift.com",
                JobTitle = "Senior Developer"
            },
            new Staff()
            {
                Id = 838,
                FullName = "Owen Manby",
                Email = "owen@digbyswift.com",
                Likes = new [] {"Tintin","Asterix"}
            },
        };
    }
}

public class Staff
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string JobTitle { get; set; }
    public string[] Likes { get; set; }
}