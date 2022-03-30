using System.ComponentModel.DataAnnotations;

namespace CoreAPIWithJWT.models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is requerid")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
