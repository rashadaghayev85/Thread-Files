using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppp
{
    internal class ExampleFile
    {
        public async Task WriteToExistFile(string path,string text)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using(StreamWriter wr = new StreamWriter(fs))
                {
                    await wr.WriteAsync(text);
                }
               
               
               
            }
            
           
            //C:\\Users\\Rashad\\OneDrive\\Desktop\\PB101\\code\\file1
        }
        public void ReadFromFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string result = sr.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
            
           
           
            
        }
        public void WriteToNewFile(string path,string text)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] datas = Encoding.UTF8.GetBytes(text);
                    fs.Write(datas, 0, datas.Length);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
