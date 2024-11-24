using PolyGraphProject.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyGraphProject
{
    public class ConnectionUtils
    {
        public ConnectionUtils() { }

        private void setConnected(bool _connected)
        {
            this.connected = _connected;
        }

        public bool isConnected()
        {
            //Gee i really wonder what this does
            return this.connected;
        }

        public void setPidandVid(int pid, int vid)
        { 
            //sets initialized HIDManager with new one specified with the pid and vid
            this.HIDManager = new HIDManager(pid, vid);
        }

        public void connectToPolygraph()
        {
            //Sets result of connecting to the HID and sets that to connected
            var connect = this.HIDManager.connect();
            setConnected(connect);
            return;
        }

        public void disconnectToPolygraph()
        {
            //Sets connected to the opposite result of disconnect.
            bool connect = !this.HIDManager.disconnect();
            setConnected(connect);
        }

        private protected HIDManager HIDManager;
        private protected bool connected;
    }
}
