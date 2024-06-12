﻿using System.Drawing;
using System.Windows.Forms;


namespace presentationLayer
{
    public class PLConsultaAlumno
    {

        public static void tituloAlumnos(Label titulo, PictureBox logo, DataGridView altaDataGridView)
        {
            //tamaño pantalla
            logo.Location = new Point(50, 20);
            logo.Size = new Size(150, 148);
            //TITULO PRINCIPAL
            titulo.Location = new Point(620, 50);
            altaDataGridView.Location = new Point(240, 230);
            altaDataGridView.Size = new Size(1070, 410);

        }

        public static void consultaBusquedaAlumnos(Panel panelB, TextBox txBusqueda, Button buscar)
        {
            panelB.Location = new Point(540, 120);
            panelB.Size = new Size(400, 50);
            buscar.Size = new Size(30, 30);
            txBusqueda.Size = new Size(335, 45);
            txBusqueda.Font = new Font("Gadugi", 14);
        }

        public static void consultaBotonesParaNavegar(Button cerrarSesion, Button imprimir, Button fichaTecnica)
        {
            cerrarSesion.Location = new Point(230, 660);
            imprimir.Location = new Point(900, 660);
            fichaTecnica.Location = new Point(1120, 660);

            cerrarSesion.Size = new Size(180, 75);
            imprimir.Size = new Size(200, 75);
            fichaTecnica.Size = new Size(180, 75);
        }
        public static void consultaBotonesAlumnos(Button agregar, Button modificar, Button eliminar)
        {

            agregar.Location = new Point(1130, 168);
            modificar.Location = new Point(1190, 168);
            eliminar.Location = new Point(1250, 168);

            agregar.Size = new Size(50, 50);
            modificar.Size = new Size(50, 50);
            eliminar.Size = new Size(50, 50);
        }

        public static void consultaFiltroAlumnos(Label filtrarLB, ComboBox filtrarCB)
        {
            filtrarLB.Size = new Size(60, 30);
            filtrarLB.Location = new Point(235,190);

            filtrarCB.Size = new Size(130, 30);
            filtrarCB.Location = new Point(320, 190);
        }
    }
}
