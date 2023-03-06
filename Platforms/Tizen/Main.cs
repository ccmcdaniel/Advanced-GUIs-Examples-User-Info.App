using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Advanced_GUIs_Examples_User_Info;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
