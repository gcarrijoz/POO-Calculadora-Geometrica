using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadoraGeometrica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limparDados();
            GerarGrade();
            pbImagens.Image = Properties.Resources.Branco;
        }

        public bool ValidaInformacao()
        {
            bool valida = true;

            if (rbCirculo.Checked == true)
            {
                if (tbRaio.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbRaio.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbTrapezio.Checked == true)
            {
                if (tbBaseMaior.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbBaseMaior.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbBaseMenor.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbBaseMenor.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbAltura.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbAltura.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbRetangulo.Checked == true)
            {
                if (tbLado.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbLado.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbAltura.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbAltura.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbQuadrado.Checked == true)
            {
                if (tbLado.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbLado.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbTriangulo.Checked == true)
            {
                if (tbLado.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbLado.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbAltura.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbAltura.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbHexagono.Checked == true)
            {
                if (tbLado.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbLado.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbPentagono.Checked == true)
            {
                if (tbLado.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor do " + lbLado.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (rbLosango.Checked == true)
            {
                if (tbDiagonalMaior.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbDiagonalMaior.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbDiagonalMenor.Text.Trim() == String.Empty)
                {
                    valida = false;
                    MessageBox.Show("Insira o valor da " + lbDiagonalMenor.Text.Replace(":", ""),
                        "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return valida;

        }
        private void MensagemCadastroArea()
        {
            MessageBox.Show("Área cadastrada com sucesso!",
                "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensagemCadastroPerimetro()
        {
            MessageBox.Show("Perímetro cadastrado com sucesso!",
                "Calculadora Geometrica", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void GerarGrade()
        {
            lvArea.Columns.Add("Nome", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Altura", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Base Menor", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Base Maior", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Diagonal Menor", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Diagonal Maior", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Raio", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.Columns.Add("Área", 60).TextAlign = HorizontalAlignment.Center;
            lvArea.View = View.Details;

            lvPerimetro.Columns.Add("Nome", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Altura", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Base Menor", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Base Maior", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Diagonal Menor", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Diagonal Maior", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Raio", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.Columns.Add("Perímetro", 60).TextAlign = HorizontalAlignment.Center;
            lvPerimetro.View = View.Details;




        } // FIM DA GRADE
        private void limparDados()
        {
            tbAltura.Text = "";
            tbBaseMaior.Text = "";
            tbBaseMenor.Text = "";
            tbDiagonalMaior.Text = "";
            tbDiagonalMenor.Text = "";
            tbLado.Text = "";
            tbRaio.Text = "";




            tbRaio.Visible = false;
            lbRaio.Visible = false;
            lbBaseMaior.Visible = false;
            tbBaseMaior.Visible = false;
            lbBaseMenor.Visible = false;
            tbBaseMenor.Visible = false;
            lbAltura.Visible = false;
            tbAltura.Visible = false;
            tbLado.Visible = false;
            lbLado.Visible = false;
            lbDiagonalMaior.Visible = false;
            tbDiagonalMaior.Visible = false;
            lbDiagonalMenor.Visible = false;
            tbDiagonalMenor.Visible = false;

            btCalcularPerimetro.Enabled = true;



        }
        private void LimparTextBox()
        {
            tbLado.Text = "";
            tbAltura.Text = "";
            tbBaseMaior.Text = "";
            tbBaseMenor.Text = "";
            tbDiagonalMaior.Text = "";
            tbDiagonalMenor.Text = "";
            tbRaio.Text = "";

        }

        private void limparRadioButtons()
        {
            rbCirculo.Checked = false;
            rbHexagono.Checked = false;
            rbLosango.Checked = false;
            rbPentagono.Checked = false;
            rbQuadrado.Checked = false;
            rbRetangulo.Checked = false;
            rbTrapezio.Checked = false;
            rbTriangulo.Checked = false;
        }

        private void btLimparDados_Click(object sender, EventArgs e)
        {
            limparRadioButtons();
            limparDados();
            lvArea.Items.Clear();
            lvPerimetro.Items.Clear();
            pbImagens.Image = Properties.Resources.Branco;
            MessageBox.Show("DADOS LIMPADOS com SUCESSO!",
                "Calculadora Geométrica", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // -------------- CALCULAR AREA --------------
        private void btCalcularArea_Click(object sender, EventArgs e)
        {
            bool recebeValidacao = ValidaInformacao();
            if (rbQuadrado.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Quadrado("Quadrado", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());

                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();

            }

            if (rbTriangulo.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Triangulo("Triangulo", Convert.ToDouble(tbLado.Text),
                    Convert.ToDouble(tbAltura.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());

                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = tbAltura.Text;
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));
                MensagemCadastroArea();


            }

            if (rbRetangulo.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Retangulo("Retangulo", Convert.ToDouble(tbLado.Text),
                    Convert.ToDouble(tbAltura.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());

                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = tbAltura.Text;
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();


            }

            if (rbCirculo.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Circulo("Circulo", Convert.ToDouble(tbRaio.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = "-";
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = tbRaio.Text;
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();


            }

            if (rbPentagono.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Pentagono("Pentagono", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();

            }

            if (rbLosango.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Losango("Losango",
                    Convert.ToDouble(tbDiagonalMaior.Text), Convert.ToDouble(tbDiagonalMenor.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = "-";
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = tbDiagonalMenor.Text;
                forma[6] = tbDiagonalMaior.Text;
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();

            }

            if (rbHexagono.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Hexagono("Hexagono", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();
                ;
            }

            if (rbTrapezio.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Trapezio("Trapezio", Convert.ToDouble(tbBaseMenor.Text),
                    Convert.ToDouble(tbBaseMaior.Text), Convert.ToDouble(tbAltura.Text)); ;
                //MessageBox.Show("A area eh: " + formaGeometrica.Area());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = "-";
                forma[2] = tbAltura.Text;
                forma[3] = tbBaseMenor.Text;
                forma[4] = tbBaseMaior.Text;
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Area());
                lvArea.Items.Add(new ListViewItem(forma));

                MensagemCadastroArea();
                ;
            }

        }

        // -------------- CALCULAR PERIMTREO ------------
        private void btCalcularPerimetro_Click(object sender, EventArgs e)
        {
            bool recebeValidacao = ValidaInformacao();

            if (rbQuadrado.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Quadrado("Quadrado", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("O perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));

                MensagemCadastroPerimetro();

            }

            if (rbTriangulo.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Triangulo("Triangulo", Convert.ToDouble(tbLado.Text),
                    Convert.ToDouble(tbAltura.Text));
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = tbAltura.Text;
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));
                MensagemCadastroPerimetro();

            }

            if (rbRetangulo.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Retangulo("Retangulo", Convert.ToDouble(tbLado.Text),
                    Convert.ToDouble(tbAltura.Text));
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = tbAltura.Text;
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));
                MensagemCadastroPerimetro();

            }

            if (rbPentagono.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Pentagono("Pentagono", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));

                MensagemCadastroPerimetro();

            }

            if (rbLosango.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Losango("Losango", Convert.ToDouble(tbDiagonalMaior.Text),
                    Convert.ToDouble(tbDiagonalMenor.Text));
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = "-";
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = tbDiagonalMenor.Text;
                forma[6] = tbDiagonalMaior.Text;
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));

                MensagemCadastroPerimetro();

            }

            if (rbHexagono.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Hexagono("Hexagono", Convert.ToDouble(tbLado.Text));
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = tbLado.Text;
                forma[2] = "-";
                forma[3] = "-";
                forma[4] = "-";
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));

                MensagemCadastroPerimetro();

            }

            if (rbTrapezio.Checked == true && recebeValidacao == true)
            {
                Formas formaGeometrica = new Trapezio("Trapezio", Convert.ToDouble(tbBaseMenor.Text),
                    Convert.ToDouble(tbBaseMaior.Text), Convert.ToDouble(tbAltura.Text)); ;
                //MessageBox.Show("O Perimetro eh: " + formaGeometrica.Perimetro());
                string[] forma = new string[9];
                forma[0] = formaGeometrica.Nome;
                forma[1] = "-";
                forma[2] = tbAltura.Text;
                forma[3] = tbBaseMenor.Text;
                forma[4] = tbBaseMaior.Text;
                forma[5] = "-";
                forma[6] = "-";
                forma[7] = "-";
                forma[8] = Convert.ToString(formaGeometrica.Perimetro());
                lvPerimetro.Items.Add(new ListViewItem(forma));

                MensagemCadastroPerimetro();

            }

        }

        // -------- RADIO BUTTONS -------------
        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = false;
            tbRaio.Visible = true;
            lbRaio.Visible = true;
            pbImagens.Image = Properties.Resources.Circulo;
        }

        private void rbHexagono_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            tbLado.Visible = true;
            lbLado.Visible = true;
            pbImagens.Image = Properties.Resources.Hexagono;
        }

        private void rbLosango_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            lbDiagonalMaior.Visible = true;
            tbDiagonalMaior.Visible = true;
            lbDiagonalMenor.Visible = true;
            tbDiagonalMenor.Visible = true;
            pbImagens.Image = Properties.Resources.Losango;
        }

        private void rbPentagono_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            tbLado.Visible = true;
            lbLado.Visible = true;
            pbImagens.Image = Properties.Resources.Pentagono;
        }

        private void rbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            lbLado.Visible = true;
            tbLado.Visible = true;
            pbImagens.Image = Properties.Resources.Quadrado;
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            lbLado.Visible = true;
            tbLado.Visible = true;
            tbAltura.Visible = true;
            lbAltura.Visible = true;
            pbImagens.Image = Properties.Resources.Retangulo;
        }

        private void rbTrapezio_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            lbBaseMaior.Visible = true;
            tbBaseMaior.Visible = true;
            lbBaseMenor.Visible = true;
            tbBaseMenor.Visible = true;
            lbAltura.Visible = true;
            tbAltura.Visible = true;
            pbImagens.Image = Properties.Resources.Trapezio;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            limparDados();
            btCalcularPerimetro.Enabled = true;
            lbLado.Visible = true;
            tbLado.Visible = true;
            tbAltura.Visible = true;
            lbAltura.Visible = true;
            pbImagens.Image = Properties.Resources.Triangulo;
        }



        // ------------ APENAS NÚMEROS E VIRGULA ---------------
        private void tbBaseMaior_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbDiagonalMaior_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbBaseMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbDiagonalMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));

                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        
    }
}
        