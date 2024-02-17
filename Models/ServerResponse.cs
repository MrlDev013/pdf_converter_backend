namespace pdf_converter_backend.Models{
    public class ServerResponse<T>{
        public string MessageReturn { get; set; } = string.Empty;
        public bool Success {get; set;} = true;
    }
}
