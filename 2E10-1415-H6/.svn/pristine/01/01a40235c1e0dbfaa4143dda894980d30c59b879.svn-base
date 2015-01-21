using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        static SerialPort _serialPort;
        

        static void Main(string[] args)
        {

            _serialPort = new SerialPort();
          

            _serialPort.PortName = "COM6";
            _serialPort.Open();


            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            

           
             _serialPort.WriteLine("yoyoyo");

             Console.ReadLine();

            _serialPort.Close();
            
        }



        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine(indata);
        }

    }    

}
