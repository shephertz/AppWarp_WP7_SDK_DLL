using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using com.shephertz.app42.gaming.multiplayer.client;

namespace AppWarp_WP7_TestSDK
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Console.WriteLine("Initializing Connection ###########");
            
            // Please update with the Api and Secret Key pair received when signing up.
            WarpClient.initialize("", "");
            //
            
            WarpClient game = WarpClient.GetInstance();
            game.AddConnectionRequestListener(new ConListen(this));
            game.AddZoneRequestListener(new ZoneReqListener(this));
            game.AddRoomRequestListener(new RoomReqListener(this));
            game.AddNotificationListener(new NotificationListener(this));
            game.AddLobbyRequestListener(new LobbyReqListen(this));
            //game.Connect();
        }

        public void showResult(String result)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                resutlBlock.Text = result;
            });
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            WarpClient.GetInstance().Connect();
        }
        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            resutlBlock.Text = "on auth clicked and name is " + inputBox.Text;
            WarpClient.GetInstance().JoinZone(inputBox.Text);
        }

        private void joinButton_Click(object sender, RoutedEventArgs e)
        {
            WarpClient.GetInstance().JoinRoom(this.inputJoinRoomIdBox.Text);
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {            
            WarpClient.GetInstance().CreateRoom(inputCreateRoomBox.Text, inputBox.Text, 5);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}