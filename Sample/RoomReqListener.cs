﻿using System;
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

namespace AppWarp_WP7_TestSDK
{
    public class RoomReqListener : com.shephertz.app42.gaming.multiplayer.client.listener.RoomRequestListener
    {
        private MainPage _page;

        public RoomReqListener(MainPage page)
        {
            _page = page;
        }

        public void onSubscribeRoomDone(RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                //WarpClient.GetInstance().SendChat("hello");
            }
        }

        public void onUnSubscribeRoomDone(RoomEvent eventObj)
        {
        }

        public void onJoinRoomDone(RoomEvent eventObj)
        {
            if (eventObj.getResult() == WarpResponseResultCode.SUCCESS)
            {
                _page.showResult("joined room!");
                //WarpClient.GetInstance().SubscribeRoom(eventObj.getData().getId());
            }
            else
            {
                _page.showResult("failed to join room!");
            }
        }

        public void onLeaveRoomDone(RoomEvent eventObj)
        {
        }

        public void onGetLiveRoomInfoDone(LiveRoomInfoEvent eventObj)
        {
            _page.showResult(eventObj.getCustomData());
        }

        public void onSetCustomRoomDataDone(LiveRoomInfoEvent eventObj)
        {
            //WarpClient.GetInstance().GetLiveRoomInfo(eventObj.getData().getId());
        }

    }
}
