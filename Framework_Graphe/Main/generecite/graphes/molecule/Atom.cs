using System;

namespace Framework_Graphe
{
	public class Atom : GSommet<Liaison, Molecule, Atom>
	{
		public Atom (String name) : base(name)
		{
		}
	}
}

