﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace PROYECTO
{
  public   interface IReceptor
    {
        void Recibir(Factura factura);
    }
}