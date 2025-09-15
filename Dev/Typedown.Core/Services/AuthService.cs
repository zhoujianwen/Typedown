using System.Threading.Tasks;

namespace Typedown.Core.Services
{
    /// <summary>
    ///     Provides authentication helpers using either OpenID Connect or LDAP.
    ///     <para>
    ///     These methods are placeholders and should be replaced with concrete
    ///     logic that contacts the identity provider and returns the user
    ///     information required by the application.
    ///     </para>
    /// </summary>
    public class AuthService
    {
        /// <summary>
        ///     Authenticate the user via OIDC and return basic profile data.
        /// </summary>
        /// <returns>Tuple containing userId and userName.</returns>
        public virtual Task<(string userId, string userName)> LoginWithOidcAsync()
        {
            // TODO: Implement OIDC login flow.
            return Task.FromResult<(string, string)>(default);
        }

        /// <summary>
        ///     Authenticate the user via LDAP and return basic profile data.
        /// </summary>
        /// <returns>Tuple containing userId and userName.</returns>
        public virtual Task<(string userId, string userName)> LoginWithLdapAsync()
        {
            // TODO: Implement LDAP login flow.
            return Task.FromResult<(string, string)>(default);
        }
    }
}

