using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Compromisos.Models
{
    public class ConexionBD
    {
            private SqlConnection con;
            private void connection()
            {
                string constring = ConfigurationManager.ConnectionStrings["LOCAL_BD"].ToString();
                con = new SqlConnection(constring);
            }

            // **************** ADD NEW STUDENT *********************
            public bool AñadirPart(Participantes smodel)
            {
                connection();
                SqlCommand cmd = new SqlCommand("agregarPart", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PART_RUT", smodel.PART_RUT);
                cmd.Parameters.AddWithValue("@PART_NOMBRE", smodel.PART_NOMBRE);
                cmd.Parameters.AddWithValue("@PART_FONO", smodel.PART_FONO);
                cmd.Parameters.AddWithValue("@PART_EMAIL", smodel.PART_EMAIL);
                cmd.Parameters.AddWithValue("@PART_INSTITUCION", smodel.PART_INSTITUCION);


                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i >= 1)
                    return true;
                else
                    return false;
            }

            // ********** VIEW STUDENT DETAILS ********************
            public List<Participantes> LeerParticipantes()
            {
                connection();
                List<Participantes> participantelist = new List<Participantes>();

                SqlCommand cmd = new SqlCommand("LeerPart", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Open();
                sd.Fill(dt);
                con.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    participantelist.Add(
                        new Participantes()
                        {
                            PART_RUT = Convert.ToString(dr["PART_RUT"]),
                            PART_NOMBRE = Convert.ToString(dr["PART_NOMBRE"]),
                            PART_FONO = Convert.ToString(dr["PART_FONO"]),
                            PART_EMAIL = Convert.ToString(dr["PART_EMAIL"]),
                            PART_INSTITUCION = Convert.ToString(dr["PART_INSTITUCION"])
                        });
                }
                return participantelist;
            }

            // ***************** UPDATE STUDENT DETAILS *********************
            public bool ActualizarPart(Participantes smodel)
            {
                connection();
                SqlCommand cmd = new SqlCommand("ActualizarParticipantes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PART_RUT", smodel.PART_RUT);
                cmd.Parameters.AddWithValue("@PART_NOMBRE", smodel.PART_NOMBRE);
                cmd.Parameters.AddWithValue("@PART_FONO", smodel.PART_FONO);
                cmd.Parameters.AddWithValue("@PART_EMAIL", smodel.PART_EMAIL);
                cmd.Parameters.AddWithValue("@PART_INSTITUCION", smodel.PART_INSTITUCION);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

    

            if (i >= 1)
                    return true;
                else
                    return false;
            }

            // ********************** DELETE STUDENT DETAILS *******************
            public bool BorrarPart(int PART_RUT)
            {
                connection();
                SqlCommand cmd = new SqlCommand("BorrarPart", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PART_RUT", PART_RUT);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i >= 1)
                    return true;
                else
                    return false;
            }
        }
<<<<<<< Updated upstream
    }
=======
    }
>>>>>>> Stashed changes
