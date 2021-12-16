﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentationLayer
{
    public partial class altaAlumno : Form
    {
        int progreso = 1;

        public altaAlumno()
        {
            int distanciaLabel = 70;
            int distanciaTextBox = 66;

            InitializeComponent();

            Evelyn.informacionMedicaGroupBox(informacionMedicaAlumnoGroupBox);
            Claudia.altasGroupBox(informacionGeneralAlumnoGroupBox);
            Claudia.altasGroupBox2(informacionEscolarGroupBox);
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);

            informacionMedicaAlumnoGroupBox.Visible = false;
            regresarButton.Visible = false;
            informacionTutorGroupBox.Visible = false;
            realizarAltaButton.Visible = false;

            distanciaLabel = Claudia.altasNombre(nombreAlumnoLabel, apellidoPaternoAlumnoLabel, apellidoMaternoAlumnoLabel, nombreAlumnoTextBox, apellidoPaternoAlumnoTextBox, apellidoMaternoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(fechaNacimientoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasDateTimePicker(fechaNacimientoDateTimePicker, distanciaTextBox);

            //Lugar nacimiento Alumno
            distanciaLabel = Claudia.altasLugarNacimiento(lugarNacimientoLabel, ciudadNacimientoAlumnoLabel, estadoNacimientoAlumnoLabel, ciudadNacimientoAlumnoTextBox, estadoNacimientoAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            //Direccion Alumno
            distanciaLabel = Claudia.altasDireccion(direccionAlumnoLabel, calleDireccionAlumnoLabel, numeroDireccionAlumnoLabel, coloniaDireccionAlumnoLabel, calleDireccionAlumnoTextBox, numeroDireccionAlumnoTextBox, coloniaDireccionAlumnoTextBox, distanciaLabel);
            distanciaTextBox = distanciaTextBox + 40;

            distanciaLabel = Claudia.altasLabel(telefonoAlumnoLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(telefonoAlumnoTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(escuelaProcedenciaLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(escuelaProcedenciaTextBox, distanciaTextBox);

            distanciaLabel = Claudia.altasLabel(canalizadoPorLabel, distanciaLabel);
            distanciaTextBox = Claudia.altasTextBox(canalizadoPorTextBox, distanciaTextBox);


            Evelyn.altasInformacionMedicaAlumno(servicioMedicoAlumnoLabel, discapacidadLabel, enfermedaresAlumnoLabel, alergiasAlumnoLabel,
                    telefonoContactoMedicoAlumnoLabel, grupoSanguineoAlumnoLabel, documentacionAlumnoLabel, mostrarDiscapacidadLabel,
                    mostrarEnfermedadesLabel, mostrarAlergiasLabel, servicioMedicoTextBox, discapacidadesCombobox, enfermedadesCombobox, alergiasCombobox, telefonoContactoMedicoAlumnoTextBox, grupoSanguineoTextBox, documentacionGB, mostrarDiscapacidadRichTextBox,
                    mostrarEnfermedadesRichTextBox, mostrarAlergiasRichTextBox, agregarAlergiasButton, agregarEnfermedadesButton, agregarDiscapacidadButton);

            Claudia.altasInformacionEscolar(cicloEscolarLabel, curpLabel, añosCumplidosLabel, cicloEscolarTextBox, curpTextBox, añosCumplidosTextBox, tipoIngresoGroupBox, nuevoIngresoRadioButton, reingresoRadioButton);
            
            Evelyn.altasBotonesParaNavegar(siguienteButton, regresarButton, realizarAltaButton);
            Evelyn.altasBotonesPanel(alumnosButton,docentesButton);

            int distanciaInfTutor = 60;
            Claudia.altasInformacionTutorGroupBox(informacionTutorGroupBox);
            distanciaInfTutor = Claudia.altasTutorOtroAlumno(otroAlumnoTutorGroupBox, seleccionarNombreLabel, seleccionarNombreComboBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasNombreTutor(nombreTutorLabel, nombreTutorTextBox, apellidoPaternoTutorLabel, apellidoPaternoTutorTextBox, apellidoMaternoTutorLabel, apellidoMaternoTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasDireccionTutor(domicilioTutorLabel, calleDireccionTutorLabel, calleDireccionTutorTextBox, numeroDireccionTutorLabel, numeroDireccionTutorTextBox, coloniaDireccionTutorLabel, coloniaDireccionTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasOcupacionTutor(ocupacionTutorLabel, ocupacionTutorTextBox, distanciaInfTutor);
            distanciaInfTutor = Claudia.altasTelefonosTutor(telefonosTutorLabel, telefonoCasaTutorLabel, telefonoCasaTutorTextBox, telefonoCelularTutorLabel, telefonoCelularTutorTextBox, telefonoTrabajoTutorLabel, telefonoTrabajoTutorTextBox, distanciaInfTutor);


            Evelyn.eliminarBotones(eliminarEnfermedadButton, eliminarDiscapacidadesButton, eliminarAlergiasButton);
            Claudia.limpiarFormatosBotones(limpiarFormato1Button,limpiarFormato2Button,limpiarFormato3Button);
        }


        private void siguienteButton_Click_1(object sender, EventArgs e)
        {
            if (progreso == 0)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 1;
            }
            if (progreso == 1)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 2;
            }
            if (progreso == 2)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                regresarButton.Visible = true;
                siguienteButton.Visible = true;
                realizarAltaButton.Visible = false;
                progreso = 3;
            }else{
                informacionMedicaAlumnoGroupBox.Visible = true;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = true;
                siguienteButton.Visible = false;
                realizarAltaButton.Visible = true;
                progreso = 4;
            }

        }

        private void regresarButton_Click(object sender, EventArgs e)
        {
            if (progreso == 3)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = true;
                informacionEscolarGroupBox.Visible = true;
                informacionTutorGroupBox.Visible = false;
                regresarButton.Visible = false;
                realizarAltaButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 2;
            }

            if (progreso == 4)
            {
                informacionMedicaAlumnoGroupBox.Visible = false;
                informacionGeneralAlumnoGroupBox.Visible = false;
                informacionEscolarGroupBox.Visible = false;
                informacionTutorGroupBox.Visible = true;
                realizarAltaButton.Visible = false;
                siguienteButton.Visible = true;
                progreso = 3;
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (!nombreAlumnoTextBox.Text.Equals("") && !apellidoPaternoAlumnoTextBox.Text.Equals("") && !apellidoMaternoAlumnoTextBox.Text.Equals(""))
            {
                MessageBox.Show("REGISTRO EXITOSO!");
                businessLayer.Hueso.SetAlumno(cicloEscolarTextBox.Text,
                                              nombreAlumnoTextBox.Text,
                                              apellidoPaternoAlumnoTextBox.Text,
                                              apellidoMaternoAlumnoTextBox.Text,
                                              fechaNacimientoDateTimePicker.Value,
                                              añosCumplidosTextBox.Text,
                                              curpTextBox.Text,
                                              estadoNacimientoAlumnoTextBox.Text,
                                              ciudadNacimientoAlumnoTextBox.Text,
                                              coloniaDireccionAlumnoTextBox.Text,
                                              calleDireccionAlumnoTextBox.Text,
                                              numeroDireccionAlumnoTextBox.Text,
                                              telefonoAlumnoTextBox.Text,
                                              escuelaProcedenciaTextBox.Text,
                                              canalizadoPorTextBox.Text
                                              );
            }
            else
            {
                MessageBox.Show("NO PUEDES CREAR UN REGISTRO SIN NOMBRE COMPLETO DEL ALUMNO!");
            }
        }

        private void alumnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas formConsulta = new Consultas();
            formConsulta.Show();
        }

        //AGREGAR ENFERMEDADES AL RICHTXTBOX
        private void agregarEnfermedadesButton_Click(object sender, EventArgs e)
        {
      
         
        }

        //AGREGAR DISCAPACIDADES AL RICHTXTBOX
        private void agregarDiscapacidadButton_Click(object sender, EventArgs e)
        {

         
        }

        //AGREGAR ALERGIAS AL RICHTXTBOX
        private void agregarAlergiasButton_Click(object sender, EventArgs e)
        {
         
         
        }

        //LIMPIAR INFORMACIÓN GENERAL ALUMNO
        private void limpiarFormato1Button_Click(object sender, EventArgs e)
        {
            nombreAlumnoTextBox.Clear();
            apellidoPaternoAlumnoTextBox.Clear();
            apellidoMaternoAlumnoTextBox.Clear();
            fechaNacimientoDateTimePicker.ResetText();
            ciudadNacimientoAlumnoTextBox.Clear();
            estadoNacimientoAlumnoTextBox.Clear();
            calleDireccionAlumnoTextBox.Clear();
            numeroDireccionAlumnoTextBox.Clear();
            coloniaDireccionAlumnoTextBox.Clear();
            telefonoAlumnoTextBox.Clear();
            escuelaProcedenciaTextBox.Clear();
            canalizadoPorTextBox.Clear();
            cicloEscolarTextBox.Clear();
            curpTextBox.Clear();
            añosCumplidosTextBox.Clear();
            nuevoIngresoRadioButton.Checked = false;
            reingresoRadioButton.Checked = false;

        }

        //LIMPIAR INFORMACIÓN TUTORA/RA
        private void limpiarFormato2Button_Click(object sender, EventArgs e)
        {
            siOtroAlumnoMadreRadioButton.Checked = false;
            noOtroAlumnoMadreRadioButton.Checked = false;
            seleccionarNombreComboBox.ResetText();
            nombreTutorTextBox.Clear();
            apellidoPaternoTutorTextBox.Clear();
            apellidoMaternoTutorTextBox.Clear();
            calleDireccionTutorTextBox.Clear();
            numeroDireccionTutorTextBox.Clear();
            coloniaDireccionTutorTextBox.Clear();
            ocupacionTutorTextBox.Clear();
            telefonoCasaTutorTextBox.Clear();
            telefonoCelularTutorTextBox.Clear();
            telefonoTrabajoTutorTextBox.Clear();
        }

        //LIMPIAR INFORMACIÓN MEDICA ALUMNO
        private void limpiarFormato3Button_Click(object sender, EventArgs e)
        {
            servicioMedicoTextBox.Clear();
        
            telefonoContactoMedicoAlumnoTextBox.Clear();
            grupoSanguineoTextBox.Clear();
            //documentacionListBox.SetItemChecked = false; *CLAUDIA CAMBIARÁ ESTO POR UN CONJUNTO DE CHECKBUTTONS*
        }

        //LIMPIAR DISCAPACIDADES
        private void eliminarDiscapacidadesButton_Click(object sender, EventArgs e)
        {
            mostrarDiscapacidadRichTextBox.Clear();
        }

        //LIMPIAR ENFERMEDADES
        private void eliminarEnfermedadButton_Click(object sender, EventArgs e)
        {
            mostrarEnfermedadesRichTextBox.Clear();
        }

        //LIMPIAR ALERGIAS
        private void eliminarAlergiasButton_Click(object sender, EventArgs e)
        {
            mostrarAlergiasRichTextBox.Clear();
        }

        private void altaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
