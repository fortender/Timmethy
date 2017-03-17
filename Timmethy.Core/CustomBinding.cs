// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: CustomBinding.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Reflection;

namespace Timmethy.Core {
    /// <summary>
    ///     Creates a unidirectional data binding between two properties. The source object informs this class when the source
    ///     property has changed by
    ///     raising the <see cref="INotifyPropertyChanged.PropertyChanged" /> event. <see cref="CustomBinding" /> class
    ///     subscribes to this event and sets
    ///     the destination property to the changed value.
    /// </summary>
    public class CustomBinding : IDisposable {
        private readonly Action<object> _dstSetter;
        private readonly Func<object> _srcGetter;

        private readonly INotifyPropertyChanged _srcObject;
        private readonly string _srcPropName;
        private bool _disposed;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CustomBinding" /> class.
        /// </summary>
        /// <param name="sourceObject">The <see cref="INotifyPropertyChanged" /> source object containing the source property.</param>
        /// <param name="sourcePropertyName">The name of the source property which notifies when it is changed.</param>
        /// <param name="destinationObject">The destination object containing the destination property.</param>
        /// <param name="destinationPropertyName">
        ///     The name of the destination property which is set when the source property is
        ///     changed.
        /// </param>
        public CustomBinding(INotifyPropertyChanged sourceObject, string sourcePropertyName, object destinationObject,
            string destinationPropertyName) {
            if (sourceObject == null)
                throw new ArgumentNullException(nameof(sourceObject));
            if (sourcePropertyName == null)
                throw new ArgumentNullException(nameof(sourcePropertyName));
            if (destinationObject == null)
                throw new ArgumentNullException(nameof(destinationObject));
            if (destinationPropertyName == null)
                throw new ArgumentNullException(nameof(destinationPropertyName));

            PropertyInfo srcProp = sourceObject.GetType()
                .GetProperty(sourcePropertyName, BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo dstProp = destinationObject.GetType()
                .GetProperty(destinationPropertyName, BindingFlags.Public | BindingFlags.Instance);

            _srcObject = sourceObject;
            _srcPropName = sourcePropertyName;
            _srcGetter = () => srcProp.GetGetMethod(false).Invoke(sourceObject, null);
            _dstSetter = o => dstProp.GetSetMethod(false).Invoke(destinationObject, new[] {o});

            _dstSetter(_srcGetter());

            sourceObject.PropertyChanged += SourceObject_PropertyChanged;
        }

        /// <summary>
        ///     Releases all resources and notifies the <see cref="GC" />
        /// </summary>
        public void Dispose() {
            Dispose(true);
        }

        private void SourceObject_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if (e.PropertyName == _srcPropName)
                _dstSetter(_srcGetter());
        }

        protected virtual void Dispose(bool disposing) {
            if (_disposed) return;
            _srcObject.PropertyChanged -= SourceObject_PropertyChanged;
            GC.SuppressFinalize(this);
            _disposed = true;
        }
    }
}