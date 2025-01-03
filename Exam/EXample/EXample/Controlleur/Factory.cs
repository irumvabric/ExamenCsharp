﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using Modele;
using System.Diagnostics;
using MySql.Data.MySqlClient.Memcached;
using System.Net.Sockets;

namespace Controlleur
{
    public class Factory
    {
        static MySqlConnection conn = null;

        static Modele.Client client = null;
        static Modele.Techniciens technicien = null;
        static Modele.Materiel mater = null;
        static Modele.Reparation repar1 = null;


        public static void initialiserConn()
        {
            string pwd = "";
            string chaine = "Server=localhost;Database=maisoninformatique;port=3306 ; User Id=root;password = " + pwd;
            conn = new MySqlConnection(chaine);
        }


        #region Client

        public static ArrayList getAllClients() {
        
            ArrayList clients = new ArrayList();

            

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select * from client";
            MySqlDataReader ClientReader = commande.ExecuteReader();
            while (ClientReader.Read())
            {
                client = new Modele.Client();

                client.Matricule = ClientReader["idClient"].ToString();
                client.Nom = ClientReader["nom"].ToString();
                client.Genre = ClientReader["genre"].ToString();
                client.Telephone = ClientReader["tel"].ToString();
                client.Email = ClientReader["email"].ToString();
                client.Nationalite = ClientReader["nationalite"].ToString();
                clients.Add(client);
            }
            ClientReader.Close();
            conn.Close();
            return clients;
        }
        //   public static Clients getClientByID() { return null; }

        public static Modele.Client addClients(Modele.Client cl1) 
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO client(idClient,nom,genre,tel,email,nationalite) VALUES(@id, @no, @ge,@tel, @email, @not)";

                command.Parameters.Add(new MySqlParameter("@id", cl1.Matricule));
                command.Parameters.Add(new MySqlParameter("@no", cl1.Nom));
                command.Parameters.Add(new MySqlParameter("@ge", cl1.Genre));
                command.Parameters.Add(new MySqlParameter("@tel", cl1.Telephone));
                command.Parameters.Add(new MySqlParameter("@email", cl1.Email));
                command.Parameters.Add(new MySqlParameter("@not", cl1.Nationalite));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cl1;
        }

        public static Modele.Client getIdByClient(string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

                Modele.Client cl2 = null;

           
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * FROM client WHERE idClient = @id";

                command.Parameters.Add(new MySqlParameter("@id", idClient));

                MySqlDataReader ClientReader = command.ExecuteReader();
                try
                {

                    if (ClientReader.Read())
                    {
                    cl2 = new Modele.Client();

                    cl2.Matricule = ClientReader["idClient"].ToString();
                    cl2.Nom = ClientReader["nom"].ToString();
                    cl2.Genre = ClientReader["genre"].ToString();
                    cl2.Telephone = ClientReader["tel"].ToString();
                    cl2.Email = ClientReader["email"].ToString();
                    cl2.Nationalite = ClientReader["nationalite"].ToString();

                    }
                    ClientReader.Close();

                    command.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    ClientReader.Close();
                    conn.Close();
                    throw ex;
                    
                }
                return cl2;
            
            
        }
        

        public static void supprimerClient(Modele.Client cl1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

          //  Modele.Client cl1 = null;

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM client WHERE idClient = @id";

                command.Parameters.Add(new MySqlParameter("@id", cl1.Matricule));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            
        }

        public static Modele.Client updateClients(Modele.Client cl1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE client SET nom = @no ,genre = @ge ,tel = @tel ,email = @email ,nationalite = @no  WHERE idClient = @id";

                command.Parameters.Add(new MySqlParameter("@id", cl1.Matricule));
                command.Parameters.Add(new MySqlParameter("@no", cl1.Nom));
                command.Parameters.Add(new MySqlParameter("@ge", cl1.Genre));
                command.Parameters.Add(new MySqlParameter("@tel", cl1.Telephone));
                command.Parameters.Add(new MySqlParameter("@email", cl1.Email));
                command.Parameters.Add(new MySqlParameter("@not", cl1.Nationalite));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cl1;
        }
        #endregion

        #region Technitien


