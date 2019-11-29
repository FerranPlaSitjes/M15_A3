﻿using A3_CSharp_MVC;
using Model.ModelDTO.Reserva;
using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Controller
{
    public class Controller1
    {
        public hotelEntities context;
        public Form1 f;
        RepositoryClient rc;
        ControllerClient ccl;

        public Controller1()
        {
            f = new Form1();
            rc = new RepositoryClient();
            ccl = new ControllerClient(f);
            Application.Run(f);
        }
    }
}
