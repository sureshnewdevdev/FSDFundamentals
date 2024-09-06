using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public interface IBrid
    {
        string BridName { get; set; }
        string Eating();

        void Fly();
    }

    public interface IAnimal
    {
        string AnimalName { get; set; }
        string Eating();

    }

    public class Bat : IBrid, IAnimal
    {
        string IBrid.BridName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IAnimal.AnimalName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IBrid.Eating()
        {
            throw new NotImplementedException();
        }

        string IAnimal.Eating()
        {
            throw new NotImplementedException();
        }

        void IBrid.Fly()
        {
            throw new NotImplementedException();
        }
    }
    // Write a program which Defines Shapes , Squre - MakingBuilding, Circle - Travelling
}