        public static ArrayList getAlltechniciens()
        {

            ArrayList techniciens = new ArrayList();

            

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select * from techniciens";
            MySqlDataReader techniciensReader = commande.ExecuteReader();
            while (techniciensReader.Read())
            {
                technicien = new Modele.Techniciens();

                technicien.Matricule = techniciensReader["matricule"].ToString();
                technicien.Nom = techniciensReader["nom"].ToString();
                technicien.Genre = techniciensReader["genre"].ToString();
                technicien.Telephone = techniciensReader["telephone"].ToString();
                technicien.Email = techniciensReader["email"].ToString();
                technicien.Nationalite = techniciensReader["nationalite"].ToString();
                technicien.DateEmbauche = DateTime.Parse(techniciensReader["dateEmbauche"].ToString());
                technicien.DateNaiss = DateTime.Parse(techniciensReader["dateNaissance"].ToString());
                technicien.Diplome = techniciensReader["diplome"].ToString();
                techniciens.Add(technicien);
            }
            techniciensReader.Close();
            conn.Close();
            return techniciens;
        }
        //   public static Clients getClientByID() { return null; }

        public static Modele.Techniciens addTechniciens(Modele.Techniciens technicien)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO techniciens(matricule,nom,genre,telephone,email,nationalite,dateNaissance,dateEmbauche,diplome) VALUES(@id, @no, @ge,@tel, @email, @not,@dN,@dE,@dipl)";

