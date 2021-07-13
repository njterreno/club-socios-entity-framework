using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Datos;

namespace Presentacion
{
    public partial class frmSocio : Form
    {
        public Int64 IDSocio;
        public clsSocios clsSocio = new clsSocios();
        //DataGridViewCheckBoxCell chkActivo = new DataGridViewCheckBoxCell();
        //DataGridViewComboBoxCell cbxActividad = new DataGridViewComboBoxCell();


        public frmSocio()
        {
            InitializeComponent();

            clsLocalidad loc = new clsLocalidad();

            List<Localidad> Lista = loc.Listar();

            cbxLocalidad.DataSource = Lista;
            cbxLocalidad.ValueMember = "IDLocalidad";
            cbxLocalidad.DisplayMember = "Nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNIBusq.Text != "" | txtNomYApeBusq.Text != "")
            {
                if (txtDNIBusq.Text != "")
                {
                    dgvDatosSocios.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<Socio> lstSxDNI = clsSocios.ListarXDNI(Convert.ToInt32(txtDNIBusq.Text));

                    foreach (var itemS in lstSxDNI)
                    {
                        this.dgvDatosSocios.Rows.Add(itemS.IDSocio, itemS.Nombre, itemS.Apellido, itemS.DNI, itemS.CorreoElectronico, itemS.Telefono, itemS.TelContacto);
                    }
                }
                else if (txtNomYApeBusq.Text != "")
                {
                    dgvDatosSocios.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<vListarXNomYApe> lstSxNomYApeV = clsSocios.ListarXNomYApe(txtNomYApeBusq.Text);

                    foreach (var itemV in lstSxNomYApeV)
                    {
                        List<Socio> lstSxID = clsSocios.ListarXID(itemV.idsocio);

                        foreach (var itemS in lstSxID)
                        {
                            this.dgvDatosSocios.Rows.Add(itemS.IDSocio, itemS.Nombre, itemS.Apellido, itemS.DNI, itemS.CorreoElectronico, itemS.Telefono, itemS.TelContacto);
                        }
                    }
                }
                else
                {
                    dgvDatosSocios.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<Socio> lstIxDNI = clsSocios.ListarXDNI(Convert.ToInt32(txtDNIBusq.Text));

                    foreach (var itemS in lstIxDNI)
                    {
                        this.dgvDatosSocios.Rows.Add(itemS.IDSocio, itemS.Nombre, itemS.Apellido, itemS.DNI, itemS.CorreoElectronico, itemS.Telefono, itemS.TelContacto);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "" || txtFechaAlta.Text == "" || txtFechaNac.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtTelContacto.Text == "" || txtCorreoElectronico.Text == "" || cbxActivo.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos", "ALERTA");
            }
            else
            {
                if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains(".com"))
                {
                    MessageBox.Show("Correo electrónico inválido", "ALERTA");
                }
                else
                {
                    Socio socio = new Socio();

                    if (txtIDSocio.Text == "")//Insertar
                    {
                        List<Socio> ListaSocioXDNI = clsSocio.ListarXDNI(Convert.ToInt32(txtDNI.Text));

                        if (txtDNI.Text == socio.DNI.ToString())
                        {
                            MessageBox.Show("El socio ya existe", "ALERTA");
                        }
                        else
                        {
                            socio.Nombre = txtNombre.Text;
                            socio.Apellido = txtApellido.Text;
                            socio.DNI = Convert.ToInt32(txtDNI.Text);
                            socio.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                            socio.FechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                            socio.Direccion = txtDireccion.Text;
                            socio.Telefono = Convert.ToInt64(txtTelefono.Text);
                            socio.TelContacto = Convert.ToInt64(txtTelContacto.Text);
                            socio.CorreoElectronico = txtCorreoElectronico.Text;
                            socio.IDLocalidad = cbxLocalidad.SelectedIndex + 1;
                            if (cbxActivo.Text == "SI")
                                socio.Activo = 1;
                            else
                                socio.Activo = 0;

                            clsSocio.CrearModificar(socio);

                            this.Refresh();
                            btnBuscar.PerformClick();

                            MessageBox.Show("EL SOCIO SE GUARDADO EXITOSAMENTE");
                        }
                    }
                    else//actualizar
                    {
                        socio.IDSocio = Convert.ToInt32(txtIDSocio.Text);
                        socio.Nombre = txtNombre.Text;
                        socio.Apellido = txtApellido.Text;
                        socio.DNI = Convert.ToInt32(txtDNI.Text);
                        socio.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                        socio.FechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
                        socio.Direccion = txtDireccion.Text;
                        socio.Telefono = Convert.ToInt64(txtTelefono.Text);
                        socio.TelContacto = Convert.ToInt64(txtTelContacto.Text);
                        socio.CorreoElectronico = txtCorreoElectronico.Text;
                        if (cbxActivo.Text == "SI")
                            socio.Activo = 1;
                        else
                            socio.Activo = 0;

                        clsSocio.CrearModificar(socio);
                        SocioActualizado(Convert.ToInt32(txtDNI.Text));
                    }
                }


                VaciarCampos();
            }
        }

        private void SocioActualizado(int dni)
        {
            //int i = dgvDatosSocios.CurrentRow.Index;

            dgvDatosSocios.Rows.Clear();

            //txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

            Socio socio = new Socio();
            List<Socio> lstS = clsSocio.ListarXDNI(dni);
            foreach (Socio s in lstS)
            {
                this.dgvDatosSocios.Rows.Add(s.IDSocio, s.Nombre, s.Apellido, s.DNI, s.CorreoElectronico, s.Telefono, s.TelContacto);
            }
        }

        private void VaciarCampos()
        {
            txtIDSocio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtCorreoElectronico.Text = "";
            txtDireccion.Text = "";
            txtFechaAlta.Text = "";
            txtFechaNac.Text = "";
            txtIDSocio.Text = "";
            txtTelefono.Text = "";
            txtTelContacto.Text = "";
            cbxActivo.Text = "SI";
            cbxLocalidad.Text = "";
        }

        private void LlenaGrilla()
        {
            dgvDatosSocios.Rows.Clear();

            clsSocios Socio = new clsSocios();

            List<Socio> Lista = Socio.Listar();
            foreach (Socio s in Lista)
            {
                this.dgvDatosSocios.Rows.Add(s.IDSocio, s.Nombre, s.Apellido, s.DNI, s.CorreoElectronico, s.Telefono, s.TelContacto);
            }
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {

            Actividad objAct = new Actividad();
            clsActividad clsAct = new clsActividad();

            cbxActividades.DataSource = clsAct.Listar();
            cbxActividades.ValueMember = "IDActividad";
            cbxActividades.DisplayMember = "Nombre";

            cbxActReporte.DataSource = clsAct.Listar();
            cbxActReporte.ValueMember = "IDActividad";
            cbxActReporte.DisplayMember = "Nombre";

            Socio objSocio = new Socio();
            clsLocalidad clsLoc = new clsLocalidad();

            cbxLocalidad.DataSource = clsLoc.Listar();
            cbxLocalidad.ValueMember = "IDLocalidad";
            cbxLocalidad.DisplayMember = "Nombre";

            if (IDSocio != 0)
            {
                clsSocio.select(IDSocio);

                if (clsSocio != null)
                {
                    txtNombre.Text = objSocio.Nombre;
                    txtApellido.Text = objSocio.Apellido;
                    objSocio.DNI = objSocio.DNI;
                }
            }

            dgvActXSocio.Rows.Add("Basquet");
            dgvActXSocio.Rows.Add("Voley");
            dgvActXSocio.Rows.Add("Bochas");
            dgvActXSocio.Rows.Add("Natacion");            
            dgvActXSocio.Rows.Add("Futbol");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatosSocios.CurrentRow.Index > -1)
            {
                int i = dgvDatosSocios.CurrentRow.Index;

                txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

                Socio socio = new Socio();
                List<Socio> lstS = clsSocio.ListarXDNI(Convert.ToInt32(dgvDatosSocios.Rows[i].Cells[3].Value));
                foreach (Socio soc in lstS)
                {
                    txtIDSocio.Text = soc.IDSocio.ToString();
                    txtNombre.Text = soc.Nombre;
                    txtApellido.Text = soc.Apellido;
                    txtDNI.Text = soc.DNI.ToString();
                    txtCorreoElectronico.Text = soc.CorreoElectronico;
                    txtTelefono.Text = soc.Telefono.ToString();
                    txtTelContacto.Text = soc.TelContacto.ToString();
                    txtFechaAlta.Text = soc.FechaAlta.ToString();
                    txtFechaNac.Text = soc.FechaNac.ToString();

                    if (soc.Activo == 1)
                    {
                        cbxActivo.Text = "SI";
                    }
                    else
                    {
                        cbxActivo.Text = "NO";
                    }
                    //cbxActivo.Text = soc.Activo.ToString();

                    txtDireccion.Text = soc.Direccion;

                    clsLocalidad Loc = new clsLocalidad();
                    List<Localidad> lstLoc = Loc.ListarXID(Convert.ToInt64(soc.IDLocalidad));
                    foreach (Localidad itemL in lstLoc)
                    {
                        cbxLocalidad.Text = itemL.Nombre;
                    }
                }
            }
        }

        

        private void dgvDatosSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.PerformClick();
            ChequearAct();
            //dgvActXSocio.Rows.Clear();

            //List<clsActividadXSocio> lstActXSoc = new List<clsActividadXSocio>();
            //Socio objSoc = new Socio();

            //if (objSoc != null)
            //{
            //    clsActividadXSocio objActXSoc = new clsActividadXSocio();
            //    List<spListarSocioXAct_Result> lstActividad = objActXSoc.ListaActividad(Convert.ToInt64(dgvDatosSocios.Rows[e.RowIndex].Cells["Column1"].Value));


            //    if (lstActividad.Count > 0)
            //    {
            //        foreach (var item in lstActividad)
            //        {
            //            //string stFechaHasta = "";
            //            //if (item.FechaHasta == null)
            //            //{
            //            //    stFechaHasta = "-";
            //            //}
            //            //else
            //            //{
            //            //    stFechaHasta = stFechaHasta = Convert.ToDateTime(item.FechaHasta).ToShortDateString();
            //            //}

            //            dgvActXSocio.Rows.Add(item.Nombre);

            //        }
            //    }
            //}
        }

