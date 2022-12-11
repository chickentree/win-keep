using System.Runtime.InteropServices;

namespace Keep;

internal class Interop
{
    [FlagsAttribute]
    internal enum EXECUTION_STATE : uint
    {
        ES_AWAYMODE_REQUIRED = 0x00000040,
        ES_CONTINUOUS = 0x80000000,
        ES_DISPLAY_REQUIRED = 0x00000002,
        ES_SYSTEM_REQUIRED = 0x00000001
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern uint SetThreadExecutionState(EXECUTION_STATE esFlags);
}
