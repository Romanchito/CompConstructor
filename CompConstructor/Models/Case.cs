namespace CompConstructor.Models
{
    public class Case : ComputerItem
    {
        private string format;
        public string Format
        {
            get { return format; }
            set
            {
                format = value;
                OnPropertyChanged("Format");
            }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged("Height");
            }
        }

        private double length;
        public double Length
        {
            get { return length; }
            set
            {
                length = value;
                OnPropertyChanged("Length");
            }
        }
    }
}
