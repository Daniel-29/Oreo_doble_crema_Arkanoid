﻿using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
  public partial class Player : UserControl
  {
    //Se crean e inicializan las variables que contienen las imagenes del diseño
    private Form frm;
    private const string path = "../../Resources/";
    private Image title = new Bitmap(path+"nickname.png");
    private Image continuar = new Bitmap(path+"btn_continuar.png");
    private Image continuarh = new Bitmap(path+"btn_continuar_hover.png");
    
    public Player(Form frm)
    {
      this.frm = frm;
      InitializeComponent();
      //Se muestran las imagenes del titulo y el boton "Continuar"
      ptb_title.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_title.Image = title;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_continuar.Image = continuar;
    }

    private void ptb_continuar_Click(object sender, EventArgs e)
    {
      //Se valida que el nickname no se encuentre vacio
      if (!txt_nickname.Text.Equals(""))
      {
        //Se guarda el valor indicado de vidas que se eligieron en las variables
        Settings.Hearts = Convert.ToInt32(n_vidas.Text);
        Settings.HeartsTotal = Convert.ToInt32(n_vidas.Text);
        //Se muestra la pantalla de juego y se esconde la de jugador
        var game = new Game(txt_nickname.Text);
        game.Show();
        frm.Hide();
      }
      else
      {
        MessageBox.Show("Debe ingresar el Nickname.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ptb_continuar_MouseEnter(object sender, EventArgs e)
    {
      //Cambia la imagen del boton "Continuar" cuando el puntero se situa sobre el
      ptb_continuar.Image = continuarh;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_continuar_MouseLeave(object sender, EventArgs e)
    {
      //Cambia la imagen del boton "Continuar" cuando el puntero deja de estar sobre el
      ptb_continuar.Image = continuar;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}