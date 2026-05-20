public class ErrorViewModel
{
    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    public int StatusCode { get; set; }
    public required string Message { get; set; }
    public required string RequestMethod { get; set; }
}