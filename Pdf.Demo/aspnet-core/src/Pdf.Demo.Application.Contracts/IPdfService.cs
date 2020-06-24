namespace Pdf.Demo
{
    public interface IPdfService
    {
        byte[] CreatePdf(string htmlContent);
    }
}
