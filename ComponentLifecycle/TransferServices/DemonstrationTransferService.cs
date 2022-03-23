using System.Collections.ObjectModel;

namespace ComponentLifecycle.TransferServices;

public class DemonstrationTransferService
{
    public ObservableCollection<string> Logs { get; set; } = new();
}