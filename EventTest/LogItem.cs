using System;

namespace EventTest
{
    public sealed class LogItem : NotifyPropertyChanged
    {
        public int Index { get; set; }

        public DateTime Time { get; set; }

        public string Message { get; set; }

        public LogKind Kind { get; set; }
    }
}