using Digbyswift.InterviewDec2023.Infrastructure;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Xunit;

namespace Digbyswift.InterviewDec2023.UI.UnitTests
{
    public class StaffRepositoryTests
    {
        [Theory]
        [InlineData(123)] //valid id, first in list
        [InlineData(838)] //valid id, not first
        public void StaffRepositoryGetMethodWithValidId_ShouldReturnTheAppropriateStaffMember(int id)
        {
            var repository = new StaffRepository();

            var staff = repository.Get(id);

            Assert.True(staff != null); //check staff returned
            Assert.True(staff.Id == id); //check its corect staff member
        }

        [Fact]
        public void StaffRepositoryGetMethodWithInvalidId_ShouldReturnNull()
        {
            var repository = new StaffRepository();
            int id = 666;

            var staff = repository.Get(id);

            Assert.Null(staff);
        }
    }
}
