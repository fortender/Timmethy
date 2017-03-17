// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: Enums.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Timmethy.Core.Helpers {
    public static class Enums {
        public static TAttribute GetEnumValueAttribute<TAttribute>(Enum enumValue) where TAttribute : Attribute {
            return Internals<TAttribute>.GetEnumValueAttribute(enumValue);
        }

        public static string GetDescription(this Enum enumValue) {
            return GetEnumValueAttribute<DescriptionAttribute>(enumValue)?.Description;
        }

        public static Dictionary<string, Enum> ToNameEnumDictionary(Type enumType) {
            if (!enumType.IsEnum)
                throw new ArgumentException("type is not enum");
            return
                Enum.GetNames(enumType)
                    .Select((k, i) => new {k, v = (Enum) Enum.GetValues(enumType).GetValue(i)})
                    .ToDictionary(e => e.k, e => e.v);
        }

        private static class Internals<T> {
            private static Dictionary<Enum, T> _enumAttributes;

            public static T GetEnumValueAttribute(Enum enumValue) {
                if (!typeof(Attribute).IsAssignableFrom(typeof(T)))
                    throw new InvalidOperationException($"Attribute type expected for generic type argument {nameof(T)}");
                if (_enumAttributes == null)
                    _enumAttributes = new Dictionary<Enum, T>();

                if (_enumAttributes.ContainsKey(enumValue))
                    return _enumAttributes[enumValue];

                FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
                var enumAttribute = (T)fi.GetCustomAttributes(typeof(T), false).FirstOrDefault();

                _enumAttributes.Add(enumValue, enumAttribute);

                return enumAttribute;
            }
        }
    }
}