        private void ChequearAct()
        {
            clsActividadXSocio clsActXSocio = new clsActividadXSocio();

            foreach (DataGridViewRow row in dgvActXSocio.Rows)
            {
                row.Cells["Column14"].Value = false;
            }

            List<spListarSocioXAct_Result> lstActXSoc = clsActXSocio.ListaActividad(Convert.ToInt64(txtIDSocio.Text));
            foreach (var valor in lstActXSoc)
            {
                string nombre = valor.Nombre;

                foreach (DataGridViewRow row in dgvActXSocio.Rows)
                {
                    string actividad = Convert.ToString(row.Cells["Column13"].Value);

                    if (nombre.Equals(actividad))
                    {
                        row.Cells["Column14"].Value = true;
                    }
                }
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            clsActividadXSocio clsActXSoc = new clsActividadXSocio();
            ActividadXSocio objActXSoc = new ActividadXSocio();

            //objActXSoc.IDActividad = Convert.ToInt64(cbxActividades.SelectedValue);

            objActXSoc.IDActividad = Convert.ToInt64(cbxActividades.SelectedValue);
            objActXSoc.IDSocio = Convert.ToInt64(txtIDSocio.Text);

            clsActXSoc.AltaSocio(objActXSoc);

            ChequearAct();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            clsActividadXSocio clsActXSoc = new clsActividadXSocio();
            ActividadXSocio objActXSoc = new ActividadXSocio();

            objActXSoc.IDActividad = Convert.ToInt64(cbxActividades.SelectedValue);
            objActXSoc.IDSocio = Convert.ToInt64(txtIDSocio.Text);

            clsActXSoc.BajaSocio(objActXSoc);

            ChequearAct();
        }

        private void btnGenerarCuotas_Click(object sender, EventArgs e)
        {
            if (txtIDSocio.TextLength != 0)
            {
                frmGenerarCuotas frmGenerarCuotas = new frmGenerarCuotas();
                frmGenerarCuotas.IDSocio = Convert.ToInt64(txtIDSocio.Text);
                frmGenerarCuotas.ShowDialog();
            }
            else
            {
                frmGenerarCuotas frmGenerarCuotas = new frmGenerarCuotas();
                frmGenerarCuotas.ShowDialog();
            }
        }

        private void btnActXSoc_Click(object sender, EventArgs e)
        {
            string filtro = "";
            Reportes.ActividadesPorSocio rpt = new Reportes.ActividadesPorSocio();

            if (Convert.ToInt64(txtIDSocio.Text) > 0)
            {
                filtro = "{vActividades.IDSocio} = " + txtIDSocio.Text;
            }

            rpt.RecordSelectionFormula = filtro;

            frmVisorReporte frm = new frmVisorReporte();
            frm.Visor.ReportSource = rpt;
            frm.Visor.Refresh();
            frm.Show();
        }

        private void btnVerReporteSocXAct_Click(object sender, EventArgs e)
        {
            string filtro = "";
            Reportes.SociosPorActividad rpt = new Reportes.SociosPorActividad();
            if (cbxActReporte.Text != "")
            {                
                filtro = "{vActividades.IDActividad} = " + cbxActReporte.SelectedValue;
            }

            rpt.RecordSelectionFormula = filtro;
            frmVisorReporte frm = new frmVisorReporte();
            frm.Visor.ReportSource = rpt;
            frm.Visor.Refresh();

            frm.Show();
        }
    }
}
