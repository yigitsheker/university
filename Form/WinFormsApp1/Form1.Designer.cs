namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            centerPoints = new Label();
            lenght = new Label();
            numberOfEdge = new Label();
            rotationAngel = new Label();
            textBox_Point_x = new TextBox();
            textBox_lenght = new TextBox();
            textBox_Point_y = new TextBox();
            textBox_number_of_edge = new TextBox();
            textBox_rotation_angle = new TextBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            button_set_random_value = new Button();
            button_draw = new Button();
            button_rotate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // centerPoints
            // 
            centerPoints.AutoSize = true;
            centerPoints.Location = new Point(76, 32);
            centerPoints.Name = "centerPoints";
            centerPoints.Size = new Size(95, 20);
            centerPoints.TabIndex = 0;
            centerPoints.Text = "Center Points";
            centerPoints.Click += label1_Click;
            // 
            // lenght
            // 
            lenght.AutoSize = true;
            lenght.Location = new Point(76, 71);
            lenght.Name = "lenght";
            lenght.Size = new Size(54, 20);
            lenght.TabIndex = 1;
            lenght.Text = "Lenght";
            // 
            // numberOfEdge
            // 
            numberOfEdge.AutoSize = true;
            numberOfEdge.Location = new Point(76, 115);
            numberOfEdge.Name = "numberOfEdge";
            numberOfEdge.Size = new Size(119, 20);
            numberOfEdge.TabIndex = 2;
            numberOfEdge.Text = "Number of Edge";
            // 
            // rotationAngel
            // 
            rotationAngel.AutoSize = true;
            rotationAngel.Location = new Point(76, 159);
            rotationAngel.Name = "rotationAngel";
            rotationAngel.Size = new Size(109, 20);
            rotationAngel.TabIndex = 3;
            rotationAngel.Text = "Rotation Angle";
            // 
            // textBox_Point_x
            // 
            textBox_Point_x.Location = new Point(214, 29);
            textBox_Point_x.Name = "textBox_Point_x";
            textBox_Point_x.PlaceholderText = "0";
            textBox_Point_x.Size = new Size(125, 27);
            textBox_Point_x.TabIndex = 4;
            textBox_Point_x.TextChanged += textBox_Point_x_TextChanged;
            // 
            // textBox_lenght
            // 
            textBox_lenght.Location = new Point(214, 68);
            textBox_lenght.Name = "textBox_lenght";
            textBox_lenght.PlaceholderText = "4";
            textBox_lenght.Size = new Size(125, 27);
            textBox_lenght.TabIndex = 5;
            // 
            // textBox_Point_y
            // 
            textBox_Point_y.Location = new Point(357, 29);
            textBox_Point_y.Name = "textBox_Point_y";
            textBox_Point_y.PlaceholderText = "0";
            textBox_Point_y.Size = new Size(125, 27);
            textBox_Point_y.TabIndex = 6;
            // 
            // textBox_number_of_edge
            // 
            textBox_number_of_edge.Location = new Point(214, 112);
            textBox_number_of_edge.Name = "textBox_number_of_edge";
            textBox_number_of_edge.PlaceholderText = "5";
            textBox_number_of_edge.Size = new Size(125, 27);
            textBox_number_of_edge.TabIndex = 7;
            // 
            // textBox_rotation_angle
            // 
            textBox_rotation_angle.Location = new Point(214, 152);
            textBox_rotation_angle.Name = "textBox_rotation_angle";
            textBox_rotation_angle.PlaceholderText = "30";
            textBox_rotation_angle.Size = new Size(125, 27);
            textBox_rotation_angle.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(76, 264);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 184);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(509, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 419);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button_set_random_value
            // 
            button_set_random_value.Location = new Point(336, 264);
            button_set_random_value.Name = "button_set_random_value";
            button_set_random_value.Size = new Size(146, 29);
            button_set_random_value.TabIndex = 11;
            button_set_random_value.Text = "Set Random Value";
            button_set_random_value.UseVisualStyleBackColor = true;
            button_set_random_value.Click += button_set_random_value_Click;
            // 
            // button_draw
            // 
            button_draw.Location = new Point(357, 299);
            button_draw.Name = "button_draw";
            button_draw.Size = new Size(94, 29);
            button_draw.TabIndex = 12;
            button_draw.Text = "Draw";
            button_draw.UseVisualStyleBackColor = true;
            button_draw.Click += button_draw_Click;
            // 
            // button_rotate
            // 
            button_rotate.Location = new Point(357, 339);
            button_rotate.Name = "button_rotate";
            button_rotate.Size = new Size(94, 29);
            button_rotate.TabIndex = 13;
            button_rotate.Text = "Rotate";
            button_rotate.UseVisualStyleBackColor = true;
            button_rotate.Click += button_rotate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 588);
            Controls.Add(button_rotate);
            Controls.Add(button_draw);
            Controls.Add(button_set_random_value);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox_rotation_angle);
            Controls.Add(textBox_number_of_edge);
            Controls.Add(textBox_Point_y);
            Controls.Add(textBox_lenght);
            Controls.Add(textBox_Point_x);
            Controls.Add(rotationAngel);
            Controls.Add(numberOfEdge);
            Controls.Add(lenght);
            Controls.Add(centerPoints);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label centerPoints;
        private Label lenght;
        private Label numberOfEdge;
        private Label rotationAngel;
        private TextBox textBox_Point_x;
        private TextBox textBox_lenght;
        private TextBox textBox_Point_y;
        private TextBox textBox_number_of_edge;
        private TextBox textBox_rotation_angle;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button button_set_random_value;
        private Button button_draw;
        private Button button_rotate;
    }
}
