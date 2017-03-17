// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: CustomBindingSource.cs (Timmethy.GUI)
// Timestamp: 11.08.2016 00:45
// ----------------------------------------------------------------

using System.ComponentModel;
using System.Windows.Forms;

namespace Timmethy.GUI {
    internal class CustomBindingSource : BindingSource {
        public CustomBindingSource() {
        }

        public CustomBindingSource(IContainer container) : base(container) {
        }

        public CustomBindingSource(object dataSource, string dataMember) : base(dataSource, dataMember) {
            if (DataSource is INotifyPropertyChanged)
                (DataSource as INotifyPropertyChanged).PropertyChanged += CustomBindingSource_PropertyChanged;
        }

        private void CustomBindingSource_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == DataMember)
            {
                object temp = DataSource;
                DataSource = null;
                DataSource = temp;
            }
        }
    }
}