using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public class userService
    {
        OleDbConnection myConnection;
        public userService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public void InsertUser(User u)
        {

            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO [Users](ID, firstName, [lastName], [mailAdrs], [age], [password], isActive) VALUES('" + u.ID + "', '" + u.Firstname + "', '" + u.Lastname + "', '" + u.Addrs + "', " + u.Age + ", '" + u.pssWrd + "', True)";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }

        }

        public DataSet GetUsersByIdAndPas(string id, string password)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Users where ID='" + id + "'and [Password]= '" + password + "'";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }

        public DataSet GetUser(string id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Users where ID='" + id + "'";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }

        public DataSet GetUsers()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Users";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }

        public void LogicalDelete(string ID)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE Users SET isActive = False WHERE ID = '" + ID + "'";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public void UpdateUser(User u)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE Users SET firstName = '" + u.Firstname + "', [lastName] = '" + u.Lastname + "', [mailAdrs] = '" + u.Addrs + "', [age] = " + u.Age + ", [password] = '" + u.pssWrd + "' WHERE ID = '" + u.ID + "'";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}