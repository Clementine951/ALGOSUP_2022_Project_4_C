using UnityEngine;
using UnityJapanOffice;





namespace UnityJapanOffice {

	public class MiniMap : MonoBehaviour {
		
		[SerializeField] private Transform player;
		[SerializeField] private Transform mapPlayer;




		private void Update () {
			mapPlayer.localPosition = new Vector3(player.localPosition.x, player.localPosition.z, 0);
			mapPlayer.localEulerAngles = new Vector3(0, 0, -player.localEulerAngles.y);
		}
	}
}