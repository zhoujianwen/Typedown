using System.Threading.Tasks;

namespace Typedown.Core.Services
{
    /// <summary>
    ///     Bridges the editor with remote code review systems such as Gitea or
    ///     GitLab using their REST APIs.
    /// </summary>
    public class ReviewService
    {
        /// <summary>
        ///     Submit a review or merge request to the remote server.
        /// </summary>
        public virtual Task SubmitReviewAsync(string serverUrl, string accessToken, object payload)
        {
            // TODO: Implement REST interaction with Gitea or GitLab.
            return Task.CompletedTask;
        }
    }
}

