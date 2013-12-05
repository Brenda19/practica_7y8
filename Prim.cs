using System;
using MySql.Data.MySqlClient;
namespace prac7
{
	
	public class Prim :c
	{
		public Prim ()
		{
		}
		
		public void verTabla(){
			this.abre();
            MySqlCommand com = new MySqlCommand(this.querySelect(), myConnection);
            MySqlDataReader re = com.ExecuteReader();	
	        while (re.Read()){
            	string id = re["id"].ToString();
            	string nom = re["Nombre"].ToString();
	            string cod = re["Codigo"].ToString();
	            string tel = re["Telefono"].ToString();
	            string em = re["Email"].ToString();
	            Console.WriteLine(" ID "+ id + " Codigo " + cod + " Nombre " + nom+
	                              "Telefono " + tel + "Email" + em);
	       }
			
            re.Close();
			re = null;
            com.Dispose();
			com = null;
			cierra();
		}
		
		public void CreaNuevo(string Nombre, string Codigo, string Telefono, string Email){
			this.abre();
			string s = "INSERT INTO `info` (`Nombre`, `Codigo`, `Telefono`, `Email`) VALUES ('" + Nombre + "', '"+Codigo +"','"+Telefono+ "', '"+Email+"')";
			this.Ejecuta(s);
			this.cierra();
		}
		
		
		
		public void Editar(string id, string nom, string cod, string em, string tel){
			this.abre();
			string s = "UPDATE `info` SET `Nombre`='" + nom +"' ,`Codigo`='" + cod + "'," +
"			`Telefono`='" + tel + "',  `Email`='" + em + "' WHERE (`id`='" + id + "')";
			this.Ejecuta(s);
			this.cierra();
		}
		
		public void EliminaPorId(string id){
			this.abre();
			string s = "DELETE FROM `info` WHERE (`id`='" + id + "')";
			this.Ejecuta(s);
			this.cierra();
		}
		private int Ejecuta(string s){
			MySqlCommand com = new MySqlCommand(s,this.myConnection);
			int a = com.ExecuteNonQuery();
			com.Dispose();
			com = null;
			return a;
		}
		
		private string querySelect(){
			return "SELECT * " + "FROM info";
		}
	}
}





