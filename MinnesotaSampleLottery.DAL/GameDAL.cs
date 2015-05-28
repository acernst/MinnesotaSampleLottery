using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MinnesotaSampleLottery.Common;

namespace MinnesotaSampleLottery.DAL
{
    public class GameDAL
    {
        #region GET ITEM AND COLLECTION

        public static Game GetItem(int gameId)
        {
            Game tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGame", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@GameId", gameId);
                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            tempItem = FillDataRecord(myReader);
                        }
                        myReader.Close();
                    }
                }
                myConnection.Close();
            }
            return tempItem;
        }

        public static GameCollection GetCollection()
        {
            GameCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGame", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new GameCollection();
                            while (myReader.Read())
                            {
                                tempList.Add(FillDataRecord(myReader));
                            }
                        }
                        myReader.Close();
                    }
                }
            }
            return tempList;
        }

        #endregion

        #region INSERT UPDATE DELETE

        public static int Save(Game gameToSave)
        {
            int result = 0;
            int queryId = 10;

            //Check for valid GameId, if it exists - update 
            // else it will insert

            if (gameToSave.GameId > 0)
                queryId = 20;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_ExecuteGame", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", queryId);

                    if (gameToSave.Name != null)
                        myCommand.Parameters.AddWithValue("Name", gameToSave.Name);

                    if (gameToSave.Multiplier != null)
                        myCommand.Parameters.AddWithValue("Multiplier", gameToSave.Multiplier);

                    if (gameToSave.NumbersDrawn > 0)
                        myCommand.Parameters.AddWithValue("NumbersDrawn", gameToSave.NumbersDrawn);

                    if (gameToSave.Description != null)
                        myCommand.Parameters.AddWithValue("Description", gameToSave.Description);

                    myCommand.Parameters.Add(HelperDAL.GetReturnParameterInt("ReturnValue"));

                    myConnection.Open();
                    myCommand.ExecuteNonQuery();

                    result = (int)myCommand.Parameters["@ReturnValue"].Value;
                }
                myConnection.Close();
            }
            return result;
        }

        #endregion

        #region PRIVATE METHODS

        private static Game FillDataRecord(IDataRecord myDataRecord)
        {
            Game myObject = new Game();

            myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            myObject.Name = myDataRecord.GetString(myDataRecord.GetOrdinal("Name"));

            myObject.Multiplier = myDataRecord.GetString(myDataRecord.GetOrdinal("Multiplier"));

            myObject.NumbersDrawn = myDataRecord.GetInt32(myDataRecord.GetOrdinal("NumbersDrawn"));

            myObject.Description = myDataRecord.GetString(myDataRecord.GetOrdinal("Description"));

            return myObject;
        }

        #endregion
    }
}
