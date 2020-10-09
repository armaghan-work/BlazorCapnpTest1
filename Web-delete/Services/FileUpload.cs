using BlazorInputFile;
//using Microsoft.AspNetCore.Hosting;  // For web server
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;  // for webassenbly
using System.IO;
using System.Threading.Tasks;
namespace Web.Services
{
    public class FileUpload : IFileUpload
    {
        private readonly IWebAssemblyHostEnvironment _environment;
        private readonly string UploadPath;

        public FileUpload(IWebAssemblyHostEnvironment env)
        {
            _environment = env;
            UploadPath = Path.Combine(_environment.BaseAddress, "Upload");  //need to test// .Environment || .BaseAddress
        }

        public void DeleteExistingFiles()
        {
            var files = Directory.GetFiles(UploadPath);
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        public async Task<string> UploadAsync(IFileListEntry fileEntry)
        {
            var filePath = Path.Combine(UploadPath, fileEntry.Name);
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);

            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }

            return filePath;
        }
    }
}