using Aeroport.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport.DAL
{
    public class AeroportBdd
    {
        private static String ConnectionString = "Server=localhost;Database=vols;Uid=root;";

        #region All

        #region AllAvion


        public static List<Avion> AllAvion()
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, Nom, IdentifiantModele
                FROM Avion;";


            MySqlDataReader reader = command.ExecuteReader();
            List<Avion> avions = new List<Avion>();
            Avion a = null;
            while (reader.Read())
            {
                a = new Avion();
                a.Identifiant = reader.GetInt32("Identifiant");
                a.IdentifiantModele = reader.GetInt32("IdentifiantModele");
                a.Nom = reader.GetString("Nom");

                avions.Add(a);

            }

            connection.Close();
            return avions;
        }
        #endregion

        #region AllConstruct


        public static List<Constructeur> AllConstruct()
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, Nom
                FROM Constructeur;";


            MySqlDataReader reader = command.ExecuteReader();
            List<Constructeur> constructeurs = new List<Constructeur>();
            Constructeur c = null;
            while (reader.Read())
            {
                c = new Constructeur();
                c.Identifiant = reader.GetInt32("Identifiant");
                c.Nom = reader.GetString("Nom");

                constructeurs.Add(c);

            }

            connection.Close();
            return constructeurs;
        }
        #endregion

        #region AllModele

        
        public static List<Modele> AllModele()
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, version, nombreMoteurs, identifiantConstructeur
                FROM Modele;";


            MySqlDataReader reader = command.ExecuteReader();
            List<Modele> modeles = new List<Modele>();
            Modele m = null;
            while (reader.Read())
            {
                m = new Modele();
                m.Identifiant = reader.GetInt32("Identifiant");
                m.IdentifiantConstructeur = reader.GetInt32("IdentifiantConstructeur");
                m.NombreDeMoteur = reader.GetInt32("nombreMoteurs");
                m.Version = reader.GetString("Version");

                modeles.Add(m);

            }

            connection.Close();
            return modeles;
        }
        #endregion

        #endregion

        #region Get


        #region GetConstruct


        public static Constructeur GetConstruct(int id)
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, Nom
                FROM Constructeur 
                WHERE Identifiant =" + id + ";";

            command.Parameters.AddWithValue("Identifiant", id);
            MySqlDataReader reader = command.ExecuteReader();
            Constructeur c = null;
            if (reader.Read())
            {
                c = new Constructeur();
                c.Identifiant = reader.GetInt32("Identifiant");
                c.Nom = reader.GetString("Nom");

            }

            connection.Close();
            return c;
        }
        #endregion
        #region Get Modele


        public static Modele GetModele(int id)
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, version, nombreMoteurs, identifiantConstructeur
                FROM Modele
                Where identifiant =" + id + ";";

            command.Parameters.AddWithValue("Identifiant", id);
            MySqlDataReader reader = command.ExecuteReader();
            Modele m = null;
            if (reader.Read())
            {
                m = new Modele();
                m.Identifiant = reader.GetInt32("Identifiant");
                m.IdentifiantConstructeur = reader.GetInt32("IdentifiantConstructeur");
                m.NombreDeMoteur = reader.GetInt32("nombreMoteurs");
                m.Version = reader.GetString("Version");

            }

            connection.Close();
            return m;
        }
        #endregion
