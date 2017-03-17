// ----------------------------------------------------------------
// Author:  Tim Gubener (fortender)
// Filename: PersistenceHelper.cs (Timmethy.Core)
// Timestamp: 11.08.2016 00:43
// ----------------------------------------------------------------

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Timmethy.Core.Configuration;
using Timmethy.Core.Helpers;
using Timmethy.Core.Memory;

namespace Timmethy.Core {
    /// <summary>
    ///     Defines whether the function shall load or save the content.
    /// </summary>
    public enum PersistenceFileMode {
        Load = FileMode.Open,
        Save = FileMode.Create
    }

    /// <summary>
    ///     Covers all savable types such as micro/macro code and both combined (project file).
    /// </summary>
    public enum PersistenceFileType {
        MicroCode,
        MacroCode,
        Project
    }

    /// <summary>
    ///     Provides all the serialization and deserialization of specific components.
    ///     It is used to write and read files of the specific type.
    /// </summary>
    public static class PersistenceHelper {
        /// <summary>
        ///     Saving and loading the specified unit
        /// </summary>
        /// <param name="simulator">A micro code containing simulator instance</param>
        /// <param name="file">Source or destination file</param>
        /// <param name="type">Specific file type such as micro/macro code or project</param>
        /// <param name="mode">Save or load micro code</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SerializationException"></exception>
        public static void SaveLoadUnit(Simulator simulator, FileInfo file, PersistenceFileType type,
            PersistenceFileMode mode) {
            switch (type)
            {
                case PersistenceFileType.MicroCode:
                    SaveLoadMicroCode(simulator, file, mode);
                    break;
                case PersistenceFileType.MacroCode:
                    SaveLoadMacroCode(simulator, file, mode);
                    break;
                case PersistenceFileType.Project:
                    SaveLoadProject(simulator, file, mode);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        /// <summary>
        ///     Saving and loading the micro code
        /// </summary>
        /// <param name="simulator">A micro code containing simulator instance</param>
        /// <param name="file">Source or destination file</param>
        /// <param name="mode">Save or load micro code</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SerializationException"></exception>
        public static void SaveLoadMicroCode(Simulator simulator, FileInfo file, PersistenceFileMode mode) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            if (file == null)
                throw new ArgumentNullException(nameof(file));
            if (mode != PersistenceFileMode.Load && mode != PersistenceFileMode.Save)
                throw new ArgumentOutOfRangeException(nameof(mode));

            FileAccess fa = (FileMode) mode == FileMode.Open ? FileAccess.Read : FileAccess.Write;
            using (FileStream fs = file.Open((FileMode) mode, fa))
            {
                var formatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.File, simulator.InstructionSet));
                if (mode == PersistenceFileMode.Load)
                {
                    simulator.Mode = (SimulatorMode) formatter.Deserialize(fs);
                    simulator.MicroProgramMemory = (Memory<MicroOperationCell>) formatter.Deserialize(fs);
                }
                else formatter.Serialize(fs, simulator.Mode, simulator.MicroProgramMemory);
            }
        }

        /// <summary>
        ///     Saving and loading the macro code
        /// </summary>
        /// <param name="simulator">A macro code containing simulator instance</param>
        /// <param name="file">Source or destination file</param>
        /// <param name="mode">Save or load macro code</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SerializationException"></exception>
        public static void SaveLoadMacroCode(Simulator simulator, FileInfo file, PersistenceFileMode mode) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            if (file == null)
                throw new ArgumentNullException(nameof(file));
            if (mode != PersistenceFileMode.Load && mode != PersistenceFileMode.Save)
                throw new ArgumentOutOfRangeException(nameof(mode));

            FileMode fm = mode == PersistenceFileMode.Load ? FileMode.Open : FileMode.Create;
            FileAccess fa = fm == FileMode.Open ? FileAccess.Read : FileAccess.Write;
            using (FileStream fs = file.Open(fm, fa))
            {
                var formatter = new BinaryFormatter();
                if (mode == PersistenceFileMode.Load)
                    simulator.RandomAccessMemory = (ClippedIntegerMemory) formatter.Deserialize(fs);
                else
                    formatter.Serialize(fs, simulator.RandomAccessMemory);
            }
        }

        /// <summary>
        ///     Saving and loading the project
        /// </summary>
        /// <param name="simulator">A project containing simulator instance</param>
        /// <param name="file">Source or destination file</param>
        /// <param name="mode">Save or load project</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="SerializationException"></exception>
        public static void SaveLoadProject(Simulator simulator, FileInfo file, PersistenceFileMode mode) {
            if (simulator == null)
                throw new ArgumentNullException(nameof(simulator));
            if (file == null)
                throw new ArgumentNullException(nameof(file));
            if (mode != PersistenceFileMode.Load && mode != PersistenceFileMode.Save)
                throw new ArgumentOutOfRangeException(nameof(mode));

            FileMode fm = mode == PersistenceFileMode.Load ? FileMode.Open : FileMode.Create;
            FileAccess fa = fm == FileMode.Open ? FileAccess.Read : FileAccess.Write;
            using (FileStream fs = file.Open(fm, fa))
            {
                var formatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.File, simulator.InstructionSet));
                if (mode == PersistenceFileMode.Load)
                {
                    simulator.Mode = (SimulatorMode) formatter.Deserialize(fs);
                    simulator.MicroProgramMemory = (Memory<MicroOperationCell>) formatter.Deserialize(fs);
                    simulator.RandomAccessMemory = (ClippedIntegerMemory) formatter.Deserialize(fs);
                }
                else
                    formatter.Serialize(fs, simulator.Mode, simulator.MicroProgramMemory, simulator.RandomAccessMemory);
            }
        }
    }
}