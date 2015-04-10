using System;
using System.Collections.Generic;

namespace Framework_Graphe
{
	public abstract class GSommet <A, G, S> : Racine
		where A : GArete<S, G, A>
		where G : GGraphe<S, A, G>
		where S : GSommet<A, G, S>
	{
		private G graphe; 
		private HashSet<A> aretes = new HashSet<A>();

		public GSommet (String name) : base(name)
		{

		}

		public G getGraphe() {
			return graphe;
		}

		public HashSet<A> getAretes() {
			return aretes;
		}

		public void addGraphe(G g) {
			graphe = g;
		}
	}
}

