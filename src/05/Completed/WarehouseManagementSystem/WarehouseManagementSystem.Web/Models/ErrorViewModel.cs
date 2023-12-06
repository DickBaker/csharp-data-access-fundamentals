namespace WarehouseManagementSystem.Web.Models;

public class ErrorViewModel(string requestId)
{
    public string RequestId { get; init; } = requestId;

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}