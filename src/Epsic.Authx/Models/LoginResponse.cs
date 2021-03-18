namespace Epsic.Authx.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
    }
}