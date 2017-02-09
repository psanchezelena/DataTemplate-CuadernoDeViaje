namespace CuadernoDeViaje.Models
{
    public class TextDesign : ImageDesign
    {
        private string _titlePost;
        private string _subTitlePost;

        public string TitlePost
        {
            get { return _titlePost; }
            set
            {
                _titlePost = value;
                RaisePropertyChanged();
            }
        }

        public string SubTitlePost
        {
            get { return _subTitlePost; }
            set
            {
                 _subTitlePost = value;
                RaisePropertyChanged();
            }
        }


    }
}
