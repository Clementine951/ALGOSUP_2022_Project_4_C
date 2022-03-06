using UnityEngine;
using UnityEngine.UI;
using UnityJapanOffice;





namespace UnityJapanOffice {

	[RequireComponent(typeof(ToggleGroup))]

	public class ToggleGroupOptions : MonoBehaviour {

		[SerializeField] private Toggle defaultToggle;




		private void Start () {
			GetComponent<ToggleGroup>().SetAllTogglesOff();
			defaultToggle.isOn = true;
		}
	}
}