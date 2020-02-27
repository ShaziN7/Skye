using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;

public class OrientationController
{
    // Store values read from sensor
 
    private string key;
    public bool firstPressed = false;
    private string oldKey = "";

    // Serial and threading for reading from sensor
    private SerialPort serialPort;
    Thread receiveThread;
    private string comPort;

    public OrientationController()
    {
        comPort = "/dev/ttyACM0";
        init();
    }

    public OrientationController(string port)
    {
        comPort = port;
        init();
    }

    public string getKey()
    {
        if (oldKey != key)
        {
            oldKey = key;
            firstPressed = true;
            return key;
        }

        firstPressed = false;
        return key;
    }

    public string getCOMvalue()
    {
        return comPort;
    }

    // Thread for processing incoming sensor data
    private void init()
    {
        receiveThread = new Thread(
        new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
    }

    private void ReceiveData()
    {
        //comPort = Load("settings.txt");
   
        serialPort = new SerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
        OpenConnection();

        while (true)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string data = serialPort.ReadLine();

                    if (data != null)
                    {
                        //data = data.Trim();

                        key = data;
                    }
                }

                catch (System.Exception)
                {

                }
            }

        }
    }

    void OpenConnection()
    {
        if (serialPort != null)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Debug.Log("Closing port, because it was already open!");
            }
            else
            {
                serialPort.Open();
                serialPort.ReadTimeout = 50;
                Debug.Log("Port Opened!");
            }
        }
    }

    void OnDestroy()
    {
        serialPort.Close();
        if (receiveThread != null)
            receiveThread.Abort();
        Debug.Log("Port closed!");
    }

    // Read from a text file the port number of the controller.
    // The port number can be found in the device manager.
    string Load(string fileName)
    {
        string readPort = "";
        try
        {
            string line;
            StreamReader theReader = new StreamReader(fileName, Encoding.Default);
            using (theReader)
            {
                do
                {
                    line = theReader.ReadLine();
                    if (line != null)
                    {
                        readPort = line;
                    }
                }
                while (line != null);
                theReader.Close();
                return readPort;
            }
        }
        catch (IOException)
        {
            return null;
        }
    }
}