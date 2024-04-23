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
using System.Reflection;

namespace Controlleur
{
    public static class Factory
    {
        public static MySqlConnection conn = null;


        public static  utilisateur user1 = null;
        public static  Profile profile1 = null;
        public static  Banque banque1 = null;
        public static  Compte compte1 = null;
        public static  Operation op1 = null;


        public static void initialiserConn()
        {
            string pwd = "";
            string chaine = "Server=localhost;Database=ok;port=3306 ; User Id=root;password = " + pwd;
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
            commande.CommandText = "select prof.id FROM utilisateur AS util "+ 
                                    "JOIN Profile AS prof ON util.idProfille = prof.id";
            MySqlDataReader utilReader = commande.ExecuteReader();
            while (utilReader.Read())
            {
                prof.Nom= utilReader["id"].ToString();
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

                profile1.Id = profilesReader["id"].ToString();
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

                command.CommandText = "UPDATE profile SET nom = @no ,Salaire = @sal WHERE idProfile = @id";

                command.Parameters.Add(new MySqlParameter("@id", profile1.Id));
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

        
       #region Banque


       public static ArrayList getAllBanque()
       {

           ArrayList Banques = new ArrayList();

           initialiserConn();

           if (conn.State != ConnectionState.Open) conn.Open();

           MySqlCommand commande = conn.CreateCommand();
           commande.CommandText = "SELECT * FROM banque";
           MySqlDataReader BanqueReader = commande.ExecuteReader();
           while (BanqueReader.Read())
           {
                banque1 = new  Banque();

               banque1.IdBanque = BanqueReader["idBanque"].ToString();
                banque1.NomBanque = BanqueReader["nom"].ToString();             
               banque1.Location = BanqueReader["Location"].ToString();
                banque1.Contact = BanqueReader["Contact"].ToString();

                Banques.Add(banque1);
           }
            BanqueReader.Close();
           conn.Close();
           return Banques;
       }

       public static  Banque addBanque(Banque banque1)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "INSERT INTO banque(idBanque,nom,Location,Contact) VALUES(@id, @no, @loc,@cont)";

               command.Parameters.Add(new MySqlParameter("@id", banque1.IdBanque));
               command.Parameters.Add(new MySqlParameter("@no", banque1.NomBanque));
               command.Parameters.Add(new MySqlParameter("@loc", banque1.Location));
               command.Parameters.Add(new MySqlParameter("@cont", banque1.Contact));
  
               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               conn.Close();
               throw ex;
           }
           return banque1;
       }

       public static Banque getIdByBanque(string idBanque)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "SELECT * FROM banque WHERE idBanque = @id";

               command.Parameters.Add(new MySqlParameter("@id", idBanque));

