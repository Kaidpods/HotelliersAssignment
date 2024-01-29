using HotelliersAssignment;
using HotelliersAssignment.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HotelliersAssignment
{
    public class ClientDatabase
{
    // private static field to store the instance of the class
    private static ClientDatabase ClientDB;

    // all players of the quiz
    private List<Client> AllClients;

    // The constructor for this type of class is private. This prevents any direct calls to create instances
    // of the class. Creates a new instance of a List to hold all the players.
    private ClientDatabase()
    {
        AllClients = new List<Client>();

        // if client information was stored in a file or database, it could be loaded here.
    }

    // Method to control access to the class. It checks if an instance has been created.
    // If it hasn't, it creates it; otherwise, it returns the existing instance.
    public static ClientDatabase Instance
        {
            get
            {
                // check if an instance of the class has already been created.
                if (ClientDB == null)
                {
                    ClientDB = new ClientDatabase();
                }
                return ClientDB;
            }
        }



        /// <summary>
        /// Method to add a client to the database
        /// </summary>
        /// <param name="client">The client to add</param>
        public void AddClient(Client client)
    {
        AllClients.Add(client);

            writeClient(client);
    }

        public void writeClient(Client client)
        {
            using (StreamWriter stream = File.AppendText("ClientDatabase.csv"))
            {
                stream.WriteLine(client.ToString());
            }
        }

        public void createFile()
        {
            string path = "ClientDatabase.csv";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) ;
                
            }
        }
}
}