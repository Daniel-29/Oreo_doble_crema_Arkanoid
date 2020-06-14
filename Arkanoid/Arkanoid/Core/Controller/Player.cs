﻿namespace Arkanoid.Core.Controller
{
    public class Player
    {
        private Model.Player new_player;

        private int id_player;
        private string nickname;
        private int lifes;
    
        public Player()
        {
            new_player = new Model.Player();
        }

        public int IdPlayer
        {
            get => id_player;
            set => id_player = value;
        }

        public string Nickname
        {
            get => nickname;
            set => nickname = value;
        }

        public int Lifes
        {
            get => lifes;
            set => lifes = value;
        }

        public bool createPlayer()
        {
            new_player.Nickname = this.nickname;
            new_player.Lifes = this.lifes;
            if(new_player.insertPlayer())
            {
                id_player = new_player.IdPlayer;
                return true;
            }
            return false;
        }
    }
}