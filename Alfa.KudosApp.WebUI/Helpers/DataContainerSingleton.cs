using Alfa.KudosApp.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Alfa.KudosApp.Helpers
{
    public class DataContainerSingleton
    {
        private static DataContainerSingleton instance = null;
        private static readonly object padlock = new object();

        public static List<User> LstUsers = new List<User>
        {
            new User{Id=1,Name="Jason",KudosCount=6},
            new User{Id=6,Name="Sabuj",KudosCount=9},
            new User{Id=6,Name="James",KudosCount=8},
            new User{Id=3,Name="Eric",KudosCount=9},
            new User{Id=5,Name="Hilary",KudosCount=15},
            new User{Id=8,Name="Charles",KudosCount=9},
            new User{Id=9,Name="Deepa",KudosCount=10},
            new User{Id=10,Name="Jake",KudosCount=6},
            new User{Id=11,Name="Mathews",KudosCount=5},
            new User{Id=12,Name="Khalid",KudosCount=8},
            new User{Id=13,Name="Karthik",KudosCount=9},
            new User{Id=14,Name="Prasanth",KudosCount=5}
        };

        public static List<Comments> LstComments = new List<Comments>
        {
            new Comments{ProviderId=2,ReceiverId=3,Comment="Good Support for Production Tickets",ProviderName="Laura",ReceiverName="Eric"},
            new Comments{ProviderId=1,ReceiverId=13,Comment="Great work on emergency releases",ProviderName="Jason",ReceiverName="Karthik"},
            new Comments{ProviderId=10,ReceiverId=4,Comment="Awesome Alfa Link Enhancements",ProviderName="Jake",ReceiverName="Charles"}
        };

        DataContainerSingleton()
        {

        }

        public static DataContainerSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataContainerSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}