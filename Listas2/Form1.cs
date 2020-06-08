using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.LstNombres.Items.Add("Juan");
            // 1. validar que haya datos ingresados en la caja de texto
            // 2. agregar el nombre ingresado en el listbox (clic botón agregar)
            // 3. el nombre se debe agregar cuando el usuario pulse enter 
            //    en la caja de texto
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.LstNombres.Items.Add(this.txtNombre_TextChanged.Tetx);
                spacio de nombres  WindowsFormsApp2
{
     Clase parcial  pública Formlista : Formulario 
    {
         formlista público ()
        {
            InitializeComponent ();
        }

        private  void  label1_Click ( remitente de objeto  , EventArgs e ) 
        {

        }

        Private  void  btnagregar_Click ( remitente de objeto  , EventArgs e ) 
        {
            if ( this . txtnombre . Text . Length  >  0 )
            {
                esta . lstNombres . Artículos . Agregar ( this . Txtnombre . Text );
                esta . txtnombre . Texto  =  " " ;
            }
        }

        private  void  text_TextChanged ( remitente del objeto  , EventArgs e ) 
        {
            
        }

        privado  vacío  btnagregar_KeyPress ( remitente de objeto  , KeyPressEventArgs e ) 
        {
           
        }

        privado  vacío  txtnombre_KeyPress ( remitente de objeto  , KeyPressEventArgs e ) 
        {
            

        }

         nulo  privado txtnombre_KeyDown ( remitente del objeto  , KeyEventArgs e ) 
        {
            if ( e . KeyCode . Equals ( Keys . Enter ))
            {
                if ( this . txtnombre . Text . Length  >  0 )
                {
                    esta . lstNombres . Artículos . Agregar ( this . Txtnombre . Text );
                    esta . txtnombre . Texto  =  " " ;
                }
            }
        }
    }
}

           


        }
    }
}