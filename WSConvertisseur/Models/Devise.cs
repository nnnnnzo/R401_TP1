﻿namespace WSConvertisseur.Models
{
    public class Devise
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string? nomDevise;

		public string? NomDevise
		{
			get { return nomDevise; }
			set { nomDevise = value; }
		}

		private int taux;

		public int Taux
		{
			get { return taux; }
			set { taux = value; }
		}

		public Devise()
		{

		}

        public Devise(int id, string? nomDevise, int taux)
        {
            Id = id;
            NomDevise = nomDevise;
            Taux = taux;
        }
    }
}