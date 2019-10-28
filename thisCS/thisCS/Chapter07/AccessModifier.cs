using System;
using System.Collections.Generic;
using System.Text;

namespace thisCS.Chapter07
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }

        internal void TurnOnWater()
        {
            Console.WriteLine($"Ture on water : {temperature}");
        }
    }
    class AccessModifier
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        WaterHeater heater = new WaterHeater();
        //        heater.SetTemperature(20);
        //        heater.TurnOnWater();

        //        heater.SetTemperature(-2);
        //        heater.TurnOnWater();

        //        heater.SetTemperature(50);
        //        heater.TurnOnWater();
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}
    }
}
/* 접근 한정자로 공개 수준 결정하기
 * 
 * public 전부
 * protected 파생클래스에서는 접근
 * private 파생에서도 불가
 * internal 같은 어셈블리만 접근
 * protected internal 같은 어셈블리 파생클래스만 접근
 * private protected  같은 어셈블리에 있는 클래스에서 상속받은 클래스 내부에서만 접근
 */