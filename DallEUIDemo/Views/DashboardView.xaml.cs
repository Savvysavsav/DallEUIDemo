using DallEUIDemo.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DallEUIDemo.Views;

public partial class DashboardView : ContentPage
{

	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
	public DashboardView()
	{
		InitializeComponent();
		LoadData();
		BindingContext = this;
	}

    private void LoadData()
    {
		Profiles = new ObservableCollection<Profile>
		{
			new Profile
			{
				Name = "Hector",
				ProfileImage="profile1.jpg",
				NoPhotos = 12
			},
			new Profile
			{
				Name = "Matt",
				ProfileImage = "profile2.jpg",
				NoPhotos = 3
			},
            new Profile
            {
                Name = "Savannah",
                ProfileImage = "profile3.jpg",
                NoPhotos = 67
            },
			new Profile
            {
                Name = "Tracy",
                ProfileImage = "profile4.jpg",
                NoPhotos = 19
            }
        };

		GeneratedImages = new ObservableCollection<GeneratedImage>
		{
			new GeneratedImage
			{
				ImagePath = "cityscape.jpg",
				Keywords = ["Dark","City","Anime"],
				MainKeyword = "Cityscape"
			},
            new GeneratedImage
            {
                ImagePath = "forestscape.jpg",
                Keywords = ["Fantasy","Forest","Glowing"],
                MainKeyword = "Forest"
            },
			new GeneratedImage
            {
                ImagePath = "desertscape.jpg",
                Keywords = ["Desert","Stars"],
                MainKeyword = "Desertscape"
            },
            new GeneratedImage
            {
                ImagePath = "ancientscape.jpg",
                Keywords = ["Abandoned","Glowing","Fountain"],
                MainKeyword = "Forest"
            }
        };
    }
}