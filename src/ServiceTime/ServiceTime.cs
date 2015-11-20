using System;
using enosiX.App.Framework.Mobile;
using Xamarin.Forms;
using enosiX.App.Framework.Mobile.Navigation;
using ServiceTime.Pages;
using enosiX;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTime
{
	public interface IServiceTimeContext : IAppContext<IServiceTimeBusinessObjectContext>
	{
		string UserName { get; }
		DateTime StartDate { get; }
		int NumberOFWeeks { get;}
       
        
		Task WithContext (Func<IOnlineContext<IServiceTimeBusinessObjectContext>, Task> action, bool alertErrors = false, string successMessage = null);
	}

public class App : EnosixMobileApplication<ServiceTimeBusinessObjectContext, IServiceTimeBusinessObjectContext>, IServiceTimeContext
    {

        readonly ServiceOrderListViewModel _serviceOrderList;


        readonly SAPMessageNavigationItem messagesNavigationItem;

		static readonly BindableProperty IsBusyProperty = 
			BindableProperty.Create<App, bool> (b => b.IsBusy, false);

		public bool IsBusy { get { return (bool)GetValue(IsBusyProperty); } set { SetValue(IsBusyProperty, value); }}


        //creates binding for progress bar
		public static BindingBase IsBusyBindable
		{
			get
			{ 
				return new Binding (IsBusyProperty.PropertyName, source: Application.Current as App);
			}

		}


		public App ()
		{

            // http://www.materialpalette.com/teal/amber
            //sets enosix items color scheme in app
            EnosixStyles.Theme.DarkPrimaryColor = Color.FromHex("C2185B");
			EnosixStyles.Theme.PrimaryColor = Color.FromHex("CC2F86");
			EnosixStyles.Theme.LightPrimaryColor = Color.FromHex("F8BBD0");
			EnosixStyles.Theme.AccentColor = Color.FromHex("C2185B");
			EnosixStyles.Theme.AltTextColor = Color.White;
			EnosixStyles.Theme.SecondaryTextColor = Color.FromHex ("808285");
            //clears navigation screen
			NavigationItems.Clear ();
            //adds settings and messages item too navigation menu
            NavigationItems.Add(new SettingsNavigationItem());
            NavigationItems.Add(messagesNavigationItem = new SAPMessageNavigationItem(this)
            {
                Title = "Messages",
            });

            //sets the navigation menu page as the startup page
            var menu = new NavigationMenu();
            MainPage = menu;

            // service order page logic
            menu.sOrder = new ServiceOrderTimeEntryListPage()
            {
                BindingContext = (_serviceOrderList = new ServiceOrderListViewModel(this)),
                ItemSelectedCommand = new Command<ServiceOrderListViewModel.ServiceOrderListItemViewModel>(ShowDetailPage, item => null != item),
            };

        }


        public override string UserName
        {
            get
            {
               //returns the username set at login
                return base.UserName;
            }
        }

        //returns current date and time
        public DateTime StartDate {
			get {
				return DateTime.Now;
			}
		}
        //sets numnber of weeks to get
		public int NumberOFWeeks {
			get {
				return 3;
			}
		}


        //gets messages
        public async Task WithContext (Func<IOnlineContext<IServiceTimeBusinessObjectContext>, Task> action, bool alertErrors = false, string successMessage = null)
		{
			var messages = new List<MessageArgs> ();

			EventHandler<MessageArgs> handler = delegate (object sender, MessageArgs e)
			{
				messages.Add(e);
			};

			if (alertErrors) {
				this.OnlineContext.Messages += handler;
			}
			IsBusy = true;

			try{
				await base.WithContext (action);
			} finally
			{
				IsBusy = false;

				this.OnlineContext.Messages -= handler;
			}

			var firstMessage = messages.FirstOrDefault(m=>m.Type == MessageType.Error) ?? messages.FirstOrDefault(m=>m.Type == MessageType.Success) ?? messages.FirstOrDefault ();

			if (null != firstMessage) {
				bool showMessages = await this.MainPage.DisplayAlert (firstMessage.Type.ToString (), firstMessage.Type == MessageType.Success ? successMessage : firstMessage.Message, "Details", "Ok");
				if (showMessages) {
					messagesNavigationItem.Tapped ();
				}
			}
		}
        //after login go to 
		protected override void OnSuccessfulLogin (object sender, EventArgs e)
		{
            base.OnSuccessfulLogin(sender, e);

            _serviceOrderList.RefreshCommand.Execute(null);
            
        }


        //show the details page after we click on a service order in the list
		protected async void ShowDetailPage(ServiceOrderListViewModel.ServiceOrderListItemViewModel itemViewModel)
		{

			var detailVm = new ServiceOrderDetailViewModel (this);

			if (await detailVm.LoadFromListItem (itemViewModel)) {

				await Navigation.PushAsync (new ServiceOrderDetailPage {
					BindingContext = detailVm,
				});
			}
		}


    protected override void ConfigureContext (IOnlineContextConfiguration config)
		{
			base.ConfigureContext (config);

			config.CID = "SOENTRY";

			#if DEBUG
			//config.ConnectToServer("http://sap.n7d.enosix.com:8000?Client=800");
			//config.SetUserNameAndPassword("enosixtest", "Enosix01!");
			#endif
		}

		protected override void OnStart ()
		{
            // refeshes service order list which in turn prompts login
            _serviceOrderList.RefreshCommand.Execute(null);
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

