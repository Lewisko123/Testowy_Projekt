using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows;

namespace Testowy_Projekt
{
    class ObslugaPlikow
    {
        private OleDbConnection conn;
        private OleDbDataAdapter adapterDanych;

        private DataSet zbiorDanych;
        public DataTable tabelaZeZbioru;

        public ObslugaPlikow()
        {
            //tabelaZeZbioru = WczytajDaneDoTabeli();
            //wypiszDane(daneZArkusza);
        }
        private void WczytajDaneDoTabeli()
        {
            zbiorDanych = new DataSet();
            DataTable daneZArkusza = new DataTable();
            zbiorDanych.Tables.Add(daneZArkusza);
            string oledbstring = "Provider=Microsoft.ACE.OLEDB.12.0;" +
             @"Data Source=" + "sierpien.xls" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\";";
            conn = new OleDbConnection(oledbstring);
            conn.Open();
            adapterDanych = new OleDbDataAdapter($"SELECT * FROM [Sheet1$]", conn);
            //OleDbCommand cmd = new OleDbCommand("SELECT C,G,J,K FROM [Sheet1$]");
            adapterDanych.Fill(zbiorDanych);
            daneZArkusza = zbiorDanych.Tables[0];
            //polaczenieDoArkusza.Close();
            new ObrobkaDanych(daneZArkusza);
        }

        
        /*
         public void wypiszDane(DataTable dane)
         {
             int i = 1;
             foreach(DataRow dr in dane.Rows)
             {

                 Console.WriteLine(i + " " + dr.ToString());i++;
             }

         }
        */
    }
}
