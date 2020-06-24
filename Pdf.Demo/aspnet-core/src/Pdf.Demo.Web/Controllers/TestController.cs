using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Pdf.Demo.Controllers
{
    [RemoteService()]
    public class TestController : DemoController
    {
        private readonly IPDFService _pdfService;

        public TestController(IPDFService pdfService)
        {
            _pdfService = pdfService;
        }

        // GET
        [HttpGet]
        public IActionResult Index()
        {
            var content = "<html><body>hello world</body></html>";
            return File(_pdfService.CreatePDF(content), "application/pdf");
        }
    }
}
