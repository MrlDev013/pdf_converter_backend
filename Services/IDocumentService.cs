using pdf_converter_backend.Models;

namespace pdf_converter_backend.Service
{
    public interface IDocumentService
    {
        Task<ServerResponse<DocumentModel>> ReceiveInputFile(string InputFile);
        Task<ServerResponse<DocumentModel>> CheckInputFile(string InputFile);
        Task<ServerResponse<DocumentModel>> CreatePassword(string Password);
        Task<ServerResponse<List<DocumentModel>>> ConvertToPdf(bool CheckInputFile, string Password, string InputFile);
    } 
}