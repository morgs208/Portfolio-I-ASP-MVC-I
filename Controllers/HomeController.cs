using Microsoft.AspNetCore.Mvc;
namespace Tester

{
    public class HomeController : Controller
    {
        // Requests
        //localhost:5000/
        [HttpGet("")]
        public string Index()
        {
            return "Hello from the Controller";
        }

        //localhose:5000/hello

        [HttpGet("projects")]
        public string Hello()
        {
            return "Hi again this is from a nother spot";
        }
        // localhost:5000/users/username
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "Chicago")
            return $"Hello {username} you are currently in {location}. Go BEARS!";
            return $"Hello {username} you are currently in {location}.";
        }

    }


}

