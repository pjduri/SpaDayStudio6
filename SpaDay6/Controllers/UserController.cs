using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost("/user")]
    public IActionResult SubmitAddUserForm(User newUser, string verify)
    {
        if (newUser.Password != verify)
        {
            ViewBag.error = "Passwords must match";
            return View("/users/add");
        }

        ViewBag.user = newUser;
        return View("Index");
    }
}

// public class UserController : Controller
// {
//     // GET: /<controller>/
//     public IActionResult Index()
//     {
//         return View();
//     }

//     // Render the form
//     public IActionResult Add()
//     {
//         return View();
//     }

//     [HttpPost]
//     [Route("/user")]
//     public IActionResult SubmitAddUserForm(User newUser, string verify)
//     {
//         // add form submission handling code here
//         if (newUser.Password == verify)
//         {
//             // Students may pass in just in the name of the user to the Index view.
//             // They only need to pass in the whole object to complete the bonus mission.
//             ViewBag.user = newUser;
//             return View("Index");
//         }
//         else
//         {
//             ViewBag.error = "Passwords do not match! Try again!";
//             ViewBag.userName = newUser.Username;
//             ViewBag.eMail = newUser.Email;
//             return View("Add");
//         }
//     }
// }
