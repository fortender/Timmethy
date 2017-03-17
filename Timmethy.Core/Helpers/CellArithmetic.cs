namespace Timmethy.Core.Helpers {
    internal static class CellArithmetic {

        internal static int GetHiCode(this int value) {
            return value / 1000;
        }

        internal static int GetLoCode(this int value) {
            return value % 1000;
        }

    }
}
