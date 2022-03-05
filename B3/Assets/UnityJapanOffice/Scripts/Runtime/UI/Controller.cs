using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityJapanOffice;





namespace UnityJapanOffice {

	public class Controller : MonoBehaviour {

		//--------------------------------------------------
		[SerializeField] private WalkThrough walkThrough;
		[SerializeField] private CanvasGroupOptions guideUI;
		[SerializeField] private CanvasGroupOptions menuUI;
		private bool isPlaying = false;
		private bool isOpenedMenu = false;



		private void Start () {
			walkThrough.LockPosition(true);
			walkThrough.LockRotation(true);
			guideUI.Show();
			menuUI.Hide();
		}


		private void Update () {
			if(!isPlaying) {
				if(Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) {
					walkThrough.LockPosition(false);
					walkThrough.LockRotation(false);
					guideUI.Hide();
					isPlaying = true;
				}

				return;
			}


			if(Input.GetMouseButtonDown(0)) {
				if(!IsHittingToUI(Input.mousePosition)){
					if(isOpenedMenu) {
						walkThrough.LockRotation(false);
						menuUI.Hide();
					} else {						
						walkThrough.LockRotation(true);
						menuUI.Show();
					}

					isOpenedMenu = !isOpenedMenu;
				}
			}
		}


		private bool IsHittingToUI (Vector2 point) {
			PointerEventData pointer = new PointerEventData(EventSystem.current);
			pointer.position = point;

			List<RaycastResult> result = new List<RaycastResult>();
			EventSystem.current.RaycastAll(pointer, result);

			return (result.Count > 0);
		}
		//--------------------------------------------------




		
		//--------------------------------------------------
		[Header("Scenes")]
		[SerializeField] private string noonA;
		[SerializeField] private string noonB;
		[SerializeField] private string eveningA;
		[SerializeField] private string eveningB;
		[SerializeField] private string nightA;
		[SerializeField] private string nightB;
		[SerializeField] private GameObject[] sceneAObjects;
		private string currentScene = string.Empty;
		private int currentSceneIndex = 0;
		private bool isExpansion = false;



		private void Awake () {
			currentScene = noonA;
			LoadCurrentScene(true);
		}


		public void LoadNoonScene () {
			if(!Input.GetMouseButtonUp(0)) return;

			currentSceneIndex = 0;

			UnloadCurrentScene();

			if(isExpansion) {
				currentScene = noonB;
				LoadCurrentScene(false);
			} else {
				currentScene = noonA;
				LoadCurrentScene(true);
			}
		}


		public void LoadEveningScene () {
			if(!Input.GetMouseButtonUp(0)) return;

			currentSceneIndex = 1;

			UnloadCurrentScene();

			if(isExpansion) {
				currentScene = eveningB;
				LoadCurrentScene(false);
			} else {
				currentScene = eveningA;
				LoadCurrentScene(true);
			}
		}


		public void LoadNightScene () {
			if(!Input.GetMouseButtonUp(0)) return;

			currentSceneIndex = 2;

			UnloadCurrentScene();

			if(isExpansion) {
				currentScene = nightB;
				LoadCurrentScene(false);
			} else {
				currentScene = nightA;
				LoadCurrentScene(true);
			}
		}


		public void ExpandFloor () {
			if(!Input.GetMouseButtonUp(0)) return;

			isExpansion = !isExpansion;

			switch(currentSceneIndex) {
				case 0:
					LoadNoonScene();
					break;
				case 1:
					LoadEveningScene();
					break;
				case 2:
					LoadNightScene();
					break;
			}
		}


		private void LoadCurrentScene (bool isAScene) {
			SceneManager.LoadScene(currentScene, LoadSceneMode.Additive);

			foreach(GameObject obj in sceneAObjects) {
				obj.SetActive(isAScene);
			}
		}


