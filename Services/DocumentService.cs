using pdf_converter_backend.Models;
using pdf_converter_backend.Service;

namespace pdf_converter_backend.Services.DocumentService{
    public class DocumentService : IDocumentService
    {
        public async Task<ServerResponse<DocumentModel>> CheckInputFile(string InputFile)
        {
            ServerResponse<DocumentModel> serviceResponse = new ServerResponse<DocumentModel>();

            try
            {
                    if(!String.IsNullOrEmpty(InputFile))
                {
                    serviceResponse.MessageReturn = "O arquivo passou pela validação e está sendo convertido para PDF!";
                    serviceResponse.Success = true;
                }

                else
                {
                    serviceResponse.MessageReturn = "O arquivo alocado está vazio. Por favor, insira um arquivo válido!";
                    serviceResponse.Success = false;
                }
            }

            catch(Exception ex)
            {
                serviceResponse.MessageReturn = ex.Message;
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }

        public Task<ServerResponse<List<DocumentModel>>> ConvertToPdf(bool CheckInputFile, string Password, string InputFile)
        {
            throw new NotImplementedException();
        }

        public Task<ServerResponse<DocumentModel>> CreatePassword(string Password)
        {
            throw new NotImplementedException();
        }

        public Task<ServerResponse<DocumentModel>> ReceiveInputFile(string InputFile)
        {
            throw new NotImplementedException();
        }
    }
}