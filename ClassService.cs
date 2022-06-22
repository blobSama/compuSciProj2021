using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public class ClassService
    {
        OleDbConnection myConnection;
        public ClassService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public DataSet getSubjects()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM topics;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
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

        public DataSet getSubtopsByTopic(int topic,int curSubTop)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM subTopic, classes WHERE topic = " + topic + " AND status = true AND";
                sSql += " subTopicNum = subTopNum AND subTopSerial BETWEEN 1 AND " + curSubTop + " ORDER BY subTopSerial;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
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

        public DataSet getSubtopsByTopicGuest(int topic)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM subTopic, classes WHERE topic = " + topic + " AND status = true AND";
                sSql += " subTopicNum = subTopNum ORDER BY subTopSerial;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
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

        public DataSet getClassBySubtop(int subTop)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM classes WHERE subTopicNum = " + subTop + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "classes");
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

        public bool checkAns(string answer, int subTop)
        {
            bool correct = false;
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT answer FROM classes WHERE subTopicNum = " + subTop + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "classes");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            if (dataset.Tables[0].Rows[0][0].ToString().Equals(answer))
            {
                correct = true;
            }
            return correct;
        }

        public void UpdateTopUsr(string userId)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE Users SET currTop = currTop+1, currSubTop = 1 WHERE ID = '" + userId + "';";
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

        public void UpdateSubTopUsr(string userId)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE Users SET currSubTop = currSubTop+1 WHERE ID = '" + userId + "';";
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

        public DataSet getSubtops(int topic)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM subTopic WHERE topic = " + topic + " ORDER BY subTopSerial;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
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

        public int getSubTopSerial(int subTopNum, int topic)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT subTopSerial FROM subTopic WHERE topic = " + topic + " AND subTopNum = " + subTopNum + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
        }

        public int getSubSerial(int topic)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT subjSerialNum FROM topics WHERE subjNum = " + topic +";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
        }

        public int getSubTopNum(int topic, int subTopSerial)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT subTopNum FROM subTopic WHERE topic = " + topic + " AND subTopSerial = " + subTopSerial + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
        }

        public void insertClass(int topic, string subTopName, string classTxt, string quest, string ans)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * FROM subTopic WHERE topic = " + topic + " ORDER BY subTopSerial;";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "topics");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            int lastSub;
            if(dataset.Tables[0].Rows.Count == 0)
            {
                lastSub = 1;
            }
            else
            {
                lastSub = Convert.ToInt32(dataset.Tables[0].Rows[dataset.Tables[0].Rows.Count - 1][3]) + 1;
            }
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO subTopic(topic, subTopName, subTopSerial) VALUES(" + topic + ", '" + subTopName + "', " + lastSub + ");";
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
            int subTopNum = getSubTopNum(topic, lastSub);
            DateTime dt = DateTime.Now;
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO classes(classText, subTopicNum, question, answer, uploadDate, status)";
                sSql += " VALUES('" + classTxt + "', " + subTopNum + ", '" + quest + "', '" + ans + "', #" + dt + "#, true);";
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