		private void UnloadCurrentScene () {
			if(currentScene != string.Empty){
				SceneManager.UnloadSceneAsync(currentScene);
			}
		}
		//--------------------------------------------------





		//--------------------------------------------------
		[Header("Hall Spotlights")]
		[SerializeField] private Light[] spotlights;
		[SerializeField] private Slider dimmerSlider;
		[SerializeField] private Slider colorTemperatureSlider;
		[SerializeField] private Texture2D colorTemperatureSample;
		private HDAdditionalLightData[] hdrpLightData = new HDAdditionalLightData[0];



		public void SetSpotlightDimmer () {
			if(hdrpLightData.Length == 0) {
				hdrpLightData = new HDAdditionalLightData[spotlights.Length];
				for(int i = 0; i < hdrpLightData.Length; i++) {
					hdrpLightData[i] = spotlights[i].GetComponent<HDAdditionalLightData>();
				}
			}

			foreach(HDAdditionalLightData light in hdrpLightData) {
				light.lightDimmer = dimmerSlider.value;
			}
		}


		public void SetSpotlightColorTemperature () {
			foreach(Light light in spotlights) {
				light.color = colorTemperatureSample.GetPixel((int)(colorTemperatureSample.width * (colorTemperatureSlider.value / 100)), 0);
			}
		}
		//--------------------------------------------------

		
		
		
		
		//--------------------------------------------------
		[Header("Wood Floor & Wood Wall")]
		[SerializeField] private Material floorMaterial;
		[SerializeField] private Texture2D[] floorTextures;
		[SerializeField] private Material wallMaterial;
		[SerializeField] private Texture2D[] wallTextures;
		[SerializeField] private ReflectionProbe[] refltimeReflectionProbes;



		public void SetFloorMaterial (int index) {
			floorMaterial.mainTexture = floorTextures[index];
			UpdateRealtimeReflectipnProbes();
		}


		public void SetWallMaterial (int index) {
			wallMaterial.mainTexture = wallTextures[index];
			UpdateRealtimeReflectipnProbes();
		}


		private void UpdateRealtimeReflectipnProbes () {
			foreach(ReflectionProbe reflectionProbe in refltimeReflectionProbes) {
				reflectionProbe.RequestRenderNextUpdate();
			}
		}
		//--------------------------------------------------





		//--------------------------------------------------
		[Header("Exposure")]
		[SerializeField] private VolumeProfile volumeProfile;
		[SerializeField] private Slider evSlider;
		private Exposure exposure;



		public void SetExposureMode (int mode) {
			if(exposure == null) {
				foreach(VolumeComponent component in volumeProfile.components) {
					if(component.GetType().Name == "Exposure") {
						exposure = component as Exposure;
						break;
					}
				}
			}

			exposure.mode.value = (ExposureMode)mode;
		}


		public void SetFixedEV () {
			exposure.fixedExposure.value = evSlider.value;
		}
		//--------------------------------------------------

		
		
		
		
		//--------------------------------------------------
		[Header("Eye Level")]
		[SerializeField] private Transform cam;



		public void SetCameraHeight (float value) {
			cam.localPosition = new Vector3(0, value, 0);
		}
		//--------------------------------------------------

		
		
		
		
		//--------------------------------------------------
		[Header("Play Movie")]
		[SerializeField] private Material tvMaterial;
		[SerializeField] private Texture2D defaultTexture;
		[SerializeField] private RenderTexture videoTexture;
		[SerializeField] private VideoPlayer videoPlayer;



		public void PlayVideo () {
			videoPlayer.Play();
			tvMaterial.SetTexture("_EmissiveColorMap", videoTexture);
		}

		public void StopVideo () {
			videoPlayer.Stop();
			tvMaterial.SetTexture("_EmissiveColorMap", defaultTexture);
		}
		//--------------------------------------------------

		
		
		
		
		//--------------------------------------------------
		public void Exit () {
			Application.Quit();
		}
		//--------------------------------------------------
	}
}