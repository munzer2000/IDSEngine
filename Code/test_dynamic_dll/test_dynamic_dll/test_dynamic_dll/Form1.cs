using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_dynamic_dll
{
    public partial class Form1 : Form
    {
        public List<string> Signitures_list = new List<string>();
        public List<string> packet_list = new List<string>();
        public static Assembly testAssembly = null; // to be assigned after browsing
        public int sig_num;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //Getting the environment information from the textboxes in the interface
            
                String namespace_name = textBox_namespace.Text;
                String class_name = textBox_className.Text;
                String method1_name = textBox_method1.Text;
                String method2_name = textBox_method2.Text;
                Type calcType = null;//to be assigned later

                try
                {
                    calcType = testAssembly.GetType(namespace_name + "." + class_name);
                    if (calcType == null)
                    {
                        MessageBox.Show("Error in the class or namespace name!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Error in the class or namespace name!");
                    return;
                }

                //int number_of_assigned_signitures = (int)calcType.InvokeMember(method1_name,
                //    BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
                //    null, null, new object[] { new string[] { "AFFF", "3636", "AA" } });
                int number_of_assigned_signitures;
                try
                {
                    string[] arg = Signitures_list.ToArray();
                    number_of_assigned_signitures = (int)calcType.InvokeMember(method1_name,
                        BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
                        null, null, new object[] { arg });
                }
                catch
                {
                    MessageBox.Show("Error in calling the preprocessing method!");
                    return;
                }


                //String found_signiture = (String)calcType.InvokeMember(method2_name,
                //BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
                //null, null, new object[] { "00003363AFFFAFF1" });
                string result_to_show = ""; // just initialization (will be filled with real array later)
                Stopwatch stopwatch = new Stopwatch();//generate timer
                long mem1 = GC.GetTotalMemory(true); // memory before

               
                stopwatch.Start(); // Begin timing

                if (radio_int.Checked)
                {
                    
                    try
                    {
                        String s = packet_list[0];
                        result_to_show = (string)calcType.InvokeMember(method2_name,
                        BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
                        null, null, new object[] { s });


                    }
                    catch
                    {
                        MessageBox.Show("Error in calling the searching method!");
                        return;
                    }
                }
                else if (radio_string.Checked)
                {
                    
                    try
                    {
                        String s = packet_list[0];
                        result_to_show = (string)calcType.InvokeMember(method2_name,
                        BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
                        null, null, new object[] { s });


                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("Error in calling the searching method!");
                        return;
                    }
                }

                long mem2 = GC.GetTotalMemory(true); // memory after
                long mem_delta = mem2 - mem1;

                stopwatch.Stop();// Stop timing
                //update labels to display the results
                String keyword_hex = "";
                List<String> matched_sig = new List<String>();
                
               
                    //for (int i = 0; i < result_to_show.Length; i++)
                    //{

                    //    int num_val;
                    //    String s_buff;

                    //    num_val = (Int32)result_to_show[i];
                    //    s_buff = Convert.ToString(num_val, 16);
                    //    keyword_hex += s_buff.ToUpper();

                    //}
                   
                label_result.Text = result_to_show;
                label_signitures_num.Text = number_of_assigned_signitures.ToString();
                long microseconds = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                //time_label.Text = stopwatch.ElapsedMilliseconds.ToString() + " msec";
                time_label.Text = microseconds + " micro sec";
                memory_label.Text = mem_delta.ToString() + " bytes";
                
                
           
        }

        private void clear_all_state()
        {
            Signitures_list.Clear();
            packet_list.Clear();
            testAssembly = null;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browse_signitures_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.ShowDialog();
            if (opendialog.FileName == "")
            {
                MessageBox.Show("Failed to open the directory!");
                return;
            }
            Signitures_list = new List<string>();//to re-initialize the list (and clear them)
            System.IO.StreamReader file = null;
            try
            {
                file = new System.IO.StreamReader(opendialog.FileName);
                String Signiture_line;
                while ((Signiture_line = file.ReadLine()) != null)
                {
                    String tmp;
                    char buff;//to handle the current charachter being read
                    List<char> buff_array = new List<char>(); // to carry all charachters in this signiture
                    for (int i = 0; i < Signiture_line.Length - 1; i += 2)//step is 2 since we will read two hex digits at a time (1B) = 1 char
                    {
                        tmp = Signiture_line.Substring(i, 2);//take hex digits as string
                        UInt32 number = Convert.ToUInt32(tmp, 16);//convert them by calculating the decimal equivalent value
                        buff = (char)number; //convert the decimal value to its corresponding char (even if this char was unprintible one!)
                        buff_array.Add(buff);//add this char to overall char's in this signiture
                    }

                    Signitures_list.Add(new string(buff_array.ToArray()));//add the char representation of this char to the signitures list (notice the conversion from char[] to string)
                }


            }
            catch
            {
                MessageBox.Show("Error in reading the signitures input!");
                return;
            }
            finally
            {
                file.Close();
            }


        }

        private void browse_Click(object sender, EventArgs e)
        {
            sig_num = Int32.Parse(textBox1.Text);
            Signitures_list.Clear();
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.ShowDialog();
            if (opendialog.FileName == "")
            {
                MessageBox.Show("Failed to open the directory!");
                return;
            }
            Signitures_list.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(opendialog.FileName);
            String Signiture_line;
            try
            {
                int counter = 0;
                while ((Signiture_line = file.ReadLine()) != null)
                {
                    if (counter++ == sig_num) break; //once reaching sig_num stop adding signitures
                    String tmp;
                    char buff;//to handle the current charachter being read
                    List<char> buff_array = new List<char>(); // to carry all charachters in this signiture
                    for (int i = 0; i < Signiture_line.Length - 1; i += 2)//step is 2 since we will read two hex digits at a time (1B) = 1 char
                    {
                        tmp = Signiture_line.Substring(i, 2);//take hex digits as string
                        UInt32 number = Convert.ToUInt32(tmp, 16);//convert them by calculating the decimal equivalent value
                        buff = (char)number; //convert the decimal value to its corresponding char (even if this char was unprintible one!)
                        buff_array.Add(buff);//add this char to overall char's in this signiture
                    }

                    Signitures_list.Add(new string(buff_array.ToArray()));//add the char representation of this char to the signitures list (notice the conversion from char[] to string)
                }


            }
            catch
            {
                MessageBox.Show("Error in reading the packet input!");
                return;
            }
            finally
            {
                if(file != null)
                    file.Close();
            }
        }

        private void browse_packet_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.ShowDialog();
            if (opendialog.FileName == "")
            {
                MessageBox.Show("Failed to open the directory!");
                return;
            }

            packet_list.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(opendialog.FileName);
            String packet_line;
            try
            {
                while ((packet_line = file.ReadLine()) != null)
                {
                    String tmp;
                    char buff;//to handle the current charachter being read
                    List<char> buff_array = new List<char>(); // to carry all charachters in this signiture
                    for (int i = 0; i < packet_line.Length - 1; i += 2)//step is 2 since we will read two hex digits at a time (1B) = 1 char
                    {
                        tmp = packet_line.Substring(i, 2);//take hex digits as string
                        UInt32 number = Convert.ToUInt32(tmp, 16);//convert them by calculating the decimal equivalent value
                        buff = (char)number; //convert the decimal value to its corresponding char (even if this char was unprintible one!)
                        buff_array.Add(buff);//add this char to overall char's in this signiture
                    }

                    packet_list.Add(new string(buff_array.ToArray()));//add the char representation of this char to the packets list (notice the conversion from char[] to string)
                }
            }
            catch
            {
                MessageBox.Show("Error in reading the packet input!");
                return;
            }

            finally
            {
                file.Close();
            }
        }

        private void browse_dll_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "DLL files (*.dll)|*.dll";
            op.ShowDialog();
            if (op.FileName == "")
            {
                MessageBox.Show("DLL file wasn't browsed correctly!");
                return;
            }

            try
            {
                //load the dll file from the browsed location
                testAssembly = Assembly.LoadFile(op.FileName);
            }
            catch
            {
                MessageBox.Show("Error in opening the browsed DLL file");
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = "ladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladsdfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasl\ndfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfjladskfjasldfj";
        }
    }
}
