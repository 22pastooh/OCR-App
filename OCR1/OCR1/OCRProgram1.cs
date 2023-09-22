using IronOcr;

namespace OCR1
{
    public partial class OCRProgram : Form
    {
        private string textBoxText = "";

        public OCRProgram()
        {
            InitializeComponent();
        }
        private void SavePath_Click(object sender, EventArgs e)
        {
            textBoxText = richTextBox1.Text;
        }

        private void ClearPath_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBoxText = richTextBox1.Text;
        }

        private void PerformOCR_Click(object sender, EventArgs e)
        {
            // Set the coordinates and dimensions for the capture area
            int startX = 304; // X-coordinate of the top-left corner
            int startY = 988; // Y-coordinate of the top-left corner
            int width = 182; // Width of the capture area
            int height = 17; // Height of the capture area

            try
            {
                // Create a bitmap to hold the captured image
                using (Bitmap bitmap = new Bitmap(width, height))
                {
                    // Create a Graphics object to draw on the bitmap
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // Capture the screen area and draw it onto the bitmap
                        g.CopyFromScreen(startX, startY, 0, 0, new System.Drawing.Size(width, height));
                    }

                    // Get the path to the executable directory
                    string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                    // Combine the executable path with the file name for the screenshot
                    string screenshotPath = Path.Combine(executablePath, "Screenshot.png");

                    // Delete screenshot if it exists
                    if (File.Exists(screenshotPath))
                    {
                        File.Delete(screenshotPath);
                    }

                    // Save the captured image to the executable directory
                    bitmap.Save(screenshotPath, System.Drawing.Imaging.ImageFormat.Png);

                    // Perform OCR on the captured image
                    var iron_ocr = new IronTesseract();
                    var result = iron_ocr.Read(screenshotPath);
                    richTextBox1.Text = textBoxText + "\\" + result.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during OCR: " + ex.Message);
            }
        }
    }
}
