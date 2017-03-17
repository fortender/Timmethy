// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: SerializationExtensions.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Timmethy.Core.Helpers {
    /// <summary>
    ///     Extends <see cref="IFormatter" /> interface to reduce code when it comes to multiple (de-)serialization.
    /// </summary>
    public static class FormatterX {
        /// <summary>
        ///     Serialize multiple objects
        /// </summary>
        /// <param name="formatter">IFormatter e.g. BinaryFormatter</param>
        /// <param name="serializationStream">Destination stream</param>
        /// <param name="graphs">Objects to serialize</param>
        public static void Serialize(this IFormatter formatter, Stream serializationStream, params object[] graphs) {
            foreach (object graph in graphs)
                formatter.Serialize(serializationStream, graph);
        }

        /// <summary>
        ///     Deserialize an object directly into the given type
        /// </summary>
        /// <typeparam name="T">Type being deserialized</typeparam>
        /// <param name="formatter">IFormatter e.g. BinaryFormatter</param>
        /// <param name="serializationStream">Destination stream</param>
        /// <returns>Deserialized object</returns>
        public static T Deserialize<T>(this IFormatter formatter, Stream serializationStream) {
            return (T) formatter.Deserialize(serializationStream);
        }

        /// <summary>
        ///     Reads the stream till the end and returns all deserializable/deserialized objects
        /// </summary>
        /// <param name="formatter">IFormatter e.g. BinaryFormatter</param>
        /// <param name="serializationStream">Source stream</param>
        /// <returns>Deserialized objects</returns>
        public static IEnumerable<object> Deserialize(this IFormatter formatter, Stream serializationStream) {
            while (serializationStream.Position < serializationStream.Length)
                yield return formatter.Deserialize(serializationStream);
        }
    }

    public static class SerializationInfoX {
        /// <summary>
        ///     Tries to get the value from the serializationinfo by a given name and type
        /// </summary>
        /// <typeparam name="T">Type to cast value to</typeparam>
        /// <param name="info">Serialization information</param>
        /// <param name="name">Value name</param>
        /// <returns>Requested value</returns>
        public static T GetValue<T>(this SerializationInfo info, string name) {
            return (T) info.GetValue(name, typeof(T));
        }
    }
}