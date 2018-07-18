using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App01_ConsultarCEP
{
	public partial class App : Application
	{
		public App () //inicio da classe
		{
			InitializeComponent();// carregao o arquivo xaml

			MainPage = new MainPage();// 1º pagina do aplicativo
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
