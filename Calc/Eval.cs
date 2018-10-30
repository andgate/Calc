using System;
using System.Runtime.InteropServices;     // DLL support
using System.Text;


class Eval
{
    [DllImport("eval.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr eval(IntPtr input);

    [DllImport("eval.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void HsStart();

    [DllImport("eval.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void HsEnd();

    public static string eval(String input)
    {
        IntPtr inputPtr = Marshal.StringToHGlobalAnsi(input);
        IntPtr resultPtr = eval(inputPtr);
        return Marshal.PtrToStringAnsi(resultPtr);
    }
}