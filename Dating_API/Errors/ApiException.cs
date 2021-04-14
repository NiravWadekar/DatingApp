namespace Dating_API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message=null, string details=null)
        {
            Details = details;
            Message = message;
            StatusCode = statusCode;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}