using System;
using Enemy;
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

    
    }

}
