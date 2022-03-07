using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityJapanOffice;





namespace UnityJapanOffice {

	[RequireComponent(typeof(Toggle))]
	[ExecuteInEditMode]

	public class ToggleOptions : MonoBehaviour {
		
		[SerializeField] private Color offNormalColor;
		[SerializeField] private Color onNormalColor;

		[Space(10)]
		[SerializeField] private UnityEvent onValueChangedOn;
		[SerializeField] private UnityEvent onValueChangedOff;

		private Toggle toggle;




		private void Start() {
			toggle = GetComponent<Toggle>();
			toggle.onValueChanged.AddListener(ChangeNormalColor);
			toggle.onValueChanged.AddListener(OnValueChanged);

			ChangeNormalColor(toggle.isOn);
			OnValueChanged(toggle.isOn);
		}



#if UNITY_EDITOR
		private void Update() {
			if(!Application.isPlaying){
				ChangeNormalColor(toggle.isOn);
				OnValueChanged(toggle.isOn);
			}
		}
		#endif
		



		private void ChangeNormalColor (bool isOn) {
			if(isOn) {
				ColorBlock colors = toggle.colors;
				colors.normalColor = onNormalColor;
				toggle.colors = colors;
			} else {
				ColorBlock colors = toggle.colors;
				colors.normalColor = offNormalColor;
				toggle.colors = colors;
			}
		}



		private void OnValueChanged (bool isOn) {
			if(isOn) {
				onValueChangedOn.Invoke();
			} else {
				onValueChangedOff.Invoke();
			}
		}
	}
}