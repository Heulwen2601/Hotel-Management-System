﻿using HotelManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        #region Method

        internal DataTable LoadFullRoom()
        {
            return DataProvider.Instance.ExecuteQuery("USP_LoadFullRoom");
        }
        internal bool InsertRoom(Room roomNow)
        {
            return InsertRoom(roomNow.Name, roomNow.IdRoomType, roomNow.IdStatusRoom);
        }
        internal bool InsertRoom(string roomName, int idRoomType, int idStatusRoom)
        {
            string query = "USP_InsertRoom @nameRoom , @idRoomType , @idStatusRoom";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { roomName, idRoomType, idStatusRoom }) > 0;
        }
        internal bool UpdateCustomer(Room roomNow)
        {
            string query = "USP_UpdateRoom  @id , @nameRoom , @idRoomType , @idStatusRoom";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { roomNow.Id, roomNow.Name, roomNow.IdRoomType, roomNow.IdStatusRoom }) > 0;
        }
        internal DataTable Search(string roomName, int idBookRoom)
        {
            string query = "USP_SearchRoom @roomName, @idBookRoom";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { roomName, idBookRoom });
        }
        public List<Room> LoadEmptyRoom(int idRoomType)
        {
            List<Room> rooms = new List<Room>();
            string query = "USP_LoadEmptyRoom @idRoomType";
            DataTable data = DataProvider.Instance.ExecuteQuery(query,new object[] { idRoomType });
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                rooms.Add(room);
            }
            return rooms;
        }
        public List<Room> LoadListFullRoom()
        {
            string query = "USP_LoadListFullRoom @getToday";
            List<Room> rooms = new List<Room>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {DateTime.Now.Date });
            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                rooms.Add(room);
            }
            return rooms;
        }
        public int GetPeoples(int idBill)
        {
            string query = "USP_GetPeoples @idBill";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idBill })+1;
        }

        public int GetIdRoomByRoomName(string roomName)
        {
            string query = "USP_GetIdRoomByRoomName @roomName";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { roomName });
        }
        public int GetIdRoomFromReceiveRoom(int idReceiveRoom)
        {
            string query = "USP_GetIDRoomFromReceiveRoom @idReceiveRoom";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { idReceiveRoom });
        }
        public bool UpdateStatusRoom(int idRoom, string idCardCustomer)
        {
            string query = "USP_UpdateStatusRoom @idRoom , @idCardCustomer";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { idRoom, idCardCustomer }) > 0;
        }

        public bool UpdateIDCustomerBookRoom(int idRoom, string idCardCustomer)
        {
            string query = "USP_UpdateIDCustomBookRoom @roomName , @idCardCustomer";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { idRoom, idCardCustomer }) > 0;
        }
        #endregion

        public static RoomDAO Instance { get {if(instance==null) instance=new RoomDAO();return instance; }
            private set => instance = value; }
        private RoomDAO() { }
    }
}