               MySqlDataReader BanqueReader = command.ExecuteReader();
               if (BanqueReader.Read())
               {
                    banque1 = new Banque();

                    banque1.IdBanque = BanqueReader["idBanque"].ToString();
                    banque1.NomBanque = BanqueReader["nom"].ToString();
                    banque1.Location = BanqueReader["Location"].ToString();
                    banque1.Contact = BanqueReader["Contact"].ToString();

                }
                BanqueReader.Close();

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }
           return banque1;
       }


       public static void supprimerBanque(Banque banque1)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "DELETE FROM banque WHERE idBanque = @id";

               command.Parameters.Add(new MySqlParameter("@id", banque1.IdBanque));

               

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static Banque updateBanque(Banque banque1)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "UPDATE banque SET nom = @nom,Location = @loc,Contact = @con WHERE idBanque = @id";

               command.Parameters.Add(new MySqlParameter("@id", banque1.IdBanque));
               command.Parameters.Add(new MySqlParameter("@nom", banque1.NomBanque));
               command.Parameters.Add(new MySqlParameter("@loc", banque1.Location));
               command.Parameters.Add(new MySqlParameter("@con", banque1.Contact));

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               conn.Close();
               throw ex;
           }
           return banque1;
       }

       #endregion


       #region Compte


       public static ArrayList getAllCompte()
       {

           ArrayList Comptes = new ArrayList();

           initialiserConn();

           if (conn.State != ConnectionState.Open) conn.Open();

           MySqlCommand commande = conn.CreateCommand();
           commande.CommandText = "SELECT * FROM compte";
           MySqlDataReader compteReader = commande.ExecuteReader();
           while (compteReader.Read())
           {
               compte1 = new  Compte();


                compte1.Solde = int.Parse(compteReader["solde"].ToString());
                compte1.IdCompte = compteReader["idCompte"].ToString();
                compte1.IdBanqueCompte = compteReader["idBanque"].ToString();
                compte1.TypeDeCompte = compteReader["typeCompte"].ToString();
                Comptes.Add(compte1);
           }
           compteReader.Close();
           conn.Close();
           return Comptes;
       }

       public static Compte addCompte(Compte compte1)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "INSERT INTO compte(idCompte,typeCompte,solde,idBanque) VALUES(@idCo,@typeCO,@solde,@idBanq)";

               command.Parameters.Add(new MySqlParameter("@idCo", compte1.IdCompte));
               command.Parameters.Add(new MySqlParameter("@typeCO", compte1.TypeDeCompte));
               command.Parameters.Add(new MySqlParameter("@solde", compte1.Solde));
               command.Parameters.Add(new MySqlParameter("@idBanq", compte1.IdBanqueCompte));

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               conn.Close();
               throw ex;
           }
           return compte1;
       }

       public static Compte getIdByCompte(string idCompte)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "SELECT * FROM compte WHERE idCompte = @idCo";

               command.Parameters.Add(new MySqlParameter("@idCo", idCompte));

               MySqlDataReader compteReader = command.ExecuteReader();
               if (compteReader.Read())
               {
                    compte1 = new Compte();

                    compte1.Solde = int.Parse(compteReader["solde"].ToString());
                    compte1.IdCompte = compteReader["idCompte"].ToString();
                    compte1.IdBanqueCompte = compteReader["idBanque"].ToString();
                    compte1.TypeDeCompte = compteReader["typeCompte"].ToString();

                }
               compteReader.Close();

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }
           return compte1;
       }


       public static void supprimerCompte(string matricule)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();



           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "DELETE FROM compte WHERE idCompte = @idCo";

               command.Parameters.Add(new MySqlParameter("@id", matricule));

               MySqlDataReader compteReader = command.ExecuteReader();
               if (compteReader.Read())
               {
                    compte1 = new Compte();

                    compte1.Solde = int.Parse(compteReader["solde"].ToString());
                    compte1.IdCompte = compteReader["idCompte"].ToString();
                    compte1.IdBanqueCompte = compteReader["idBanque"].ToString();
                    compte1.TypeDeCompte = compteReader["typeCompte"].ToString();

                }
               compteReader.Close();

               command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static  Compte updateCompte(Compte compte)
       {
           initialiserConn();
           if (conn.State != ConnectionState.Open) conn.Open();

           try
           {
               MySqlCommand command = conn.CreateCommand();

               command.CommandText = "UPDATE compte SET typeCompte = @typeCO,solde = @solde,idBanque = @idBanq WHERE  idCompte = @idCo";


                command.Parameters.Add(new MySqlParameter("@idCo", compte1.IdCompte));
                command.Parameters.Add(new MySqlParameter("@typeCO", compte1.TypeDeCompte));
                command.Parameters.Add(new MySqlParameter("@solde", compte1.Solde));
                command.Parameters.Add(new MySqlParameter("@idBanq", compte1.IdBanqueCompte));

                command.ExecuteNonQuery();
               conn.Close();

           }
           catch (Exception ex)
           {
               conn.Close();
               throw ex;
           }
           return compte1;
       }
        #endregion


        #region Operation


        public static ArrayList getAllOperation()
        {

            ArrayList Operations = new ArrayList();

            initialiserConn();

            if (conn.State != ConnectionState.Open) conn.Open();

            MySqlCommand commande = conn.CreateCommand();
            commande.CommandText = "SELECT * FROM operation";
            MySqlDataReader operationReader = commande.ExecuteReader();
            while (operationReader.Read())
            {
                op1 = new Operation();


                op1.Fond = int.Parse(operationReader["Fond"].ToString());
                op1.IdOperation = operationReader["IdOperation"].ToString();
                op1.Date = DateTime.Parse(operationReader["Date"].ToString());
                op1.TypeOperation = operationReader["TypeOperation"].ToString();
                op1.Libele = operationReader["Libele"].ToString();
                op1.IdCompte = operationReader["idCompte"].ToString();
                Operations.Add(op1);
            }
            operationReader.Close();
            conn.Close();
            return Operations;
        }
        //   public static Clients getClientByID() { return null; }

        public static Operation addOperation(Operation op1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "INSERT INTO operation(idOperation,idCompte,Libele,TypeOperation,Fond,Date)" +
                    " VALUES(@idOp,@idCo,@Lib,@TypeOp,@Fond,@Date)";


                command.Parameters.Add(new MySqlParameter("@idOp", op1.IdOperation));
                command.Parameters.Add(new MySqlParameter("@idCo", op1.IdCompte));
                command.Parameters.Add(new MySqlParameter("@Lib", op1.Libele));
                command.Parameters.Add(new MySqlParameter("@TypeOp", op1.TypeOperation));
                command.Parameters.Add(new MySqlParameter("@Fond", op1.Fond));
                command.Parameters.Add(new MySqlParameter("@Date", op1.Date));

                command.ExecuteNonQuery();
                
                
                MySqlCommand command2 = conn.CreateCommand();

                command2.CommandText = "UPDATE compte c SET c.solde = (SELECT c.solde + CASE WHEN o.TypeOperation = 'Retrait' THEN - o.Fond ELSE o.Fond END FROM operation o WHERE o.idCompte = c.idCompte ) WHERE c.idCompte = @idCo";

                command2.Parameters.Add(new MySqlParameter("@idCo", op1.IdCompte));

                command2.ExecuteNonQuery(); 

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return op1;
        }

        public static Operation getIdByOperation(string idOperation)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "SELECT * FROM operation WHERE idOperation = @idOperation";

                command.Parameters.Add(new MySqlParameter("@idOperation", idOperation));

                MySqlDataReader operationReader = command.ExecuteReader();
                if (operationReader.Read())
                {
                    op1 = new Operation();

                    op1.Fond = int.Parse(operationReader["Fond"].ToString());
                    op1.IdOperation = operationReader["IdOperation"].ToString();
                    op1.Date = DateTime.Parse(operationReader["Date"].ToString());
                    op1.TypeOperation = operationReader["TypeOperation"].ToString();
                    op1.Libele = operationReader["Libele"].ToString();
                    op1.IdCompte = operationReader["idCompte"].ToString();

                }
                operationReader.Close();

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return op1;
        }


        public static void supprimerOperation(Operation op1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "DELETE FROM operation WHERE idOperation = @id";

                command.Parameters.Add(new MySqlParameter("@id", op1.IdOperation));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static Operation updateOperation(Operation op1)
        {
            initialiserConn();
            if (conn.State != ConnectionState.Open) conn.Open();

            try
            {
                MySqlCommand command = conn.CreateCommand();

                command.CommandText = "UPDATE operation SET idCompte = @idCo,Libele = @Lib," +
                    "TypeOperation = @TypeOp,Fond = @Fond,Date = @Date WHERE  idOperation = @idOp";

                command.Parameters.Add(new MySqlParameter("@idOp", op1.IdOperation));
                command.Parameters.Add(new MySqlParameter("@idCo", op1.IdCompte));
                command.Parameters.Add(new MySqlParameter("@Lib", op1.Libele));
                command.Parameters.Add(new MySqlParameter("@TypeOp", op1.TypeOperation));
                command.Parameters.Add(new MySqlParameter("@Fond", op1.Fond));
                command.Parameters.Add(new MySqlParameter("@Date", op1.Date));

                command.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            return op1;
        }
        #endregion
    }
}
