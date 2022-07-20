using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartDrug.forms
{
    public partial class frmCupomReemprimirVenda : Form
    {
        frmReemprimirVenda instancia;

        string Nota, formaPagamento, dataCompra;

        public frmCupomReemprimirVenda(frmReemprimirVenda cupom)
        {
            InitializeComponent();
            instancia = cupom;

            Nota = instancia.dataGridViewReemprimirVendas.CurrentRow.Cells[0].Value.ToString();
            formaPagamento = instancia.dataGridViewReemprimirVendas.CurrentRow.Cells[5].Value.ToString();
            dataCompra = instancia.dataGridViewReemprimirVendas.CurrentRow.Cells[3].Value.ToString();


            this.relacaoVendasTableAdapter.queryReceber(this.drogariaParanaDataSet.RelacaoVendas, Nota);
            this.relacaoContasTableAdapter.queryNota(this.drogariaParanaDataSet.RelacaoContas, Nota);
            this.relacaoNotasTableAdapter.queryNotaVenda(this.drogariaParanaDataSet.RelacaoNotas, Nota);
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataCompra", dataCompra));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("title", "C U P O M  D E  V E N D A"));
            this.reportViewer1.RefreshReport();
        }

        #region our=tro metodo que deu certo, mas não é de construcao, ele pegar o reportViewer
        /*public class ImpressorRelatorio
        {
            private LocalReport report;
            private IList<Stream> listaStreams;
            private PrintDocument documento;
            private int paginaAtual;

            public static ImpressorRelatorio Novo(LocalReport report)
            {
                return new ImpressorRelatorio(report);
            }

            private ImpressorRelatorio(LocalReport report)
            {
                this.report = report;
                listaStreams = new List<Stream>();
            }

            public void Imprimir(PrintDocument documento)
            {
                this.documento = documento;
                ExportarParaImagem();
                Imprimir();
            }

            private void ExportarParaImagem()
            {
                string informacao =
                    @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";
                Warning[] warnings;
                report.Render("Image", informacao, CriarStream, out warnings);
                foreach (Stream stream in listaStreams)
                    stream.Position = 0;
            }

            private Stream CriarStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
            {
                var stream = new MemoryStream();
                listaStreams.Add(stream);
                return stream;
            }

            private void Imprimir()
            {
                if (listaStreams.Count == 0)
                    throw new Exception("Erro ao imprimir: nenhuma 'Stream' foi carregada para a impressão");
                if (!documento.PrinterSettings.IsValid)
                    throw new Exception(string.Format("Erro ao imprimir: não foi possivel encontrar a impressora '{0}'", documento.PrinterSettings.PrinterName));

                documento.PrintPage += Imprimindo;
                paginaAtual = 0;
                documento.Print();
            }

            private void Imprimindo(object sender, PrintPageEventArgs ev)
            {
                var imagemAtual = new Metafile(listaStreams[paginaAtual]);

                // Adjust rectangular area with printer margins.
                var retanguloAjustado = new Rectangle(
                    ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                    ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                    ev.PageBounds.Width,
                    ev.PageBounds.Height);

                // Draw a white background for the report
                ev.Graphics.FillRectangle(Brushes.White, retanguloAjustado);

                // Draw the report content
                ev.Graphics.DrawImage(imagemAtual, retanguloAjustado);

                // Prepare for the next page. Make sure we haven't hit the end.
                paginaAtual++;
                ev.HasMorePages = (paginaAtual < listaStreams.Count);
            }
        }
        

        private void ImrprimirCupom()
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                //Log.Info("Imprimindo relatório...");
                //var documento = new PrintDocument();
                //var impressor = ImpressorRelatorio.Novo(this.reportViewer1.LocalReport);
                //impressor.Imprimir(documento);
            }
        }*/
        #endregion

        #region Metodo Deconstrucao que deu certo, não necessita do report viewer
        /*private void imprimir()
        {
            PrintDocument printDoc = new PrintDocument();
            //printDoc.PrinterSettings.PrinterName = "Bematech 4200";
            printDoc.DocumentName = "Cupom";

            //if (!printDoc.PrinterSettings.IsValid)
                //throw new Exception("Não foi possível localizar a impressora");

            printDoc.PrintPage += new PrintPageEventHandler(PrintPageFicha);

            printDoc.Print();
        }

        private void PrintPageFicha(object sender, PrintPageEventArgs ev)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 17f, FontStyle.Bold);
            System.Drawing.Font pdvFont = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular);
            System.Drawing.Font obsFont = new System.Drawing.Font("Segoe UI", 7f, FontStyle.Regular);

            SizeF size = new SizeF();
            float currentUsedHeight = 0f;

            ev.Graphics.DrawString("PDV : " + "DINAIAS", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("PDV : " + "dinaias", pdvFont);
            currentUsedHeight += size.Height;

            ev.Graphics.DrawString("VENDA : Cartão", pdvFont, Brushes.Black, 15, currentUsedHeight, new StringFormat());
            size = ev.Graphics.MeasureString("VENDA", pdvFont);
            currentUsedHeight += size.Height;
        }*/
        #endregion

        #region Metodo Deconstrucao que deu certo, não necessita do report viewer - 2
        /*private void imprimir()
        {
            PrintDocument printDoc = new PrintDocument();
            //printDoc.PrinterSettings.PrinterName = "Bematech 4200";
            printDoc.DocumentName = "Cupom";

            //if (!printDoc.PrinterSettings.IsValid)
                //throw new Exception("Não foi possível localizar a impressora");

            printDoc.PrintPage += new PrintPageEventHandler(printPage);

            printDoc.Print();
        }
         
        private void printPage(object send, PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 17f, FontStyle.Bold);

            Graphics graphics = e.Graphics;
            int offset = 105;

            //print header
            graphics.DrawString("DROGARIA PARANA", titleFont, Brushes.Black, 20, 0);
            graphics.DrawString("CENTRO" + " Nº " + "1", titleFont, Brushes.Black, 100, 15);
            graphics.DrawLine(Pens.Black, 20, 30, 310, 30);
            graphics.DrawString("CUPOM NÃO FISCAL", titleFont, Brushes.Black, 80, 35);
            graphics.DrawLine(Pens.Black, 20, 50, 310, 50);
            graphics.DrawString("PEDIDO: " + "10000", titleFont, Brushes.Black, 20, 60);
            graphics.DrawLine(Pens.Black, 20, 75, 310, 75);

            //itens header
            graphics.DrawString("PRODUTO", titleFont, Brushes.Black, 20, 80);
            graphics.DrawString("UNIT.", titleFont, Brushes.Black, 150, 80);
            graphics.DrawString("QTD.", titleFont, Brushes.Black, 200, 80);
            graphics.DrawString("TOTAL", titleFont, Brushes.Black, 245, 80);
            graphics.DrawLine(Pens.Black, 20, 95, 310, 95);

            
            //itens de venda
            foreach (ItemVenda iv in venda.items)
            {
                string produto = iv.produto.descricao;
                graphics.DrawString(produto.Length > 20 ? produto.Substring(0, 20) + "..." : produto, regularItens, Brushes.Black, 20, offset);
                graphics.DrawString(FormataMonetario.format(iv.valorUn), regularItens, Brushes.Black, 155, offset);
                graphics.DrawString(Convert.ToString(iv.quantidade), regularItens, Brushes.Black, 215, offset);
                graphics.DrawString(FormataMonetario.format(iv.total), regularItens, Brushes.Black, 250, offset);
                offset += 20;
            }
            //total
            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            decimal total = 0;
            foreach (ItemVenda iv in venda.items)
            {
                total += iv.total;
            }
            graphics.DrawString("TOTAL R$: ", bold, Brushes.Black, 20, offset);
            graphics.DrawString(FormataMonetario.format(total), bold, Brushes.Black, 230, offset);
            offset += 15;

            graphics.DrawLine(Pens.Black, 20, offset, 310, offset);
            offset += 5;

            //bottom
            graphics.DrawString("Data: " + DateTime.Now.ToString("dd/MM/yyyy"), titleFont, Brushes.Black, 20, offset);
            graphics.DrawString("HORA: " + DateTime.Now.ToString("HH:mm:ss"), titleFont, Brushes.Black, 220, offset);

            e.HasMorePages = false;

        }*/
        #endregion


        private void frmCupomReemprimirVenda_Load(object sender, EventArgs e)
        {
            
        }          
    }
}
