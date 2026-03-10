namespace ejercicio1.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequessstId => !string.IsNullOrEmpty(RequestId);
}
