using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static String p = "";
        static String connection = "Server= 127.0.0.1 ;Port=3325; Database=dispenser ; User ID=root ; Password=" + p + ";SSL Mode=None";
        static MySqlConnection DBConnect = new MySqlConnection(connection);

        static int cuprice;
        static int ctotal ;
        int cavailable;

        static int puprice;
        static int ptotal;
        int pavailable;

        static int ouprice;
        static int ototal;
        int oavailable;

        static int cbavailable;
        static int pbavailable;
        static int obavailable;

        static String order ;
// Coca Cola Button
        private void coke_Click(object sender, EventArgs e)
        {
            number.ReadOnly = true;
            coke.Enabled = false;
            coke.BackColor = Color.DarkSlateGray;
            pepsi.BackColor = Color.MidnightBlue;
            orange.BackColor = Color.DarkOrange;
            pepsi.Enabled = true;
            orange.Enabled = true;
            price.Visible = false;
            info.Visible = false;
            listd.SetBounds(496, 215, 197, 19);
            this.BackgroundImage = null;
            panel1.Visible = true;
            number.Visible = true;
            ok.Visible = true;
            next1.Visible = true;
            cancel1.Visible = true;
            try
            {
                DBConnect.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `drinks` ;", DBConnect);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader["Name"].ToString())
                        {
                            case "Coca Cola":
                                cuprice = reader.GetInt32(1);
                                ctotal = reader.GetInt32(2);
                                cbavailable = reader.GetInt32(3);
                                break;
                            case "Pepsi":
                                pbavailable = reader.GetInt32(3);
                                ptotal = reader.GetInt32(2);
                                break;
                            case "Orange Crush":
                                obavailable = reader.GetInt32(3);
                                ototal = reader.GetInt32(2);
                                break;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Details are Unavailable!","Warning");
                }
                
                DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TotalPrice();
            
            if (cbavailable == 0 || cavailable == 0 )
                
            {
                MessageBox.Show("Unavailable !", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                panel1.Enabled = false;
                number.Enabled = false;
                ok.Enabled = false;
                if (listd.Text == "Selected Quantity")
                {
                    next1.Enabled = false;
                }
                else
                {
                    next1.Enabled = true;
                }


            }
            else
            {
                MessageBox.Show("Available ! \n\nQuantity = " + cavailable + "\n\nUnit Price = Rs." + cuprice, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                cancel1.Visible = true;
                panel1.Enabled = true;
                number.Enabled = true;
                ok.Enabled = true;
                next1.Enabled = true;


            }
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            this.CenterToScreen();
            price.Visible = false;
            panel1.Visible = false;
            number.Visible = false;
            clear.Visible = false;
            listd.Visible = false;
            next1.Visible = false;
            pay.Visible = false;
            cancel.Visible = false;
            cancel1.Visible = false;
            ok.Visible = false;
            ok1.Visible = false;
            cpay.Visible = false;
            bal.Visible = false;
            customer.Visible = false;
            balan.Visible = false;
            info.Text = "          It's drink time! \nBe intensely refreshing ...... ";
            
            back.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number.Text = number.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        { 
            if(number.Text != "")
            {
                number.Text = number.Text + "0";
            }
            
        }
// Button to clear the bucket list
        private void clear_Click(object sender, EventArgs e)
        {
            
            String display="";
            if (listd.Text != "Selected Quantity")
            {
                String drinkdetails = listd.Text;
                String details = drinkdetails.Replace("\n\n", ",");
                List<String> list = details.Split(',').ToList();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (i == 0)
                    {
                        display += Convert.ToString(list[i]);

                    }
                    else
                    {
                        display += "\n\n" + Convert.ToString(list[i]);
                    }
                    
                }
                listd.Text = display;
                if (display == "Selected Quantity")
                {
                    listd.Visible = false;
                    clear.Visible = false;
                }
            }
            
            
        }
        //Button to navigate from item selection section to bill display section
        private void next1_Click(object sender, EventArgs e)
        {
            if (listd.Text== "Selected Quantity")
            {
                MessageBox.Show("Please select the required quantity first by using numeric keypad and then clicking OK button!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string message = "Do you want to buy more drinks?";
                string title = "Complete Order";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    coke.Enabled = true;
                    pepsi.Enabled = true;
                    orange.Enabled = true;
                    orange.BackColor = Color.DarkOrange;
                    coke.BackColor = Color.DarkRed;
                    pepsi.BackColor = Color.MidnightBlue;
                    panel1.Visible = false;
                    number.Visible = false;
                    clear.Visible = false;
                    next1.Visible = false;
                    ok.Visible = false;
                    price.Visible = true;
                    listd.SetBounds(45, 64, 67, 40);
                    price.SetBounds(300, 64, 67, 13);
                    pay.SetBounds(550, 64, 86, 45);
                    cancel.SetBounds(550, 120, 86, 45);
                    pay.Visible = true;
                    cancel.Visible = true;
                    cancel1.Visible = false;
                    coke.Visible = false;
                    pepsi.Visible = false;
                    orange.Visible = false;
                    back.Visible = true;
                    info.Visible = false;
                    TotalPrice();


    

                }
            }
            


        }
// Pepsi Button
        private void pepsi_Click(object sender, EventArgs e)
        {
            number.ReadOnly = true;
            coke.Enabled = true;
            pepsi.Enabled = false;
            orange.Enabled = true;
            price.Visible = false;
            info.Visible = false;
            listd.SetBounds(496, 215, 197, 19);
            this.BackgroundImage = null;
            pepsi.BackColor = Color.DarkSlateGray;
            coke.BackColor = Color.DarkRed;
            orange.BackColor = Color.DarkOrange;
            panel1.Visible = true;
            number.Visible = true;
            ok.Visible = true;
            next1.Visible = true;
            cancel1.Visible = true;
            try
            {
                DBConnect.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `drinks` ;", DBConnect);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader["Name"].ToString())
                        {
                            case "Pepsi":
                                puprice = reader.GetInt32(1);
                                ptotal = reader.GetInt32(2);
                                pbavailable = reader.GetInt32(3);
                                break;
                            case "Coca Cola":
                                cbavailable = reader.GetInt32(3);
                                ctotal = reader.GetInt32(2);
                                break;
                            case "Orange Crush":
                                obavailable = reader.GetInt32(3);
                                ototal = reader.GetInt32(2);
                                break;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Details are Unavailable!", "Warning");
                }

                DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TotalPrice();
            

            if (pbavailable == 0 || pavailable == 0)
            {
                MessageBox.Show("Unavailable !", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel1.Enabled = false;
                number.Enabled = false;
                ok.Enabled = false;
                if (listd.Text == "Selected Quantity")
                {
                    next1.Enabled = false;
                }
                else
                {
                    next1.Enabled = true;
                }
              
            }
            else
            {
                MessageBox.Show("Available ! \n\nQuantity = "+pavailable+"\n\nUnit Price = Rs." + puprice, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                panel1.Enabled = true;
                number.Enabled = true;
                ok.Enabled = true;
                next1.Enabled = true;

            }
        }
// Orange Crush Button
        private void orange_Click(object sender, EventArgs e)
        {
            number.ReadOnly = true;
            coke.Enabled = true;
            pepsi.Enabled = true;
            orange.Enabled = false;
            price.Visible = false;
            info.Visible = false;
            listd.SetBounds(496, 215, 197, 19);
            this.BackgroundImage = null;
            orange.BackColor = Color.DarkSlateGray;
            coke.BackColor = Color.DarkRed;
            pepsi.BackColor = Color.MidnightBlue;
            panel1.Visible = true;
            number.Visible = true;
            ok.Visible = true;
            next1.Visible = true;
            cancel1.Visible = true;
            

            try
            {
                DBConnect.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `drinks` ;", DBConnect);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        switch (reader["Name"].ToString())
                        {
                            case "Orange Crush":
                                ouprice = reader.GetInt32(1);
                                ototal = reader.GetInt32(2);
                                obavailable = reader.GetInt32(3);
                                break;
                            case "Coca Cola":
                                cbavailable = reader.GetInt32(3);
                                ctotal = reader.GetInt32(2);
                                break;
                            case "Pepsi":
                                pbavailable = reader.GetInt32(3);
                                ptotal = reader.GetInt32(2);
                                break;

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Details are Unavailable!", "Warning");
                }

                DBConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TotalPrice();
            
            if (obavailable == 0 || oavailable == 0)
            {
                MessageBox.Show("Unavailable !", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                panel1.Enabled = false;
                number.Enabled = false;
                ok.Enabled = false;
                if (listd.Text == "Selected Quantity")
                {
                    next1.Enabled = false;
                }
                else
                {
                    next1.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Available ! \n\nQuantity = " + oavailable + "\n\nUnit Price = Rs." + ouprice, "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                panel1.Enabled = true;
                number.Enabled = true;
                ok.Enabled = true;
                next1.Enabled = true;

            }
        }

        private void price_Click(object sender, EventArgs e)
        {

        }
// Button to add selected items to the list
        private void ok_Click(object sender, EventArgs e)
        {
            if (number.Text != "")

            {
                DialogResult res = MessageBox.Show(" Do you want to add the quantity selected ","CONFIRMATION",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes )
                {
                    TotalPrice();
                    if (coke.Enabled == false)
                    {

                        if (Convert.ToInt32(number.Text)<= ctotal  && cavailable-(Convert.ToInt32(number.Text)) >= 0)
                        {
                            
                            listd.Text = listd.Text + "\n\n\u2022 Coca Cola : " + number.Text;
                            number.Text = "";
                            listd.Visible = true;
                            clear.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Ordered amount is out of range of the availability !","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            number.Text = "";
                        }
                        
                    }
                    else if (pepsi.Enabled == false)
                    {
                        if (Convert.ToInt32(number.Text) <= ptotal && pavailable - (Convert.ToInt32(number.Text)) >= 0)
                        {
                            listd.Text = listd.Text + "\n\n\u2022 Pepsi : " + number.Text;
                            number.Text = "";
                            listd.Visible = true;
                            clear.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Ordered amount is out of range of the availability !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            number.Text = "";
                        }
                       
                    }
                    else
                    {
                        if (Convert.ToInt32(number.Text) <= ototal && oavailable - (Convert.ToInt32(number.Text)) >= 0)
                        {
                            listd.Text = listd.Text + "\n\n\u2022 Orange Crush : " + number.Text;
                            number.Text = "";
                            listd.Visible = true;
                            clear.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Ordered amount is out of range of the availability !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            number.Text = "";
                        }
                        
                    }
                    price.Text = "Total Price :";
                }

            }
            
            

        }
        // button to cancel selecting items prior to placing the order and navigate to home section
        private void cancel1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            number.Visible = false;
            clear.Visible = false;
            next1.Visible = false;
            price.Visible = false;
            ok.Visible = false;
            listd.Text = "Selected Quantity";
            listd.Visible = false;
            cancel1.Visible = false;
            back.Visible = false;
            coke.Enabled = true;
            pepsi.Enabled = true;
            orange.Enabled = true;
            orange.BackColor = Color.DarkOrange;
            coke.BackColor = Color.DarkRed;
            pepsi.BackColor = Color.MidnightBlue;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Untitled;
            info.Text = "          It's drink time! \nBe intensely refreshing ...... ";
            info.Visible = true;


        }
        // Button to cancel entire order
        private void cancel_Click(object sender, EventArgs e)
        {
            listd.Text = "Selected Quantity";
            coke.Enabled = true;
            pepsi.Enabled = true;
            orange.BackColor = Color.DarkOrange;
            coke.BackColor = Color.DarkRed;
            pepsi.BackColor = Color.MidnightBlue;
            orange.Enabled = true;
            coke.Visible= true;
            pepsi.Visible = true;
            orange.Visible = true;
            listd.Visible = false;
            back.Visible = false;
            pay.Visible = false;
            cancel.Visible = false;
            price.Visible = false;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Untitled;
            price.Text = "Total Price :";
            info.Text = "          It's drink time! \nBe intensely refreshing ...... ";
            info.Visible = true;
        }
        // Button to navigate to pay section
        private void pay_Click(object sender, EventArgs e)
        {
            cpay.SetBounds(323, 171, 145, 24);
            customer.SetBounds(100, 176, 145, 24);
            ok1.SetBounds(323, 220, 75, 41);
            cancel.Visible = false;
            pay.Visible = false;
            ok.Visible = false;
            listd.Visible = false;
            cpay.Visible = true;
            customer.Visible = true;
            back.Text = "BACK";
            back.Visible = true;
            ok1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        // Button to confirm customer payment and verify the payment

        private void ok1_Click(object sender, EventArgs e)

        {
            Balance();
            
            void Balance(){
                String totalp = price.Text;
                List<String> list = totalp.Split('.').ToList();
                int total = Convert.ToInt32(list[1]);
                int customerp = Convert.ToInt32(cpay.Text);
                if (total> customerp)
                {
                    MessageBox.Show("Insufficient Payment! ", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    int balance = customerp - total;
                    
                    balan.SetBounds(323, 220, 145, 24);
                    bal.SetBounds(100, 220, 46, 13);
                    balan.Text = ""+balance;
                    balan.ReadOnly = true;
                    cpay.ReadOnly = true;
                    ok1.Visible = false;
                    listd.Visible = false;
                    balan.Visible = true;
                    bal.Visible = true;
                    balan.Focus();
                    info.SetBounds(140, 300, 20, 10);             
                    back.Text = "HOME";
                    if (balance != 0)
                    {
                        MessageBox.Show("Please collect your balance!", "Customer Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    info.Text = "                 Thank You! \nEnjoy the drinks && Have a nice day .....";
                    info.Visible = true;
                    try
                    {
                        DBConnect.Open();
                        // update the dtabase for a vaild transaction
                        var detail = "UPDATE drinks SET qavailable = (case WHEN Name = 'Coca Cola' THEN " + cavailable + " WHEN Name = 'Pepsi' THEN " + pavailable + " WHEN Name = 'Orange Crush' THEN " + oavailable + " end), sold = (case WHEN Name = 'Coca Cola' THEN " + (ctotal- cavailable)+ " WHEN Name = 'Pepsi' THEN " + (ptotal - pavailable) + " WHEN Name = 'Orange Crush' THEN " + (ototal - oavailable) + " end), revenue = (case WHEN Name = 'Coca Cola' THEN " + (ctotal - cavailable)*120 + "  WHEN Name = 'Pepsi' THEN " + (ptotal - pavailable) * 140 + "  WHEN Name = 'Orange Crush' THEN " + (ototal - oavailable) * 100 + " end);";
                        new MySqlCommand(detail, DBConnect).ExecuteScalar();

                        DBConnect.Close();
                        
        }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        // Button as home button to navigate to home section or as back button to naviagte to order summary section
        
        private void back_Click(object sender, EventArgs e)
        {
            if (back.Text == "HOME")
            {
                listd.Text = "Selected Quantity";
                coke.Visible = true;
                pepsi.Visible = true;
                orange.Visible = true;
                listd.Visible = false;
                pay.Visible = false;
                cancel.Visible = false;
                price.Visible = false;
                price.Text = "Total Price :";
                cpay.Visible = false;
                bal.Visible = false;
                balan.Visible = false;
                customer.Visible = false;
                back.Visible = false;
                listd.Text = "Selected Quantity";
                balan.Text = "";
                cpay.Text = "";
                cpay.ReadOnly = false;
                this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Untitled;
                info.SetBounds(175, 409,44,30);
                info.Text = "          It's drink time! \nBe intensely refreshing ...... ";
                info.Visible = true;
            }
            else if (listd.Visible == true)
            {
                panel1.Enabled = false;
                panel1.Visible = true;
                number.Visible = true;
                clear.Visible = true;
                next1.Visible = true;
                ok.Visible = true;
                price.Visible = false;
                listd.SetBounds(496, 215, 197, 19);
                pay.Visible = false;
                cancel.Visible = false;
                cancel1.Visible = true;
                coke.Visible = true;
                pepsi.Visible = true;
                orange.Visible = true;
                back.Visible = false;
                info.Visible = false;
                listd.Text = order;
            }
            else
            {
                pay.Visible = true;
                cancel.Visible = true;
                listd.Visible = true;
                cpay.Visible = false;
                customer.Visible = false;
                back.Visible = false;
                ok1.Visible = false;
            }
        }
        /* to find order value,display order calculations and update availbility of each drink types based on placed order */
        void TotalPrice()
        {
            String drinkdetails = listd.Text;
            order = listd.Text;
            String details = drinkdetails.Replace("\n\n", ",");
            List<String> list = details.Split(',').ToList();
            int result = 0;
            int bp = 0;
            int bc = 0;
            int bo = 0;
            String cal1="";
            String cal2 = "";
            String cal3 = "";
            

            for (int i = 1; i < list.Count; i++)
            {
                String drink = list[i];
                List<String> list1 = drink.Split(':').ToList();
                int d = Convert.ToInt32(list1[1]);
                


                if (list1[0] == "\u2022 Coca Cola ")
                {
                    
                    result += (d * cuprice);
                    bc += d;
                    cal1 = cal1+"\u2022 Coca Cola : " + d + " x Rs." + cuprice+"\n\n";
                }
                else if (list1[0] == "\u2022 Pepsi ")
                {

                    result += (d * puprice);
                    bp += d;
                    cal2 = cal2+"\u2022 Pepsi : " + d + " x Rs." + puprice + "\n\n";
                }
                else
                {

                    result += (d * ouprice);
                    bo += d;
                    cal3 = cal3+"\u2022 Orange Crush : " + d + " x Rs." + ouprice + "\n\n";
                }
               

            }
            price.Text = "Total Price :\n\n  Rs. " + result;
            if (next1.Visible==false)
            {
                listd.Text = "Order \n\n" + cal1 + cal2 + cal3;

            }
            
            if (cbavailable!=0)
            {
                cavailable = (cbavailable - bc) ;
                
            }
            if (pbavailable != 0)
            {
                pavailable = (pbavailable - bp) ;
            }
            if (obavailable != 0)
            {
                oavailable = (obavailable - bo) ;
            }
             
        }


        private void all_Click(object sender, EventArgs e)
        {
            number.Text = "";
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            if ((number.Text).Length > 3)
            {
                number.Text = (number.Text).Substring(0,3);

            }
            
        }

        private void clr_Click(object sender, EventArgs e)
        {
            if ((number.Text) != "")
            {
                number.Text = (number.Text).Substring(0, (number.Text).Length - 1);
            }
            
        }

    }
}
