using System.Collections;
using UnityEngine;
using UnityJapanOffice;





namespace UnityJapanOffice {

	public class Door : MonoBehaviour {

		[SerializeField] private Transform door;
		[SerializeField] private Transform handle1;
		[SerializeField] private Transform handle2;

		[Space(10)]
		[SerializeField] private float closedAngle;
		[SerializeField] private float openAngle;

		[Space(10)]
		[SerializeField] private float doorDuration;
		[SerializeField] private float handleDuration;
		[SerializeField] private AnimationCurve animationCurve;




		public void Open () {
			StopAllCoroutines();
			StartCoroutine(Animate(door.eulerAngles.y, openAngle));
		}



		public void Close () {
			StopAllCoroutines();
			StartCoroutine(Animate(door.eulerAngles.y, closedAngle));
		}




		private IEnumerator Animate (float start, float end) {
			float timeCount = 0;

			if(Mathf.Abs(Mathf.DeltaAngle(start, closedAngle)) < 2){
				while(timeCount < 1) {
					timeCount += Time.deltaTime / handleDuration;

					handle1.localRotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(0, 0, 60), animationCurve.Evaluate(timeCount));
					handle2.localEulerAngles = handle1.localEulerAngles;

					yield return null;
				}
			}


			Quaternion handleStartAngle = handle1.localRotation;
			timeCount = 0;

			while(timeCount < 1) {
				timeCount += Time.deltaTime / doorDuration;

				door.rotation = Quaternion.Lerp(Quaternion.Euler(0, start, 0), Quaternion.Euler(0, end, 0), animationCurve.Evaluate(timeCount));
				handle1.localRotation = Quaternion.Lerp(handleStartAngle, Quaternion.identity, animationCurve.Evaluate(timeCount));
				handle2.localRotation = handle1.localRotation;

				yield return null;
			}
		}
	}
}