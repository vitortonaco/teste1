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
        public Esteira(Vector3 velocity)
        {
            this.Velocidade = velocity;
        }

        private Vector3 Velocidade;

        
        public List<Conteiner> Conteiners = new List<Conteiner>();

        public void Update(float elapsedTime)
        {
            Conteiners.ForEach(conteiner => conteiner.Position += new Vector3(elapsedTime*Velocidade.X,elapsedTime*Velocidade.Y,elapsedTime*Velocidade.Z));
        }


    }
}
