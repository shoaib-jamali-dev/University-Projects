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
            ArrivalWise.SelectedIndex = 0;
            displaytimebox.SelectedIndex = 1;
            servicewise.SelectedIndex = 0;
            Servicetimeunit.SelectedIndex = 1;
            servicedist.SelectedIndex = 0;
            arrivaldist.SelectedIndex = 0;
            errorRho.Visible = false;
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
                ArrivalWise.Visible = true;
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
                ArrivalWise.Visible = true;
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
                ArrivalWise.Visible = false;
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


        private void calculation(object sender, EventArgs e)
        {
            if (!double.TryParse(arrival_input1.Text, out double lambda) || !double.TryParse(service_input1.Text, out double mu))

            {
                MessageBox.Show("Please enter a valid number for arrival and service inputs.");
                return;
            }

         
            double variance = 0;
            double arrival_variance= 0;
         


            switch (modelbox.Text)
            {
                case "M/M/1":
                {
                if (ArrivalWise.Text == "Mean")
                {
                    lambda = 1 / lambda;
                }

                if (servicewise.Text == "Mean")
                {
                    mu = 1 / mu;
                }

                CalculateMM1(lambda, mu);

            
                    break;
                }
                case "M/G/1":
                {
                if (ArrivalWise.Text == "Mean")
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
                    variance = Math.Pow((max_service - min_service), 2) / 12;
                    CalculateMG1(lambda, mu,variance);

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
                    variance = K * (Math.Pow(Q, 2));
                    CalculateMG1(lambda, mu, variance);
                }
                else if (servicedist.Text == "Exponential")
                {
                    CalculateMM1(lambda, mu);
                }
                else if (servicedist.Text == "Normal")
                {

                    if (!double.TryParse(service_input1.Text, out double ES) ||
                        !double.TryParse(service_input2.Text, out double sd))

                    {
                        MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                        return;
                    }

                    mu = 1 / ES;
                    variance = Math.Pow(sd, 2);
                    CalculateMG1(lambda, mu, variance);

                } else if (servicedist.Text == "Deterministic")
                {
                    mu = 1 / mu;
                    variance = 0;
                    CalculateMG1(lambda, mu, variance);

                }
                    break;
                }

                case "G/G/1":
                {
                if (arrivaldist.Text == "Uniform")
                {
                    if (!double.TryParse(arrival_input1.Text, out double min_arrival) ||
                         !double.TryParse(arrival_input2.Text, out double max_arrival))

                    {
                        MessageBox.Show("Please enter a valid number for min and max service inputs.");
                        return;
                    }

                    lambda = (min_arrival + max_arrival) / 2;
                    lambda = 1 / lambda;
                    arrival_variance = Math.Pow((max_arrival - min_arrival), 2) / 12;

                    if(servicedist.Text == "Uniform")
                    {

                        if (!double.TryParse(service_input1.Text, out double min_service) ||
                        !double.TryParse(service_input2.Text, out double max_service))

                        {
                            MessageBox.Show("Please enter a valid number for min and max service inputs.");
                            return;
                        }

                        mu = (min_service + max_service) / 2;
                        mu = 1 / mu;
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                        CalculateGG1(lambda, mu,arrival_variance, variance);

                    } else if (servicedist.Text == "Gamma") 
                    {
                        if (!double.TryParse(service_input1.Text, out double K) ||
                         !double.TryParse(service_input2.Text, out double Q))

                        {
                            MessageBox.Show("Please enter a valid number for K and Q service inputs.");
                            return;
                        }

                        mu = K * Q;
                        mu = 1 / mu;

                        variance = K * (Math.Pow(Q, 2));
                        CalculateGG1(lambda, mu, arrival_variance, variance);

                    } else if(servicedist.Text == "Normal")
                    {
                        if (!double.TryParse(service_input1.Text, out double ES) ||
                        !double.TryParse(service_input2.Text, out double sd))

                        {
                            MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                            return;
                        }

                        mu = 1 / ES;
                        variance = Math.Pow(sd, 2);
                        CalculateGG1(lambda, mu, arrival_variance, variance);
                    }
                    else if (servicedist.Text == "Deterministic")
                    {
                        mu = 1 / mu;
                        variance = 0;
                        CalculateGG1(lambda, mu,arrival_variance, variance);

                    } else if(servicedist.Text == "Exponential")
                            {
                                mu = 1 / mu;
                                variance = 1/Math.Pow(mu,2);
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }

                } else if(arrivaldist.Text == "Gamma")
                {
                    if (!double.TryParse(arrival_input1.Text, out double K) ||
                         !double.TryParse(arrival_input2.Text, out double Q))

                    {
                        MessageBox.Show("Please enter a valid number for min and max service inputs.");
                        return;
                    }

                    lambda = K * Q;
                    lambda = 1 / lambda;
                    arrival_variance = K * (Math.Pow(Q, 2));


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
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                        CalculateGG1(lambda, mu, arrival_variance, variance);
                    }
                    else if (servicedist.Text == "Gamma")
                    {
                        if (!double.TryParse(service_input1.Text, out double k) ||
                         !double.TryParse(service_input2.Text, out double q))

                        {
                            MessageBox.Show("Please enter a valid number for K and Q service inputs.");
                            return;
                        }
                        mu = k * q;
                        mu = 1 / mu;

                        variance = k * (Math.Pow(q, 2));
                        CalculateGG1(lambda, mu, arrival_variance, variance);

                    }
                    else if (servicedist.Text == "Normal")
                    {
                        if (!double.TryParse(service_input1.Text, out double ES) ||
                       !double.TryParse(service_input2.Text, out double sd))

                        {
                            MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                            return;
                        }

                        mu = 1 / ES;
                        variance = Math.Pow(sd, 2);
                        CalculateGG1(lambda, mu, arrival_variance, variance);
                    }
                    else if (servicedist.Text == "Deterministic")
                    {
                        mu = 1 / mu;
                        variance = 0;
                        CalculateGG1(lambda, mu, arrival_variance, variance);

                    }else if(servicedist.Text == "Exponential")
                            {
                                mu = 1 / mu;
                                variance = 1/Math.Pow(mu,2);
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }



                } else if(arrivaldist.Text == "Normal")
                {
                    if (!double.TryParse(arrival_input1.Text, out double EA) ||
                        !double.TryParse(arrival_input2.Text, out double sd))

                    {
                        MessageBox.Show("Please enter a valid number for min and max service inputs.");
                        return;
                    }
                    lambda = 1 / EA;
                    arrival_variance = Math.Pow(sd, 2);


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
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                        CalculateGG1(lambda, mu, arrival_variance, variance);
                    }
                    else if (servicedist.Text == "Gamma")
                    {
                        if (!double.TryParse(service_input1.Text, out double k) ||
                       !double.TryParse(service_input2.Text, out double q))

                        {
                            MessageBox.Show("Please enter a valid number for K and Q service inputs.");
                            return;
                        }

                        mu = k * q;
                        mu = 1 / mu;
                        variance = k * (Math.Pow(q, 2));
                        CalculateGG1(lambda, mu, arrival_variance, variance);

                    }
                    else if (servicedist.Text == "Normal")
                    {
                        if (!double.TryParse(service_input1.Text, out double ES) ||
                            !double.TryParse(service_input2.Text, out double SD))

                        {
                            MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                            return;
                        }

                        mu = 1 / ES;
                        variance = Math.Pow(SD, 2);
                        CalculateGG1(lambda, mu, arrival_variance, variance);
                    }
                    else if (servicedist.Text == "Deterministic")
                    {
                        mu = 1 / mu;
                        variance = 0;
                        CalculateGG1(lambda, mu, arrival_variance, variance);

                    } else if(servicedist.Text == "Exponential")
                            {
                                mu = 1 / mu;
                                variance = 1/Math.Pow(mu,2);
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }
                } else if (arrivaldist.Text == "Exponent")
                {
                    
                        lambda = 1 / lambda;

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
                        variance = Math.Pow((max_service - min_service), 2) / 12;
                        CalculateMG1(lambda, mu, variance);

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
                        variance = K * (Math.Pow(Q, 2));
                        CalculateMG1(lambda, mu, variance);
                    }
                    else if (servicedist.Text == "Exponential")
                    {

                        CalculateMM1(lambda, mu);
                    }
                    else if (servicedist.Text == "Normal")
                    {

                        if (!double.TryParse(service_input1.Text, out double ES) ||
                            !double.TryParse(service_input2.Text, out double sd))

                        {
                            MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                            return;
                        }

                        mu = 1 / ES;
                        variance = Math.Pow(sd, 2);
                        CalculateMG1(lambda, mu, variance);

                    }
                    else if (servicedist.Text == "Deterministic")
                    {
                        mu = 1 / mu;
                        variance = 0;
                        CalculateMG1(lambda, mu, variance);

                    }

                } else if (arrivaldist.Text == "Deterministic")
                        {
                            if (!double.TryParse(arrival_input1.Text, out double EA))

                            {
                                MessageBox.Show("Please enter a valid number for min and max service inputs.");
                                return;
                            }
                            lambda = 1 / EA;
                            arrival_variance = 0;


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
                                variance = Math.Pow((max_service - min_service), 2) / 12;
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }
                            else if (servicedist.Text == "Gamma")
                            {
                                if (!double.TryParse(service_input1.Text, out double k) ||
                                 !double.TryParse(service_input2.Text, out double q))

                                {
                                    MessageBox.Show("Please enter a valid number for K and Q service inputs.");
                                    return;
                                }
                                mu = k * q;
                                mu = 1 / mu;

                                variance = k * (Math.Pow(q, 2));
                                CalculateGG1(lambda, mu, arrival_variance, variance);

                            }
                            else if (servicedist.Text == "Normal")
                            {
                                if (!double.TryParse(service_input1.Text, out double ES) ||
                               !double.TryParse(service_input2.Text, out double sd))

                                {
                                    MessageBox.Show("Please enter a valid number for ES and sd inputs.");
                                    return;
                                }

                                mu = 1 / ES;
                                variance = Math.Pow(sd, 2);
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }
                            else if (servicedist.Text == "Deterministic")
                            {
                                mu = 1 / mu;
                                variance = 0;
                                CalculateGG1(lambda, mu, arrival_variance, variance);

                            }
                            else if (servicedist.Text == "Exponential")
                            {
                                mu = 1 / mu;
                                variance = 1 / Math.Pow(mu, 2);
                                CalculateGG1(lambda, mu, arrival_variance, variance);
                            }

                        }
                        break;
                }
                default:
                    break;
            }

            }

        private void CalculateMM1(double lambda, double mu)
        {

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

            double rho = lambda / mu;


            if (rho >= 1.0)
            {
                errorRho.Visible = true;
                labelrho.Text = "0";
                idle_value.Text = "0";
                labelLq.Text = "0";
                labelWq.Text = "0";
                labelW.Text = "0";
                labelL.Text = "0";
                return;
            }

            double idle = 1 - rho;
            double Lq = Math.Pow(rho, 2) / (1 - rho);
            double  Wq = Lq / lambda;
            double W = Wq + (1 / mu);
             double L = lambda * W;

            errorRho.Visible = false;
            ShowResult(rho, idle, Lq, Wq, W, L);

        }

        private void CalculateMG1(double lambda,double mu,double variance)
        {


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

            double rho = lambda / mu;

            if (rho >= 1.0)
            {
                errorRho.Visible = true;
                labelrho.Text = "0";
                idle_value.Text = "0";
                labelLq.Text = "0";
                labelWq.Text = "0";
                labelW.Text = "0";
                labelL.Text = "0";
                return;
            }

            double Lq = (Math.Pow(lambda, 2) * variance + Math.Pow(rho, 2)) / (2 * (1 - rho));

            double idle = 1 - rho;
            double Wq = Lq / lambda;
            double W = Wq + (1 / mu);
            double L = lambda * W;

            errorRho.Visible = false;
            ShowResult(rho, idle, Lq, Wq, W, L);
        }


        private void CalculateGG1(double lambda, double mu, double arrival_variance,double variance)
        {


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
            double rho = lambda / mu;

            if (rho >= 1.0)
            {
                errorRho.Visible = true;
                labelrho.Text = "0";
                idle_value.Text = "0";
                labelLq.Text = "0";
                labelWq.Text = "0";
                labelW.Text = "0";
                labelL.Text = "0";
                return;
            }


            double idle = 1 - rho;

            double Ca2 = arrival_variance / Math.Pow((1 / lambda), 2);
            double Cs2 = variance / Math.Pow((1 / mu), 2);
            double Lq = (Math.Pow(rho, 2) * (1 + Ca2) * (Ca2 + Cs2)) / (2 * (1 - rho) * (1 + Math.Pow(rho, 2)) * (1 + (Math.Pow(rho, 2) * Ca2)));

           double Wq = Lq / lambda;
           double W = Wq + (1 / mu);
           double L = lambda * W;

            errorRho.Visible = false;
            ShowResult(rho, idle, Lq, Wq, W, L);
        }


        private void ShowResult(double rho,double idle,double Lq,double Wq,double W, double L)
       {
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
            Wqtime.Text = Servicetimeunit.Text;
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
            Wqtime.Text = displaytimebox.Text;
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
                labelservice1.Text = "Mean Service Rate";

            }
            else if (servicedist.Text == "Deterministic")
            {
                lblservice2.Visible = false;
                service_input2.Visible = false;
                labelservice1.Text = "Mean Service Rate E[S]";

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
                lbl_arrival_input1.Text = "Mean Arrival Rate";
                arrival_input2.Visible = false;
            }
            else if (arrivaldist.Text == "Deterministic")
            {
                lbl_arrival_input2.Visible = false;
                lbl_arrival_input1.Text = "Mean Arrival Rate E[A]";
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


    }
}
