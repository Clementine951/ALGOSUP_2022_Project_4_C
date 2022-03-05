using UnityEngine;
using UnityEngine.UI;
using UnityJapanOffice;





namespace UnityJapanOffice {

	[RequireComponent(typeof(CanvasGroup))]

	public class CanvasGroupOptions : MonoBehaviour {

		private CanvasGroup canvasGroup;




		public void Show () {
			if(canvasGroup == null) {
				canvasGroup = GetComponent<CanvasGroup>();
			}

			canvasGroup.alpha = 1;
			canvasGroup.interactable = true;
			canvasGroup.blocksRaycasts = true;
		}



		public void Hide () {
			if(canvasGroup == null) {
				canvasGroup = GetComponent<CanvasGroup>();
			}

			canvasGroup.alpha = 0;
			canvasGroup.interactable = false;
			canvasGroup.blocksRaycasts = false;
		}
	}
}