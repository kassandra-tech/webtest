namespace KassandraWebTest.Kassandra
{
    /// <summary>
    /// Kassandra site details for screens and links to Kassandra pages.
    /// </summary>
    public static class SiteMap
    {
        /// <summary>
        /// Account
        /// </summary>
        public const string AccountActivity = "Account Activity";

        /// <summary>
        /// API Keys
        /// </summary>
        public const string ApiKeys = "API Keys";

        /// <summary>
        /// Create Account
        /// </summary>
        public const string CreateAccount = "Create Account";

        /// <summary>
        /// Delete Account
        /// </summary>
        public const string DeleteAccount = "Delete Account";

        /// <summary>
        /// Favorite Coins
        /// </summary>
        public const string FavoriteCoins = "Favorite Coins";

        /// <summary>
        /// Favorite Content
        /// </summary>
        public const string FavoriteContent = "Favorite Content";

        /// <summary>
        /// Favorite Markets
        /// </summary>
        public const string FavoriteMarkets = "Favorite Markets";

        /// <summary>
        /// Forgot Account Credentials
        /// </summary>
        public const string ForgotPassword = "Forgot Password";

        /// <summary>
        /// Home
        /// </summary>
        public const string Home = "Home";

        /// <summary>
        /// Log In
        /// </summary>
        public const string LogIn = "Log In";

        /// <summary>
        /// Markets
        /// </summary>
        public const string Markets = "Markets";

        /// <summary>
        /// Profile
        /// </summary>
        public const string Profile = "Profile";

        /// <summary>
        /// Reset Password
        /// </summary>
        public const string ResetPassword = "Reset Password";

        /// <summary>
        /// Recover Security Token
        /// </summary>
        public const string ResetSecurityToken = "Reset Security Token";

        /// <summary>
        /// Resume Account
        /// </summary>
        public const string ResumeAccount = "Resume Account";

        /// <summary>
        /// Security Token
        /// </summary>
        public const string SecurityToken = "Security Token";

        /// <summary>
        /// Suspend Account
        /// </summary>
        public const string SuspendAccount = "Suspend Account";

        /// <summary>
        /// Trusted Devices
        /// </summary>
        public const string TrustedDevices = "Trusted Devices";

        /// <summary>
        /// Unknown Screen
        /// </summary>
        public const string UnknownScreen = "Unknown Screen";

        /// <summary>
        /// User Information
        /// </summary>
        public const string UserInformation = "User Information";

        /// <summary>
        /// https://kassandra.tech/
        /// </summary>
        public const string KassandraBaseAddress = "https://kassandra.tech/";

        /// <summary>
        /// Navigate to a Kassandra screen.
        /// </summary>
        /// <param name="screen">Screen to navigate to.</param>
        /// <returns></returns>
        public static string GetPageUrl(string screen)
        {
            return screen switch
            {
                AccountActivity => $"{KassandraBaseAddress}account-activity{FileExtension}",
                ApiKeys => $"{KassandraBaseAddress}api-keys{FileExtension}",
                CreateAccount => $"{KassandraBaseAddress}create-account{FileExtension}",
                DeleteAccount => $"{KassandraBaseAddress}delete-account{FileExtension}",
                FavoriteCoins => $"{KassandraBaseAddress}favorite-coins{FileExtension}",
                FavoriteContent => $"{KassandraBaseAddress}favorite-content{FileExtension}",
                FavoriteMarkets => $"{KassandraBaseAddress}favorite-markets{FileExtension}",
                ForgotPassword => $"{KassandraBaseAddress}forgot-password{FileExtension}",
                Home => $"{KassandraBaseAddress}home{FileExtension}",
                LogIn => $"{KassandraBaseAddress}login{FileExtension}",
                Markets => $"{KassandraBaseAddress}markets{FileExtension}",
                Profile => $"{KassandraBaseAddress}profile{FileExtension}",
                ResetPassword => $"{KassandraBaseAddress}reset-password{FileExtension}",
                ResetSecurityToken => $"{KassandraBaseAddress}reset-security-token{FileExtension}",
                ResumeAccount => $"{KassandraBaseAddress}resume-acount{FileExtension}",
                SecurityToken => $"{KassandraBaseAddress}security-token{FileExtension}",
                SuspendAccount => $"{KassandraBaseAddress}suspend-account{FileExtension}",
                TrustedDevices => $"{KassandraBaseAddress}trusted-devices{FileExtension}",
                UserInformation => $"{KassandraBaseAddress}user-information{FileExtension}",
                _ => UnknownScreen,
            };
        }

        private const string FileExtension = ".html";
    }
}
