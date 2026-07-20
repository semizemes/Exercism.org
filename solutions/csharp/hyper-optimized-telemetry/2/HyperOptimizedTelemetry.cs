public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];

        if (reading >= ushort.MinValue && reading <= ushort.MaxValue)
        {
            var buff = BitConverter.GetBytes((ushort)reading);
            buffer[0] = 2;
            Array.Copy(buff, 0, buffer, 1, buff.Length);
        }
        else if (reading >= short.MinValue && reading <= short.MaxValue)
        {
            var buff = BitConverter.GetBytes((short)reading);
            buffer[0] = 254;
            Array.Copy(buff, 0, buffer, 1, buff.Length);
        }
        else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            var buff = BitConverter.GetBytes((int)reading);
            buffer[0] = 252;
            Array.Copy(buff, 0, buffer, 1, buff.Length);
        }
        else if (reading >= uint.MinValue && reading <= uint.MaxValue)
        {
            var buff = BitConverter.GetBytes((uint)reading);
            buffer[0] = 4;
            Array.Copy(buff, 0, buffer, 1, buff.Length);
        }


        else
        {
            var buff = BitConverter.GetBytes(reading);

            buffer[0] = 248;
            Array.Copy(buff, 0, buffer, 1, buff.Length);
        }
        return buffer;

    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch
    {
        2 => BitConverter.ToUInt16(buffer[1..]),
        254 => BitConverter.ToInt16(buffer, 1), // better
        252 => BitConverter.ToInt32(buffer[1..]),
        4 => BitConverter.ToUInt32(buffer[1..]),
        248 => BitConverter.ToInt64(buffer[1..]),
        _ => 0
    };

}