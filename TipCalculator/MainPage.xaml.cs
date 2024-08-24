namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public object LablPersent { get; private set; }
        public object LablPercent { get; private set; }
        public object TipPercentLabel { get; private set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Label_SizeChanged(object sender, EventArgs e)
        {

        }

        private void setLowTip_Clicked(object sender, EventArgs e)
        {
            tipSLider.Value = 15;
            TipsPercentLabel.Text = tipSLider.Value.ToString();

        }

        private void setHighTip_Clicked(object sender, EventArgs e)
        {
            tipSLider.Value = 20;
            TipsPercentLabel.Text = tipSLider.Value.ToString();
        }

        private void RoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundDown_Clicked(object sender, EventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipsPercentLabel.Text = tipSLider.Value.ToString("#.##") + "%";
        }
    }
    }


