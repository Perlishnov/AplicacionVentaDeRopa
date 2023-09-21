namespace AplicacionVentaDeRopa
{
    public partial class Form1 : Form
    {
        object[,] lista = new object[11, 7];
        object[] userInputs = new object[7];

        int ItemIndex = 0;
        int productCounter = 1;
        int[] AllSalesTotal = new int[10];

        int MondayIndex = 1;
        int TuesdayIndex = 2;
        int WednesdayIndex = 3;
        int ThursIndex = 4;
        int FridayIndex = 5;
        int TotalIndex = 6;


        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitItem_Click(object sender, EventArgs e)
        {
            if (ItemIndex > 10)
            {
                MessageBox.Show("No se pueden agregar mas productos");
                return;
            }

            userInputs[0] = txtItem.Text;
            userInputs[1] = Convert.ToInt32(txtDayMonday.Text);
            userInputs[2] = Convert.ToInt32(txtDayTuesday.Text);
            userInputs[3] = Convert.ToInt32(txtDayWednesday.Text);
            userInputs[4] = Convert.ToInt32(txtDayThursday.Text);
            userInputs[5] = Convert.ToInt32(txtDayFriday.Text);
            userInputs[6] = 0;

            int row, col;

            for (row = ItemIndex; row < productCounter; row++)
            {
                int precioProducto = rnd.Next(1, 11);
                int acumuladorTotal = 0;
                lista[row, 0] = txtItem.Text;
                for (col = 1; col < userInputs.Length - 1; col++)
                {
                    int precioPorCantidad = (int)userInputs[col] * precioProducto;
                    lista[row, col] = precioPorCantidad;
                    acumuladorTotal += precioPorCantidad;

                }
                AllSalesTotal[row] = acumuladorTotal;
                lista[row, TotalIndex] = acumuladorTotal;
                RenderMatrix();
            }
            ++ItemIndex;
            ++productCounter;

            renderAccumulatedTotal();
            Resetter();
        }

        private void RenderMatrix()
        {
            lbDisplaySales.Items.Clear();
            string headers = "name\t\tMon.\t\tTue.\t\tWed.\t\tThu.\t\tFri.\t\tTotal\t\t";
            lbDisplaySales.Items.Add(headers);
            for (int row = 0; row < productCounter; row++)
            {
                lbDisplaySales.Items.Add($"{lista[row, 0]}" + "\t\t" + $"${lista[row, MondayIndex]}" + "\t\t" + $"${lista[row, TuesdayIndex]}" + "\t\t" + $"${lista[row, WednesdayIndex]}" + "\t\t" + $"${lista[row, ThursIndex]}" + "\t\t" + $"${lista[row, FridayIndex]}" + "\t\t" + $"${lista[row, TotalIndex]}" + "\t\t");
            }
        }
        private void renderAccumulatedTotal()
        {
            int acc = 0;
            foreach (int total in AllSalesTotal)
            {
                acc += total;
            }
            lblGrossSalesOutput.Text = $"${acc} pesos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resetter();
        }

        private void Resetter()
        {
            btnSubmitItem.Enabled = false;
            txtDayMonday.Text = "0";
            txtDayTuesday.Text = "0";
            txtDayWednesday.Text = "0";
            txtDayThursday.Text = "0";
            txtDayFriday.Text = "0";
            txtItem.Text = "";
            Array.Clear(userInputs);
            userInputs[0] = "";
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtItem.Text))
            {
                btnSubmitItem.Enabled = true;
            }
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}