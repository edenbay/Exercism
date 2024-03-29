using System;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{TelemetryBuffer.ToBuffer(Int16.MinValue - 1)}");
        Console.WriteLine($"{TelemetryBuffer.FromBuffer(new byte[] { 0 })}");

    }
}
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            int size = Marshal.SizeOf(reading);
            size = GetSize(reading);

            var h = BitConverter.GetBytes(reading).ToList();
            byte prefix = (byte)(256 - size);
            byte[] bytes = new byte[] { prefix };

            if (size != 0)
            {
                h.InsertRange(0, bytes);
            }
            bytes = h.ToArray<byte>();
            return bytes;
        }

        public static long FromBuffer(byte[] buffer)
        {
            buffer = new byte[] { 0xf8, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x7f };
            return BitConverter.ToInt64(buffer, 1);
        }

    private static int GetSize(long reading)
    {
        try
        {
            var output = reading;
            if (reading > 0)
            {
                Convert.ToUInt64(output);
                Convert.ToUInt32(output);
                Convert.ToUInt16(output);
            }
            else
            {
                Convert.ToInt64(output);
                Convert.ToInt32(output);
                Convert.ToInt16(output);
                Convert.ToSByte(output);
            }

            return Marshal.SizeOf(output);
        }
        catch (Exception)
        {

            return 0;
        }
        //        4_294_967_296 | 9_223_372_036_854_775_807 | `long`   |
        //| 2_147_483_648 | 4_294_967_295 | `uint`   |
        //| 65_536 | 2_147_483_647 | `int`    |
        //| 0 | 65_535 | `ushort` |
        //| -32_768 | -1 | `short`  |
        //| -2_147_483_648 | -32_769 | `int`    |
        //| -9_223_372_036_854_775_808 | -2_147_483_649 | `long`   |

           

           
    }
}

