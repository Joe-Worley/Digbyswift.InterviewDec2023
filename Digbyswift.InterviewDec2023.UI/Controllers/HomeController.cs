using Digbyswift.InterviewDec2023.Infrastructure;
using Digbyswift.InterviewDec2023.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection.Metadata;

namespace Digbyswift.InterviewDec2023.UI.Controllers;

public class HomeController : Controller
{
    private IStaffRepository _staffRepository;
    private HomeModel _homeModel;
    public HomeController(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
        var staff = _staffRepository.AllStaff();

        _homeModel = new HomeModel();
        
        foreach(var staffMember in staff)
        {
            _homeModel.StaffSelectList.Add(new SelectListItem
            {
                Text = staffMember.FullName,
                Value = staffMember.Id.ToString(),
            });
        }
    }

    public IActionResult Index()
    {
        return View(_homeModel);
    }


    public ActionResult GetSelectedStaffMember(string id)
    {
        var staffId = Convert.ToInt32(id);

        var staff = _staffRepository.Get(staffId);

        return Json(staff?.FullName);
    }
}