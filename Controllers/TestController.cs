using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robot.Services;

namespace Robot.Controllers
{
    public class TestController : Controller
    {
        // GET /test
        [HttpGet]
        public string Index()
        {
            // connect to I2C device bus 1
            var i2cBushandle = I2CService.Open("/dev/i2c-1", I2CService.OPEN_READ_WRITE);
            Console.WriteLine(i2cBushandle);
            // open the slave device at address 0x48 for communication
            int registerAddress = 0x7;
            var deviceReturnCode = I2CService.Ioctl(i2cBushandle, I2CService.I2C_SLAVE, registerAddress);

            // read the first two bytes from the device into an array
            var deviceDataInMemory = new byte[2];
            I2CService.Read(i2cBushandle, deviceDataInMemory, deviceDataInMemory.Length);

            Console.WriteLine($"Most significant byte = {deviceDataInMemory[0]}");
            Console.WriteLine($"Least significant byte = {deviceDataInMemory[1]}");

            return "OK";
        }
    }
}
