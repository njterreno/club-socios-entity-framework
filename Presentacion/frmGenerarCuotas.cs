using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class frmGenerarCuotas : Form
    {
        public Int64 IDSocio;
        bool tildar = true;

        public frmGenerarCuotas()
        {
            InitializeComponent();

            dgvCuotasGeneradas.ReadOnly = false;

            txtAñoCuota.Text = DateTime.Now.Year.ToString();
            txtMesCuota.Text = DateTime.Now.Month.ToString();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool band = false;
            clsCuotaXSocio clsCuotaXSoc = new clsCuotaXSocio();
            CuotaXSocio objCuoXSoc = new CuotaXSocio();

            if (rdbGenCuotaSocEspecif.Checked == true)
            {
                objCuoXSoc.IDSocio = IDSocio;
                if (Convert.ToInt32(txtMesCuota.Text) <= 12)
                {
                    List<CuotaXSocio> lstCuXSo = clsCuotaXSoc.ListarXIDSoc(IDSocio);
                    if (lstCuXSo.Count != 0)
                    {
                        foreach (var item in lstCuXSo)
                        {
                            if (item.MesCuota.ToString() == txtMesCuota.Text && item.AñoCuota.ToString() == txtAñoCuota.Text)
                            {
                                band = true;
                            }
                        }

                        if (band == false)
                        {
                            objCuoXSoc.IDSocio = IDSocio;
                            objCuoXSoc.MesCuota = Convert.ToInt32(txtMesCuota.Text);
                            objCuoXSoc.AñoCuota = Convert.ToInt32(txtAñoCuota.Text);

                            clsCuotaXSoc.GenerarCuota(objCuoXSoc);
                        }
                        else
                        {
                            MessageBox.Show("CUOTA YA GENERADA", "ALERTA");
                        }
                    }
                    else
                    {
                        objCuoXSoc.MesCuota = Convert.ToInt32(txtMesCuota.Text);
                        objCuoXSoc.AñoCuota = Convert.ToInt32(txtAñoCuota.Text);

                        clsCuotaXSoc.GenerarCuota(objCuoXSoc);
                    }


                    dgvCuotasGeneradas.Rows.Clear();

                    foreach (var item in lstCuXSo)
                    {
                        dgvCuotasGeneradas.Rows.Add(item.MesCuota, item.AñoCuota, item.MontoTotal);
                    }
                }
                else
                {
                    MessageBox.Show("FECHA INCORRECTA", "ALERTA");
                }
            }
            else if (rdbGenCuotaTodosSoc.Checked == true)
            {
                clsSocios clsSoc = new clsSocios();

                List<vSociosActivos> lstVSocAct = clsSoc.ListarSociosActivos();

                foreach (var itemV in lstVSocAct)
                {
                    band = false;

                    if (Convert.ToInt32(txtMesCuota.Text) <= 12)
                    {
                        List<CuotaXSocio> lstCxS = clsCuotaXSoc.ListarXIDSoc(itemV.IDSocio);
                        if (lstCxS.Count != 0)
                        {
                            foreach (var item in lstCxS)
                            {
                                if (item.MesCuota.ToString() == txtMesCuota.Text && item.AñoCuota.ToString() == txtAñoCuota.Text)
                                {
                                    band = true;
                                }
                            }

                            if (band == false)
                            {
                                objCuoXSoc.IDSocio = itemV.IDSocio;
                                objCuoXSoc.MesCuota = Convert.ToInt32(txtMesCuota.Text);
                                objCuoXSoc.AñoCuota = Convert.ToInt32(txtAñoCuota.Text);

                                clsCuotaXSoc.GenerarCuota(objCuoXSoc);
                            }
                        }
                        else
                        {
                            objCuoXSoc.IDSocio = itemV.IDSocio;

                            objCuoXSoc.MesCuota = Convert.ToInt32(txtMesCuota.Text);
                            objCuoXSoc.AñoCuota = Convert.ToInt32(txtAñoCuota.Text);

                            clsCuotaXSoc.GenerarCuota(objCuoXSoc);
                        }
                    }
                }
            }
        }

        private void dgvSociosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                IDSocio = Convert.ToInt64(dgvSociosActivos.Rows[e.RowIndex].Cells["Column1"].Value);

            btnConsultarCuotas.PerformClick();
        }

        private void btnConsultarCuotas_Click(object sender, EventArgs e)
        {
            dgvCuotasGeneradas.Rows.Clear();

            clsPago objPago = new clsPago();
            clsCuotaXSocio clsCuotaXSoc = new clsCuotaXSocio();
            List<CuotaXSocio> lstCuXSo = clsCuotaXSoc.ListarXIDSoc(IDSocio);

            int i = 0;
            
            foreach (var item in lstCuXSo)
            {
                List<Pago> lstP = objPago.ListarXIDCxS(item.IDCuotaXSocio);

                if (lstP.Count != 0)
                {
                    foreach (var itemP in lstP)
                    {
                        if (item.Cancelado == 1) tildar = true; else tildar = false;

                        string fechaPago;
                        if (itemP.FechaEmisionComprob == null)
                            fechaPago = "-";
                        else
                        {
                            DateTime fecha = (DateTime)itemP.FechaEmisionComprob;
                            fechaPago = fecha.ToShortDateString();
                        }


                        int pendiente = (int)item.MontoTotal - (int)itemP.Monto;

                        dgvCuotasGeneradas.Rows.Add(item.IDCuotaXSocio, item.MesCuota + "/" + item.AñoCuota, item.MontoTotal, fechaPago, tildar, itemP.Monto, pendiente);


                        DataGridViewCheckBoxCell chkPago = dgvCuotasGeneradas.Rows[i].Cells["Column7"] as DataGridViewCheckBoxCell;
                        //if (Convert.ToBoolean(ckAnt.Value) == false)
                        if (Convert.ToBoolean(chkPago.Value) == false)
                        {
                            dgvCuotasGeneradas.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        }
                        else
                        {
                            dgvCuotasGeneradas.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 192, 0);
                        }

                        i++;
                    }
                }
                else
                {
                    dgvCuotasGeneradas.Rows.Add(item.IDCuotaXSocio, item.MesCuota + "/" + item.AñoCuota, item.MontoTotal, "", false, "-", "-");

                    DataGridViewCheckBoxCell chkPago = dgvCuotasGeneradas.Rows[i].Cells["Column7"] as DataGridViewCheckBoxCell;
                    //if (Convert.ToBoolean(ckAnt.Value) == false)
                    if (Convert.ToBoolean(chkPago.Value) == false)
                    {
                        dgvCuotasGeneradas.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgvCuotasGeneradas.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(0, 192, 0);
                    }

                    i++;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDNIBusq.Text != "" | txtNomYApeBusq.Text != "")
            {
                if (txtDNIBusq.Text != "")
                {
                    dgvSociosActivos.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<Socio> lstSxDNI = clsSocios.ListarXDNI(Convert.ToInt32(txtDNIBusq.Text));

                    foreach (var itemS in lstSxDNI)
                    {
                        this.dgvSociosActivos.Rows.Add(itemS.IDSocio, itemS.Nombre + " " + itemS.Apellido, itemS.DNI);
                    }
                }
                else if (txtNomYApeBusq.Text != "")
                {
                    dgvSociosActivos.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<vSociosActivos> lstVSocActXNomYApe = clsSocios.ListarSocActXNomYApe(txtNomYApeBusq.Text);

                    foreach (var itemV in lstVSocActXNomYApe)
                    {
                        List<Socio> lstSxID = clsSocios.ListarXID(itemV.IDSocio);

                        foreach (var itemS in lstSxID)
                        {
                            this.dgvSociosActivos.Rows.Add(itemS.IDSocio, itemS.Nombre + " " + itemS.Apellido, itemS.DNI);
                        }
                    }
                }
                else
                {
                    dgvSociosActivos.Rows.Clear();

                    clsSocios clsSocios = new clsSocios();
                    List<Socio> lstSxDNI = clsSocios.ListarXDNI(Convert.ToInt32(txtDNIBusq.Text));

                    foreach (var itemS in lstSxDNI)
                    {
                        this.dgvSociosActivos.Rows.Add(itemS.IDSocio, itemS.Nombre + " " + itemS.Apellido, itemS.DNI);
                    }
                }
            }
        }

        private void frmGenerarCuotas_Load(object sender, EventArgs e)
        {
            dgvSociosActivos.Rows.Clear();

            clsSocios clsSocios = new clsSocios();
            List<Socio> lstSxID = clsSocios.ListarXID(IDSocio);

            foreach (var itemS in lstSxID)
            {
                this.dgvSociosActivos.Rows.Add(itemS.IDSocio, itemS.Nombre + " " + itemS.Apellido, itemS.DNI);
            }

            btnConsultarCuotas.PerformClick();

            frmSocio frmSoc = new frmSocio();
            frmSoc.Opacity = 70;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //string val = dgvCuotasGeneradas.CurrentRow.DefaultCellStyle.ForeColor = Color.FromArgb(0,192,0);
            if (dgvCuotasGeneradas.CurrentRow.Cells["Column10"].Value.ToString() != "0")
            {
                if (txtMonto.Text != "")
                {
                    for (int i = 0; i < dgvCuotasGeneradas.Rows.Count; i++)
                    {
                        clsCuotaXSocio objCuotaXSocio = new clsCuotaXSocio();
                        clsPago objPago = new clsPago();
                        List<CuotaXSocio> lstCuotaXSoc = objCuotaXSocio.ListarXIDCuotaXSoc(Convert.ToInt64(dgvCuotasGeneradas.Rows[i].Cells["Column9"].Value));
                        CuotaXSocio cuotaXSocio = new CuotaXSocio();
                        Pago pago = new Pago();

                        var chk = Convert.ToBoolean(dgvCuotasGeneradas.Rows[i].Cells["Column7"].Value);
                        string fecha = (string)dgvCuotasGeneradas.Rows[i].Cells["Column6"].Value;
                        int Monto = Convert.ToInt32(dgvCuotasGeneradas.Rows[i].Cells["Column5"].Value);

                        if ((chk == true && fecha == "") || (chk == true && fecha == "-"))
                        {
                            foreach (var itemCXSoc in lstCuotaXSoc)
                            {
                                List<Pago> lstP = objPago.ListarXIDCxS(itemCXSoc.IDCuotaXSocio);

                                if (lstP.Count != 0)
                                {
                                    foreach (var itemP in lstP)
                                    {
                                        cuotaXSocio.IDCuotaXSocio = itemCXSoc.IDCuotaXSocio;
                                        cuotaXSocio.IDSocio = itemCXSoc.IDSocio;
                                        cuotaXSocio.MontoTotal = itemCXSoc.MontoTotal;

                                        if (itemCXSoc.MontoPendiente != 0)
                                        {
                                            cuotaXSocio.MontoPendiente = itemCXSoc.MontoPendiente - Convert.ToInt32(txtMonto.Text);
                                            pago.Monto = itemP.Monto + Convert.ToInt32(txtMonto.Text);
                                        }
                                        else
                                        {
                                            cuotaXSocio.MontoPendiente = itemCXSoc.MontoTotal - Convert.ToInt32(txtMonto.Text);
                                        }

                                        if (itemCXSoc.MontoPendiente == 0) cuotaXSocio.Cancelado = 1;

                                        pago.IDCuotaXSocio = itemCXSoc.IDCuotaXSocio;
                                        pago.Monto = Convert.ToInt32(txtMonto.Text);
                                        if (itemCXSoc.MontoTotal == Convert.ToInt32(txtMonto.Text))
                                            pago.FechaEmisionComprob = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                                        objCuotaXSocio.Pago(cuotaXSocio);
                                        objPago.ActPago(pago);

                                        //Imprimir recibo (reporte)
                                        #region Reporte Recibo
                                        Reportes.Recibo rpt = new Reportes.Recibo();
                                        string nombre = dgvSociosActivos.CurrentRow.Cells["Socio"].Value.ToString();
                                        DateTime fechaRecibo = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                        string periodo = "Al día " + fechaRecibo.Day.ToString() + " del mes de " + NombreMes(fechaRecibo.Month) + " del año " + fechaRecibo.Year;
                                        string monto = txtMonto.Text;
                                        Random random = new Random();
                                        string numRandom = "000" + random.Next(01, 99).ToString();
                                        string Detalle = "Pago de cuota";

                                        clsConversion Conversion = new clsConversion();
                                        string numeroEscrito = Conversion.enletras(monto.ToString()) + " pesos.";

                                        rpt.SetParameterValue("NumeroEscrito", numeroEscrito);
                                        rpt.SetParameterValue("Observacion", Detalle);
                                        rpt.SetParameterValue("Socio", nombre);
                                        rpt.SetParameterValue("Periodo", periodo);
                                        rpt.SetParameterValue("Monto", monto);
                                        rpt.SetParameterValue("numeroRecibo", numRandom);

                                        frmVisorReporte frm = new frmVisorReporte();
                                        frm.Visor.ReportSource = rpt;
                                        frm.Visor.Refresh();
                                        frm.Show();
                                        #endregion
                                    }
                                }
                                else
                                {
                                    cuotaXSocio.IDCuotaXSocio = itemCXSoc.IDCuotaXSocio;
                                    cuotaXSocio.IDSocio = itemCXSoc.IDSocio;
                                    cuotaXSocio.MontoTotal = itemCXSoc.MontoTotal;

                                    //if (itemCXSoc.MontoPendiente != 0)
                                    //{
                                    //    cuotaXSocio.MontoPendiente = itemCXSoc.MontoPendiente - Convert.ToInt32(txtMonto.Text);
                                    //    pago.Monto = itemP.Monto + Convert.ToInt32(txtMonto.Text);
                                    //}
                                    //else
                                    //{
                                    cuotaXSocio.MontoPendiente = itemCXSoc.MontoTotal - Convert.ToInt32(txtMonto.Text);
                                    //}
                                    cuotaXSocio.Cancelado = 1;

                                    pago.IDCuotaXSocio = itemCXSoc.IDCuotaXSocio;
                                    pago.Monto = Convert.ToInt32(txtMonto.Text);
                                    if (itemCXSoc.MontoTotal == Convert.ToInt32(txtMonto.Text))
                                        pago.FechaEmisionComprob = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                                    objCuotaXSocio.Pago(cuotaXSocio);
                                    objPago.Pago(pago);

                                    //Imprimir recibo (reporte)
                                    #region Reporte Recibo
                                    //Reportes.Recibo rpt = new Reportes.Recibo();
                                    Reportes.Recibo rpt = new Reportes.Recibo();
                                    string nombre = dgvSociosActivos.CurrentRow.Cells["Column2"].Value.ToString();
                                    DateTime fechaRecibo = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                                    string periodo = "Al día " + fechaRecibo.Day.ToString() + " del mes de " + NombreMes(fechaRecibo.Month) + " del año " + fechaRecibo.Year;
                                    string monto = txtMonto.Text;
                                    Random random = new Random();
                                    string numRandom = "000" + random.Next(01, 99).ToString();
                                    string Detalle = "Pago de cuota";

                                    clsConversion Conversion = new clsConversion();
                                    string numeroEscrito = Conversion.enletras(monto.ToString()) + " pesos.";

                                    rpt.SetParameterValue("NumeroEscrito", numeroEscrito);
                                    rpt.SetParameterValue("Observacion", Detalle);
                                    rpt.SetParameterValue("Socio", nombre);
                                    rpt.SetParameterValue("Periodo", periodo);
                                    rpt.SetParameterValue("Monto", monto);
                                    rpt.SetParameterValue("numeroRecibo", numRandom);

                                    frmVisorReporte frm = new frmVisorReporte();
                                    frm.Visor.ReportSource = rpt;
                                    frm.Visor.Refresh();
                                    frm.Show();
                                    #endregion
                                }
                            }
                        }

                        if (chk == false && fecha != "")
                        {
                            foreach (var itemCXSoc in lstCuotaXSoc)
                            {
                                cuotaXSocio.IDCuotaXSocio = itemCXSoc.IDCuotaXSocio;
                                cuotaXSocio.IDSocio = itemCXSoc.IDSocio;

                                objCuotaXSocio.Anular(cuotaXSocio);
                            }
                        }
                    }

                    btnConsultarCuotas.PerformClick();
                }
                else
                {
                    MessageBox.Show("DEBE INGRESAR UN MONTO", "ALERTA");
                }
            }
            else 
            {
                MessageBox.Show("ESA CUOTA YA FUE CANCELADA","ALERTA");
            }
        }

        private void dgvCuotasGeneradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaAnterior = null;

            if (e.RowIndex > -1)
            {
                var fila = dgvCuotasGeneradas.Rows[e.RowIndex];

                if (fila.Index != 0)
                {
                    filaAnterior = dgvCuotasGeneradas.Rows[e.RowIndex - 1];

                    var chkPagoAnt = Convert.ToBoolean(filaAnterior.Cells[4].Value);
                    //var chkPagoAnt = (bool)filaAnterior.Cells["Column7"].Value;

                    var chkPagoAct = Convert.ToBoolean(fila.Cells[4].Value);

                    if (chkPagoAnt == true)
                    {
                        chkPagoAct = true;
                    }
                    else
                    {
                        chkPagoAct = false;
                    }
                }
            }
        }

        public string NombreMes(int mes)
        {
            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
            return dtinfo.GetMonthName(mes);
        }

        private void btnResumenDeCuentas_Click(object sender, EventArgs e)
        {
            string filtro = "";
            Reportes.ResumenDeCuenta rpt = new Reportes.ResumenDeCuenta();
            if (IDSocio != 0)
            {
                filtro = "{vResumen.ID} = " + IDSocio;
            }

            rpt.RecordSelectionFormula = filtro;
            if (txtFechaResumen.Enabled)
            {
                DateTime fecha = Convert.ToDateTime(txtFechaResumen.Text);
                string FechaFinal = "date(" + (fecha.Year + "," + fecha.Month + "," + fecha.Day) + ")".ToString();
                rpt.DataDefinition.FormulaFields["Fecha"].Text = FechaFinal;
            }

            frmVisorReporte frm = new frmVisorReporte();
            frm.Visor.ReportSource = rpt;
            frm.Visor.Refresh();

            frm.Show();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechaResumen.Checked)
            {
                txtFechaResumen.Enabled = true;
            }
            else
            {
                txtFechaResumen.Enabled = false;
            }
        }
    }
}
