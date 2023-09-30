namespace OrganizerBlazor.Auth{

    public interface ILoginService
    {
        Task LoginAsync(string Username, string Password);
        Task<string> getJwtToken();
    }
}