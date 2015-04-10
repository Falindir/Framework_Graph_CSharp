using System;

namespace Framework_Graphe
{
	public class Molecule : GGraphe<Atom, Liaison, Molecule>
	{
		public Molecule (String name) : base(name)
		{
		}
	}
}

