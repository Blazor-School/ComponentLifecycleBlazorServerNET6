using System.Collections.ObjectModel;

namespace ComponentLifecycle.TransferServices;

public class DemonstrationTransferService
{
    //private string _log = "";

    //public string Log
    //{
    //    get => _log;
    //    set
    //    {
    //        _log = value;
    //        OnLogChanged?.Invoke(this, EventArgs.Empty);
    //    }
    //}

    //public event EventHandler OnLogChanged = new((sender, args) => { });
    public ObservableCollection<string> Logs { get; set; } = new();
}
