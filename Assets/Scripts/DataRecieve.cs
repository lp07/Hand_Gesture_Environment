using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class DataRecieve : MonoBehaviour
{
    Thread recieveThread;
    UdpClient client;
    public int port = 5053;
    public bool startRecieving = true;
    public bool printToConsole = false;
    public string data;

    // Start is called before the first frame update
    void Start()
    {
        recieveThread = new Thread(
            new ThreadStart(RecieveData));
        recieveThread.IsBackground = true;
        recieveThread.Start();
    }

    private void RecieveData()
    {
        client = new UdpClient(port);
        while(startRecieving)
        {
            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any,0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                // if(printToConsole){print(data);}
            }
            catch (Exception err)
            {
                print(err.ToString());
            }
        }
    }
}
