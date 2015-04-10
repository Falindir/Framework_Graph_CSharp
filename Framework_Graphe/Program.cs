using System;

namespace Framework_Graphe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Framework Graphe test generecite");

			Graphe g1 = new Graphe ("G1");

			Console.WriteLine (g1.getName());

			g1.whoamI();

			Sommet s1 = new Sommet ("S1");

			Console.WriteLine (s1.getName());

			s1.whoamI();

			s1.addGraphe (g1);

			s1.getGraphe ().whoamI ();

			Molecule m1 = new Molecule ("M1");

			Atom a1 = new Atom ("A1");

			a1.addGraphe (m1);

			a1.getGraphe ().whoamI();

			Reseau r1 = new Reseau ("R1");

			Noeud n1 = new Noeud ("N1");

			n1.addGraphe (r1);

			n1.getGraphe ().whoamI();
			


		


		}
	}
}
