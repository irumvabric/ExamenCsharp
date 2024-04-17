using System;
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

namespace Controlleur
{
    public static class Factory
    {
        public static MySqlConnection conn = null;


        public static  utilisateur user1 = null;
        public static  Profile profile1 = null;


        public static void initialiserConn()
        {
            string pwd = "";
            string chaine = "Server=localhost;Database=gestionfinance;port=3306 ; User Id=root;password = " + pwd;
            conn = new MySqlConnection(chaine);
        }


        #region Utilisateur

        public static Boolean Connexion(string username, string password)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

             utilisateur util1 = null;


            MySqlCommand command = conn.CreateCommand();

            command.CommandText = "SELECT username,motDePasse FROM utilisateur WHERE username = @user AND motDePasse = @password";

            command.Parameters.Add(new MySqlParameter("@user", username));
            command.Parameters.Add(new MySqlParameter("@password", password));

            using (MySqlDataReader utilReader = command.ExecuteReader())
            {
                try
                {

                    if (utilReader.HasRows)
                    {
                        return true;
                    }
                    utilReader.Close();

                    command.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    
                    utilReader.Close();
                    conn.Close();
                    throw ex;
                   
                }

            }
            return false;
        }

        public static ArrayList ProfileName()
        {

            utilisateur util2 = new utilisateur();
            Profile prof = new Profile();
            ArrayList user = new ArrayList();
            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select prof.idProfile FROM utilisateur AS util "+ 
                                    "JOIN Profile AS prof ON util.idProfille = prof.idProfile";
            MySqlDataReader utilReader = commande.ExecuteReader();
            while (utilReader.Read())
            {
                prof.Nom= utilReader["idProfile"].ToString();
                user.Add(prof);
            }
            utilReader.Close();
            conn.Close();
            return user;
        }
        public static ArrayList getAllUsers() {
        
            ArrayList utilisateur = new ArrayList();

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select * from utilisateur";
            MySqlDataReader userReader = commande.ExecuteReader();
            while (userReader.Read())
            {
                user1 = new  utilisateur();

                user1.IdUtilisateur = userReader["idUtilisateur"].ToString();
                user1.Nom = userReader["nom"].ToString();
                user1.Prenom = userReader["prenom"].ToString();
                user1.Username = userReader["username"].ToString();
                user1.IdUtilisateur = userReader["motDePasse"].ToString();
                user1.NomProfile = userReader["idProfille"].ToString();


                utilisateur.Add(user1);
            }
            userReader.Close();
            conn.Close();
            return utilisateur;
        }
        //   public static Clients getClientByID() { return null; }

        public static  utilisateur addUtilisateur( utilisateur user1) 
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO utilisateur(idUtilisateur,nom,prenom,username,motDePasse,idProfille) VALUES(@idUt, @no,@pre, @user,@pass, @idProfile)";

