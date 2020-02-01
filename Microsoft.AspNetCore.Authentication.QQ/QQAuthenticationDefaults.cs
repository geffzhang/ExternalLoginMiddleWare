﻿namespace Microsoft.AspNetCore.Authentication.QQ
{
    /// <summary>
    /// Contains constants specific to the <see cref="QQAuthenticationHandler"/>.
    /// </summary>
    public static class QQAuthenticationConstants
    {
        public static class Claims
        {
            public const string AvatarFullUrl = "urn:qq:avatar_full";
            public const string AvatarUrl = "urn:qq:avatar";
            public const string PictureFullUrl = "urn:qq:picture_full";
            public const string PictureMediumUrl = "urn:qq:picture_medium";
            public const string PictureUrl = "urn:qq:picture";
        }
    }

    /// <summary>
    /// Default values for QQ authentication.
    /// </summary>
    public static class QQAuthenticationDefaults
    {
        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.Name"/>.
        /// </summary>
        public const string AuthenticationScheme = "QQ";

        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "QQ";

        /// <summary>
        /// Default value for <see cref="AuthenticationSchemeOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "QQ";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.CallbackPath"/>.
        /// </summary>
        public const string CallbackPath = "/signin-qq";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.AuthorizationEndpoint"/>.
        /// </summary>
        public const string AuthorizationEndpoint = "https://graph.qq.com/oauth2.0/authorize";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.TokenEndpoint"/>.
        /// </summary>
        public const string TokenEndpoint = "https://graph.qq.com/oauth2.0/token";

        /// <summary>
        /// Default value for <see cref="QQAuthenticationOptions.UserIdentificationEndpoint"/>.
        /// </summary>
        public const string UserIdentificationEndpoint = "https://graph.qq.com/oauth2.0/me";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationEndpoint = "https://graph.qq.com/user/get_user_info";
    }
}
