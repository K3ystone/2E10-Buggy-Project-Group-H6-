using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


//




namespace ConsoleApplication6
{
    class XbeeChatter
    {

        static bool _continue;
        static SerialPort _serialPort;


        static void Main(string[] args)
        {

            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();
             */

            _serialPort = new SerialPort(); //Make a new SerialPort type variable (this class is in the System.IO.Ports)
                                            //Initializes with default constructor for that class 
                                            //[ie. No parameters/Parenthesis is blank/We assume it is set to a default blank value]

            _serialPort.PortName = "COM6";  //Name the variable PortName (in the new SeialPort we just created) to the port we want to use 
                                            //(in this case COM6 has our xbee on it so we are telling it we want to use that port)
           
            
            // Set the read/write timeouts [Not important ignore this, just good practice to have this for now]
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();             //Open the port (like picking up a telephone to make a call :D)
            _continue = true;               //Set our variable to true (just cause we need it later not important now)

            Console.Write("Name: ");        //Prints the string to the console screen
            name = Console.ReadLine();      //sets variable name equal to whatever the user types in

            Console.WriteLine("Type QUIT to exit");     //Prints the string to the console screen



            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("quit", message))     //test if variable message equals quit (if user typed it in)
                {
                    _continue = false;                          //change value to false [this will stop the loop]
                }
                else
                {
                    _serialPort.WriteLine(String.Format("<{0}>: {1}", name, message));
                }
            }

            _serialPort.Close();    //Port is close so no more data can send or be recieved





        }
    }
}
