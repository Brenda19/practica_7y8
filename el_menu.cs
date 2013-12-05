
using System;

namespace prac7
{
	
	public class el_menu
	{
		public el_menu()
		{
		}
		
		Prim p = new Prim();
		public void verMenu(){
		
			 
			string nom, em, cod, tel, id, o;
							
					Console.WriteLine("-----Menu-----");
					Console.WriteLine("a.-Ver tabla");
					Console.WriteLine("b.-Agregar");
					Console.WriteLine("c.-Editar");
					Console.WriteLine("d.-Eliminar");
					Console.WriteLine("e.-Salir");
					
				
					o=Console.ReadLine();
				switch(o){
						
				case "a":
					//Console.WriteLine("Ver tabla");
					p.verTabla();
					verMenu();
					break;
					
					
				case "b":
					Console.WriteLine("Agregar");
					Console.Clear();
					Console.Write("Nombre: ");
					nom= Console.ReadLine();
					Console.Write("Codigo: ");
					cod = Console.ReadLine();
					Console.Write("Telefono: ");
					tel= Console.ReadLine();
					Console.Write("Email: ");
					em=Console.ReadLine();
					Console.WriteLine("\n");
					p.CreaNuevo(nom,cod,tel,em);
					Console.WriteLine("\n");
					verMenu();
					break;
					
					
				case "c":
					Console.WriteLine("Editar");
					Console.WriteLine("ID a editar");
					id=Console.ReadLine();
					Console.Write("Nombre: ");
					nom= Console.ReadLine();
					Console.Write("Codigo: ");
					cod= Console.ReadLine();
					Console.Write("Telefono: ");
					tel= Console.ReadLine();
					Console.Write("Email: ");
					em=Console.ReadLine();
					Console.WriteLine("\n");
					p.Editar(id,nom,cod,tel,em);
              		Console.WriteLine("\n");
					verMenu();
					break;
					
				case "d":
					Console.WriteLine("Eliminar");
					Console.WriteLine("ID del ingreso a eliminar:");
					id=Console.ReadLine();
				    p.EliminaPorId(id);
					Console.WriteLine("\n");
			    	verMenu();
					break;
					
				case "e": System.Environment.Exit(-1);
					break;			
						
						
			}
			
		}
	}
}
