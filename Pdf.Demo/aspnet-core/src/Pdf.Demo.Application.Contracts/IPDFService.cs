namespace Pdf.Demo
{
    public interface IPDFService
    {
        byte[] CreatePDF(string htmlContent);
    }
}
