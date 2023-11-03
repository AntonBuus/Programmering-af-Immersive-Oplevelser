// using System.IO.Ports;
// using UnityEngine;

// public class ArduinoCommunication : MonoBehaviour
// {
//     // private SerialPort serialPort;
//     public string portName = "COM3"; // Adjust this to match your Arduino's port
//     public int baudRate = 9600;      // Match the Arduino's baud rate

//     void Start()
//     {
//         serialPort = new SerialPort(portName, baudRate);
//         serialPort.Open();
//     }

//     void Update()
//     {
//         if (serialPort.IsOpen)
//         {
//             try
//             {
//                 string data = serialPort.ReadLine();
//                 int emgValue = int.Parse(data);

//                 // Use the EMG value to control the cube's flying behavior
//                 // For example, you can adjust the forceMultiplier based on the EMG value
//                 float forceMultiplier = emgValue / 100.0f;
//                 // Apply force to the cube's Rigidbody as shown in the previous Unity script
//             }
//             catch (System.Exception e)
//             {
//                 Debug.LogWarning("Error reading serial data: " + e.Message);
//             }
//         }
//     }

//     void OnDestroy()
//     {
//         serialPort.Close();
//     }
// }
