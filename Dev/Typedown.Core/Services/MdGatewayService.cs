using System.Threading.Tasks;

namespace Typedown.Core.Services
{
    /// <summary>
    ///     Placeholder for a markdown gateway that offers file locking and
    ///     auditing features backed by Redis or a small database table.
    /// </summary>
    public class MdGatewayService
    {
        /// <summary>
        ///     Acquire a named lock to prevent concurrent edits.
        /// </summary>
        public virtual Task<bool> AcquireLockAsync(string key)
        {
            // TODO: Implement Redis based locking.
            return Task.FromResult(false);
        }

        /// <summary>
        ///     Record an audit entry for the provided action.
        /// </summary>
        public virtual Task AuditAsync(string action, string user)
        {
            // TODO: Write audit information to Redis or a database table.
            return Task.CompletedTask;
        }
    }
}

