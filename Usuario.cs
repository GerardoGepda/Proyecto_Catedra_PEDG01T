using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Proyecto_Catedra_PEDG01T
{
    class Usuario
    {
        Conexion cone = new Conexion();
        private SqlCommand cmnd;

        private string nombre;
        private string apellido;
        private string idUsuario;
        private string fechanacimiento;
        private int telefono;
        private string email;
        private string tipousuario;
        private string contrasena;
        private string usuario;
        private string idtipoUsuario;
        private string verificarcontra;
        public SqlDataAdapter dataAdapter;
        public SqlDataReader dataReader;
        public SqlCommand sqlCommand;






        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                if (string.IsNullOrEmpty(Nombre))
                {
                    throw new Exception("El campo Nombre no puede estar vació.");
                }
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                if (string.IsNullOrEmpty(Apellido))
                {
                    throw new Exception("El campo Apellido no puede estar vació.");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                if (string.IsNullOrEmpty(Email))
                {
                    throw new Exception("El campo Email no puede estar vació.");
                }

            }
        }

        public string VerficarContra
        {
            get { return verificarcontra; }
            set
            {
                verificarcontra = value;
                if (string.IsNullOrEmpty(VerficarContra))
                {
                    throw new Exception("El campo Verificar Contrasena no puede estar vació.");
                }
            }
        }

        public string FechaNacimiento
        {
            get { return fechanacimiento; }
            set
            {
                fechanacimiento = value;
                if (string.IsNullOrEmpty(FechaNacimiento))
                {
                    throw new Exception("El campo Fecha de Nacimiento no puede estar vació.");
                }
            }
        }
        public int Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value;
                if (string.IsNullOrEmpty(Telefono.ToString()))
                {
                    throw new Exception("El campo Telefono no puede estar vació.");
                }
            }
        }
        public string IdUsuario
        {
            get { return idUsuario; }
            set
            {
                idUsuario = value;
                if (string.IsNullOrEmpty(IdUsuario))
                {
                    throw new Exception("El campo IdUsuario no puede estar vació.");
                }
            }
        }
        public string TipoUsuario
        {
            get { return tipousuario; }
            set
            {
                tipousuario = value;
                if (string.IsNullOrEmpty(TipoUsuario))
                {
                    throw new Exception("El campo TipoUsuario no puede estar vació.");
                }
            }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                contrasena = value;
                if (string.IsNullOrEmpty(Contrasena))
                {
                    throw new Exception("El campo Contraseña no puede estar vació.");
                }
            }
        }

        public string Uusuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                if (string.IsNullOrEmpty(Uusuario))
                {
                    throw new Exception("El campo Usuario no puede estar vació.");
                }
            }
        }
        public string IdTipoUsuario
        {
            get { return idtipoUsuario; }
            set
            {
                idtipoUsuario = value;
                if (string.IsNullOrEmpty(IdTipoUsuario))
                {
                    throw new Exception("El campo IdTTipousuario no puede estar vació.");
                }
            }
        }
        public void guardarusuario()
        {
            string sqlinsert = "INSERT INTO Usuarios(idUsuario,nombre, apellido,fechaNacimiento, usuario, contrasena, email, Telefono ,idTipoUsuario)" +
                        "VALUES (@codigo, @nombre, @apellido, @fechanaci, @Usuario, @Clave, @correo, @tel, @codigotusu)";

            try
            {
                cone.Conectar();

                sqlCommand = new SqlCommand(sqlinsert, cone.Conn);
                sqlCommand.Parameters.Add
                                (new SqlParameter("@codigo", SqlDbType.VarChar));
                sqlCommand.Parameters["@codigo"].Value = IdUsuario;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@nombre", SqlDbType.NChar));
                sqlCommand.Parameters["@nombre"].Value = Nombre;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@apellido", SqlDbType.VarChar));
                sqlCommand.Parameters["@apellido"].Value = Apellido;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@fechanaci", SqlDbType.VarChar));
                sqlCommand.Parameters["@fechanaci"].Value = FechaNacimiento;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@Usuario", SqlDbType.VarChar));
                sqlCommand.Parameters["@Usuario"].Value = Uusuario;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@Clave", SqlDbType.Int));
                sqlCommand.Parameters["@Clave"].Value = Contrasena;
                sqlCommand.Parameters.Add
                    (new SqlParameter("@correo", SqlDbType.VarChar));
                sqlCommand.Parameters["@correo"].Value = Email;
                sqlCommand.Parameters.Add
                   (new SqlParameter("@tel", SqlDbType.VarChar));
                sqlCommand.Parameters["@tel"].Value = Telefono;
                sqlCommand.Parameters.Add
                   (new SqlParameter("@codigotusu", SqlDbType.VarChar));
                sqlCommand.Parameters["@codigotusu"].Value = IdTipoUsuario;
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Usuario creado exitosamente, ahora inicie sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al registrar usuario: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cone.Cerrar();
            }
        }

        public void generarCod()
        {
            string codigo = "USR";
            int aleatorio;
            DateTime dateTime = DateTime.Now;
            Random random = new Random();

            aleatorio = random.Next(0, 99);
            codigo += dateTime.Second.ToString().Length == 1 ? "0" + dateTime.Second.ToString() : dateTime.Second.ToString();
            codigo += aleatorio.ToString().Length == 1 ? "0" + aleatorio.ToString() : aleatorio.ToString();
            codigo += dateTime.Day.ToString().Length == 1 ? "0" + dateTime.Day.ToString() : dateTime.Day.ToString();

            idUsuario = codigo;
        }

        public bool extraerUsuario(string nombre, string contrasena, string tipoUsuario)
        {
            cone.Conectar();

            string seleccionar = "Select * FROM Usuarios Where nombre='" + nombre + "' AND contrasena='" + contrasena + "' AND Tipo='" + tipousuario + "'";
            dataAdapter = new SqlDataAdapter(seleccionar, cone.Conn);
            SqlParameter prm = new SqlParameter("nombre", SqlDbType.VarChar);
            SqlParameter prm2 = new SqlParameter("contrasena", SqlDbType.VarChar);
            SqlParameter prm3 = new SqlParameter("Tipo", SqlDbType.VarChar);
            prm.Value = nombre;
            prm2.Value = contrasena;
            prm3.Value = tipoUsuario;
            dataAdapter.SelectCommand.Parameters.Add(prm);
            dataAdapter.SelectCommand.Parameters.Add(prm2);
            dataAdapter.SelectCommand.Parameters.Add(prm3);

            dataReader = dataAdapter.SelectCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                dataReader.Read();
                IdUsuario = dataReader["idUsuario"].ToString();
                Nombre = dataReader["nombre"].ToString();
                Apellido = dataReader["apellido"].ToString();
                FechaNacimiento = dataReader["fechaNacimiento"].ToString();
                Uusuario = dataReader["usuario"].ToString();
                Contrasena = dataReader["contrasena"].ToString();
                Email = dataReader["email"].ToString();
                Telefono = Convert.ToInt32(dataReader["Telefono"].ToString());
                IdTipoUsuario = dataReader["idTipoUsuario"].ToString();              
                dataReader.Close();
                cone.Cerrar();
                return true;
            }
            else
            {
                dataReader.Close();
                cone.Cerrar();
                return false;
            }
        }

        public bool claveEsfuerte(string password)
        {
            int cuentanum = 0;
            int cuentaminusculas = 0;
            int cuentamayusculas = 0;
            char[] contra = password.ToArray<char>();

            Regex reminus = new Regex(@"\A([a-z])\Z");
            Regex remayuus = new Regex(@"\A([A-Z])\Z");
            Regex renum = new Regex(@"\A([0-9])\Z");

            //Vamos caracter a caracter y comprobamos que tipo de caracter es
            for (int i = 0; i < password.Length; i++)
            {
                if (remayuus.IsMatch(Convert.ToString(contra[i])))
                {
                    cuentamayusculas++;
                }
                else if (reminus.IsMatch(Convert.ToString(contra[i])))
                {
                    cuentaminusculas++;
                }
                else if (renum.IsMatch(Convert.ToString(contra[i])))
                {
                    cuentanum++;
                }
            }

            //Si la constraseña tiene mas de 5 numeros, mas de 1 minuscula y mas de 2 mayusculas
            if (cuentanum >= 5 && cuentaminusculas >= 1 && cuentamayusculas >= 2)
                return true;
            else
                return false;
        }

        private bool actualizarUsuario()
        {
            int rowsAffected = 0;
            try
            {
                cone.Conectar();

                string sqlupdate = "UPDATE Usuarios (Nombre, Apellido, Correo, Clave, Direccion, Telefono) " +
                    "values (@nombre, @apellido, @correo, @clave, @direccion, @telefono)";

                cmnd = new SqlCommand(sqlupdate, cone.Conn);
                cmnd.Parameters.AddWithValue("@codigo", IdUsuario);
                cmnd.Parameters.AddWithValue("@nombre", Nombre);
                cmnd.Parameters.AddWithValue("@apellido", Apellido);
                cmnd.Parameters.AddWithValue("@fechanaci", FechaNacimiento);
                cmnd.Parameters.AddWithValue("@Usuario", Uusuario);
                cmnd.Parameters.AddWithValue("@Clave", Contrasena);
                cmnd.Parameters.AddWithValue("@correo", Email);
                cmnd.Parameters.AddWithValue("@tel", Telefono);
                cmnd.Parameters.AddWithValue("@codigotusu", IdTipoUsuario);
                rowsAffected = cmnd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar Usuario de BD: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = 0;
            }
            finally
            {
                cone.Cerrar();
            }

            if (rowsAffected != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> extraerMpagos()
        {
            string sqlSelect = "SELECT metodo FROM MetodoPago WHERE CodigoUsuario = @codUser";
            List<string> metodos = new List<string>();

            try
            {
                cone.Conectar();

                dataAdapter = new SqlDataAdapter(sqlSelect, cone.Conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@codUSer", cone);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al recibir métodos de pago: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    metodos.Add(dataReader["metodo"].ToString());
                    Console.WriteLine();
                }
            }

            cone.Cerrar();
            dataReader.Close();

            return metodos;
        }

    }
}

