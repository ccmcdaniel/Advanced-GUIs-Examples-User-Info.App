namespace Advanced_GUIs_Examples_User_Info;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		
		//Load the states from the "states.txt" file 
		//Can be found in Resources->Raw
		FillStatesList();
		
		InitializeComponent();
	}

	/* This method fills in the State Picker control for the
	 * address with the list of states from states.txt in
	 * Resources->Raw.
	 * This method is asynchronous, meaning that it will
	 * run as a separate thread from the core program.
	 * We do not go into that in this course, but it is 
	 * here for syntax.
	 */
	public async void FillStatesList()
	{
		//Perform an asynchronous read from file.
		Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync("states.txt");
		StreamReader reader = new StreamReader(fileStream);

		//Store our states in this as we read them from the file.
		List<string> states = new List<string>();	
		
		string line;

		//Read the states from the file and store them
		//in the states list.
		while((line = reader.ReadLine()) != null)
		{
			states.Add(line);
		}
		
		//Populate the state picker control with the states read
		//in from the file.
		pckState.ItemsSource = states;
		pckState.ItemsSource = pckState.GetItemsAsArray();

		//close both file stream objects since we are finished
		//with the file.
		reader.Close();
		fileStream.Close();
	}

	
}

