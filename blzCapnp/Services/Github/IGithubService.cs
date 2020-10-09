using Octokit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blzCapnp.Services.Github
{
    public interface IGithubService
    {
        string RepoName { get; set; }
        string RepoOwner { get; set; }

        void SetRepoInfo(string repoPath);
        string GetRepoPath(string repoPath);
        string GetRepoResultPath(string repoPath);
        
        void CommitOnGit(string FileName, string JsonContent, string CsvContent, string username, string password, string monicaResultsPathOnGithub);
        void CreateFile(string username, string password);

        /// <summary>
        /// Return all directories and files inside the directory path.
        /// </summary>
        /// <param name="path">The directory path</param>
        /// <param name="username">The username of owner</param>
        /// <param name="password">The password of owner</param>
        /// <returns>Return list of existing contents int he path</returns>
        IEnumerable<RepositoryContent> GetContents(string path, string username, string password);

        /// <summary>
        /// Return all directories and files inside the directory path.
        /// </summary>
        /// <param name="path">The directory path</param>
        /// <param name="username">The username of owner</param>
        /// <param name="password">The password of owner</param>
        /// <returns>Return list of existing contents int he path</returns>
        Task<IEnumerable<RepositoryContent>> GetContentsAsync(string path, string username, string password);
        List<string> GetContentsList(string path, string username, string monicaResultsPathOnGithub);
        string GetDownloadPath(string path, string username, string password);
        Task<string> GetDownloadPathAsync(string path, string username, string password);
        string GetFileContent(string path, string username, string password);
        Task<string> GetFileContentAsync(string path, string username, string password);
        string GetFileContentUsingSha(string Sha, string username, string password);
        Task<string> GetFileContentUsingShaAsync(string Sha, string username, string password);
        bool IsExistPath(string path, string username, string passowrd, string monicaResultsPathOnGithub);
        bool PathValidator(string path, string username, string passowrd, string monicaResultsPathOnGithub);
        Task<bool> IsExistPathAsync(string path, string username, string passowrd);
        bool Login(string username, string password);
    }
}