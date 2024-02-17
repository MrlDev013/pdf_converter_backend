namespace pdf_converter_backend.Models{
    public class DocumentModel{
        public string? InputFile { get; set; }
        public string? OutputFile { get; set; }
        private string? Password { get; set; }
        public string? Content { get; set; }
    }
}