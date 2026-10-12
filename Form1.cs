using AlgoritmoDiCesare_sacchiero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmiCifratura_Sacchiero
{

    /*
     	
Algoritmi di cifratura: Cesare, Rot13 e Vigenère
Realizzare una o più applicazioni per implementare i cifrari richiesti. Utilizzare classi e metodi per riutilizzarli ove opportuno.
Specifiche del programma:
consentire all'utente di inserire una frase da cifrare o decifrare
una chiave K
mostrare il testo cifrato o decifrato


    per il cifrario di Cesare, la chiave K è un numero intero che indica di quante posizioni spostare le lettere dell'alfabeto (ad esempio, con K=3, A diventa D, B diventa E, ecc.)

    per il cifrario di Rot13, la chiave K è fissa e corrisponde a uno spostamento di 13 posizioni (ad esempio, A diventa N, B diventa O, ecc.)

    per il cifrario di Vigenère, la chiave K è una parola o una frase che viene ripetuta per tutta la lunghezza del testo da cifrare o decifrare. Ogni lettera della chiave indica di quante posizioni spostare la lettera corrispondente del testo (ad esempio, se la chiave è "KEY", la prima lettera del testo viene spostata di K posizioni, la seconda di E posizioni, e così via).
     */
    public partial class Form1 : Form
    {

        private int scelta = 0; // 0 = Cesare, 1 = Rot13, 2 = Vigenère

        public Form1()
        {
            InitializeComponent();

            Form1_Load();
        }

        private void Form1_Load()
        {
            // Aggiungi le opzioni al ComboBox
            cmb_scelta.Items.Add("Cesare");
            cmb_scelta.Items.Add("Rot13");
            cmb_scelta.Items.Add("Vigenère");

            // di base seleziona la prima opzione
            cmb_scelta.SelectedIndex = 0;
            scelta = 0;

            // permette di vedere il numero di spostamento
            flp_shiftIn.Visible = true;

            // non permette di vedere la chiave di Vigenère
            flp_keyIn.Visible = false;

            // non permette di scrivere nella casella di output
            txt_output.ReadOnly = true;

            // non permette di scrivere nel combo box
            cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void lbl_numero_Click(object sender, EventArgs e)
        {

        }

        private void nmr_numero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cripta_Click(object sender, EventArgs e)
        {
            if (scelta == 0)
            {
                txt_output.Text = CifCesare.Cifra(txt_input.Text.ToUpper().Trim(), (int)nmr_numero.Value);
            }
            else if (scelta == 1)
            {
                txt_output.Text = CifRot13.Cifra(txt_input.Text.ToUpper().Trim());
            }
            else if (scelta == 2)
            {
                txt_output.Text = CifVigenere.Cifra(txt_input.Text.ToUpper().Trim(), txt_chiave.Text.ToUpper().Trim());
            }
        }

        private void btn_decripta_Click(object sender, EventArgs e)
        {
            if (scelta == 0)
            {
                txt_output.Text = CifCesare.Decifra(txt_input.Text.ToUpper().Trim(), (int)nmr_numero.Value);
            }
            else if (scelta == 1)
            {
                txt_output.Text = CifRot13.Decifra(txt_input.Text.ToUpper().Trim());
            }
            else if (scelta == 2)
            {
                txt_output.Text = CifVigenere.Decifra(txt_input.Text.ToUpper().Trim(), txt_chiave.Text.ToUpper().Trim());
            }
        }

        private void txt_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_scelta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_scelta.SelectedItem.ToString() == "Cesare")
            {
                flp_shiftIn.Visible = true;
                flp_keyIn.Visible = false;
                scelta = 0;
            }
            else if (cmb_scelta.SelectedItem.ToString() == "Vigenère")
            {
                flp_shiftIn.Visible = false;
                flp_keyIn.Visible = true;
                scelta = 2;
            }
            else if (cmb_scelta.SelectedItem.ToString() == "Rot13")
            {
                flp_shiftIn.Visible = false;
                flp_keyIn.Visible = false;
                scelta = 1;
            }
        }
    }
}
