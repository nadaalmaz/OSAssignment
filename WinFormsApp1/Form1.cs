using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Make_Table_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(textBox2.Text);
            int columns = int.Parse(textBox1.Text);

            //Total Resources Table:

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            int ascii = 65;

            dataGridView2.Columns.Add("", "");

            for (int i = 0; i < columns; i++)

            {

                dataGridView2.Columns.Add("R " + i, Convert.ToString((char)ascii));
                ascii++;
            }


            dataGridView2.Rows.Add("Num.");


            dataGridView2.AllowUserToAddRows = false;

            //Available Resources Table:

            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            ascii = 65;

            dataGridView3.Columns.Add("", "");

            for (int i = 0; i < columns; i++)

            {

                dataGridView3.Columns.Add("R " + i, Convert.ToString((char)ascii));
                ascii++;
            }


            dataGridView3.Rows.Add("Num.");


            dataGridView3.AllowUserToAddRows = false;

            //Maximum Need table

            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();

            dataGridView4.Columns.Add("", "");

            ascii = 65;

            for (int i = 0; i < columns; i++)

            {

                dataGridView4.Columns.Add("R " + i, Convert.ToString((char)ascii));
                ascii++;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridView4.Rows.Add("P " + (i + 1));
            }

            dataGridView4.AllowUserToAddRows = false;

            //Current Allocation Table:

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("", "");

            ascii = 65;

            for (int i = 0; i < columns; i++)

            {

                dataGridView1.Columns.Add("R " + i, Convert.ToString((char)ascii));
                ascii++;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridView1.Rows.Add("P " + (i + 1));
            }

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {


            int rows1 = dataGridView1.Rows.Count;
            int columns1 = dataGridView1.Columns.Count - 1;
            int[,] current_2D = new int[rows1, columns1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 1; j < columns1 + 1; j++)
                {
                    string value1 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    current_2D[i, j - 1] = int.Parse(value1);
                }
            }



            int rows4 = dataGridView4.Rows.Count;
            int columns4 = dataGridView4.Columns.Count - 1;
            int[,] max_2D = new int[rows4, columns4];
            for (int i = 0; i < rows4; i++)
            {
                for (int j = 1; j < columns4 + 1; j++)
                {
                    string value4 = dataGridView4.Rows[i].Cells[j].Value.ToString();
                    max_2D[i, j - 1] = int.Parse(value4);
                }
            }



            int rows2 = dataGridView2.Rows.Count;
            int columns2 = dataGridView2.Columns.Count - 1;
            int[,] totalres_2D = new int[rows2, columns2];
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 1; j < columns2 + 1; j++)
                {
                    string value2 = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    totalres_2D[i, j - 1] = int.Parse(value2);
                }
            }


            int rows3 = dataGridView3.Rows.Count;
            int columns3 = dataGridView3.Columns.Count - 1;
            int[,] available_2D = new int[rows3, columns3];
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 1; j < columns3 + 1; j++)
                {
                    string value2 = dataGridView3.Rows[i].Cells[j].Value.ToString();
                    available_2D[i, j - 1] = int.Parse(value2);
                }
            }




            int rownum = int.Parse(textBox5.Text) - 1;
            int columnnum = (int)((textBox6.Text)[0]) - 65;
            int val = int.Parse(textBox7.Text);
            current_2D[rownum, columnnum] = val;




            int[,] remaining_2D = new int[rows1, columns1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns1; j++)
                {
                    remaining_2D[i, j] = (max_2D[i, j]) - (current_2D[i, j]);
                }
            }

            //checking if safe

            bool issafe = false;

            int numProcesses = max_2D.GetLength(0);
            int numResources = max_2D.GetLength(1);
            int[] work = new int[numResources]; //a copy of the avialable array so that we can work on it

            // Initialize work array to available resources
            for (int i = 0; i < numResources; i++)
            {
                work[i] = available_2D[0, i]; //copy the array
            }

            bool[] finish = new bool[numProcesses]; //will have a bool for each process (row)

            for (int i = 0; i < numProcesses; i++)
            {
                finish[i] = false; //initialize to false (not yet added to my 'work' array)

            }

            bool found = true; //there is a process that can be done (has resources from available/work array)

            while (found)
            {
                found = false; //keep false till we find a process
                for (int i = 0; i < numProcesses; i++) //check each process
                {
                    if (!finish[i]) //if this process is not yet finished (added values to available)
                    {
                        bool canBeCompleted = true; //can be completed unless proven otherwise
                        for (int j = 0; j < numResources; j++)
                        {
                            if (remaining_2D[i, j] > work[j])
                            {
                                canBeCompleted = false;
                                break; //get out if it doesnt have enough available resources and set to false
                            }
                        }

                        if (canBeCompleted)
                        {
                            found = true; //we can continue the while loop
                            finish[i] = true; //mark this process as finised
                            for (int j = 0; j < numResources; j++)
                            {
                                work[j] += current_2D[i, j]; //add the values in the process to the array
                            }
                        }

                    }

                }
            }

            for (int i = 0; i < numProcesses; i++)
            {
                if (!finish[i])
                {
                    issafe = false;
                    MessageBox.Show("Not Safe! Request is not granted");
                }
            }

            if (issafe)
            {
                MessageBox.Show("Safe! Request is granted");
            }
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

