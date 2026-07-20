using System.Dynamic;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading, ushort prefixByte)
    {
        string numberType;
        ushort numberBytes;
        bool signed;
        ushort prefixByte;    

        if ((reading <= -2147483649 && reading < 0) || (reading >= 4294967296 && reading > 0 ))
        {
            numberType = "long";
            numberBytes = 8;
            if (reading < 0)
            {
                prefixByte = 256 - 8;
            } else
            {
                prefixByte = numberBytes;
            }
        } 
        else if (reading >= 2147483648 && reading > 0)
        {
            numberType = "uint";
            numberBytes = 4;
            prefixByte = numberBytes;
        }
        else if (reading >= 65536 && reading > 0)
        {
            numberType = "int";
            numberBytes = 4;
            prefixByte = numberBytes;
        }
        else if (reading >= 0 && reading > 0)
        {
            numberType = "ushort";
            numberBytes = 2;
            prefixByte = numberBytes;
        }
        else if (reading >= -32768 && reading < 0)
        {
            numberType = "short";
            numberBytes = 2;
            prefixByte = 256 - 2;
        }
        else if (reading >= -2147483648 && reading < 0)
        {
            numberType = "int";
            numberBytes = 4;
            prefixByte = 256 - 4;
        }

        byte[] buffer = new byte[9];
        buffer[0] = (byte)prefixByte;

        byte[] arr = BitConverter.GetBytes((numberType)reading);

        for (int i = 1; i < arr.Length; i++)
        {
            buffer[i] = arr[i];
        }

        return buffer; //example return, just avoiding error
    }

    public static long FromBuffer(byte[] buffer)
    {
        return 2;
    }
}
