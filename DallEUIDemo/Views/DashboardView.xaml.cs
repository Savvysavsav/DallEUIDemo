using DallEUIDemo.Models;
using System.Collections.ObjectModel;

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
				ImagePath = "dark_forest.jpg",
				Keywords = ["Dark","Forest","Green"],
				MainKeyword = "Forest"
			},
            new GeneratedImage
            {
                ImagePath = "forest.jpg",
                Keywords = ["Dark","Forest","Gold"],
                MainKeyword = "Forest"
            },
			new GeneratedImage
            {
                ImagePath = "forest_fantasy.jpg",
                Keywords = ["Dark","Forest","Teal"],
                MainKeyword = "Forest"
            },
            new GeneratedImage
            {
                ImagePath = "forest_lifeline.jpg",
                Keywords = ["Dark","Purple","Green"],
                MainKeyword = "Forest"
            }
        };
    }
}