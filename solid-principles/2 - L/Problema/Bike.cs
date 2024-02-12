using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles._2___L.Problema
{
    internal class Bike : Vehicle
    {
        //Acelerar aplica para bicicleta
        public override void SpeedUp()
        {
            //code to SpeedUp
        }

        //Despegar no aplica para bicicleta, aqui nace el principio
        public override void TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
