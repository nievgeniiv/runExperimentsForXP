using System.IO.Ports;
using System.Windows.Forms;

namespace experiments.Services
{
    class ServiceStepMotor
    {
        public static SerialPort _comPort;

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

        public static void transmitterStepForward()
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            _comPort.Write("1");
        }

        public static void transmitterStepBack()
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            _comPort.Write("2");
        }

        public static void receiverStepForward()
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            _comPort.Write("3");
        }

        public static void receiverStepBack()
        {
            if (!isConnectComPort())
            {
                MessageBox.Show(_messageErrorNotConnectComPortText);
                return;
            }
            _comPort.Write("4");
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
