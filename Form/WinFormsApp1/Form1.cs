/************************************************************************************************************************************************
                                 STUDENT NAME: YÝÐÝT ÞEKER
                                 STUDENT NUMBER: B221202063
*************************************************************************************************************************************************
*/
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private PointF[] polygonPoints;
        private int centerX, centerY, length, edges, angle;
        private const int ScaleFactor = 20;
        public Form1()
        {
            InitializeComponent();
            InitializeDefaults();
        }
        private void InitializeDefaults()
        {
            textBox_Point_x.Text = "0";
            textBox_Point_y.Text = "0";
            textBox_lenght.Text = "4";
            textBox_number_of_edge.Text = "5";
            textBox_rotation_angle.Text = "30";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Point_x_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_draw_Click(object sender, EventArgs e)
        {
            centerX = int.Parse(textBox_Point_x.Text);// Takes the texts from text boxes
            centerY = int.Parse(textBox_Point_y.Text);
            length = int.Parse(textBox_lenght.Text);
            edges = int.Parse(textBox_number_of_edge.Text);
            angle = 0;

            DrawPolygon();
        }
        private void DrawPolygon() // The method that drawing the polygon points
        {
            int width = pictureBox1.Width;// Get the width of the picture box.
            int height = pictureBox1.Height;// Get the height of the picture box.
            int centerX = width / 2;// Calculate the center X coordinate of the picture box.
            int centerY = height / 2;// Calculate the center Y coordinate of the picture box.

            polygonPoints = CalculatePolygonPoints(centerX, centerY, length * ScaleFactor, edges, angle);// Calculate the polygon points with the given center, length, number of edges, and angle.

            pictureBox1.Invalidate();
            pictureBox1.Paint += new PaintEventHandler(DrawPolygonOnPictureBox);// Attach the Paint to the picture box to draw the polygon.
            listBox1.Items.Clear();// Clear the list box to remove any previous items.
            foreach (var point in polygonPoints) // Iterate over each point in the polygonPoints array.
            {
                listBox1.Items.Add($"({point.X}, {point.Y})"); // Add the point coordinates to the list box in the format (X, Y).
            }
        }
        private PointF[] CalculatePolygonPoints(int centerX, int centerY, int length, int edges, int angle)
        {
            PointF[] points = new PointF[edges]; // A PointF array that keeps edges coordinates 
            double step = 360.0 / edges;// Calculate the angle step in degrees between each vertex
            double radianAngle = Math.PI * angle / 180.0;

            for (int i = 0; i < edges; i++)// Loop to calculate the coordinates of each vertex.
            {
                double theta = step * i + angle;// Calculate the angle for the current vertex in degrees and add the input angle.
                double radian = Math.PI * theta / 180.0;// Convert the angle to radians.
                float x = centerX + (float)(length * Math.Cos(radian));// Calculate the x-coordinate of the vertex.
                float y = centerY + (float)(length * Math.Sin(radian));// Calculate the y-coordinate of the vertex.
                points[i] = new PointF(x, y);
            }

            return points;
        }

        private void DrawPolygonOnPictureBox(object sender, PaintEventArgs e)
        {
            if (polygonPoints == null || polygonPoints.Length < 2) return; //We don't want that polygon points equals to null or less than two so we are checking if we are gettin the right thing or right way or not

            e.Graphics.Clear(pictureBox1.BackColor); //This clears all drawings that created before
            e.Graphics.DrawPolygon(Pens.Black, polygonPoints);//Draws polygon points with the color of black
        }
        public class Point2D
        {

            private double x, y;
            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }

            public double r { set; get; }
            public double theta { set; get; }

            public Point2D()// First Constructor as mentioned in the instructions
            {
                x = 0;
                y = 0;

            }

            public Point2D(int _x, int _y)// Second Constructor as mentioned in the instructions
            {
                x = _x;
                y = _y;
            }

            public void PrintCoordinates() // The method that prints the center point coordinates. 
            {
                Console.WriteLine("Center Point Coordinates x:" + x + " y: " + y);
            }

            public void calculatePolarCoordinates() // The method that calculates the polar coordinates form the center point
            {
                r = Math.Sqrt(x * x + y * y);
                theta = Math.Atan2(y, x);
            }
            public void calculateCartesianCoordinates() // The method that calculates cartesian coordinates from polar coordinates and print
            {
                x = (int)(r * Math.Cos(theta));
                y = (int)(r * Math.Sin(theta));
                Console.WriteLine("Cartesian Coordinates: (" + x + ", " + y + ")");
            }
            public void PrintPolarCoordinates()
            {
                Console.WriteLine("Polar Coordinates P(" + r + "," + theta + ")");
            }
        }
        public class Polygon
        {
            public Point2D center = new Point2D(0, 0);
            public int length;
            public int numberOfEdges;
            public Point2D[] edgeCoordinates;

            public Polygon() // First Constructor as mentioned in the instructions
            {
                length = numberOfEdges = 0;
                edgeCoordinates = new Point2D[numberOfEdges];
            }
            public Polygon(Point2D _center, int _length, int _numberOfEdges) // Second Constructor as mentioned in the instructions
            {
                center = _center;
                length = _length;
                numberOfEdges = _numberOfEdges;
                edgeCoordinates = new Point2D[numberOfEdges];
                CalculateEdgeCoordinates();
            }
            public void CalculateEdgeCoordinates() // The method that calculates the coordinates of each edge
            {
                double angle = 0;
                double angleIncrement = 2 * Math.PI / numberOfEdges;// Calculate the angle increment between each vertex in radians.
                double x, y;

                for (int i = 0; i < numberOfEdges; i++)// Loop through each edge to calculate its coordinates.
                {
                    x = center.X + length * Math.Cos(angle);// Calculate the x-coordinate of the vertex.
                    y = center.Y + length * Math.Sin(angle);// Calculate the y-coordinate of the vertex.
                }
            }
            public void RotatePolygon(double angle)
            {
                double rotationMatrixX = Math.Cos(angle);// Calculate the cosine of the rotation angle.
                double rotationMatrixY = Math.Sin(angle);// Calculate the sine of the rotation angle.

                foreach (Point2D point in edgeCoordinates)// Loop through each vertex in the edgeCoordinates array.
                {
                    double x = point.X * rotationMatrixX - point.Y * rotationMatrixY; // Apply the rotation matrix to the x-coordinate.
                    double y = point.X * rotationMatrixY + point.Y * rotationMatrixX; // Apply the rotation matrix to the y-coordinate.
                    point.X = x;
                    point.Y = y;
                }
            }
        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            if (polygonPoints == null)
            {
                MessageBox.Show("No polygon drawn to rotate!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);// If there is noothing to rotate printing a error message
                return;
            }

            angle += int.Parse(textBox_rotation_angle.Text); // Add the new angle to the current angle
            DrawPolygon();
        }

        private void button_set_random_value_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox_Point_x.Text = rnd.Next(0, 4).ToString(); // Sets a random number between 0-4 and assigning it to the center points x
            textBox_Point_y.Text = rnd.Next(0, 4).ToString();// Sets a random number between 0-4 and assigning it to the center points y
            textBox_lenght.Text = rnd.Next(3, 10).ToString(); // Sets a random number between 3-10 and assigning it to the lenght
            textBox_number_of_edge.Text = rnd.Next(3, 11).ToString();// Set a random number between 3-11 and assigning it to the edge number
            textBox_rotation_angle.Text = rnd.Next(0, 360).ToString();// Set a random number between 0-360 and assigning it to the angle that we want to rotate
        }
    }
}
