using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    internal class Conteiner:MateriaFisica
    {
        public Conteiner(float volume, Vector3 position, float weight)
            :base(volume)
        {
            this.Position = position;
            this.Maxweight = weight;
        }
        
        private float weight;
        public float Maxweight { get => weight; set { weight = value; FreeWeightCalculate(); } }

        public Vector3 Position { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        public void AddItem(Item item)
        {
            if (FreeVolume > item.Volume && FreeWeight > item.Weight)
            {
                Itens.Add(item);
                FreeWeightCalculate();
            }
            else
            {
                throw new Exception("Volume or weight not allowed");
            }

        }
        public float FreeVolume => this.Volume - Itens.Sum(item=>item.Volume); 

        public float FreeWeight {  get; set; }

        public void FreeWeightCalculate()
        {
            FreeWeight = this.Maxweight - Itens.Sum(item => item.Weight);

        }

    }
}
