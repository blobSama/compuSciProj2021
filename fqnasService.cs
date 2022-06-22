using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public class fqnasService
    {
        OleDbConnection myConnection;
        public fqnasService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public void InsertQuestion(fqnas f)
        {

            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO faqs(userIdAsk, question, questDate) VALUES('" + f.AskUsrId + "', '" + f.Qstn + "', #" + f.AskDate + "#);";
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

        public void InsertAnswer(fqnas f, int num)
        {

            try
            {
                myConnection.Open();
                string sSql = "UPDATE faqs SET userIdAns = '" + f.AnsUsrId + "', answer = '" + f.Ans + "', ansDate = #" + f.AnsDate + "# WHERE questionNum = " + num + ";";
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

        public DataSet GetFaqs()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM faqs;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "faqs");
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

        public bool isAnswered(int qNum)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM faqs WHERE questionNum = " + qNum  + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "faqs");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            bool ok = true;
            if(dataset.Tables[0].Rows[0][2].ToString().Equals(""))
            {
                ok = false;
            }
            return ok;
        }

        public DataSet GetFaqByNum(int qNum)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM faqs WHERE questionNum = " + qNum + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "faqs");
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
    }
}