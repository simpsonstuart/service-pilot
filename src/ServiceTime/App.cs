using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceTime.Pages;
using Xamarin.Forms;

namespace ServiceTime
{
    public class ServiceAPP : Application
    {
        /// <summary>
        ///   Returns the startup page.
        /// </summary>
        /// <returns>The main page.</returns>
		public ServiceAPP()
        {
            //sets navigation page as startup page
            NavigationPage mainNav = new NavigationPage(new NavigationMenu());
            MainPage = mainNav;
        }
    }
}
