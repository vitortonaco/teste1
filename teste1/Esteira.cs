using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace teste1
{
    internal class Esteira
    {
        float Velocidade = 0.3f;
        public List<Conteiner> Conteiners = new List<Conteiner>();

        public void Update(float elapsedTime)
        {
            Conteiners.ForEach(conteiner => conteiner.Position += new Vector3(elapsedTime*Velocidade,0,0));
        }


    }
}
