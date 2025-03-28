using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        Enemy[] nRoom;
        Hardness difficulty;

        public GameLevel (int nRoom , Hardness difficulty)
        {
            this.nRooms = new Enemy[nRooms];
            this.difficulty = difficulty;
        }
        
        public void SetEnemyInRoom(int RoomInd,Enemy enemy )
        {
            nRoom[RoomInd] = enemy
        }
        public Hardness GetHardness() => difficulty;
        public int GetNumRooms() => nRooms.Length;

        public int GetNumEnemies()
        {
            int nEnemies = 0;
            foreach (Enemy en in nRooms)
            {
                if (en != null)
                    nEnemies++;
            }
            return nEnemies;
        }
          public void PrintEnemies()
        {
            for (int i = 0; i < nRooms.Length; i++)
            {
                if (nRooms[i] != null)
                {
                    Console.WriteLine($"ROOM {i.ToRoman()}: " + nRooms[i].GetName());
                }
            }
        }
    }
}
