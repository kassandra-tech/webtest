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
        public const string ForgotAccountCredentials = "Forgot Account Credentials";

        /// <summary>
        /// Home
        /// </summary>
        public const string Home = "Home";

        /// <summary>
        /// Log In
        /// </summary>
        public const string LogIn = "Log In";

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
                AccountActivity => $"{KassandraBaseAddress}account-activity",
                ApiKeys => $"{KassandraBaseAddress}api-keys",
                CreateAccount => $"{KassandraBaseAddress}create-account",
                DeleteAccount => $"{KassandraBaseAddress}delete-account",
                FavoriteCoins => $"{KassandraBaseAddress}favorite-coins",
                FavoriteContent => $"{KassandraBaseAddress}favorite-content",
                FavoriteMarkets => $"{KassandraBaseAddress}favorite-markets",
                ForgotAccountCredentials => $"{KassandraBaseAddress}forgot-account-credentials",
                Home => KassandraBaseAddress,
                LogIn => $"{KassandraBaseAddress}log-in",
                Profile => $"{KassandraBaseAddress}profile",
                ResetPassword => $"{KassandraBaseAddress}reset-password",
                ResetSecurityToken => $"{KassandraBaseAddress}reset-security-token",
                ResumeAccount => $"{KassandraBaseAddress}resume-acount",
                SecurityToken => $"{KassandraBaseAddress}security-token",
                SuspendAccount => $"{KassandraBaseAddress}suspend-account",
                TrustedDevices => $"{KassandraBaseAddress}trusted-devices",
                UserInformation => $"{KassandraBaseAddress}user-information",
                _ => UnknownScreen,
            };
        }
    }
}
