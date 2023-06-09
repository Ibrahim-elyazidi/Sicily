﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Secteur
    {
        private string id;
        private string libelle;
       

        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        public string Libelle { get => libelle; set => libelle = value; }

        // remplace getId()
        public string Id { get => id; }


        public Secteur(string unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }

        // Constructeur vide
        public Secteur()
        {


        }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.libelle;
        }
    }
}
