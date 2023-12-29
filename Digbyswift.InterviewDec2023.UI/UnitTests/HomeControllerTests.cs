using Digbyswift.InterviewDec2023.Infrastructure;
using Digbyswift.InterviewDec2023.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Digbyswift.InterviewDec2023.UI.UnitTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void HomeControllerGetSelectedMemberWithValidId_ShouldReturnStaffJsonResult()
        {
            var controller = new HomeController(new StaffRepository());
            int id = 123;

            ActionResult<string> staff = controller.GetSelectedStaffMember(id.ToString());

            Assert.True(staff != null);
            Assert.True(staff.Value == "Kieron McIntyre");
        }

        [Fact]
        public void HomeControllerGetSelectedMemberWithValidId_ShouldReturnEmptyJsonResult()
        {
            var controller = new HomeController(new StaffRepository());
            int id = 666;

            ActionResult<string> staff = controller.GetSelectedStaffMember(id.ToString());

            Assert.True(staff != null);
            Assert.True(staff.Value == null);
        }
    }
}
