﻿namespace YuhanTalkModule
{

    public static class Protocols
    {
        // 클라이언트 -> 서버 
        public const byte C_REQ_LOGIN = 1;
        public const byte C_MSG = 2;
        public const byte C_REQ_SIGN_UP = 3;
        public const byte C_REQ_ROOM_LIST = 4;
        public const byte C_REQ_CHAT_LIST = 5;

        // 서버 -> 클라이언트 
        public const byte S_PING = 101;
        public const byte S_ERROR = 102;
        public const byte S_MSG = 103;
        public const byte S_RES_LOGIN = 104;
        public const byte S_RES_SIGN_UP = 105;
        public const byte S_RES_ROOM_LIST = 106;
        public const byte S_RES_CHAT_LIST = 107;

        
    }

}
