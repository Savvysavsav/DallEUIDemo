
using DallEUIDemo.Models;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace DallEUIDemo.Views;

public partial class GenerationOptionsView : ContentPage
{
    public List<string> Options { get; set; }
    public List<ArtStyle> Styles { get; set; }
	public GenerationOptionsView()
	{
        InitializeComponent();
        FillOptions();
        BindingContext = this;

        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("My Customization", (handler, view) =>
        {
            #if ANDROID
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            #elif IOS || MACCATALYST
            #elif WINDOWS
            #endif
        });
    }

    private void FillOptions()
    {
        Options = new List<string>
        {
            "World",
            "Winter",
            "Trees"
        };
        Styles = new List<ArtStyle>()
        {
            new ArtStyle() {Name = "Cartoon", ImageURL = "cartoon.jpg"},
            new ArtStyle() {Name = "Realistic", ImageURL = "realistic.jpg"},
            new ArtStyle() {Name = "Watercolor Art", ImageURL = "watercolor.jpg"},
            new ArtStyle() {Name="Isometric", ImageURL="isometric.jpg"},
            new ArtStyle() {Name="Pop Art", ImageURL="popart.jpg"},
            new ArtStyle() {Name="Surrealism", ImageURL="surrealism.jpg"},
            new ArtStyle() {Name="Minimalism", ImageURL="minimalism.jpg"},
            new ArtStyle() {Name="Funko", ImageURL="funko.jpg"},
            new ArtStyle() {Name="Anime", ImageURL="anime.jpg"},
            new ArtStyle() {Name="Storybook", ImageURL="storybook.jpg"},
        };
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}