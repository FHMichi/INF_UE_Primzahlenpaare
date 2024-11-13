using System.Transactions;

namespace INF_UE_Primzahlenpaare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean isPrime(int num)
        {
            if (num <= 1) return false; 

            for (int i = 2; i< num; i++)
            {
                if (num % i == 0) return false; 
            }
            return true; 
            
        }
        private void btmStart_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            int end = Convert.ToInt32(tbInput.Text); 
            Boolean b = false; 
            List<int> primes = new List<int>();   
           
            for (int z = 0; z < end ; z++)
            {
                if(isPrime(z)) primes.Add(z);
            }

            int counter = 0; 
            for (int i = 0; i < primes.Count-1; i++)
            {       
                if (primes[i+1] - primes[i] == 2)
                {
                    lbOutput.Items.Add("[" + primes[i] + "," + primes[i + 1] + "]");
                    counter++;  
                }

            }
            lblTextOutput.Text = "" + counter + " Primzahlenpaare gefunden unter \n" + primes.Count + " Primzahlen";  
        }
    }
}
