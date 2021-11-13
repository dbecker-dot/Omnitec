﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DocumentFormat.OpenXml;
using SpreadsheetLight;
using CapaEntidades;
using System.Data;
using QRCoder;

namespace CapaDatos.Services
{
    public class FileServices
    {
        public void ExportarExcel(DataTable grilla)
        {
            try
            {
                SaveFileDialog guardarexcel = new SaveFileDialog();
                guardarexcel.Filter = "Libro de Excel|*.xlsx";
                guardarexcel.Title = "Ubicacion del Archivo";
                if (guardarexcel.ShowDialog() == DialogResult.OK)
                {
                    if (guardarexcel.FileName != "")
                    {
                        E_Deposito.RutaExportacionExcel = guardarexcel.FileName;
                        E_Deposito.ErrorFile = false;
                    } else
                    {
                        E_Deposito.ErrorFile=true;
                    }
                }
                if (E_Deposito.ErrorFile == false)
                {
                    SLDocument sl = new SLDocument();
                    sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Ubicaciones " + E_Deposito.Deposito);
                    sl.ImportDataTable(1, 1, grilla, true);
                    sl.SaveAs(E_Deposito.RutaExportacionExcel);
                }
            }
            catch (Exception)
            {


            }
        }

        public Bitmap imagenQR (string codigo, int tamimg)
        {
            try
            {
                if (codigo != null) { 
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData datqr = qr.CreateQrCode(codigo, QRCodeGenerator.ECCLevel.H);
                QRCode qrg = new QRCode(datqr);
                Bitmap imgqr = qrg.GetGraphic(tamimg, Color.Black, Color.White, true);
                return imgqr;
            } else
            {
                return null;
            }
            }
            catch (Exception)
            {

                return null;
            }
            
        }

    }
}
