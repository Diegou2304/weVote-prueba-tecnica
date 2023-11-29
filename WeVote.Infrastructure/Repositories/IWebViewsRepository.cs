

using WeVote.Domain;

namespace WeVote.Infrastructure.Repositories
{
    public interface IWebViewsRepository
    {
        Task<bool> RegisterWebView(PageViews pageViews);

    }
}
