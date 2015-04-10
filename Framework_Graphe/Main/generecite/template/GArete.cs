using System;
using System.Collections.Generic;

namespace Framework_Graphe
{
	public abstract class GArete <S, G, A> : Racine
		where S : GSommet<A, G, S>
		where G : GGraphe<S, A, G>
		where A : GArete<S, G, A>
	{
		private G graphe;
		private S s1;
		private S s2;

		public GArete (String name) : base(name)
		{

		}

		public G getGraphe() {
			return graphe;
		}

		public S getS1() {
			return s1;
		}

		public S getS2() {
			return s2;
		}

		public void addGraphe(G g) {
			graphe = g;
		}


	}
}

