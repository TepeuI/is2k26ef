using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Seguridad;
using Capa_Controlador_Seguridad;
using System.Drawing.Imaging;
using Capa_Vista_Reporteador;

namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        private Cls_ControladorAsignacionUsuarioAplicacion controladorPermisos = new Cls_ControladorAsignacionUsuarioAplicacion();
        private Cls_Asignacion_Permiso_PerfilControlador controladorPermisosPerfil = new Cls_Asignacion_Permiso_PerfilControlador();

        public enum MenuOpciones
        {
            Archivo,
            Catalogos,
            Procesos,
            Reportes,
            Ayudas,
            Seguridad
        }

        private Dictionary<MenuOpciones, ToolStripMenuItem> menuItems;

        public Frm_MDI()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.Load += Frm_MDI_Load;
            this.IsMdiContainer = true;

        }

        private void Frm_MDI_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"Estado: Conectado | Usuario: {Capa_Controlador_Seguridad.Cls_Usuario_Conectado.sNombreUsuario}";
        }



        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_LOGIN login = new Frm_LOGIN();
            login.ShowDialog();
            this.Close();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes Reporteador = new Frm_Reportes();
            Reporteador.MdiParent = this;
            Reporteador.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bitacora Bitacora = new Frm_Bitacora();
            Bitacora.MdiParent = this;
            Bitacora.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_cambiar_contrasena cambiar_Contrasena = new Frm_cambiar_contrasena(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario);
            cambiar_Contrasena.MdiParent = this;
            cambiar_Contrasena.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usuario frm = new Frm_Usuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mantenimientoAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAplicacion formAplicacion = new FrmAplicacion();
            formAplicacion.MdiParent = this;
            formAplicacion.Show();
        }

        private void permisosAplicacionUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_asignacion_aplicacion_usuario asig_app_user = new Frm_asignacion_aplicacion_usuario();
            asig_app_user.MdiParent = this;
            asig_app_user.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cursos Cursos = new Frm_Cursos();
            Cursos.MdiParent = this;
            Cursos.Show();
        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}