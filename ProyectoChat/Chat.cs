using System;

namespace ProyectoChat
{
    class Chat
    {
        private string nombre;
        private string mensaje;
        private DateTime fecha;

        public Chat(string nombre, string mensaje, DateTime fecha)
        {
            this.nombre = nombre;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        /*
            A property is like a combination of a variable field and a method, and it has two methods: 
            get and set. It is a good practice to use the same name for both the property and the private 
            field associated with it, but with an uppercase first letter.

                https://www.w3schools.com/cs/cs_properties.asp
        */

        public string Nombre // valor de propiedad (Nombre) es el que se muestra como cabecera en la columna del DataGridView al establecer la lista extraida de la Base de Datos como DataSource
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }

            set
            {
                mensaje = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }
}