namespace MyDigitalDiary.Shared
{
    public class UserState
    {
        public event Action OnChange;
        public event Action<object, CRUD> OnCrudAction; 
        public bool IsUserLoggedIn { get; set; }
        public string LoggedInUserID { get; set; } = null;

        public string Theme { get; set; } = MudBlazor.Colors.Indigo.Darken2;

        private void NotifyStateChanged() => OnChange?.Invoke();
        private void NotifyCrudAction<T>(T card, CRUD action) => OnCrudAction?.Invoke(card, action);

        public async Task SetLogin(bool isLoggedIn, string userId)
        {
            IsUserLoggedIn = isLoggedIn;
            LoggedInUserID = userId;
            await Task.CompletedTask;
        }

        public async Task SetTheme(string themeColor)
        {
            Theme = themeColor;
            NotifyStateChanged();
            await Task.CompletedTask;
        }

        public async Task NotifyFormAction<T>(T card, CRUD action)
        {
            NotifyCrudAction(card, action);
            await Task.CompletedTask;
        }
    }
}
