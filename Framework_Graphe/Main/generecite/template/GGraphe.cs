using System;
using System.Collections.Generic;

namespace Framework_Graphe
{
	public abstract class GGraphe <S, A, G> : Racine
		where S : GSommet<A, G, S>
		where A : GArete <S, G, A>
		where G : GGraphe<S, A, G>

	{
		private HashSet<S> sommets = new HashSet<S>();
		private HashSet<A> aretes = new HashSet<A>();

		public GGraphe (String name) : base(name)
		{

		}


	}
}

