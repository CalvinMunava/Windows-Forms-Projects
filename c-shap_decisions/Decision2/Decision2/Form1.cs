namespace Decision2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") //--> True Condition [ and && ] [ or || ] [ is not != 18  ]
            {
                //try and convert the text to be a int 
                int Age;
                bool isNumber = false;
                isNumber = int.TryParse(textBox1.Text, out Age); // !!!!!!!! Age = int.TryParse(textBox1.Text)

                //check whether we were successful
                if (isNumber == true)
                {
                    //Ayep yep , strip , social club 
                    if(Age >= 18)
                    {
                        //let you into club
                        listBox1.Items.Add(Age);
                    }
                    else if(Age >= 15  &&   Age < 18)
                    {
                        MessageBox.Show("Just wait a few more years");
                    }
                    else if(Age >= 10 && Age < 15)
                    {
                        MessageBox.Show("Go back to High School");
                    }
                    else
                    {
                        //Go away youre waay to young 
                        MessageBox.Show("Go away lol you're under age");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid int number");
                }
            }
            else
            {
                MessageBox.Show("Please Go Study");
            }
        }

  
    }
}