﻿using MaraudersAdventure.Zones.Etage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MaraudersAdventure
{
    /// <summary>
    /// Interaction logic for MapGame.xaml
    /// </summary>
    public partial class MapGame : Window
    {
        ConfigurationGame conf;
        MapDesign design;

        public MapGame(ConfigurationGame _conf)
        {
            InitializeComponent();
            conf = _conf;
            switch (conf.Plateau.mytype)
            {
                case MapType.etage:
                    design = new MapDesign(Properties.Resources.inconnu, Properties.Resources.herbe, Properties.Resources.arbre, Properties.Resources.objet);
                    break;
                case MapType.maraudeurs:
                    design = new MapDesign(Properties.Resources.inconnu, Properties.Resources.herbe, Properties.Resources.arbre, Properties.Resources.objet);
                    break;
                case MapType.standard:
                    design = new MapDesign(Properties.Resources.inconnu, Properties.Resources.herbe, Properties.Resources.arbre, Properties.Resources.objet);
                    break;
            }
            UpdateMapLayout();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        public void UpdateMapLayout()
        {
            ChessBoard.Children.Clear();
            for (int x = 0; x < 12; ++x)
            {
                for (int y = 0; y < 12; ++y)
                {
                    
                    ZoneAbstraite zone = conf.Plateau.GetZone(new Position(x, y));
                    List<ZoneAbstraite> meszones = conf.Plateau.GetNeighbourZones(zone.point);

                    ChessBoard.Children.Add(design.GetCaseImage(zone, conf.EquipeRouge.Joueurs, conf.EquipeVerte.Joueurs));
                    
                }
            }
            this.Refresh();
            UpdateLayout();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
