using UnityEngine;

#if !UNITY_3_5
namespace Smooth.Slinq.Test {
#endif
	
	public class ExceptSlinq : MonoBehaviour {
		private void Update() {
			for (int i = 0; i < SlinqTest.loops; ++i) {
				SlinqTest.tuples1.Slinq().Except(SlinqTest.tuples2.Slinq(), SlinqTest.eq_1).Count();
			}
		}
	}

#if !UNITY_3_5
}
#endif
