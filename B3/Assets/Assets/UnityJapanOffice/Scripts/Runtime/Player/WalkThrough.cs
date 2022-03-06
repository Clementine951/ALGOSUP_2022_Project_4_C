using System.Collections;
using UnityEngine;
using UnityJapanOffice;





namespace UnityJapanOffice {
	
	[RequireComponent(typeof(Rigidbody))]

	public class WalkThrough : MonoBehaviour {

		[SerializeField] private Transform player;
		[SerializeField] private Transform cam;

		[Space(10)]
		[SerializeField] private  float moveSpeed = 1;
		[SerializeField] private  float rotateSpeed = 1;

	
		private Rigidbody rigid;
		private Vector3 dir = Vector3.zero;
		private float yaw = 0, tilt = 0;

		private bool isRunning = false;
		private bool isLockedPosition = false;
		private bool isLockedRotation = false;




		private void Start () {
			rigid = GetComponent<Rigidbody>();
		}



		private void Update() {
			if(!isLockedRotation){
				yaw  += Input.GetAxis("Mouse X") * rotateSpeed;
				tilt -= Input.GetAxis("Mouse Y") * rotateSpeed;

				tilt = Mathf.Clamp(tilt, -89, 89);

				player.eulerAngles = new Vector3(0, yaw, 0);
				cam.localEulerAngles = new Vector3(tilt, 0, 0);
			}


			if(!isLockedPosition){
				if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) {
					isRunning = !isRunning;
				}

				dir = Quaternion.Euler(0, player.localEulerAngles.y, 0) * new Vector3(Input.GetAxis("Horizontal"), 0 , Input.GetAxis("Vertical"));

				if(isRunning) {
					dir *= moveSpeed * 2;
				} else {
					dir *= moveSpeed;
				}
				
				rigid.velocity = dir * Time.deltaTime;
			}
		}



		public void Teleport (Transform target) {
			player.position = target.position;
			player.rotation = target.rotation;

			yaw = player.eulerAngles.y;
		}



		public void LockPosition (bool value) {
			isLockedPosition = value;
		}



		public void LockRotation (bool value) {
			isLockedRotation = value;

			if(value){
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			} else {
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}
		}
	}
}