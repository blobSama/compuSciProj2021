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

        public DataSet GetTestsUser(int curTop)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select difficulty, subjName, subjNum, testTopic, testNum, descript from tests, topics where subjNum = testTopic AND subjSerialNum BETWEEN 1 AND " + curTop + " AND isActiveTest = true;";
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

                if(topic != 0)
                {
                    sSql += " AND subjSerialNum = " + topic + ";";
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
                string sSql = "select questNum, question, answer1, answer2, answer3, answer4, rightAns, explanation from testQuestions where testNumber = " + num + "";
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

        public DataSet GetRghtAnsByQ(int num, int testNum)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT rightAns FROM testQuestions WHERE questNum = " + num + " AND testNumber = " + testNum + ";";
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

        public DataSet GetAllComplTestsM()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT topics.subjNum, topics.subjName, tests.testTopic, tests.testNum, testSerialNum, testTime, grade, testedUserID, firstName, lastName FROM allTests, tests, topics,Users WHERE testSerialNum = testNum and testTopic = subjNum and testedUserId = ID;";
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

        public DataSet getSubjects(int curTop)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from topics WHERE subjSerialNum BETWEEN 1 AND " + curTop + " ORDER BY subjSerialNum;";
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

        public DataSet getSubjectsGuest()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from topics ORDER BY subjSerialNum;";
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

        public int CreateTest(int num)
        {
            DateTime now = DateTime.Now;
            try
            {
                myConnection.Open();
                string sSql = "insert into tests(testTopic, uploadDate) values(" + num + ", #" + now + "#)";
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

            int testNum = 0;
            DataSet dataset = new DataSet();
            long min = long.MaxValue;
            try
            {
                myConnection.Open();
                string sSql = "select * from tests;";
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
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                if (Math.Abs(((DateTime)dr[1]).Ticks - now.Ticks) < min)
                {
                    Math.Abs(((DateTime)dr[1]).Ticks - now.Ticks);
                    testNum = Convert.ToInt32(dr[0]);
                }
            }
            return testNum;
        }

        public void insertQuestion(int qNum, int testNum, string quest, string ans1, string ans2, string ans3, string ans4, string realAns, string expln)
        {
            try
            {
                myConnection.Open();
                string sSql = "insert into testQuestions(questNum, testNumber, question, answer1, answer2, answer3, answer4, rightAns, explanation) values(" + qNum + ", " + testNum  + ", '" + quest + "', '" + ans1 + "', '" + ans2 + "', '" + ans3 + "', '" + ans4 + "', '" + realAns + "', '" + expln + "')";
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

        public void insertDiffAndDesc(string diff, string desc, int num)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE tests SET difficulty = '" + diff + "', descript = '" + desc + "' WHERE testNum = " + num + ";";
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

        public void makeRelevant(int num)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE tests SET isActiveTest = true WHERE testNum = " + num + ";";
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

        public DataSet getTestByNum(int testNum)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from tests WHERE testNum = " + testNum + ";";
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

        public DataSet GetTests()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select testNum, uploadDate, isActiveTest, subjName, difficulty, descript from tests, topics WHERE testTopic = subjNum;";
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

        public void deleteTest(int num)
        {
            try
            {
                myConnection.Open();
                string sSql = "DELETE FROM tests WHERE testNum = " + num + ";";
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

        public void updateTest(Test t)
        {
            try
            {
                myConnection.Open();
                string sSql = "UPDATE tests SET testTopic = " + t.TestTopic + ", isActiveTest = " + t.IsActive + ", uploadDate = #" + t.UploadDate + "#, difficulty = '" + t.Difficulty + "', descript = '" + t.Descript + "' WHERE testNum = " + t.TestNum + ";";
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

        public bool hasPassed(string usrId, int testSerial)
        {
            bool pass = false;
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * FROM allTests WHERE testedUserId = '" + usrId + "' AND testSerialNum = " + testSerial + ";";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "allTests");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            if(dataset.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow dr in dataset.Tables[0].Rows)
                {
                    if(Convert.ToInt32(dr[3]) >= 75)
                    {
                        pass = true;
                    }
                }
            }
            return pass;
        }
    }
}