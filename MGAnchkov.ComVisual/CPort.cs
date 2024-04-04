using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGAnchkov.ComVisual;

internal class CPort
{
    System.IO.Ports.SerialPort Port;

    public CPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits)
    {
        Port = new System.IO.Ports.SerialPort(portName, baudRate, parity, dataBits, stopBits);
    }


}