#endregion

        #region Insert


        #region Insert Avion


        public static int InsertAvion(Avion avion)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = $@"
                                INSERT INTO Avion(Nom) 
                                VALUES(@nom);";

            command.Parameters.AddWithValue("@nom", avion.Nom);
            int ajout = command.ExecuteNonQuery();
            connection.Close();
            return ajout;

        }
        #endregion
        #region Insert Modele


        public static int InsertModele(Modele modele)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = $@"
                                INSERT INTO Modele(version, nombreMoteurs) 
                                VALUES(@version, @nombremoteurs);";

            command.Parameters.AddWithValue("@version", modele.Version);
            command.Parameters.AddWithValue("@nombremoteurs", modele.NombreDeMoteur);
            int ajout = command.ExecuteNonQuery();
            connection.Close();
            return ajout;

        }
        #endregion

        #region Insert Construc


        public static int InsertConstruc(Constructeur constr)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = $@"
                                INSERT INTO Constructeur(Nom) 
                                VALUES(@nom);";

            command.Parameters.AddWithValue("@nom", constr.Nom);
            int ajout = command.ExecuteNonQuery();
            connection.Close();
            return ajout;

        }
        #endregion
        #endregion

        #region Delete


        #region Delete Avion
        public static int DeleteAvion(int id)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"DELETE FROM Avion
                                          WHERE Avion.Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@Identifiant", id);
            int avion = command.ExecuteNonQuery();
            connection.Close();
            return avion;
        }
        #endregion

        #region Delete Modele


        public static int DeleteModele(int id)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"DELETE FROM Modele
                                          WHERE Modele.Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@Identifiant", id);
            int modele = command.ExecuteNonQuery();
            connection.Close();
            return modele;
        }
        #endregion

        #region Delete Constructeur
        public static int DeleteConstruc(int id)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"DELETE FROM Constructeur
                                          WHERE Constructeur.Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@Identifiant", id);
            int constr = command.ExecuteNonQuery();
            connection.Close();
            return constr;
        }

        #endregion
        #endregion

        #region Update


        #region Update Avion


        public static int UpdateAvion(Avion avion)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = @"UPDATE Avion SET Identifiant = @Identifiant, Nom = @nom  
                                    WHERE Avion.Identifiant = @Identifiant;";



            command.Parameters.AddWithValue("@Identifiant", avion.Identifiant);
            command.Parameters.AddWithValue("@nom", avion.Nom);
            int update = command.ExecuteNonQuery();
            connection.Close();
            return update;

        }
        #endregion

        #region Update Modele


        public static int UpdateModele(Modele modele)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = @"UPDATE Modele SET Identifiant = @Identifiant, Version = @Version, nombreMoteurs = @nbMoteur
                                    WHERE Modele.Identifiant = @Identifiant;";



            command.Parameters.AddWithValue("@Identifiant", modele.Identifiant);
            command.Parameters.AddWithValue("@Version", modele.Version);
            command.Parameters.AddWithValue("@nbMoteur", modele.NombreDeMoteur);
            int update = command.ExecuteNonQuery();
            connection.Close();
            return update;

        }
        #endregion

        #region Update Construcuteur
        public static int UpdateConstruc(Constructeur constructeur)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = @"UPDATE Modele SET Identifiant = @Identifiant, Nom = @nom
                                    WHERE Modele.Identifiant = @Identifiant;";



            command.Parameters.AddWithValue("@Identifiant", constructeur.Identifiant);
            command.Parameters.AddWithValue("@nom", constructeur.Nom);
            int update = command.ExecuteNonQuery();
            connection.Close();
            return update;

        }
        #endregion 
        #endregion
    }



}


//        public static Livre Find(int id)
//        {
//            MySqlConnection connection = new MySqlConnection(ConnectionString);

//            MySqlCommand command = new MySqlCommand();
//            command.Connection = connection;
//            connection.Open();
//            command.CommandText = @"SELECT Identifiant, NombrePages, Titre, Edition, ISBN, DateEdition, DateLecture, Note, Resume, Commentaire
//                FROM Livre
//                WHERE Livre.Identifiant = @Identifiant;";

//            command.Parameters.AddWithValue("@Identifiant", id);
//            MySqlDataReader reader = command.ExecuteReader();
//            Livre l = null;
//            if (reader.Read())
//            {
//                l = new Livre();
//                l.Identifiant = reader.GetInt32("Identifiant");
//                l.ISBN = reader.GetString("ISBN");
//                l.NombresPages = reader.GetInt32("NombrePages");
//                l.Commentaire = reader.GetString("Commentaire");
//                l.Titre = reader.GetString("Titre");
//                l.Resume = reader.GetString("Resume");
//                l.Edition = reader.GetString("Edition");
//                l.DateLecture = reader.GetDateTime("DateLecture");
//                l.DateEdition = reader.GetInt32("DateEdition");
//                l.Note = reader.GetInt32("Note");


//            }

//            connection.Close();
//            return l;

//        }




//        public static int Update(Livre livre)
//        {

//            MySqlConnection connection = new MySqlConnection(ConnectionString);

//            connection.Open();

//            MySqlCommand command = new MySqlCommand();
//            command.Connection = connection;


//            command.CommandText = @"UPDATE Livre SET Identifiant = @Identifiant, NombrePages = @nbpages, 
//                                  Titre = @titre, Edition = @edition, ISBN = @isbn, DateEdition = @dateedition, 
//                                  DateLecture = @datelecture, Note = @note, Resume = @resume, Commentaire = @commentaire

//                WHERE Livre.Identifiant = @Identifiant;";

//            command.Parameters.AddWithValue("@Identifiant", livre.Identifiant);
//            command.Parameters.AddWithValue("@nbpages", livre.NombresPages);
//            command.Parameters.AddWithValue("@titre", livre.Titre);
//            command.Parameters.AddWithValue("@edition", livre.Edition);
//            command.Parameters.AddWithValue("@isbn", livre.ISBN);
//            command.Parameters.AddWithValue("@dateedition", livre.DateEdition);
//            command.Parameters.AddWithValue("@datelecture", livre.DateLecture);
//            command.Parameters.AddWithValue("@note", livre.Note);
//            command.Parameters.AddWithValue("@resume", livre.Resume);
//            command.Parameters.AddWithValue("@commentaire", livre.Commentaire);
//            int ajout = command.ExecuteNonQuery();
//            connection.Close();
//            return ajout;

//        }
//    }
//}

