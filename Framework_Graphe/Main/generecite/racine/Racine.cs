using System;

namespace Framework_Graphe
{
	public abstract class Racine
	{
		public String name;

		public Racine (String name)
		{
			this.name = name;
		}
		 
		public String getName() {
			return name;
		}

		public void whoamI() {
			Console.WriteLine ("Object : name -> " + name + ", class -> " + GetType().Name + " , super -> " + GetType().BaseType.Name);
		}

	}
}

