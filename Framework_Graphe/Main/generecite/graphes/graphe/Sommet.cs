using System;

namespace Framework_Graphe
{
	public class Sommet : GSommet<Arete, Graphe, Sommet>
	{
		public Sommet (String name) : base(name)
		{
		}
	}
}

