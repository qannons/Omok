using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePacketID : UInt16
{
    CHAT_MESSAGE = 0,
    ROOMS_MESSAGE = 1,
    CONTENT_MESSAGE = 2,
    ENTER_ROOM = 3,
    LOGIN_SUCCESS = 4,
    WINNER_MESSAGE = 5,
    QUIT_ROOM_MESSAGE = 6,
    MATCHMAKIING_MESSAGE = 7,
    MATCHMAKED_MESSAGE = 8,
    ROOM_CREATED_MESSAGE = 9,
    ENTER_FAST_ROOM = 10,
    MAKE_ROOM_MESSAGE = 11,
    MAKE_FAST_ROOM_MESSAGE = 12,
    GAME_START_MESSAGE = 13,
}

[Serializable]
public struct PacketHeader
{
    public UInt16 size;
    public UInt16 id; // 프로토콜ID (ex. 1=로그인, 2=이동요청)
}
