using Client.Orders;
using Client.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersClient ordersClient = new OrdersClient();
            ProductsClient productsClient = new ProductsClient();

            const string MENU = @"******************BIENVENIDO****************
            1 - Obtener precio
            2 - Actualizar precio
            3 - Salir
            Seleccione una opción: ";


            bool stop = false;
            int option = 0;
            string code = String.Empty;
           
            bool stopAux = false;

            do
            {

                Console.Write(MENU);

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Caractér inválido, ingrese otro");
                    
                }

                // se verifica cuál opción desea realizar
                switch (option)
                {
                    case 1:
                        decimal quantity = 0;

                        Console.Write("Ingrese el código: ");
                        code = Console.ReadLine();

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese la cantidad a comprar: ");
                                quantity = decimal.Parse(Console.ReadLine());

                                stopAux = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Verifique el caracter ingresado, debe ser numérico");
                                stopAux = false;
                            }


                        } while (!stopAux);

                        decimal finalPrice = ordersClient.GetPrice(code, quantity);

                        Console.WriteLine(String.Format("El precio es {0}", finalPrice));
                        break;

                    case 2:

                        decimal newPrice = 0;

                        Console.Write("Ingrese el código: ");
                        code = Console.ReadLine();

                        do
                        {
                            try
                            {
                                Console.Write("Ingrese el nuevo precio: ");
                                newPrice = decimal.Parse(Console.ReadLine());

                                stopAux = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Verifique el caracter ingresado, debe ser numérico");
                                stopAux = false;
                            }


                        } while (!stopAux);

                        bool result = productsClient.UpdatePrice(code, newPrice);

                        Console.WriteLine(result ? "El precio ha sido actualizado" : "Ha ocurrido un error a la hora de actualizar, intente de nuevo");
                        break;

                    case 3:
                        stop = true;
                        break;

                    default:
                        break;
                }

                Console.WriteLine();

            } while (!stop);
        
            Console.ReadLine();
        }
    }
}
