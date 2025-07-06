using Microsoft.Maui.Controls;

namespace TIGApp;

public partial class NewPage1 : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public NewPage1()
	{
		InitializeComponent();
        if (File.Exists(_fileName))
        {
            //editor.Text = File.ReadAllText(_fileName);
        }
    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {

    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {

    }

    private void OnNormalTip(object sender, EventArgs e)
    {

    }

    private void OnGenerousTip(object sender, EventArgs e)
    {

    }
}