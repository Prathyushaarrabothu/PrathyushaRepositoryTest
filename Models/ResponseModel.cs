namespace WebApplication2.Models
{
    public class ResponseModel

    {
        public string? Message { get; set; }

      public bool Success { get; set; }
      public object? Data { get; set; }
      public ResponseModel(string message, bool success, object? data = null)
      {
          Message = message;
          Success = success;
          Data = data;
        }
    }
}
