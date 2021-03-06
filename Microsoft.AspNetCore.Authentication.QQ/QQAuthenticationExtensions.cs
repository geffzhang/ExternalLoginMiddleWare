﻿using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.QQ;
using Microsoft.Extensions.Options;
using System;


namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    /// <summary>
    /// Extension methods to add QQ authentication capabilities to an HTTP application pipeline.
    /// </summary>
    public static class QQAuthenticationExtensions
    {
        /// <summary>
        /// Adds <see cref="QQAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddQQ([NotNull] this AuthenticationBuilder builder)
        {
            return builder.AddQQ(QQAuthenticationDefaults.AuthenticationScheme, options => { });
        }

        /// <summary>
        /// Adds <see cref="QQAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="configuration">The delegate used to configure the OpenID 2.0 options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddQQ(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] Action<QQAuthenticationOptions> configuration)
        {
            return builder.AddQQ(QQAuthenticationDefaults.AuthenticationScheme, configuration);
        }

        /// <summary>
        /// Adds <see cref="QQAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the QQ options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddQQ(
            [NotNull] this AuthenticationBuilder builder, [NotNull] string scheme,
            [NotNull] Action<QQAuthenticationOptions> configuration)
        {
            return builder.AddQQ(scheme, QQAuthenticationDefaults.DisplayName, configuration);
        }

        /// <summary>
        /// Adds <see cref="QQAuthenticationHandler"/> to the specified
        /// <see cref="AuthenticationBuilder"/>, which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="builder">The authentication builder.</param>
        /// <param name="scheme">The authentication scheme associated with this instance.</param>
        /// <param name="caption">The optional display name associated with this instance.</param>
        /// <param name="configuration">The delegate used to configure the QQ options.</param>
        /// <returns>The <see cref="AuthenticationBuilder"/>.</returns>
        public static AuthenticationBuilder AddQQ(
            [NotNull] this AuthenticationBuilder builder,
            [NotNull] string scheme, [CanBeNull] string caption,
            [NotNull] Action<QQAuthenticationOptions> configuration)
        {
            return builder.AddOAuth<QQAuthenticationOptions, QQAuthenticationHandler>(scheme, caption, configuration);
        }
    }
}
