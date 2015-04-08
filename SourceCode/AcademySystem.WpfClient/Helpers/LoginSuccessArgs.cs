namespace AcademySystem.WpfClient.Helpers
{
    using System;

    public class LoginSuccessArgs : EventArgs
    {
        public string Username { get; set; }

        public LoginSuccessArgs(string username)
            : base()
        {
            this.Username = username;
        }
    }
}