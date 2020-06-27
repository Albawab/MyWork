using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace HenE.Aeolus.Identity.Manager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHostingEnvironment hostingEnv;

        public ValuesController(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }

        [HttpGet]
        public IActionResult GetItem()
        {
            return this.Ok();
        }

        [HttpPost("[action]")]
        public void Save(IList<IFormFile> uploadFiles)
        {
            long size = 0;
            try
            {
                foreach (var file in uploadFiles)
                {
                    var filename = ContentDispositionHeaderValue
                            .Parse(file.ContentDisposition)
                            .FileName
                            .Trim('"');
                    filename = @"C:\Users\albaw\Desktop\D" + $@"\{filename}";
                    size += (int)file.Length;
                    if (!System.IO.File.Exists(filename))
                    {
                        using (FileStream fs = System.IO.File.Create(filename))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                this.Response.Clear();
                this.Response.StatusCode = 204;
                this.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
                this.Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
    }
}
