using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection;
using System.IO;



namespace Proyecto_estacionamiento
{
    public partial class Fr_Reportes : Form
    {
        public Fr_Reportes()
        {
            InitializeComponent();
        }

        private void volverAtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Menu_administracion menu = new Fr_Menu_administracion();
            this.Hide();
            menu.Show();
        }

        private void Fr_Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetReporte_Arriendo.V_ARRIENDO' Puede moverla o quitarla según sea necesario.
            this.v_ARRIENDOTableAdapter.Fill(this.dataSetReporte_Arriendo.V_ARRIENDO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetReporte_estacionamiento.V_ESTACIONAMIENTO' Puede moverla o quitarla según sea necesario.
            this.v_ESTACIONAMIENTOTableAdapter.Fill(this.dataSetReporte_estacionamiento.V_ESTACIONAMIENTO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetReporte_tipo_cliente.V_TIPO_CLIENTE' Puede moverla o quitarla según sea necesario.
            this.v_TIPO_CLIENTETableAdapter.Fill(this.dataSetReporte_tipo_cliente.V_TIPO_CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'dataSetReporte_Cliente.V_CLIENTE' Puede moverla o quitarla según sea necesario.
            this.v_CLIENTETableAdapter.Fill(this.dataSetReporte_Cliente.V_CLIENTE);

        }

        private void btn_excel_cliente_Click(object sender, EventArgs e)
        {
            // SaveFileDialog fichero = new SaveFileDialog();
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }


            // storing Each row and column value to Excel sheet
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }


            // save the application
            //workbook.SaveAs("c:\\Clientes_Estacionamiento.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

           // workbook.SaveAs(fichero.FileName,
           // Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
         
            workbook.Close(true);

            // Exit from the application
            app.Quit();
        }

        private void btn_pdf_cliente_Click(object sender, EventArgs e)
        {
             //Creating iTextSharp Table from the DataTable data
                 PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
                 pdfTable.DefaultCell.Padding = 6;
                 pdfTable.WidthPercentage = 60;
                 pdfTable.HorizontalAlignment = Element.ALIGN_BASELINE;
                 pdfTable.DefaultCell.BorderWidth = 2;
 
                //Adding Header row
                 foreach (DataGridViewColumn column in dataGridView2.Columns)
                 {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                 }
 
                   //Adding DataRow
                 foreach (DataGridViewRow row in dataGridView2.Rows)
                      {
                           foreach (DataGridViewCell cell in row.Cells)
                             {
                                  if(cell.Value!=null){
                                      pdfTable.AddCell(cell.Value.ToString());
                                  
                                      } 
                                }
                      }
 
                        //Exporting to PDF
                        string folderPath = "C:\\PDFs\\";
                        if (!Directory.Exists(folderPath))
                         {
                              Directory.CreateDirectory(folderPath);
                         }
                            using (FileStream stream = new FileStream(folderPath + "Datos_cliente.pdf", FileMode.Create))
                        {
                              Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                              PdfWriter.GetInstance(pdfDoc, stream);
                              pdfDoc.Open();
                              pdfDoc.Add(pdfTable);
                              pdfDoc.Close();
                              stream.Close();

                              MessageBox.Show("Se guardo PDF", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);               
          }

     }
        

        private void btn_actualizar_cliente_Click(object sender, EventArgs e)
        {
            this.v_CLIENTETableAdapter.Fill(this.dataSetReporte_Cliente.V_CLIENTE);
        }

        private void btn_excel_tipo_Click(object sender, EventArgs e)
        {
            // SaveFileDialog fichero = new SaveFileDialog();
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView4.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView4.Columns[i - 1].HeaderText;
            }


            // storing Each row and column value to Excel sheet
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value.ToString();
                }
            }


            // save the application
            //workbook.SaveAs("c:\\Clientes_Estacionamiento.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // workbook.SaveAs(fichero.FileName,
            // Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);

            workbook.Close(true);

            // Exit from the application
            app.Quit();
        }

        private void btn_pdf_tipo_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView4.ColumnCount);
            pdfTable.DefaultCell.Padding = 6;
            pdfTable.WidthPercentage = 60;
            pdfTable.HorizontalAlignment = Element.ALIGN_BASELINE;
            pdfTable.DefaultCell.BorderWidth = 2;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView4.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());

                    }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Datos_Tipo_cliente.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                MessageBox.Show("Se guardo PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        private void btn_Actualizar_tipo_Click(object sender, EventArgs e)
        {
            this.v_TIPO_CLIENTETableAdapter.Fill(this.dataSetReporte_tipo_cliente.V_TIPO_CLIENTE);
        }

        private void btn_actualizar_es_Click(object sender, EventArgs e)
        {
            this.v_ESTACIONAMIENTOTableAdapter.Fill(this.dataSetReporte_estacionamiento.V_ESTACIONAMIENTO);
        }

        private void btn_excel_esta_Click(object sender, EventArgs e)
        {
            // SaveFileDialog fichero = new SaveFileDialog();
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }


            // storing Each row and column value to Excel sheet
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }


            // save the application
            //workbook.SaveAs("c:\\Estacionamiento.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // workbook.SaveAs(fichero.FileName,
            // Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);

            workbook.Close(true);

            // Exit from the application
            app.Quit();
        }

        private void btn_pdf_esta_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 6;
            pdfTable.WidthPercentage = 60;
            pdfTable.HorizontalAlignment = Element.ALIGN_BASELINE;
            pdfTable.DefaultCell.BorderWidth = 2;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());

                    }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Datos_Estacionamiento.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                MessageBox.Show("Se guardo PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        private void btn_actualizar_arr_Click(object sender, EventArgs e)
        {
            this.v_ARRIENDOTableAdapter.Fill(this.dataSetReporte_Arriendo.V_ARRIENDO);
        }

        private void btn_excel_arr_Click(object sender, EventArgs e)
        {
            // SaveFileDialog fichero = new SaveFileDialog();
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView3.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView3.Columns[i - 1].HeaderText;
            }


            // storing Each row and column value to Excel sheet
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value.ToString();
                }
            }


            // save the application
            //workbook.SaveAs("c:\\arriendo.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // workbook.SaveAs(fichero.FileName,
            // Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);

            workbook.Close(true);

            // Exit from the application
            app.Quit();
        }

        private void btn_pdf_arr_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView3.ColumnCount);
            pdfTable.DefaultCell.Padding = 6;
            pdfTable.WidthPercentage = 60;
            pdfTable.HorizontalAlignment = Element.ALIGN_BASELINE;
            pdfTable.DefaultCell.BorderWidth = 2;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView3.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());

                    }
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Arriendo.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                MessageBox.Show("Se guardo PDF", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

       


        }
       
    }

