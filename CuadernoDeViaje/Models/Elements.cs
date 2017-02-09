using CuadernoDeViaje.ViewModels;

namespace CuadernoDeViaje.Models
{
    public class Elements : ViewModelBase
    {
        private string _textPost;
        private string _colorPost;

        public string TextPost
        {
            get { return _textPost; }
            set
                {
                    _textPost = value;
                    RaisePropertyChanged();
                }
        }

        public string ColorPost
        {
            get { return _colorPost; }
            set
                {
                    _colorPost = value;
                    RaisePropertyChanged();
                }
        }

    }
}
