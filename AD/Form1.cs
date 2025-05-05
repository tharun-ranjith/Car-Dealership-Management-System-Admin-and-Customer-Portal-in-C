using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD
{
    public partial class Form1 : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex = -1; // Initialize tempIndex
        private Form activeForm;

        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //methods
        private Color SelectThemecolor()
        {
            // Ensure that the list of colors is not empty
            if (Themecolor.ColorList.Count == 0)
                throw new InvalidOperationException("Color list is empty.");

            int index;
            do
            {
                index = random.Next(Themecolor.ColorList.Count);
            } while (tempIndex == index);

            tempIndex = index;

            // Convert hex string to Color
            string hexColor = Themecolor.ColorList[tempIndex];
            Color color = ColorTranslator.FromHtml(hexColor);

            return color;
        }

        private void ActivationButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button newButton)
            {
                if (currentButton != newButton)
                {
                    DisableButton();
                    Color color = SelectThemecolor();
                    currentButton = newButton;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = color;
                    currentButton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = Themecolor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn is Button btn)
                {
                    btn.BackColor = Color.DeepSkyBlue;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivationButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.CarForm(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.CarpartsForm(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.CustomerForm(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.CustomerOrderForm(), sender);
        }
    }
}
