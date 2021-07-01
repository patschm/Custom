using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.FileProviders;

namespace WepZeurver.Controllers
{
    [Route("assembly")]
    public class AssemblyController : ControllerBase
    {
        private readonly IFileProvider _fileProvider;

        public AssemblyController(IFileProvider fileProvider)
        {
            _fileProvider = fileProvider;
        }

        [Route("ow")]
        public IActionResult Onderwater()
        {
            //var stream = File.Open()
            IFileInfo inf = _fileProvider.GetFileInfo("Resources/OnderWater.dll");
            return File(inf.CreateReadStream(), "application/octet-stream");
        }
    }
}