                command.Parameters.Add(new MySqlParameter("@id", technicien.Matricule));
                command.Parameters.Add(new MySqlParameter("@no", technicien.Nom));
                command.Parameters.Add(new MySqlParameter("@ge", technicien.Genre));
                command.Parameters.Add(new MySqlParameter("@tel", technicien.Telephone));
                command.Parameters.Add(new MySqlParameter("@email", technicien.Email));
                command.Parameters.Add(new MySqlParameter("@not", technicien.Nationalite));
                command.Parameters.Add(new MySqlParameter("@dN", technicien.DateNaiss));
                command.Parameters.Add(new MySqlParameter("@dE", technicien.DateEmbauche));
                command.Parameters.Add(new MySqlParameter("@dipl", technicien.Diplome));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return technicien;
        }

        public static Modele.Techniciens getIdByTech(string idTech)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

             

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "select * from techniciens WHERE matricule = @id";

                command.Parameters.Add(new MySqlParameter("@id", idTech));

                MySqlDataReader techniciensReader = command.ExecuteReader();
                if (techniciensReader.Read())
                {
                    technicien = new Modele.Techniciens();

                    technicien.Matricule = techniciensReader["matricule"].ToString();
                    technicien.Nom = techniciensReader["nom"].ToString();
                    technicien.Genre = techniciensReader["genre"].ToString();
                    technicien.Telephone = techniciensReader["telephone"].ToString();
                    technicien.Email = techniciensReader["email"].ToString();
                    technicien.Nationalite = techniciensReader["nationalite"].ToString();
                    technicien.DateEmbauche = DateTime.Parse(techniciensReader["dateEmbauche"].ToString());
                    technicien.DateNaiss = DateTime.Parse(techniciensReader["dateNaissance"].ToString());
                    technicien.Diplome = techniciensReader["diplome"].ToString();

                }
                techniciensReader.Close();

                command.ExecuteNonQuery();

                
                conn.Close();

            }
            catch (Exception ex)
            {
                
                conn.Close();
                throw ex;
            }
            return technicien;
        }


        public static void supprimerTechnicien(Techniciens technicien)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM techniciens WHERE matricule = @id";

                command.Parameters.Add(new MySqlParameter("@id", technicien.Matricule));
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static Modele.Techniciens updateTechnicien(Modele.Techniciens technicien)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE techniciens SET nom = @no ,genre = @ge ,telephone = @tel ,email = @email ,nationalite = @no,dateNaissance = @dN ,dateEmbauche = @dE,diplome = @dipl WHERE matricule = @id";

                command.Parameters.Add(new MySqlParameter("@id", technicien.Matricule));
                command.Parameters.Add(new MySqlParameter("@no", technicien.Nom));
                command.Parameters.Add(new MySqlParameter("@ge", technicien.Genre));
                command.Parameters.Add(new MySqlParameter("@tel", technicien.Telephone));
                command.Parameters.Add(new MySqlParameter("@email", technicien.Email));
                command.Parameters.Add(new MySqlParameter("@not", technicien.Nationalite));
                command.Parameters.Add(new MySqlParameter("@dN", technicien.DateNaiss));
                command.Parameters.Add(new MySqlParameter("@dE", technicien.DateEmbauche));
                command.Parameters.Add(new MySqlParameter("@dipl", technicien.Diplome));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return technicien;
        }

        #endregion

        #region Materiel


        public static ArrayList getAllMateriel()
        {

            ArrayList materiels = new ArrayList();

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT * FROM materiel";
            MySqlDataReader materielReader = commande.ExecuteReader();
            while (materielReader.Read())
            {
                mater = new Modele.Materiel();

                mater.Idmat = materielReader["idMat"].ToString();
                mater.Nom = materielReader["nom"].ToString();
                mater.NumeroSerie = materielReader["serie"].ToString();
                mater.Marque = materielReader["marque"].ToString();
                mater.Photo = materielReader["photo"] as byte[];
                mater.Commentaire = materielReader["commentaire"].ToString();
                mater.IdClient = materielReader["IdClient"].ToString();
                materiels.Add(mater);
            }
            materielReader.Close();
            conn.Close();
            return materiels;
        }
        //   public static Clients getClientByID() { return null; }

        public static Modele.Materiel addMateriel(Modele.Materiel mater)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO materiel(idMat,nom,serie,marque,photo,commentaire,idClient) VALUES(@id, @no, @se,@mar, @photo, @com,@idCl)";

                command.Parameters.Add(new MySqlParameter("@id", mater.Idmat));
                command.Parameters.Add(new MySqlParameter("@no", mater.Nom));
                command.Parameters.Add(new MySqlParameter("@se", mater.NumeroSerie));
                command.Parameters.Add(new MySqlParameter("@mar", mater.Marque));
                command.Parameters.Add(new MySqlParameter("@photo", mater.Photo));
                command.Parameters.Add(new MySqlParameter("@com", mater.Commentaire));
                command.Parameters.Add(new MySqlParameter("@idCl", mater.IdClient));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return mater;
        }

        public static Modele.Materiel getIdByMateriel(string idMater)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * FROM client WHERE idClient = @id";

                command.Parameters.Add(new MySqlParameter("@id", idMater));

                MySqlDataReader materielReader = command.ExecuteReader();
                if (materielReader.Read())
                {
                    mater = new Modele.Materiel();

                    mater.Idmat = materielReader["idmater"].ToString();
                    mater.Nom = materielReader["nom"].ToString();
                    mater.NumeroSerie = materielReader["serie"].ToString();
                    mater.Marque = materielReader["marque"].ToString();
                    mater.Photo = materielReader["photo"] as byte[];
                    mater.Commentaire = materielReader["commentaire"].ToString();

                }
                materielReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mater;
        }


        public static void supprimerMateriel(Materiel mater1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

           

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM materiel WHERE idMat = @id";

                command.Parameters.Add(new MySqlParameter("@id", mater1.Idmat));

                MySqlDataReader materielReader = command.ExecuteReader();
                if (materielReader.Read())
                {
                    mater = new Modele.Materiel();  

                    mater.Idmat = materielReader["idmater"].ToString();
                    mater.Nom = materielReader["nom"].ToString();
                    mater.NumeroSerie = materielReader["serie"].ToString();
                    mater.Marque = materielReader["marque"].ToString();
                    mater.Photo = materielReader["photo"] as byte[];
                    mater.Commentaire = materielReader["commentaire"].ToString();

                }
                materielReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public static Modele.Materiel updateMateriel(Modele.Materiel mater)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE materiel SET nom = @no,serie = @se,marque = @mar,photo = @photo,commentaire = @com , idClient = @idCli WHERE idMat = @id";

                command.Parameters.Add(new MySqlParameter("@id", mater.Idmat));
                command.Parameters.Add(new MySqlParameter("@no", mater.Nom));
                command.Parameters.Add(new MySqlParameter("@se", mater.NumeroSerie));
                command.Parameters.Add(new MySqlParameter("@mar", mater.Marque));
                command.Parameters.Add(new MySqlParameter("@photo", mater.Photo));
                command.Parameters.Add(new MySqlParameter("@com", mater.Commentaire));
                command.Parameters.Add(new MySqlParameter("@idCli", mater.IdClient));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return mater;
        }

        #endregion


        #region Reparation


        public static ArrayList getAllReparation()
        {

            ArrayList reparations = new ArrayList();

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT * FROM reparation";
            MySqlDataReader reparationReader = commande.ExecuteReader();
            while (reparationReader.Read())
            {
                repar1 = new Modele.Reparation();

               
                repar1.Cout = int.Parse(reparationReader["cout"].ToString());
                repar1.Panne = reparationReader["panne"].ToString();
                repar1.Date = DateTime.Parse(reparationReader["date"].ToString());
                repar1.IdMateriel = reparationReader["idMat"].ToString();
                repar1.IdClient = reparationReader["idClient"].ToString();
                reparations.Add(repar1);
            }
            reparationReader.Close();
            conn.Close();
            return reparations;
        }
        //   public static Clients getClientByID() { return null; }

        public static Modele.Reparation addReparation(Modele.Reparation repar1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO reparation(date,panne,cout,idMat,idClient) VALUES(@date, @panne,@cout, @idMat,@idCl)";

                
                command.Parameters.Add(new MySqlParameter("@date", repar1.Date));
                command.Parameters.Add(new MySqlParameter("@panne", repar1.Panne));
                command.Parameters.Add(new MySqlParameter("@cout", repar1.Cout));
                command.Parameters.Add(new MySqlParameter("@idMat", repar1.IdMateriel));
                command.Parameters.Add(new MySqlParameter("@idCl", repar1.IdClient));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return repar1;
        }

        public static Modele.Reparation getIdByReparation(string idMater, string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * FROM reparation WHERE idClient = @idClient AND idMat = @idMat";

                command.Parameters.Add(new MySqlParameter("@idClient", idMater));
                command.Parameters.Add(new MySqlParameter("@idMat", idClient));

                MySqlDataReader reparationReader = command.ExecuteReader();
                if (reparationReader.Read())
                {
                    repar1 = new Modele.Reparation();

                    repar1.Cout = int.Parse(reparationReader["cout"].ToString());
                    repar1.Panne = reparationReader["panne"].ToString();
                    repar1.Date = DateTime.Parse(reparationReader["date"].ToString());
                    repar1.IdMateriel = reparationReader["idMat"].ToString();
                    repar1.IdClient = reparationReader["idClient"].ToString();

                }
                reparationReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return repar1;
        }


        public static void supprimerReparation(Modele.Reparation repar1,string idMat,string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();



            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM reparation WHERE idMat = @idCl AND idMat = @idMat";

                command.Parameters.Add(new MySqlParameter("@idMat", idMat));
                command.Parameters.Add(new MySqlParameter("@idCl", idClient));
                MySqlDataReader reparationReader = command.ExecuteReader();
                if (reparationReader.Read())
                {
                    repar1 = new Modele.Reparation();

                    repar1.Cout = int.Parse(reparationReader["cout"].ToString());
                    repar1.Panne = reparationReader["panne"].ToString();
                    repar1.Date = DateTime.Parse(reparationReader["date"].ToString());
                    repar1.IdMateriel = reparationReader["idMat"].ToString();
                    repar1.IdClient = reparationReader["idClient"].ToString();

                }
                reparationReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static Modele.Reparation updateReparation(Modele.Reparation repa1,string idMat,string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE reparation SET date = @date,panne = @panne,cout = @cout WHERE  idMat = @idMat AND idClient=@idCl";

                command.Parameters.Add(new MySqlParameter("@date", repar1.Date));
                command.Parameters.Add(new MySqlParameter("@panne", repar1.Panne));
                command.Parameters.Add(new MySqlParameter("@cout", repar1.Cout));
                command.Parameters.Add(new MySqlParameter("@idMat", idMat));
                command.Parameters.Add(new MySqlParameter("@idCl",idClient));


                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return repa1;
        }
        #endregion



        #region Rapport


        public static DataTable getAllClientWithReparation()
        {
            DataTable rapport = new DataTable();
            rapport.Columns.Add("date", typeof(DateTime));
            rapport.Columns.Add("panne", typeof(string));
            rapport.Columns.Add("cout", typeof(int));
            rapport.Columns.Add("idMat", typeof(string));
            rapport.Columns.Add("idClient", typeof(string));
            rapport.Columns.Add("nom", typeof(string));
            rapport.Columns.Add("nationalite", typeof(string));
            rapport.Columns.Add("genre", typeof(string));
            rapport.Columns.Add("tel", typeof(string));
            rapport.Columns.Add("email", typeof(string));

            initialiserConn(); // Assuming this function establishes a connection

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT  rep.idClient,cli.nom, cli.nationalite, cli.genre, cli.tel, cli.email,rep.date, rep.panne, rep.cout, rep.idMat " +
                                    "FROM reparation AS rep " +
                                    "JOIN client AS cli ON rep.idClient = cli.idClient"; // More efficient JOIN syntax
            MySqlDataReader reparationReader = commande.ExecuteReader();

            while (reparationReader.Read())
            {
                string date = reparationReader.GetDateTime("date").ToString();
                string panne = reparationReader.GetString("panne");
                int cout = reparationReader.GetInt32("cout");
                string idMat = reparationReader.GetString("idMat");
                string idClient = reparationReader.GetString("idClient");
                string nom = reparationReader.GetString("nom");
                string nationalite = reparationReader.GetString("nationalite");
                string genre = reparationReader.GetString("genre");
                string tel = reparationReader.GetString("tel");
                string email = reparationReader.GetString("email");

                DataRow rapportRow = rapport.NewRow();
                rapportRow["date"] = date;
                rapportRow["panne"] = panne;
                rapportRow["cout"] = cout;
                rapportRow["idMat"] = idMat;
                rapportRow["idClient"] = idClient;
                rapportRow["nom"] = nom;
                rapportRow["nationalite"] = nationalite;
                rapportRow["genre"] = genre;
                rapportRow["tel"] = tel;
                rapportRow["email"] = email;

                // Add the newly created row to the DataTable
                rapport.Rows.Add(rapportRow);
            }

            reparationReader.Close();
            conn.Close();
            return rapport;
        }

        public static DataTable getClientDeCeMois()
        {
            DataTable rapport = new DataTable();
            rapport.Columns.Add("date", typeof(DateTime));
            rapport.Columns.Add("panne", typeof(string));
            rapport.Columns.Add("cout", typeof(int));
            rapport.Columns.Add("idMat", typeof(string));
            rapport.Columns.Add("idClient", typeof(string));
            rapport.Columns.Add("nom", typeof(string));
            rapport.Columns.Add("nationalite", typeof(string));
            rapport.Columns.Add("genre", typeof(string));
            rapport.Columns.Add("tel", typeof(string));
            rapport.Columns.Add("email", typeof(string));

            initialiserConn(); // Assuming this function establishes a connection

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT rep.date, cli.nom, cli.nationalite, cli.genre, cli.tel, cli.email ,rep.panne, rep.cout, rep.idMat, rep.idClient " +
                            "FROM reparation AS rep " +
                            "JOIN client AS cli ON rep.idClient = cli.idClient " +
                            "WHERE YEAR(rep.date) = YEAR(CURDATE()) AND MONTH(rep.date) = MONTH(CURDATE())";

            MySqlDataReader reparationReader = commande.ExecuteReader();

            while (reparationReader.Read())
            {
                string date = reparationReader.GetDateTime("date").ToString();
                string panne = reparationReader.GetString("panne");
                int cout = reparationReader.GetInt32("cout");
                string idMat = reparationReader.GetString("idMat");
                string idClient = reparationReader.GetString("idClient");
                string nom = reparationReader.GetString("nom");
                string nationalite = reparationReader.GetString("nationalite");
                string genre = reparationReader.GetString("genre");
                string tel = reparationReader.GetString("tel");
                string email = reparationReader.GetString("email");

                DataRow rapportRow = rapport.NewRow();
                rapportRow["date"] = date;
                rapportRow["panne"] = panne;
                rapportRow["cout"] = cout;
                rapportRow["idMat"] = idMat;
                rapportRow["idClient"] = idClient;
                rapportRow["nom"] = nom;
                rapportRow["nationalite"] = nationalite;
                rapportRow["genre"] = genre;
                rapportRow["tel"] = tel;
                rapportRow["email"] = email;

                // Add the newly created row to the DataTable
                rapport.Rows.Add(rapportRow);
            }

            reparationReader.Close();
            conn.Close();
            return rapport;
        }


        public static DataTable getClientDeLeMoisDernier()
        {
            DataTable rapport = new DataTable();
            rapport.Columns.Add("date", typeof(DateTime));
            rapport.Columns.Add("panne", typeof(string));
            rapport.Columns.Add("cout", typeof(int));
            rapport.Columns.Add("idMat", typeof(string));
            rapport.Columns.Add("idClient", typeof(string));
            rapport.Columns.Add("nom", typeof(string));
            rapport.Columns.Add("nationalite", typeof(string));
            rapport.Columns.Add("genre", typeof(string));
            rapport.Columns.Add("tel", typeof(string));
            rapport.Columns.Add("email", typeof(string));

            initialiserConn(); // Assuming this function establishes a connection

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT rep.date, cli.nom, cli.nationalite, cli.genre, cli.tel, cli.email ,rep.panne, rep.cout, rep.idMat, rep.idClient " +
                            "FROM reparation AS rep " +
                            "JOIN client AS cli ON rep.idClient = cli.idClient " +
                            "WHERE YEAR(rep.date) = YEAR(CURDATE()) AND MONTH(rep.date) = MONTH(CURDATE() - 1)";

            MySqlDataReader reparationReader = commande.ExecuteReader();

            while (reparationReader.Read())
            {
                string date = reparationReader.GetDateTime("date").ToString();
                string panne = reparationReader.GetString("panne");
                int cout = reparationReader.GetInt32("cout");
                string idMat = reparationReader.GetString("idMat");
                string idClient = reparationReader.GetString("idClient");
                string nom = reparationReader.GetString("nom");
                string nationalite = reparationReader.GetString("nationalite");
                string genre = reparationReader.GetString("genre");
                string tel = reparationReader.GetString("tel");
                string email = reparationReader.GetString("email");

                DataRow rapportRow = rapport.NewRow();
                rapportRow["date"] = date;
                rapportRow["panne"] = panne;
                rapportRow["cout"] = cout;
                rapportRow["idMat"] = idMat;
                rapportRow["idClient"] = idClient;
                rapportRow["nom"] = nom;
                rapportRow["nationalite"] = nationalite;
                rapportRow["genre"] = genre;
                rapportRow["tel"] = tel;
                rapportRow["email"] = email;

                // Add the newly created row to the DataTable
                rapport.Rows.Add(rapportRow);
            }

            reparationReader.Close();
            conn.Close();
            return rapport;
        }



        public static DataTable getSumReparationDeCetteAnne()
        {
            DataTable rapport = new DataTable();
            rapport.Columns.Add("Sum", typeof(Int32));


            initialiserConn(); // Assuming this function establishes a connection

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT SUM(rep.cout) AS total_cost " +
                          "FROM reparation AS rep " +
                          "JOIN client AS cli ON rep.idClient = cli.idClient " +
                          "WHERE YEAR(rep.date) = YEAR(CURDATE())";

            MySqlDataReader reparationReader = commande.ExecuteReader();

            while (reparationReader.Read())
            {
                int somme = reparationReader.GetInt32("total_cost");


                DataRow rapportRow = rapport.NewRow();
                rapportRow["Sum"] = somme;


                // Add the newly created row to the DataTable
                rapport.Rows.Add(rapportRow);
            }

            reparationReader.Close();
            conn.Close();
            return rapport;
        }

        public static DataTable getSumReparationDeCeMois()
        {
            DataTable rapport = new DataTable();
            rapport.Columns.Add("Sum", typeof(Int32));
            

            initialiserConn(); // Assuming this function establishes a connection

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT SUM(rep.cout) AS total_cost " +
                          "FROM reparation AS rep " +
                          "JOIN client AS cli ON rep.idClient = cli.idClient " +
                          "WHERE YEAR(rep.date) = YEAR(CURDATE()) AND MONTH(rep.date) = MONTH(CURDATE())";

            MySqlDataReader reparationReader = commande.ExecuteReader();

            while (reparationReader.Read())
            {
                int somme = reparationReader.GetInt32("total_cost");


                DataRow rapportRow = rapport.NewRow();
                rapportRow["Sum"] = somme;
                

                // Add the newly created row to the DataTable
                rapport.Rows.Add(rapportRow);
            }

            reparationReader.Close();
            conn.Close();
            return rapport;
        }
        #endregion
    }
}
