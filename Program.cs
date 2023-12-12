using System;

namespace U4_programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
                //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

                //Si vende menos de 100 litros, no hay descuento.
                //Si vende entre 101 y 300 litros, el descuento es del 10%.
                //Si vende entre 301 y 500 litros, el descuento es del 15%.
                //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
                //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de //litros vendidos y calcule y emita el importe con el descuento  aplicado.
            float importe,desc,final;
            int lts;
            Console.WriteLine("Bienvenido a nuestra tienda, por favor indique el importe de su compra");
            importe=float.Parse(Console.ReadLine());
            Console.WriteLine("por favor indique la cantidad de litros de su compra");
            lts= int.Parse(Console.ReadLine());

            if (lts>500){   
                desc=((importe*25)/100);
                final=importe-desc;
                Console.WriteLine("usted tiene el  25% de descuento,su importe es de "+final);
            }   else if(lts>300 && lts<=500){
                    desc=((importe*15)/100);
                    final=importe-desc;
                    Console.WriteLine("usted tiene el  15% de descuento,su importe es de "+final);
                }   else if (lts> 100 && lts <= 300){
                    desc=((importe*10)/100);
                    final=importe-desc;
                    Console.WriteLine("usted tiene el  10% de descuento,su importe es de "+final);  
                }   else{
                        Console.WriteLine("el precio final es "+ importe);
                    }
        }
    }
}
