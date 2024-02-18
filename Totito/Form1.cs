namespace Totito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
        }

        string jugador = "";
        int contador = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                jugador = button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (jugador == "")
            {
                jugador = button11.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (jugador != "") {
                if (button1.Text == "")
                {
                    button1.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button1.Text == button2.Text && button1.Text == button3.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button1.Text == button4.Text && button1.Text == button7.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //diagonal
                        if (!ganadorEncontrado && button1.Text == button5.Text && button1.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button1.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button2.Text == "")
                {
                    button2.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button2.Text == button1.Text && button2.Text == button3.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button2.Text == button5.Text && button2.Text == button8.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button2.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button2.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button3.Text == "")
                {
                    button3.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button3.Text == button2.Text && button3.Text == button1.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button3.Text == button6.Text && button3.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //diagonal
                        if (!ganadorEncontrado && button3.Text == button5.Text && button3.Text == button7.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button3.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button3.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button4.Text == "")
                {
                    button4.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button4.Text == button5.Text && button4.Text == button6.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button4.Text == button1.Text && button4.Text == button7.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button4.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button4.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button5.Text == "")
                {
                    button5.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button5.Text == button4.Text && button5.Text == button6.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button5.Text == button2.Text && button5.Text == button8.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //diagonal
                        if (!ganadorEncontrado && button5.Text == button1.Text && button5.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button5.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button5.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button6.Text == "")
                {
                    button6.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button6.Text == button4.Text && button6.Text == button5.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button6.Text == button3.Text && button6.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button6.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button6.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button7.Text == "")
                {
                    button7.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button7.Text == button8.Text && button7.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button7.Text == button4.Text && button7.Text == button1.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //diagonal
                        if (!ganadorEncontrado && button7.Text == button5.Text && button7.Text == button3.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button7.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button7.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button8.Text == "")
                {
                    button8.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (button8.Text == button7.Text && button8.Text == button9.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button8.Text == button5.Text && button8.Text == button2.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button8.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button8.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (jugador != "")
            {
                if (button9.Text == "")
                {
                    button9.Text = jugador;
                    contador++;
                    bool ganadorEncontrado = false;

                    if (contador > 5)
                    {
                        //horizontal
                        if (!ganadorEncontrado && button9.Text == button8.Text && button9.Text == button7.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //vertical
                        if (!ganadorEncontrado && button9.Text == button3.Text && button9.Text == button6.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                        //diagonal
                        if (!ganadorEncontrado && button9.Text == button5.Text && button9.Text == button1.Text)
                        {
                            MessageBox.Show("El ganador es el jugador " + jugador);
                            button12_Click(null, null);
                            ganadorEncontrado = true;
                        }
                    }

                    if (jugador == button11.Text)
                    {
                        jugador = button10.Text;
                        button9.ForeColor = Color.Red;
                    }
                    else
                    {
                        jugador = button11.Text;
                        button9.ForeColor = Color.Blue;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = 
            button6.Text = button7.Text = button8.Text = button9.Text = "";
            jugador = "";
            MessageBox.Show("Debe seleccionar un jugador antes de comenzar");
        }
    }
}
