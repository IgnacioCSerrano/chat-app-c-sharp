using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Password Text Box --> UseSystemPasswordChar = true;

namespace ProyectoChat
{
    public partial class ChatForm : Form
    {
        MySqlConnection conexion = new MySqlConnection();

        public ChatForm()
        {
            InitializeComponent();
            tbName.Select();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            //conexion.ConnectionString = "server=db4free.net; database=dam2020; uid=camachin2020; pwd=pruden2020; old guids=true";
            conexion.ConnectionString = "server=freedb.tech; database=freedbtech_dam2020; uid=freedbtech_camachin2020; pwd=pruden2020; old guids=true";

            //Refrescar();
        }

        private void rbLogin_Click(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        private void rbRegistro_CheckedChanged(object sender, EventArgs e)
        {
            tbName.Focus();
        }

        /*
         * Método que recibe una cadena por parámetro y la devuelve en minúsculas
         * con el primer carácter en mayúscula.
         */ 
        private string CapitaliseFirst(string cadena)
        {
            return char.ToUpper(cadena[0]) + cadena.Substring(1).ToLower();
        }

        /*
         * Método que muestra el panel del chat y oculta la caja de inicio de sesión y registro. 
         * Se efectúa la operación de refresco para evitar que Data Grid View se muestre vacío al 
         * inicio.    
         */ 
        private void ShowChat()
        {
            Refrescar();
            labUsername.Text = CapitaliseFirst(tbName.Text);
            gbUsername.Visible = false;
            panelChat.Visible = true;
            tbMensaje.Focus();
        }

        /*
         * Mensaje emergente de error genérico en la conexión con la Base de Datos MySQL del servidor
         * o en la ejecución de sentencias. 
         */ 
        private void MensajeErrorDB()
        {
            MessageBox.Show("Error de conexión con la Base de Datos. \nInténtelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /*
         * Método para registrar un nuevo usuario en la Base de Datos y permitirle acceder al chat.
         * Muestra un mensaje emergente de error específico si fallo de conexión se debe a que nombre 
         * de usuario introducido corresponde a registro existente.
         */ 
        private void Registro()
        {
            bool error = false;
            bool duplicado = false;
            try
            {
                conexion.Open();

                String cadenaSQL = "INSERT INTO usuarios VALUES (?nombre, ?password);";

                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion);
                comando.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = tbName.Text;
                comando.Parameters.Add("?password", MySqlDbType.VarChar).Value = tbPassw.Text;

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                error = true;
                duplicado = ex.Message.StartsWith("Duplicate");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
                if (error)
                {
                    if (duplicado)
                    {
                        MessageBox.Show("Ya hay registrado un usuario con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MensajeErrorDB();
                    }
                    tbName.Focus();
                }
                else
                {
                    ShowChat();
                }
            }
        }

        /*
         * Método para iniciar sesión en el chat como usuario registrado. Muestra un mensaje emergente 
         * de error específico si fallo de conexión se debe a que credenciales introducidas no corresponden 
         * a usuario registrado en la Base de Datos.
         */
        private void Login()
        {
            long count = 0;
            //byte count = 0;
            bool error = false;
            try
            {
                conexion.Open();

                String cadenaSQL = "SELECT COUNT(*) FROM usuarios WHERE login = ?login AND password = ?password;";

                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion);
                comando.Parameters.Add("?login", MySqlDbType.VarChar).Value = tbName.Text;
                comando.Parameters.Add("?password", MySqlDbType.VarChar).Value = tbPassw.Text;

                MySqlDataReader resultado = comando.ExecuteReader();
                resultado.Read();

                /*
                    If we want to use explicit cast conversion on the MySqlDataReader object we have to use
                    the exact data type of the correspondig object stored in the database (count(*) returns
                    a BIGINT type, which is a 64-bit signed integer, so we need to cast it to long).
                    If we do not know the origin type or simply want to cast it to a different type then we 
                    have to use Convert.ToXXX().
                */
                count = (long)resultado[0];
                //count = Convert.ToByte(resultado[0]);
            }
            catch (MySqlException ex)
            {
                error = true;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexion.Close();
                if (error)
                {
                    MensajeErrorDB();
                    tbName.Focus();
                }
                else if (count == 0)
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbName.Focus();
                }
                else
                {
                    ShowChat();
                }
            }
        }

        /*
         * Evento de pulsación de tecla sobre campo de contraseña. Para proceder a inicio de sesión 
         * o registro controla si tecla pulsada es 'Enter', si ambos campos están rellenos (lanzando 
         * mensajes emergendes de advertencia en caso contrario) y cuál de los dos radio botones es 
         * el que está seleccionado.
         */ 
        private void tbPassw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbName.Text == "")
                {
                    MessageBox.Show("Rellene el campo de nombre.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tbPassw.Text == "")
                {
                    MessageBox.Show("Rellene el campo de contraseña.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbLogin.Checked)
                    {
                        Login();
                    }
                    else
                    {
                        Registro();
                    }
                    tbName.Clear();
                    tbPassw.Clear();
                }
            }
        }

        /*
         * Método desloguea al usuario registrado, ocultando el panel del chat, vaciando el Data Grid View
         * y mostrando de nuevo la cabecera de registro de credenciales.    
         */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            labUsername.Text = "";
            gbUsername.Visible = true;
            panelChat.Visible = false;
            dgvChat.DataSource = null;
            rbLogin.Checked = true;
            tbName.Focus();
        }

