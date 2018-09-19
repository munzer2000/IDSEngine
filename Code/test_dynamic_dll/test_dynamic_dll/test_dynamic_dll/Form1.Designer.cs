namespace test_dynamic_dll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_namespace = new System.Windows.Forms.TextBox();
            this.textBox_className = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_method1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_method2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.browse_packet = new System.Windows.Forms.Button();
            this.browse_dll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_signitures_num = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.radio_int = new System.Windows.Forms.RadioButton();
            this.radio_string = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.memory_label = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Information about the environment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Namespace:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class:";
            // 
            // textBox_namespace
            // 
            this.textBox_namespace.Location = new System.Drawing.Point(427, 75);
            this.textBox_namespace.Name = "textBox_namespace";
            this.textBox_namespace.Size = new System.Drawing.Size(100, 20);
            this.textBox_namespace.TabIndex = 4;
            this.textBox_namespace.Text = "Alg";
            // 
            // textBox_className
            // 
            this.textBox_className.Location = new System.Drawing.Point(427, 104);
            this.textBox_className.Name = "textBox_className";
            this.textBox_className.Size = new System.Drawing.Size(100, 20);
            this.textBox_className.TabIndex = 5;
            this.textBox_className.Text = "Class1";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(608, 440);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 1;
            this.lineShape2.X2 = 286;
            this.lineShape2.Y1 = 137;
            this.lineShape2.Y2 = 137;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 287;
            this.lineShape1.X2 = 288;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 440;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Should have these two methods with this format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "public static int";
            // 
            // textBox_method1
            // 
            this.textBox_method1.Location = new System.Drawing.Point(376, 187);
            this.textBox_method1.Name = "textBox_method1";
            this.textBox_method1.Size = new System.Drawing.Size(99, 20);
            this.textBox_method1.TabIndex = 9;
            this.textBox_method1.Text = "PreProcessing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(string[] signiture_list)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "**Take array of signitures to search for";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "**Return number of signitures that was assigned succesfully";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "**Return the index of signiture that was found, or -1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "**Take String representing the packet to search in";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "(String packet)";
            // 
            // textBox_method2
            // 
            this.textBox_method2.Location = new System.Drawing.Point(419, 301);
            this.textBox_method2.Name = "textBox_method2";
            this.textBox_method2.Size = new System.Drawing.Size(99, 20);
            this.textBox_method2.TabIndex = 14;
            this.textBox_method2.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(293, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "public static";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(12, 13);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(107, 23);
            this.browse.TabIndex = 19;
            this.browse.Text = "Browse Signitures";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // browse_packet
            // 
            this.browse_packet.Location = new System.Drawing.Point(12, 43);
            this.browse_packet.Name = "browse_packet";
            this.browse_packet.Size = new System.Drawing.Size(107, 23);
            this.browse_packet.TabIndex = 20;
            this.browse_packet.Text = "Browse Packet";
            this.browse_packet.UseVisualStyleBackColor = true;
            this.browse_packet.Click += new System.EventHandler(this.browse_packet_Click);
            // 
            // browse_dll
            // 
            this.browse_dll.Location = new System.Drawing.Point(12, 74);
            this.browse_dll.Name = "browse_dll";
            this.browse_dll.Size = new System.Drawing.Size(107, 23);
            this.browse_dll.TabIndex = 21;
            this.browse_dll.Text = "Browse DLL";
            this.browse_dll.UseVisualStyleBackColor = true;
            this.browse_dll.Click += new System.EventHandler(this.browse_dll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(8, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Results";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "number of signitures assigned:";
            // 
            // label_signitures_num
            // 
            this.label_signitures_num.AutoSize = true;
            this.label_signitures_num.Location = new System.Drawing.Point(169, 177);
            this.label_signitures_num.Name = "label_signitures_num";
            this.label_signitures_num.Size = new System.Drawing.Size(16, 13);
            this.label_signitures_num.TabIndex = 24;
            this.label_signitures_num.Text = "...";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(219, 208);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(19, 13);
            this.label_result.TabIndex = 26;
            this.label_result.Text = "....";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "number of signitures found in the packet:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label15.Location = new System.Drawing.Point(125, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 12);
            this.label15.TabIndex = 27;
            this.label15.Text = "only one string per line (signiture)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 7F);
            this.label16.Location = new System.Drawing.Point(125, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "only one string  (packet)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(301, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(290, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Please make sure to fill these before clicking the Run button";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 406);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "**Or Return the the signiture found, or \"\"";
            // 
            // radio_int
            // 
            this.radio_int.AutoSize = true;
            this.radio_int.Location = new System.Drawing.Point(360, 316);
            this.radio_int.Name = "radio_int";
            this.radio_int.Size = new System.Drawing.Size(36, 17);
            this.radio_int.TabIndex = 31;
            this.radio_int.Text = "int";
            this.radio_int.UseVisualStyleBackColor = true;
            // 
            // radio_string
            // 
            this.radio_string.AutoSize = true;
            this.radio_string.Checked = true;
            this.radio_string.Location = new System.Drawing.Point(360, 294);
            this.radio_string.Name = "radio_string";
            this.radio_string.Size = new System.Drawing.Size(52, 17);
            this.radio_string.TabIndex = 32;
            this.radio_string.TabStop = true;
            this.radio_string.Text = "String";
            this.radio_string.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Generate result file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Execution time:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(99, 294);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 13);
            this.time_label.TabIndex = 36;
            // 
            // memory_label
            // 
            this.memory_label.AutoSize = true;
            this.memory_label.Location = new System.Drawing.Point(99, 318);
            this.memory_label.Name = "memory_label";
            this.memory_label.Size = new System.Drawing.Size(0, 13);
            this.memory_label.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 318);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Memory:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(164, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "# of signitures (-1 for all)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 440);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.memory_label);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radio_string);
            this.Controls.Add(this.radio_int);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label_signitures_num);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.browse_dll);
            this.Controls.Add(this.browse_packet);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_method2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_method1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_className);
            this.Controls.Add(this.textBox_namespace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_namespace;
        private System.Windows.Forms.TextBox textBox_className;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_method1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_method2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button browse_packet;
        private System.Windows.Forms.Button browse_dll;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_signitures_num;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radio_int;
        private System.Windows.Forms.RadioButton radio_string;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label memory_label;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox1;
    }
}

