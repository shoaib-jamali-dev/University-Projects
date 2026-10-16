using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class system_box : Form
    {

        double globalW = 0;
        double globalWq = 0;
        string current_time = "Minutes";

        public system_box()
        {
            InitializeComponent();
            modelbox.SelectedIndex = 0;
            timebox.SelectedIndex = 1;
            wisebox.SelectedIndex = 0;
            displaytimebox.SelectedIndex = 1;
            servicewise.SelectedIndex = 0;
            Servicetimeunit.SelectedIndex = 1;
            servicedist.SelectedIndex = 0;
            arrivaldist.SelectedIndex = 0;
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void system_box_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelbox.Text == "M/M/1")
            {
                lblservice2.Visible = false;
                service_input2.Visible = false;
                service_dist_lbl.Visible = false;
                servicedist.Visible = false;
                service_rate_label.Visible = true;
                servicewise.Visible = true;
                arrivaldistlbl.Visible = false;
                arrivaldist.Visible = false;
                arrivalwise_lbl.Visible = true;
                wisebox.Visible = true;
                lbl_arrival_input2.Visible = false;
                arrival_input2.Visible = false;
                servicedist.SelectedItem = null;
                arrivaldist.SelectedItem = null;
                lbl_arrival_input1.Text = "Arrival Rate:";
                labelservice1.Text = "Service Rate:";

            }
            else if (modelbox.Text == "M/G/1")
            {
                service_rate_label.Visible = false;
                servicewise.Visible = false;
                lblservice2.Visible = true;
                service_input2.Visible = true;
                service_dist_lbl.Visible = true;
                servicedist.Visible = true;
                lblservice2.Text = "Max Service Rate:";
                labelservice1.Text = "Min Service Rate:";
                arrivaldistlbl.Visible = false;
                arrivaldist.Visible = false;
                arrivalwise_lbl.Visible = true;
                wisebox.Visible = true;
                servicedist.SelectedItem = "Uniform";
                arrivaldist.SelectedItem = null;
                lbl_arrival_input2.Visible = false;
                arrival_input2.Visible = false;


            }
            else if (modelbox.Text == "G/G/1")
            {
                arrivaldistlbl.Visible = true;
                arrivaldist.Visible = true;
                arrivalwise_lbl.Visible = false;
                wisebox.Visible = false;
                service_rate_label.Visible = false;
                servicewise.Visible = false;
                lblservice2.Visible = true;
                service_input2.Visible = true;
                service_dist_lbl.Visible = true;
                servicedist.Visible = true;
                lbl_arrival_input2.Visible = true;
                arrival_input2.Visible = true;
                servicedist.SelectedItem = "Uniform";
                arrivaldist.SelectedItem = "Uniform";
                lblservice2.Text = "Max Service Rate:";
                labelservice1.Text = "Min Service Rate:";
                lbl_arrival_input1.Text = "Min Arrival Rate:";
                lbl_arrival_input2.Text = "Max Arrival Rate";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calculation(object sender, EventArgs e)
        {
            if (!double.TryParse(arrival_input1.Text, out double lambda) || !double.TryParse(service_input1.Text, out double mu))

            {
                MessageBox.Show("Please enter a valid number for arrival and service inputs.");
                return;
            }

            double rho = 0;
            double idle = 0;
            double Lq = 0;
            double Wq = 0;
            double W = 0;
            double L = 0;
            double variance = 0;
            double arrival_variance= 0;
            double Ca2 = 0;
            double Cs2 = 0;

            if (Servicetimeunit.Text == "Seconds")
            {
                if (timebox.Text == "Minutes")
                {
                    lambda = lambda / 60.0;
                }
                else if (timebox.Text == "Hours")
                {
                    lambda = lambda / 3600.0;
                }
            }

            if (Servicetimeunit.Text == "Hours")
            {
                if (timebox.Text == "Seconds")
                {
                    lambda = lambda * 3600.0;
                }
                else if (timebox.Text == "Hours")
                {
                    lambda = lambda * 60.0;
                }
            }

            if (Servicetimeunit.Text == "Minutes")
            {
                if (timebox.Text == "Seconds")
                {
                    lambda = lambda * 60.0;
                }
                else if (timebox.Text == "Hours")
                {
                    lambda = lambda / 60.0;
                }
            }


            if (modelbox.Text == "M/M/1")
            {
                if (wisebox.Text == "Mean")
                {
                    lambda = 1 / lambda;
                }

                if (servicewise.Text == "Mean")
                {
                    mu = 1 / mu;
                }

                rho = lambda / mu;

                if (rho >= 1.0)
                {
                    MessageBox.Show("The system is unstable: rho must be less than 1.");
                    labelrho.Text = "0";
                    idle_value.Text = "0";
                    labelLq.Text = "0";
                    labelWq.Text = "0";
                    labelW.Text = "0";
                    labelL.Text = "0";
                    return;
                }

                idle = 1 - rho;
                Lq = Math.Pow(rho, 2) / (1 - rho);
                Wq = Lq / lambda;
                W = Wq + (1 / mu);
                L = lambda * W;


                globalW = W;
                globalWq = Wq;
                current_time = Servicetimeunit.Text;

                displaytimebox.SelectedIndex = Servicetimeunit.SelectedIndex;

                labelrho.Text = rho.ToString();
                idle_value.Text = idle.ToString();
                labelLq.Text = Lq.ToString();
                labelWq.Text = Wq.ToString();
                labelW.Text = W.ToString();
                labelL.Text = L.ToString();

                wtime.Text = Servicetimeunit.Text;
                wqtime.Text = Servicetimeunit.Text;
            }
            else if (modelbox.Text == "M/G/1")
            {
                if (wisebox.Text == "Mean")
                {
                    lambda = 1 / lambda;
                }

                if (servicedist.Text == "Uniform")

                {
                    if (!double.TryParse(service_input1.Text, out double min_service) || 
                        !double.TryParse(service_input2.Text, out double max_service))

                    {
                        MessageBox.Show("Please enter a valid number for min and max service inputs.");
                        return;
                    }


                    mu = (min_service + max_service) / 2;
                    mu = 1 / mu;

                    rho = lambda / mu;
                    variance = Math.Pow((max_service - min_service), 2) / 12;
                    Lq = (Math.Pow(lambda, 2) * variance + Math.Pow(rho, 2)) / (2 * (1 - rho));
                }
                else if (servicedist.Text == "Gamma")
                {

                    if (!double.TryParse(service_input1.Text, out double K) ||
                        !double.TryParse(service_input2.Text, out double Q))

                    {
                        MessageBox.Show("Please enter a valid number for K and Q service inputs.");
                        return;
                    }

                    mu = K * Q;
                    mu = 1 / mu;

                    rho = lambda / mu;

                    variance = K * (Math.Pow(Q, 2));
                    Lq = (Math.Pow(lambda, 2) * variance + Math.Pow(rho, 2)) / (2 * (1 - rho));
                }
                else if (servicedist.Text == "Exponential")
                {

                    rho = lambda / mu;
                    Lq = Math.Pow(rho, 2) / (1 - rho);
                }
                else if (servicedist.Text == "Normal")
                {

                    if (!double.TryParse(service_input1.Text, out double ES) ||
                        !double.TryParse(service_input2.Text, out double sd))

                    {
                        MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                        return;
                    }

                    variance = Math.Pow(sd, 2);

                    rho = lambda * ES;
                    double ES2 = variance + Math.Pow(ES, 2);

                    Lq = (Math.Pow(lambda, 2) * ES2) / (2 * (1 - rho));

                }
                idle = 1 - rho;
                Wq = Lq / lambda;
                W = Wq + (1 / mu);
                L = lambda * W;


                globalW = W;
                globalWq = Wq;
                current_time = Servicetimeunit.Text;

                displaytimebox.SelectedIndex = Servicetimeunit.SelectedIndex;

                labelrho.Text = rho.ToString();
                idle_value.Text = idle.ToString();
                labelLq.Text = Lq.ToString();
                labelWq.Text = Wq.ToString();
                labelW.Text = W.ToString();
                labelL.Text = L.ToString();

                wtime.Text = Servicetimeunit.Text;
                wqtime.Text = Servicetimeunit.Text;

            }
            else if (modelbox.Text == "G/G/1")
            {
                if (arrivaldist.Text == "Uniform")
                {
                    double min_arrival = Convert.ToDouble(arrival_input1.Text);
                    double max_arrival = Convert.ToDouble(arrival_input2.Text);

                    lambda = (min_arrival + max_arrival) / 2;
                    lambda = 1 / lambda;
                    arrival_variance = Math.Pow((max_arrival - min_arrival), 2) / 12;

                    if(servicedist.Text == "Uniform")
                    {

                        double max_service = Convert.ToDouble(service_input2.Text);
                        double min_service = Convert.ToDouble(service_input1.Text);

                        mu = (min_service + max_service) / 2;
                        mu = 1 / mu;
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                    } else if (servicedist.Text == "Gamma") 
                    {
                        double K = Convert.ToDouble(service_input1.Text);
                        double Q = Convert.ToDouble(service_input2.Text);

                        mu = K * Q;
                        mu = 1 / mu;

                        variance = K * (Math.Pow(Q, 2));

                    } else if(servicedist.Text == "Normal")
                    {
                        double ES = Convert.ToDouble(service_input1.Text);
                        double sd = Convert.ToDouble(service_input2.Text);

                        mu = 1 / ES;
                        variance = Math.Pow(sd, 2);
                    }

                } else if(arrivaldist.Text == "Gamma")
                {
                    double K = Convert.ToDouble(arrival_input1.Text);
                    double Q = Convert.ToDouble(arrival_input2.Text);

                    mu = K * Q;
                    arrival_variance = K * (Math.Pow(Q, 2));


                    if (servicedist.Text == "Uniform")
                    {

                        double max_service = Convert.ToDouble(service_input2.Text);
                        double min_service = Convert.ToDouble(service_input1.Text);

                        mu = (min_service + max_service) / 2;
                        mu = 1 / mu;
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                    }
                    else if (servicedist.Text == "Gamma")
                    {
                        double k = Convert.ToDouble(service_input1.Text);
                        double q = Convert.ToDouble(service_input2.Text);

                        mu = k * q;
                        mu = 1 / mu;

                        variance = k * (Math.Pow(q, 2));

                    }
                    else if (servicedist.Text == "Normal")
                    {
                        double ES = Convert.ToDouble(service_input1.Text);
                        double sd = Convert.ToDouble(service_input2.Text);

                        mu = 1 / ES;
                        variance = Math.Pow(sd, 2);
                    }



                } else if(arrivaldist.Text == "Normal")
                {

                    double EA = Convert.ToDouble(arrival_input1.Text);
                    double sd = Convert.ToDouble(arrival_input2.Text);

                    lambda = 1 / EA;
                    arrival_variance = Math.Pow(sd, 2);


                    if (servicedist.Text == "Uniform")
                    {

                        double max_service = Convert.ToDouble(service_input2.Text);
                        double min_service = Convert.ToDouble(service_input1.Text);

                        mu = (min_service + max_service) / 2;
                        mu = 1 / mu;
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                    }
                    else if (servicedist.Text == "Gamma")
                    {
                        double k = Convert.ToDouble(service_input1.Text);
                        double q = Convert.ToDouble(service_input2.Text);

                        mu = k * q;
                        mu = 1 / mu;
                        variance = k * (Math.Pow(q, 2));

                    }
                    else if (servicedist.Text == "Normal")
                    {
                        double ES = Convert.ToDouble(service_input1.Text);
                        double SD = Convert.ToDouble(service_input2.Text);

                        mu = 1 / ES;
                        variance = Math.Pow(SD, 2);
                    }
                    
                } else if (arrivaldist.Text == "Exponent")
                {

                }

                rho = lambda / mu;
                idle = 1 - rho;
                Ca2 = arrival_variance / Math.Pow((1 / lambda),2);
                Cs2 = variance / Math.Pow((1 / mu),2);

                Lq = (Math.Pow(rho, 2) * (1 + Ca2) * (Ca2 + Cs2)) / (2 * (1 - rho) * (1 + Math.Pow(rho, 2)) * (1 + (Math.Pow(rho, 2) * Ca2)));

                Wq = Lq / lambda;
                W = Wq + (1 / mu);
                L = lambda * W;


                globalW = W;
                globalWq = Wq;
                current_time = Servicetimeunit.Text;

                displaytimebox.SelectedIndex = Servicetimeunit.SelectedIndex;

                
                labelrho.Text = rho.ToString();
                idle_value.Text = idle.ToString();
                labelLq.Text = Lq.ToString();
                labelWq.Text = Wq.ToString();
                labelW.Text = W.ToString();
                labelL.Text = L.ToString();

                wtime.Text = Servicetimeunit.Text;
                wqtime.Text = Servicetimeunit.Text;

            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            double displayW = globalW;
            double displayWq = globalWq;

            if (current_time == "Hours")
            {
                if (displaytimebox.Text == "Seconds")
                {
                    displayWq = displayWq * 3600.0;
                    displayW = displayW * 3600.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else if (displaytimebox.Text == "Minutes")
                {
                    displayWq = displayWq * 60.0;
                    displayW = displayW * 60.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else
                {
                    labelWq.Text = globalWq.ToString();
                    labelW.Text = globalW.ToString();
                }
            }


            if (current_time == "Minutes")
            {
                if (displaytimebox.Text == "Seconds")
                {
                    displayWq = displayWq * 60.0;
                    displayW = displayW * 60.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else if (displaytimebox.Text == "Hours")
                {
                    displayWq = displayWq / 60.0;
                    displayW = displayW / 60.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else
                {
                    labelWq.Text = globalWq.ToString();
                    labelW.Text = globalW.ToString();
                }
            }


            if (current_time == "Seconds")
            {
                if (displaytimebox.Text == "Minutes")
                {
                    globalWq = displayWq / 60.0;
                    globalW = displayW / 60.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else if (displaytimebox.Text == "Hours")
                {
                    displayWq = displayWq / 3600.0;
                    displayW = displayW / 3600.0;
                    labelWq.Text = displayWq.ToString();
                    labelW.Text = displayW.ToString();
                }
                else
                {
                    labelWq.Text = globalWq.ToString();
                    labelW.Text = globalW.ToString();
                }
            }

            wtime.Text = displaytimebox.Text;
            wqtime.Text = displaytimebox.Text;
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void servicedist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelbox.Text == "M/M/1")
            {
                lblservice2.Visible = false;
                service_input2.Visible = false;
                return;
            }

            if (servicedist.Text == "Gamma")
            {
                lblservice2.Visible = true;
                service_input2.Visible = true;
                labelservice1.Text = "Shape (K):";
                lblservice2.Text = "Scale (Q):";
            }
            else if (servicedist.Text == "Exponential")
            {
                lblservice2.Visible = false;
                service_input2.Visible = false;
                labelservice1.Text = "Service Rate";

            }
            else if (servicedist.Text == "Uniform")
            {
                lblservice2.Visible = true;
                service_input2.Visible = true;
                lblservice2.Text = "Max Service Rate:";
                labelservice1.Text = "Min Service Rate:";

            }
            else if (servicedist.Text == "Normal")
            {
                lblservice2.Visible = true;
                service_input2.Visible = true;
                lblservice2.Text = "Standard Deviation - σ:";
                labelservice1.Text = " Mean Service Rate E[S]:";
               

            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void arrivaldist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelbox.Text != "G/G/1")
            {
                lbl_arrival_input2.Visible = false;
                arrival_input2.Visible = false;
                return;
            }

            if (arrivaldist.Text == "Gamma")
            {
                arrival_input2.Visible = true;
                lbl_arrival_input2.Visible = true;
                lbl_arrival_input1.Text = "Shape(K)";
                lbl_arrival_input2.Text = "Scale (Q)";

            }
            else if (arrivaldist.Text == "Exponential")
            {
                lbl_arrival_input2.Visible = false;
                lbl_arrival_input1.Text = "Arrival Rate";
                arrival_input2.Visible = false;
            }
            else if (arrivaldist.Text == "Uniform")
            {
                arrival_input2.Visible = true;
                lbl_arrival_input2.Visible = true;
                lbl_arrival_input1.Text = "Min Arrival Rate:";
                lbl_arrival_input2.Text = "Max Arrival Rate";
            }
            else if (arrivaldist.Text == "Normal")
            {
                arrival_input2.Visible = true;
                lbl_arrival_input2.Visible = true;
                lbl_arrival_input1.Text = "Mean Arrival Rate E[A]:";
                lbl_arrival_input2.Text = "Standard Deviation - σ:";
            }

        }

        private void lblservice2_Click(object sender, EventArgs e)
        {

        }
    }
}
