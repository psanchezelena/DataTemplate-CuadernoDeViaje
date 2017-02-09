namespace CuadernoDeViaje.Models
{
    public class ImageDesign : Elements 
    {
        private string _pathImage;

        public string PathImage
        {
            get { return _pathImage; }
            set
            {
                _pathImage = value;
                RaisePropertyChanged();
            }
        }

    }
}
