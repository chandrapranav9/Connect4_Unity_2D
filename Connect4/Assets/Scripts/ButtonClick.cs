using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {
	public BoardManager boardManager;

	void Start(){

	}

	void OnMouseUpAsButton(){

		//if (boardManager != null) {
			boardManager.GetComponent<BoardManager>().performAction(5);
		/*} else if (boardManager == null){
			Debug.Log ("Hello");
		}*/
	}

}
