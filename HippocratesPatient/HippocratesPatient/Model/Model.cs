using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For database connection and data access

using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using HippocratesPatient.View;

namespace HippocratesPatient.Model
{
    class Model : IModel//, IValidate
    {
        private View.IView view;
        public Model(View.IView v)
        {
            if (v != null)
                view = v;
        }

        public bool ConnectToDatabase(string constring)
        {
            string connection = "server=139.59.132.29;user=paja;charset=utf8;database=Hippocrates;port=3306;password=pajapro1234;protocol=TCP";
            bool success = true;

            MySqlConnection conn = new MySqlConnection(connection);
            try
            {
                // Open connection
                conn.Open();
                // Copy to local 
                // Perform database operations
                string sql = "select jmbg, lbo from PACIJENT where jmbg = '" + view.GetJMBG()+ "' and lbo = '" + view.GetLBO() + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() != true) // only one JMBG and LBO combination
                    return false;
                
                rdr.Close();

            }
            catch (Exception ex)
            {
                
                success = false;
            }
            finally
            {
                conn.Close();
                // Database is always closed
            }
            return success;
        }
        
        public bool ValidateJMBG(string s)
        {
            return true;
            ////////////////////////////////
            if (s.Length == 13)
                return Is_String_Number(s);
            else
                return false;
        }

        public bool ValidateLBO(string s)
        {
            return true;
            ///////////////////////////////
            if (s.Length == 10)
                return Is_String_Number(s);
            else
                return false;
        }

        public bool Is_String_Number(string s)
        {
            char[] array = s.ToCharArray();
            if (s.Length != 13)
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(array[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public IView GetView()
        {
            return view;
        }
    }
}
