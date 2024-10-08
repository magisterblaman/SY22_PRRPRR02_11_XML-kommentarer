using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_11_XML_kommentarer {
	/// <summary>
	/// 
	/// </summary>
	internal class KoolKlass {
		private int koolVariabel;

		/// <summary>
		/// 
		/// </summary>
		public int KoolEgenskap {
			get {
				return koolVariabel;
			}
			set {
				koolVariabel = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="inputKoolVariabel"></param>
		public KoolKlass(int inputKoolVariabel) {
			// sätter ett värde på KoolEgenskap
			KoolEgenskap = inputKoolVariabel;
		}

		/// <summary>
		/// Multiplicerar ett tal med 69, ett med 420 och beräknar summan.
		/// </summary>
		/// <param name="koolParameter1">Det första talet</param>
		/// <param name="koolParameter2">Det andra talet</param>
		/// <returns>Summan av produkterna</returns>
		public int KoolMetod(int koolParameter1, int koolParameter2) {
			return 69 * koolParameter1 + 420 * koolParameter2;
		}
	}
}
