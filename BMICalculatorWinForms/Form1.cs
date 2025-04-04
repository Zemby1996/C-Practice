namespace BMICalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitForm();
            InitControls();
        }

        private void InitForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitControls()
        {
          
            this.cbWeight.Items.Add("kg");
            this.cbWeight.Items.Add("lbs");
            this.cbWeight.SelectedIndex = 0;

            this.cbHeight.Items.Add("cm");
            this.cbHeight.Items.Add("in");
            this.cbHeight.SelectedIndex = 0;

            this.tbResult.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHeight.Text) || string.IsNullOrEmpty(tbWeight.Text))
            {
                MessageBox.Show("Pola liczbowe musz¹ byæ uzupe³nione");
                return;
            }

            if (cbWeight.SelectedItem == null || cbHeight.SelectedItem == null)
            {
                MessageBox.Show("Musisz wybraæ jednostki dla wagi i wzrostu");
                return;
            }

            string result = CalculatorBMI.CalculateBMI(
                tbWeight.Text,
                cbWeight.SelectedItem?.ToString(),
                tbHeight.Text,
                cbHeight.SelectedItem?.ToString()
            );

            tbResult.Text = result;
        }
    }

    public class CalculatorBMI
    {
        public static string CalculateBMI(string weightText, string weightUnit, string heightText, string heightUnit)
        {
            try
            {
                double weight = double.Parse(weightText);
                double height = double.Parse(heightText);

                
                if (weightUnit == "lbs") weight *= 0.453592;
                if (heightUnit == "in") height *= 0.0254;
                if (heightUnit == "cm") height /= 100.0;

                if (height <= 0)
                    throw new ArgumentException("Wzrost musi byæ wiêkszy od zera");
                if (weight <= 0)
                    throw new ArgumentException("Waga musi byæ wiêksza od zera");

                double bmi = weight / (height * height);
                return $"BMI: {bmi:F2} {weightUnit}/{heightUnit}^2 ";
            }
            catch (FormatException)
            {
                return "Niepoprawny format danych (u¿yj liczb)";
            }
            catch (Exception ex)
            {
                return $"B³¹d: {ex.Message}";
            }
        }
    }
}