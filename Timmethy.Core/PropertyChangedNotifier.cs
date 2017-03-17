// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: PropertyChangedNotifier.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.ComponentModel;

namespace Timmethy.Core {
    /// <summary>
    ///     A base for classes which needs to notify when a property has changed
    /// </summary>
    [Serializable]
    public abstract class PropertyChangedNotifier : INotifyPropertyChanged {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(params string[] propNames) {
            if (PropertyChanged == null) return;
            foreach (string name in propNames)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}