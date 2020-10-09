using BlazorInputFile;
using System.Threading.Tasks;
namespace Web.Services
{
    public interface IFileUpload
    {
        void DeleteExistingFiles();

        Task<string> UploadAsync(IFileListEntry file);
    }
}