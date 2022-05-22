namespace MyDigitalDiaryWeb.Shared
{
    public class UserState
    {
        public bool IsUserLoggedIn { get; set; }
        public string? LoggedInUserID { get; set; } = null;

        public string Theme { get; set; } = MudBlazor.Colors.Indigo.Darken2;

        public async Task SetLogin(bool isLoggedIn, string? userId)
        {
            IsUserLoggedIn = isLoggedIn;
            LoggedInUserID = userId;
            await Task.CompletedTask;
        }

        public async Task SetTheme(string themeColor)
        {
            Theme = themeColor;
            await Task.CompletedTask;
        }
    }
}