                command.Parameters.Add(new MySqlParameter("@idUt", user1.IdUtilisateur));
                command.Parameters.Add(new MySqlParameter("@no", user1.Nom));
                command.Parameters.Add(new MySqlParameter("@pre", user1.Prenom));
                command.Parameters.Add(new MySqlParameter("@user", user1.Username));
                command.Parameters.Add(new MySqlParameter("@pass", user1.Password));
                command.Parameters.Add(new MySqlParameter("@idProfile", user1.NomProfile));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user1;
        }

        public static  utilisateur getIdByUtilisateur(string idClient)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

                 utilisateur user2 = null;

                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * FROM utilisateur WHERE idUtilisateur = @id";

                command.Parameters.Add(new MySqlParameter("@id", idClient));

                MySqlDataReader utilisateurReader = command.ExecuteReader();
                try
                {

                    if (utilisateurReader.Read())
                    {
                        user2 = new  utilisateur();

                        user2.IdUtilisateur = utilisateurReader["idUtilisateur"].ToString();
                        user2.Nom = utilisateurReader["nom"].ToString();
                        user2.Prenom = utilisateurReader["prenom"].ToString();
                        user2.Username = utilisateurReader["username"].ToString();
                        user2.IdUtilisateur = utilisateurReader["motDePasse"].ToString();
                        user2.NomProfile = utilisateurReader["idProfille"].ToString();

                }
                utilisateurReader.Close();

                    command.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception ex)
                {
                    utilisateurReader.Close();
                    conn.Close();
                    throw ex;
                    
                }
                return user2;
            
            
        }
        

        public static void supprimerutilisateur(utilisateur user1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

          //   Client cl1 = null;

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM utilisateur WHERE idUtilisateur = @id";

                command.Parameters.Add(new MySqlParameter("@id", user1.IdUtilisateur));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            
        }

        public static utilisateur updateUtilisateurs( utilisateur user1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE utilisateur SET nom = @no ,prenom = @pre, username = @user, motDePasse = @pass, idProfille = @idProfile WHERE idUtilisateur = @idUt";

                command.Parameters.Add(new MySqlParameter("@idUt", user1.IdUtilisateur));
                command.Parameters.Add(new MySqlParameter("@no", user1.Nom));
                command.Parameters.Add(new MySqlParameter("@pre", user1.Prenom));
                command.Parameters.Add(new MySqlParameter("@user", user1.Username));
                command.Parameters.Add(new MySqlParameter("@pass", user1.Password));
                command.Parameters.Add(new MySqlParameter("@idProfile", user1.NomProfile));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user1;
        }


        #endregion

        #region Profile


        public static ArrayList getAllProfiles()
        {

            ArrayList profiles = new ArrayList();

            

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "select * from profile";
            MySqlDataReader profilesReader = commande.ExecuteReader();
            while (profilesReader.Read())
            {
                profile1 = new  Profile();

                profile1.Id = profilesReader["idProfile"].ToString();
                profile1.Nom = profilesReader["nom"].ToString();
                profile1.Salaire = int.Parse(profilesReader["Salaire"].ToString());

                profiles.Add(profile1);
            }
            profilesReader.Close();
            conn.Close();
            return profiles;
        }
        //   public static Clients getClientByID() { return null; }

        public static  Profile addProfiles(Profile Profile1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO profile(idProfile,nom,Salaire,privileges) VALUES(@id, @no, @sal,@priv)";

                command.Parameters.Add(new MySqlParameter("@id", Profile1.Id));
                command.Parameters.Add(new MySqlParameter("@no", Profile1.Nom));
                command.Parameters.Add(new MySqlParameter("@sal", Profile1.Salaire));
                command.Parameters.Add(new MySqlParameter("@priv", Profile1.Privilege));
                

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Profile1;
        }

        public static  Profile getIdByProfile(string idProfile)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

             

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "select * from profile WHERE idProfile = @id";

                command.Parameters.Add(new MySqlParameter("@id", idProfile));

                MySqlDataReader profilesReader = command.ExecuteReader();
                if (profilesReader.Read())
                {
                    profile1 = new  Profile();

                    profile1.Id = profilesReader["idProfile"].ToString();
                    profile1.Nom = profilesReader["nom"].ToString();
                    profile1.Salaire = int.Parse(profilesReader["Salaire"].ToString());
                    profile1.Privilege = profilesReader["telephone"].ToString();


                }
                profilesReader.Close();

                command.ExecuteNonQuery();

                
                conn.Close();

            }
            catch (Exception ex)
            {
                
                conn.Close();
                throw ex;
            }
            return profile1;
        }


        public static void supprimerprofile(Profile profile1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM profile WHERE idProfile = @id";

                command.Parameters.Add(new MySqlParameter("@id", profile1.Id));
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public static  Profile updateProfile( Profile profile1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE profile SET nom = @no ,Salaire = @ge ,telephone = @tel ,email = @email ,nationalite = @no,dateNaissance = @dN ,dateEmbauche = @dE,diplome = @dipl WHERE matricule = @id";

                command.Parameters.Add(new MySqlParameter("@no", profile1.Nom));
                command.Parameters.Add(new MySqlParameter("@sal", profile1.Salaire));
                command.Parameters.Add(new MySqlParameter("@priv", profile1.Privilege));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return profile1;
        }

        #endregion

        /*
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
               mater = new  Materiel();

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

       public static  Materiel addMateriel( Materiel mater)
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

       public static  Materiel getIdByMateriel(string idMater)
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
                   mater = new  Materiel();

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
                   mater = new  Materiel();  

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

       public static  Materiel updateMateriel( Materiel mater)
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
               repar1 = new  Reparation();


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

       public static  Reparation addReparation( Reparation repar1)
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

       public static  Reparation getIdByReparation(string idMater, string idClient)
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
                   repar1 = new  Reparation();

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


       public static void supprimerReparation( Reparation repar1)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();



           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "DELETE FROM reparation WHERE idMat = @id AND idMat = @idMat";

               command.Parameters.Add(new MySqlParameter("@id", repar1.IdMateriel));

               MySqlDataReader reparationReader = command.ExecuteReader();
               if (reparationReader.Read())
               {
                   repar1 = new  Reparation();

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

       public static  Reparation updateReparation( Reparation repa1,string idMat,string idClient)
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
       */
    }
}
