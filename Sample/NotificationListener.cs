using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using com.shephertz.app42.gaming.multiplayer.client.events;
using com.shephertz.app42.gaming.multiplayer.client.command;
using com.shephertz.app42.gaming.multiplayer.client;
using System.Collections.Generic;

namespace AppWarp_WP7_TestSDK
{
    public class NotificationListener : com.shephertz.app42.gaming.multiplayer.client.listener.NotifyListener
    {
        private MainPage _page;

        public NotificationListener(MainPage page)
        {
            _page = page;
        }

        public void onRoomCreated(RoomData eventObj)
        {
        }
        public void onRoomDestroyed(RoomData eventObj)
        {
        }
        public void onUserLeftRoom(RoomData eventObj, String username)
        {
        }
        public void onUserJoinedRoom(RoomData eventObj, String username)
        {
            _page.showResult(username + " joined " + eventObj.getId());
        }

        public void onUserLeftLobby(LobbyData eventObj, String username)
        {
        }
        public void onUserJoinedLobby(LobbyData eventObj, String username)
        {
        }

        public void onChatReceived(ChatEvent eventObj)
        {
            _page.showResult("chat from " + eventObj.getSender() + " msg " + eventObj.getMessage() + " id "+eventObj.getLocationId() + eventObj.isLocationLobby());
            WarpClient.GetInstance().GetLiveLobbyInfo();
        }
        public void onUpdatePeersReceived(UpdateEvent eventObj)
        {
            string j = System.Text.UTF8Encoding.UTF8.GetString(eventObj.getUpdate(), 0, eventObj.getUpdate().Length);
            _page.showResult("update recvd " + j );
        }
        public void onUserChangeRoomProperty(RoomData roomData, string sender, Dictionary<String, Object> properties)
        {
            _page.showResult("Notification for User Changed Room Propert received");
            _page.showResult(roomData.getId());
            _page.showResult(sender);
            foreach (KeyValuePair<string, object> entry in properties)
            {
                _page.showResult("KEY:" + entry.Key);
                _page.showResult("VALUE:" + entry.Value.ToString());
            }
        }
    }
}
