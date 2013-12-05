
using System;
using MySql.Data.MySqlClient;

namespace prac7
{
	
	public class c
	{
		protected MySqlConnection myConnection;
		public c ()
		{
		}
		
		protected void abre(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=informacion;" +
	          	"User ID=root;" +
	          	"Password=nolove78;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cierra(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}


