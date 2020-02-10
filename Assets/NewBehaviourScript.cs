using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	private GameObject scoretext;
	public int score = 0;

	// Use this for initialization
	void Start () {
		this.scoretext = GameObject.Find ("ScoreText");
	}
	
	// Update is called once per frame
	void Update () {
		this.scoretext.GetComponent<Text> ().text ="score:"+score;
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (other.gameObject.tag == "LargeStarTag") {
			score += 20;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			score += 15;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			score += 20;
		}
	}
}
