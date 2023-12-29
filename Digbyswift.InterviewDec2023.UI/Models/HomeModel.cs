using Microsoft.AspNetCore.Mvc.Rendering;

namespace Digbyswift.InterviewDec2023.UI.Models
{
    public class HomeModel
    {
        public int SelectedStaffId { get; set; }
        public List<SelectListItem> StaffSelectList { get; set; } = new();
    }
}
