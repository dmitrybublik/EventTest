using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace EventTest
{
    public sealed class MainViewModel : NotifyPropertyChanged
    {
        private readonly ObservableCollection<LogItem> _logItems = new ObservableCollection<LogItem>();

        public IEnumerable<LogItem> LogItems => _logItems;

        public void Log(string message, LogKind kind)
        {
            var logItem = new LogItem
            {
                Index = _logItems.Count + 1,
                Time = DateTime.Now,
                Message = message,
                Kind = kind,
            };

            _logItems.Add(logItem);
        }
    }
}