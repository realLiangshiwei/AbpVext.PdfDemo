using DinkToPdf;
using DinkToPdf.Contracts;
using Volo.Abp.DependencyInjection;

namespace Pdf.Demo
{
    public class PdfService : IPdfService, ITransientDependency
    {
        private readonly IConverter _converter;

        public PdfService(IConverter converter)
        {
            _converter = converter;
        }


        public byte[] CreatePdf(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                //Margins = new MarginSettings
                //{
                //    Top = 10,
                //    Left = 0,
                //    Right = 0,
                //},
                DocumentTitle = "PDF Report",
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = {DefaultEncoding = "utf-8"},
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = {objectSettings}
            };

            var file = _converter.Convert(pdf);

            return file;
        }
    }
}
