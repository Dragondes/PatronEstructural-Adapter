using System;

namespace patron_de_diseño_estructural_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Motor motor1 = new MotorDiesel();
            motor1.Arrancar();
            motor1.Acelerar();
            motor1.Detener();


            Motor motor2 = new MotorElectricoAdapter();
            motor2.Arrancar();
            motor2.Acelerar();
            motor2.Detener();

            Console.ReadKey();
        }
    }
}
