using System.Runtime.InteropServices;

namespace Robot.Services
{
    public class I2CService {
        public static int OPEN_READ_WRITE = 2;
        public static int I2C_SLAVE = 0x0703;
 
        [DllImport("libc.so.6", EntryPoint = "open")]
        public extern static int Open(string fileName, int mode);
 
        [DllImport("libc.so.6", EntryPoint = "ioctl", SetLastError = true)]
        public extern static int Ioctl(int fd, int request, int data);
 
        [DllImport("libc.so.6", EntryPoint = "read", SetLastError = true)]
        public static extern int Read(int handle, byte[] data, int length);

    }
}