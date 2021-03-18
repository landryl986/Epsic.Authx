namespace Epsic.Authx.Models
{
    public class RegistrationResponse
    {
        public string Token { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
    }
}