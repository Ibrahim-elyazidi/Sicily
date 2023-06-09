﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;


namespace Connecte.Controleur
{
    public class Mgr
    {

        LiaisonDAO liaiDAO = new LiaisonDAO();
        SecteurDAO sectDAO = new SecteurDAO();


        List<Liaison> MaListeLiaison;

        List<Secteur> MaListeSecteur;

        public Mgr()
        {

            MaListeLiaison = new List<Liaison>();
            MaListeSecteur = new List<Secteur>();
        }



        // Récupération de la liste des liaisons à partir de la DAL
        public List<Liaison> chargementLiaiBD(string id, string name)
        {

            MaListeLiaison = LiaisonDAO.GetLiaison(id, name);

            return (MaListeLiaison);
        }


        public List<Secteur> chargementSectBD()
        {

            MaListeSecteur = SecteurDAO.GetSecteur();

            return (MaListeSecteur);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateLiaison(Liaison l, string id, string name)
        {

            LiaisonDAO.updateLiaison(l,id,name);

        }

        internal void updateLiai(List<Liaison> lLiai)
        {
            throw new NotImplementedException();
        }

        public void deleteLiaison(Liaison l, string id, string name)
        {

            LiaisonDAO.deleteLiaison(l, id, name);

        }
    }
    

    }

