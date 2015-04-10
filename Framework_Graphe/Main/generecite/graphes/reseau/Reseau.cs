using System;

namespace Framework_Graphe
{
	public class Reseau : GGraphe<Noeud, Lien, Reseau>
	{
		public Reseau (String name) : base(name)
		{
		}
	}
}

