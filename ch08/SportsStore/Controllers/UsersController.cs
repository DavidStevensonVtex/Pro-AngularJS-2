using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;

namespace SportsStore.Controllers
{
    public class User
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class UsersController : ApiController
    {
        //[System.Web.Http.AllowAnonymous]
        [System.Web.Http.Route("users/login")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Post(User user)
        {
            if ( user.UserName == "Admin" && user.Password == "letmein" )
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new HttpError()
            {
                Message = "Invalid user name or password"
            });
        }

        [System.Web.Http.Route("users/logout")]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return new RedirectResult("#/Login");
        }
    }
}
