using System;
using System.Collections.Generic;
using System.Text;

namespace Management_Hospital
{
     class RoomFullException:Exception
    {

        public RoomFullException(string message):base(message) {

           

        }
    }
}