        /*
         * Método que efectúa una consulta contra la Base de Datos para retraer los últimos diez
         * registros de la tabla `chat` ordenados descendientemente por fecha y mostrarlos en
         * un Data Grid View.
         */ 
        private void Refrescar()
        {
            List<Chat> listaRanking = new List<Chat>();
            try
            {
                conexion.Open();

                String cadenaSQL = "SELECT * FROM chat ORDER BY tiempo DESC LIMIT 10";
                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion);
                MySqlDataReader resultadoLista = comando.ExecuteReader();

                while (resultadoLista.Read())
                {
                    listaRanking.Add(new Chat((string)resultadoLista[0], (string)resultadoLista[1], (DateTime)resultadoLista[2]));
                }

                dgvChat.DataSource = listaRanking;
                dgvChat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvChat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvChat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MensajeErrorDB();
            }
            finally
            {
                conexion.Close();
            }
        }

        /*
         * Método que efectúa una sentencia de manipulación de datos contra la Base de Datos 
         * para registrar el mensaje de un usuario, recogido del valor del campo correspondiente.
         */
        private void RegistrarmensajeDB(string mensaje)
        {
            try
            {
                conexion.Open();

                String cadenaSQL = "INSERT INTO chat VALUES (?nombre, ?mensaje, ?fecha)";
                MySqlCommand comando = new MySqlCommand(cadenaSQL, conexion);

                comando.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = labUsername.Text;
                comando.Parameters.Add("?mensaje", MySqlDbType.VarChar).Value = mensaje;
                comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now; // DateTime.Now registra hora local del equipo

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MensajeErrorDB();
            }
            finally
            {
                conexion.Close();
            }
        }

        /*
         * Método que lleva a cabo la llamada al método para registrar mensaje, controlando que 
         * haya algún valor en el campo de entrada correspondiente y lanzando un mensaje emergende
         * de advertencia en caso contrario.
         */
        private void SendMessage()
        {
            if (tbMensaje.Text != "")
            {
                RegistrarmensajeDB(tbMensaje.Text);
                Refrescar();
                tbMensaje.Clear();
                tbMensaje.Focus();
            }
            else
            {
                MessageBox.Show("Escribe un texto para mandar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void tbMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        /*
         * Evento de pintado sobre etiqueta de línea horizontal queue dibuja el borde 
         * con un diseño específico (color corporativo).
         */ 
        private void labHL_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labHL.DisplayRectangle, Color.FromArgb(1, 142, 128), ButtonBorderStyle.Solid);
        }
    }
}
