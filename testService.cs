using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

namespace compuSciProj2021
{
    public class testService
    {
        OleDbConnection myConnection;
        public testService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }

        public DataSet GetTests()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select difficulty, subjName, subjNum, testTopic, testNum from tests, topics where subjNum = testTopic";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "tests");
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

        public DataSet GetMatchTests(int diff, int time, int topic)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select difficulty, subjName, subjNum, testTopic, testNum from tests, topics where subjNum = testTopic";
                switch (diff)
                {
                    case 0:
                        break;
                    case 1:
                        sSql += " AND difficulty = 'Hard'";
                        break;
                    case 2:
                        sSql += " AND difficulty = 'Medium'";
                        break;
                    case 3:
                        sSql += " AND difficulty = 'Easy'";
                        break;
                    default: break;
                }

                switch (time)
                {
                    case 0: break;

                    case 1:
                        sSql += " AND Year(uploadDate) = " + DateTime.Now.Year;
                        break;
                    case 2:
                        sSql += " AND Year(uploadDate) = " + DateTime.Now.Year + " AND MONTH(uploadDate) = " + DateTime.Now.Month;
                        break;
                    case 3:
                        sSql += " AND Year(uploadDate) = " + DateTime.Now.Year + " AND MONTH(uploadDate) = " + DateTime.Now.Month + " AND DAY(uploadDate) = " + DateTime.Now.Day;
                        break;
                    default: break;
                }

                switch (topic)
                {
                    case 0: break;

                    case 1:
                        sSql += " AND subjNum = 1";
                        break;
                    case 2:
                        sSql += " AND subjNum = 2";
                        break;
                    case 3:
                        sSql += " AND subjNum = 3";
                        break;
                    case 4:
                        sSql += " AND subjNum = 4";
                        break;
                    case 5:
                        sSql += " AND subjNum = 5";
                        break;
                    default: break;
                }
                OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset);
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

        public DataSet GetTestById(int num)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select questNum, question, answer1, answer2, answer3, answer4, rightAns from testQuestions where testNumber = " + num + "";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "tests");
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

        public DataSet GetRghtAnsByQ(int num)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select rightAns from testQuestions where questNum = " + num + "";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "tests");
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

        public DataSet GetAllComplTests(string usrID)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select topics.subjNum, topics.subjName, tests.testTopic, tests.testNum, testSerialNum, testTime, grade, testedUserID from allTests, tests, topics where testSerialNum = testNum and testTopic = subjNum and testedUserId = '"+ usrID +"';";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "tests");
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

        public void insertTest(DateTime testTime, int grade, string id, int testNum)
        {
            try
            {
                myConnection.Open();
                string sSql = "insert into allTests(testTime, grade, testSerialNum, testedUserId) values(#" + testTime+ "#, " + grade + ", " + testNum +", '" + id + "')";
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