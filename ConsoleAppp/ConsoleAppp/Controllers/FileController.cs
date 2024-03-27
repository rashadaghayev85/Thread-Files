using ConsoleAppp.Services;
using ConsoleAppp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppp.Controllers
{
    internal class FileController
    {
        private readonly IFileService _fileService;
        public FileController()
        {
                _fileService = new FileService();
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Users\\Rashad\\OneDrive\\Desktop\\PB101\\code\\file1.txt");
            Console.WriteLine(result);
           
        }
        public async Task CreateFileWithContentAsync()
        {
            await _fileService.WriteToNewFileAsync("C:\\Users\\Rashad\\OneDrive\\Desktop\\PB101\\code\\file3.txt","necesiiiz?");
        }
        public async Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C:\\Users\\Rashad\\OneDrive\\Desktop\\PB101\\code\\file3.txt");
        }
    }
}
