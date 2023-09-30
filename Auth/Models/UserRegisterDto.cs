namespace OrganizerBlazor.Auth.Models
{
    public class UserRegisterDto
    {
        public string name { get; set; }

        public string emailAddress { get; set; }
        public string password { get; set; }
        public string registrationCode { get; set; }
    }
}
