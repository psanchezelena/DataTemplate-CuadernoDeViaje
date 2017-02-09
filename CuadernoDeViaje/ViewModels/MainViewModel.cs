using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CuadernoDeViaje.Command;
using CuadernoDeViaje.Models;

namespace CuadernoDeViaje.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private const string LaoTse = "El viaje más largo comienza con un paso";
        private const string LinkBlog = "geeks.ms/windowsplatform";
        private const string ItemTextPost = "Aprovecha al máximo tus items con data template";
        private const string ItemTitlePost = "Hi";

        public ObservableCollection<Elements> AddElements { get; } = new ObservableCollection<Elements>();
        readonly Random _random = new Random();
        private string [] _pathImagesList;
        private string[] _colorsRandom;
        
        public MainViewModel()
        {
            LoadAssets();
        }

        public ICommand CreateTextDesignCommand => new RelayCommand(CreateTextDesign);
        public ICommand CreateImageDesignCommand => new RelayCommand(CreateImageDesign);
        public ICommand CreateTextImageDesignCommand => new RelayCommand(CreateTextImageDesign);


        public void CreateTextDesign(object sender)
        {
            AddElements.Add(new Elements
                {   TextPost= LaoTse ,
                    ColorPost = _colorsRandom[_random.Next(6)] });
        }

        public void CreateImageDesign(object parameter)
        {
            AddElements.Add(new ImageDesign
                {   ColorPost = _colorsRandom[_random.Next(6)],
                    PathImage = _pathImagesList[_random.Next(6)] });
        }

        public void CreateTextImageDesign(object parameter)
        {
            AddElements.Add(new TextDesign
                {   TextPost = ItemTextPost,
                    TitlePost = ItemTitlePost,
                    SubTitlePost = LinkBlog, ColorPost = _colorsRandom[_random.Next(6)],
                    PathImage = _pathImagesList[_random.Next(6)] });
        }

        private void LoadAssets()
        {
            _pathImagesList = new string[]
            {
                "/Assets/Images/image1.jpg","/Assets/Images/image2.jpg","/Assets/Images/image3.jpg","/Assets/Images/image4.jpg","/Assets/Images/image5.jpg","/Assets/Images/image6.jpg"
            };

            _colorsRandom = new string[]
            {
                "#6D7F77","#6CA174","#FFE35E","#FC9381","#AECCBE","#45689C",
            };
        }
    }
}
