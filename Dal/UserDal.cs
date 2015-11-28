using Ent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal
    {
        #region Methods
        public int add(UserEnt user)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "addUser";
            sqlCommand.Parameters.AddWithValue("@Name", user.NAME);
            sqlCommand.Parameters.AddWithValue("@Last_Name", user.LAST_NAME);
            if (user.MATERNAL_SURNAME != "")
            {
                sqlCommand.Parameters.AddWithValue("@Maternal_Surname", user.MATERNAL_SURNAME);
            }
            else
            {
                sqlCommand.Parameters.AddWithValue("@Maternal_Surname", DBNull.Value);
            }
            sqlCommand.Parameters.AddWithValue("@Username", user.USERNAME);
            sqlCommand.Parameters.AddWithValue("@Password", user.PASSWORD);
            sqlCommand.Parameters.AddWithValue("@Condition", user.CONDITION);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        public int login(UserEnt user)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionDal.connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "Select ISNULL(MAX([Id]), 0) As Id From [User] Where [Condition] = 'ACTIVE' And [Username] = @Username "
                + "And [Password] = @Password";
            sqlCommand.Parameters.AddWithValue("@Username", user.USERNAME);
            sqlCommand.Parameters.AddWithValue("@Password", user.PASSWORD);
            sqlConnection.Open();
            int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnection.Close();
            return id;
        }
        #endregion
    }
}