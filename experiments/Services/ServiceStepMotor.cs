using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace experiments.Services
{
    class ServiceStepMotor
    {
        public static string TRANSMITTER_STEP_FORWARD = "1";
        public static string TRANSMITTER_STEP_BACK = "2";
        public static string RECEIVER_STEP_FORWARD = "3";
        public static string RECEIVER_STEP_BACK = "4";
        
        public static string TRANSMITTER_SECTOR_FORWARD = "0";
        public static string TRANSMITTER_SECTOR_BACK = "9";
        public static string RECEIVER_SECTOR_FORWARD = "8";
        public static string RECEIVER_SECTOR_BACK = "7";
        
        private static SerialPort _comPort;

        private static string _selectedComPort;
        private static string _messageErrorNotConnectComPortText = "Нет соединения с COM-портом";
        private static string _messageErrorNotSelectedComPortText = "Не выбран COM-порт";

        public static string[] getAllComPort()
        {
            return SerialPort.GetPortNames();
        }

        public static void connectWithComPort(string nameComPort, int speedComPort)
        {
            if (nameComPort == "")
            {
                MessageBox.Show(_messageErrorNotSelectedComPortText);
                return;
            }
            if (!isConnectComPort())
            {
                _selectedComPort = nameComPort;
                _comPort = new SerialPort(_selectedComPort, speedComPort, Parity.None, 8, StopBits.One);
                _comPort.Open();
            }
           
        }

        public static string getSelectedComPort()
        {
            return _selectedComPort;
        }

        public static void disconnectWithComPort()
        {
            if (_comPort.IsOpen)
            {
                _comPort.Close();
            }
        }

        public static void stepMotorGo(string action)
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            _comPort.Write(action);
        }

        public static void stepMotorGoSerious()
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            
            for (int i = 1; i <= 4; i++)
            {
                _comPort.Write(TRANSMITTER_SECTOR_FORWARD);
                System.Threading.Thread.Sleep(1000);
                MessageBox.Show("Transmitter in Sector: " + i.ToString());
                for (int j = 1; j <= 4; j++)
                {
                    _comPort.Write(RECEIVER_SECTOR_FORWARD);
                    System.Threading.Thread.Sleep(1000);
                    MessageBox.Show("Receiver in Sector: " + j.ToString());
                }
            }
        }

        public static bool isConnectComPort()
        {
            if (_comPort == null)
            {
                return false;
            }
            return _comPort.IsOpen;
        }
    }
}
