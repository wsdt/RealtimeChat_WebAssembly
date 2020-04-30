using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WSDTChat.Controllers
{
    [Route(ICommonRoutes.FILE_UPLOAD)]
    public class FileController : ControllerBase
    {
        private string FILE_NAME;
        private readonly string FILE_PATH;
        private const string SUB_FOLDER = "img/uploaded_imgs";

        public FileController(IHostEnvironment env) {
            FILE_PATH = Path.Combine(env.ContentRootPath, "wwwroot", SUB_FOLDER);
        }

        private string GetNewFileName()
        {
            FILE_NAME = Path.GetRandomFileName().Split('.')[0] + ".jpg";
            string pathStr = Path.Combine(FILE_PATH, FILE_NAME);

            if (System.IO.File.Exists(pathStr))
            {
                return GetNewFileName();
            }

            Console.WriteLine("Saving file to: {0}\n", pathStr);

            return pathStr;
        }

        [HttpPost]
        public async Task<IActionResult> SaveImg() {

            if (!Directory.Exists(FILE_PATH)) Directory.CreateDirectory(FILE_PATH);

            string pathStr = GetNewFileName();
            using (FileStream fs = System.IO.File.Create(pathStr))
            {
                await Request.Body.CopyToAsync(fs);
            }

            //return Ok(Path.GetFileNameWithoutExtension(tempFileName));
            return Ok(Path.Combine(SUB_FOLDER, FILE_NAME));
        }
    }
}
