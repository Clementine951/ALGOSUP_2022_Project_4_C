using UnityEngine;
using UnityEngine.UI;
using UnityJapanOffice;





namespace UnityJapanOffice {

	[RequireComponent(typeof(Slider))]
	[ExecuteInEditMode]

	public class SliderOptions : MonoBehaviour {
		
		[SerializeField] private Text valueField;
		[SerializeField] private int decimalDigits;
		[SerializeField] private int multiplyer = 1;
		[SerializeField] private string unit;
		[SerializeField] private bool displayUnitBeforeValue;

		private Slider slider;




		private void Start() {
			slider = GetComponent<Slider>();
			slider.onValueChanged.AddListener(OnValueChanged);

			OnValueChanged(slider.value);
		}


		
		#if UNITY_EDITOR
		private void Update() {
			if(!Application.isPlaying) {
				OnValueChanged(slider.value);
			}
		}
		#endif




		private void OnValueChanged (float value) {
			value = Mathf.Floor(value * multiplyer * Mathf.Pow(10, decimalDigits)) / Mathf.Pow(10, decimalDigits);

			if(displayUnitBeforeValue) {
				valueField.text = unit + " " + value.ToString("f" + decimalDigits);
			} else {
				valueField.text = value.ToString("f" + decimalDigits) + " " + unit;
			}	
		}
	}
}