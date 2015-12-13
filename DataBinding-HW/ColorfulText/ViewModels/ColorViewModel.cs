using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace ColorfulText.ViewModels
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        private string foregroundColor;
        private string backgroundColor;


        public event PropertyChangedEventHandler PropertyChanged;

        public string ForegroundColor
        {
            get { return this.foregroundColor; }
            set
            {
                if (this.foregroundColor != value)
                {
                    this.foregroundColor = value;
                    OnPropertyChanged("ForegroundColor");
                }
            }
        }

        public string BackgroundColor
        {
            get { return this.backgroundColor; }
            set
            {
                if (this.backgroundColor != value)
                {
                    this.backgroundColor = value;
                    OnPropertyChanged("BackgroundColor");
                }
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
