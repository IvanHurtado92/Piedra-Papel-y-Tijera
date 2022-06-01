namespace PPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Hide();
            button3.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            listBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            JugImagen.Hide();
            MaqImagen.Hide();
            label2.Text = "";
        }
        public static int[] datos = new int[100];
        public static Random aleatorio = new Random();
        public static int valorm,valorj,gana,boton = new int();
        int i = 0;
        public static List<int> lista = new List<int>();

        public void conversor(int num,Label etiqueta,PictureBox imagen)
        {
            if(num == 1)
            {
                etiqueta.Text = "Piedra";
                imagen.Image = Properties.Resources.puño80x80; 

            }
            else if (num == 2)
            {
                etiqueta.Text = "Papel";
                imagen.Image = Properties.Resources.mano80x80;
            }
            else
            {
                etiqueta.Text = "Tijera";
                imagen.Image = Properties.Resources.amorypaz80x80;
            }
        }

        public void victoria(int jug,int maq)
        {
            if(jug == 1 && maq == 3)
            {
                MessageBox.Show("Ganó el jugador");
                gana = 1;
            }
            else if(jug == 1 && maq == 2)
            {
                MessageBox.Show("Ganó la IA");
                gana = 0;
            }
            else if (jug == 2 && maq == 1)
            {
                MessageBox.Show("Ganó el jugador");
                gana = 1;
            }
            else if (jug == 2 && maq == 3)
            {
                MessageBox.Show("Ganó la IA");
                gana = 0;
            }
            else if (jug == 3 && maq == 2)
            {
                MessageBox.Show("Ganó el jugador");
                gana = 1;
            }
            else if (jug == 3 && maq ==1)
            {
                MessageBox.Show("Ganó la IA");
                gana = 0;
            }
            else if(jug == maq)
            {
                MessageBox.Show("Empate");
                gana = 2;
            }
            if (boton == 1) basedatos(gana);
            else if (boton == 2 && gana != 2) i++;
        }

        public void recopilacion(int victoria,int movimiento)
        {
            if(victoria == 1)
            {
                switch (movimiento)
                {
                    case 1: listBox1.Items.Add("Ronda " + i + ": Jugador Gana con Piedra, Maquina Pierde con Tijeras");
                        break;
                    case 2:
                        listBox1.Items.Add("Ronda " + i + ": Jugador Gana con Papel, Maquina Pierde con Piedra");
                        break;
                    case 3:
                        listBox1.Items.Add("Ronda " + i + ": Jugador Gana con Tijera, Maquina Pierde con Papel");
                        break;
                }
            }
            else if(victoria == 0)
            {
                switch (movimiento)
                {
                    case 1:
                        listBox1.Items.Add("Ronda " + i + ": Jugador Pierde con Piedra, Maquina Gana con Papel");
                        break;
                    case 2:
                        listBox1.Items.Add("Ronda " + i + ": Jugador Pierde con Papel, Maquina Gana con Tijeras");
                        break;
                    case 3:
                        listBox1.Items.Add("Ronda " + i + ": Jugador Pierde con Tijera, Maquina Gana con Piedra");
                        break;
                }
            }
        }

        public void basedatos(int val)
        {
                switch (val)
                {
                    case 1:
                        switch (valorj)
                        {
                            case 1:
                                datos[i] = 2;
                                break;
                            case 2:
                                datos[i] = 3;
                                break;
                            case 3:
                                datos[i] = 1;
                                break;
                        }
                            i++;
                            break;
                    case 0:
                        datos[i] = valorm;
                            i++;
                            break;
                }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            label1.Show();
            label4.Show();
            boton = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            label1.Show();
            label4.Show();
            boton = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Show();
            listBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Show();
            valorj = 1;
            if(boton == 1)
            {
                valorm = aleatorio.Next(1, 4);
            }
            else if(boton == 2)
            {
                int rand2 = aleatorio.Next(0,i);
                valorm = datos[rand2];
                
            }
            label2.Text = Convert.ToString(valorm);
            conversor(valorj, label3,JugImagen);
            conversor(valorm,label2,MaqImagen);
            label2.Show();
            label3.Show();
            MaqImagen.Show();
            JugImagen.Show();
            victoria(valorj, valorm);
            recopilacion(gana, valorj);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Show();
            valorj = 2;
            if (boton == 1)
            {
                valorm = aleatorio.Next(1, 4);
            }
            else if (boton == 2)
            {
                int rand2 = aleatorio.Next(0, i);
                valorm = datos[rand2];
                
            }
            label2.Text = Convert.ToString(valorm);
            conversor(valorj, label3, JugImagen);
            conversor(valorm, label2, MaqImagen);
            label2.Show();
            label3.Show();
            MaqImagen.Show();
            JugImagen.Show();
            victoria(valorj, valorm);
            recopilacion(gana, valorj);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Show();
            valorj = 3;
            if (boton == 1)
            {
                valorm = aleatorio.Next(1, 4);
            }
            else if (boton == 2)
            {
                int rand2 = aleatorio.Next(0, i);
                valorm = datos[rand2];
                
            }
            label2.Text = Convert.ToString(valorm);
            conversor(valorj, label3, JugImagen);
            conversor(valorm, label2, MaqImagen);
            MaqImagen.Show();
            JugImagen.Show();
            label2.Show();
            label3.Show();
            victoria(valorj, valorm);
            recopilacion(gana, valorj);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Hide();
            JugImagen.Hide();
            MaqImagen.Hide();
            label2.Text = "";
            label3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Show();
            if (i > 0) { 
                button2.Show();
                button3.Show();
            }
            button4.Show();

            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();

            listBox1.Hide();
            JugImagen.Hide();
            MaqImagen.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}