﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Push:INotificador
    {
        public void Notificar()
        {
            Console.WriteLine("Notificar por Push");
        }
    }
}
