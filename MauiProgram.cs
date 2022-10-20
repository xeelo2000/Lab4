namespace Lab4;

public static class MauiProgram
{
    /**
	Name: XEE LO
	Date: 10/19/2022
	Description: LAB 4
	Bugs: None that i know of
	Reflection: learned how to unit test
	*/
    public static IBusinessLogic ibl = new BusinessLogic();
    public static MauiApp CreateMauiApp()
	{

		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
