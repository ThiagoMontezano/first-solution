using System;

namespace library
{
    public class Calculator : ICalculator
    {
        public float sum(float firstValue, float secondValue){
            return firstValue+secondValue;
        }

        public float div(float dividend, float divider){
            return dividend/divider;
        }

        //TODO: fazer demais operações 
    }
}
