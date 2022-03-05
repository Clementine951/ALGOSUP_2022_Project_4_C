using UnityEngine;
using UnityEngine.Events;
using UnityJapanOffice;





namespace UnityJapanOffice {

	public class Trigger : MonoBehaviour {
		
		[SerializeField] private string targetTag;

		[Space(10)]
		[SerializeField] private UnityEvent onEnter;
		[SerializeField] private UnityEvent onExit;




		private void OnTriggerEnter (Collider other) {
			if(other.CompareTag(targetTag)) {
				onEnter.Invoke();
			};
		}



		private void OnTriggerExit (Collider other) {
			if(other.CompareTag(targetTag)) {
				onExit.Invoke();
			}
		}
	}
}