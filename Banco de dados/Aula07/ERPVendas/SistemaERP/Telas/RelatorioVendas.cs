using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        private void RelatorioVendas_Load(object sender, EventArgs e)
        {

            var tabela = new VendasDataSet();

            new VendasDataSetTableAdapters.VendasTableAdapter().Fill(tabela.Vendas);

            reportViewer1 = new ReportViewer { Dock = DockStyle.Fill };

            var arquivoRelatorio = File.OpenRead(Path.GetFullPath(@"C:\\Users\\FIC\\Documents\\DEVBACKEND\\Banco de dados\\Aula07\\ERPVendas\\SistemaERP\\Relatorios\\Report1.rdlc"));

            reportViewer1.LocalReport.LoadReportDefinition(arquivoRelatorio);

            reportViewer1.LocalReport.DataSources
                .Add(new ReportDataSource("DataSet1", (System.Data.DataTable)tabela.Vendas));

            Controls.Clear();
            Controls.Add(reportViewer1);

            reportViewer1.RefreshReport();

        }

        private void RelatorioVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ERP janela = new ERP();
            janela.Show();
            
        }
    }
}
