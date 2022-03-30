using System.ComponentModel.DataAnnotations;

namespace CoreAPIWithJWT.models
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
