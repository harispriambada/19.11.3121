﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeMechine
{
    class Milk
    {
  
            private int isi = 0;
            private int isiOneCup = 100;

            public Milk(int isi)
            {
                this.isi = isi;
            }

            public Boolean isAvailable()
            {
                return this.isi >= this.isiOneCup;
            }

            public void makeOneCup()
            {
                this.isi -= isiOneCup;
            }

            public int getIsi()
            {
                return this.isi;
            }
        }
    }

