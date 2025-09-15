using System.Collections.Generic;
using System.Threading.Tasks;

namespace Typedown.Core.Services
{
    /// <summary>
    ///     Lightweight wrapper around Git operations. The methods are designed
    ///     to be filled with LibGit2Sharp based implementations in the future.
    /// </summary>
    public class GitService
    {
        /// <summary>
        ///     Retrieve commit history for the supplied repository path.
        /// </summary>
        public virtual Task<IReadOnlyList<string>> GetHistoryAsync(string repositoryPath)
        {
            // TODO: Use LibGit2Sharp to enumerate commits.
            return Task.FromResult<IReadOnlyList<string>>(new List<string>());
        }

        /// <summary>
        ///     Get a textual diff between two revisions.
        /// </summary>
        public virtual Task<string> GetDiffAsync(string repositoryPath, string oldRevision, string newRevision)
        {
            // TODO: Use LibGit2Sharp to generate diffs.
            return Task.FromResult(string.Empty);
        }
    }
}

