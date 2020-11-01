using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays___DrawingWithButtons
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int x = 12;
        private int y = 40;
        private int cont = 0;
        private int filas = 37;
        private int columnas = 39;
        Button[,] pixels = new Button[37, 39];

        public Form()
        {
            InitializeComponent();
        }

        private void Botones(bool valor)
        {
            this.btnCrear.Visible = !valor;
            this.btnLimpiar.Visible = valor;
            this.btnNaranja.Visible = valor;
            this.btnCirculo.Visible = valor;
            this.btnEscudo.Visible = valor;
            this.btnBordar.Visible = valor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Botones(false);
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    
                    Button pixel = new Button();

                    
                    pixel.FlatStyle = FlatStyle.Flat;
                    pixel.Location = new Point(x, y);
                    pixel.Name = "btn" + cont.ToString();
                    pixel.Size = new Size(15, 15);
                    this.x += 15;
                    pixel.Text = "";
                    pixel.UseVisualStyleBackColor = true;

                    this.pixels[i, j] = pixel;

                    Controls.Add(pixels[i, j]);
                    this.cont++;
                }

                this.x = 12;
                this.y += 15;

            }
            Botones(true);
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    this.pixels[i, j].BackColor = Color.White;
                    this.pixels[i, j].FlatAppearance.BorderColor = Color.White;
                }
            }
        }

        private void Naranja_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.filas; i++)
            {
                for(int j = 0; j < this.columnas; j++)
                {
                    if(i == 0 || i == 36)
                    {
                        if(j < 14 || j > 24)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 1 || i == 35)
                    {
                        if (j < 11 || j > 27)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 2 || i == 34)
                    {
                        if (j < 9 || j > 29)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 3 || i == 33)
                    {
                        if (j < 8 || j > 30)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 4 || i == 32)
                    {
                        if (j < 6 || j > 32)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 5 || i == 31)
                    {
                        if (j < 5 || j > 33)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 6 || i == 7 || i == 29 || i == 30)
                    {
                        if (j < 4 || j > 34)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 8 || i == 28)
                    {
                        if (j < 3 || j > 35)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 9 || i == 10 || i == 26 || i == 27)
                    {
                        if (j < 2 || j > 36)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                    if (i == 11 || i == 12 || i == 13 || i == 23 || i == 24 || i == 25)
                    {
                        if (j < 1 || j > 37)
                        {
                            this.pixels[i, j].BackColor = Color.Orange;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Orange;
                        }
                    }
                }
            }
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    if (i == 0 || i == 36)
                    {
                        if (j > 13 && j < 25)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 1 || i == 35)
                    {
                        if (j > 10 && j < 28)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 2 || i == 34)
                    {
                        if (j > 8 && j < 14 || j > 24 && j < 30)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 3 || i == 33)
                    {
                        if (j > 7 && j < 12 || j > 26 && j < 31)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 4 || i == 32)
                    {
                        if (j > 5 && j < 10 || j > 28 && j < 33)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 5 || i == 31)
                    {
                        if (j > 4 && j < 8 || j > 30 && j < 34)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 6 || i == 30)
                    {
                        if (j > 3 && j < 7 || j > 31 && j < 35)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 7 || i == 29)
                    {
                        if (j > 3 && j < 6 || j > 32 && j < 35)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 8 || i == 28)
                    {
                        if (j > 2 && j < 5 || j > 33 && j < 36)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 9 || i == 27)
                    {
                        if (j > 1 && j < 5 || j > 33 && j < 37)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i == 10 || i == 26)
                    {
                        if (j > 1 && j < 4 || j > 34 && j < 37)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i > 10 && i < 14 || i > 22 && i < 26)
                    {
                        if (j > 0 && j < 3 || j > 35 && j < 38)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                    if (i > 13 && i < 23)
                    {
                        if (j >= 0 && j < 2 || j > 36 && j <= 38)
                        {
                            this.pixels[i, j].BackColor = Color.Black;
                            this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void btnEscudo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    if (i == 6 && j == 15)
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 7 && (j > 13 && j < 17))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 8 && (j > 12 && j < 16 || j == 22))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 9 && (j > 11 && j < 24))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 10 && (j > 10 && j < 14 || j > 19 && j < 22))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 11 && ((j > 9 && j < 13 || j > 18 && j < 21 || j == 25)))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 12 && (j > 8 && j < 11 || j > 11 && j < 28))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 13 && (j > 7 && j < 10 || j > 11 && j < 14 || j > 17 && j < 20 || j > 24 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 14 && (j > 6 && j < 9 || j > 11 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 15 && (j > 5 && j < 8 || j > 11 && j < 14 || j > 17 && j < 20 || j > 24 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 16 && (j > 11 && j < 14 || j > 17 && j < 20 || j > 24 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 17 && (j > 11 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 18 && (j > 11 && j < 14 || j > 17 && j < 20 || j > 25 && j < 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 19 && (j == 10 || j > 17 && j < 20 || j == 27))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 20 && (j > 9 && j < 30))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 21 && (j > 9 && j < 12 || j > 17 && j < 20 || j > 26 && j < 29))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 22 && (j > 9 && j < 29))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 23 && (j > 9 && j < 12 || j > 17 && j < 20 || j > 26 && j < 29))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 24 && (j > 9 && j < 12 || j > 17 && j < 20 || j > 26 && j < 29))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 25 && (j > 9 && j < 29 || j == 31))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 26 && (j > 9 && j < 12 || j > 17 && j < 20 || j == 28 || j == 31))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 27 && (j > 17 && j < 20 || j == 31))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 28 && (j > 17 && j < 33))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                    if (i == 29 && (j > 17 && j < 32))
                    {
                        this.pixels[i, j].BackColor = Color.Black;
                        this.pixels[i, j].FlatAppearance.BorderColor = Color.Black;
                    }
                }
            }
        }

        private void btnBordar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < this.columnas; j++)
                {
                    this.pixels[i, j].FlatAppearance.BorderColor = Color.Gray;
                }
            }
        }
    }
}