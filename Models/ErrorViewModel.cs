namespace ejercicio1.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public string? Address1 { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
