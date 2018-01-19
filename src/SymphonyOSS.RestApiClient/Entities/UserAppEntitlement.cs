using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SymphonyOSS.RestApiClient.Entities
{
   public class UserAppEntitlement
    {
        /// <summary>Unique ID for the Application</summary>
        public string AppId { get; }

        /// <summary> Name for this Application </summary>
        public string AppName { get; }

        /// <summary>if true, it indicate this application is installed for this user.  Otherwise, this user does not have this application installed.</summary>
        public bool Install { get; }

        /// <summary>if true, this application will be listed in the appstore for this user.  Otherwise, this application will be hidden in the appstore.</summary>
        public bool Listed { get; }

        public ObservableCollection<Product> Products { get; }

        public UserAppEntitlement(string appId, string appName, bool install, bool listed, IEnumerable<Product> product)
        {
            AppId = appId;
            AppName = appName;
            Install = install;
            Listed = listed;
            Products = new ObservableCollection<Product>(product);
        }
    }
}
