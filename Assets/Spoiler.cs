using UnityEngine;
using System.Collections;
 
public class Spoiler : MonoBehaviour {
       
    public GameObject world;
	public GUIStyle style;
	GameController control;

	void Start () {
	  control = world.GetComponent<GameController>();
	}
       
        string[] quotes = {
          "A Lannister always pays his depts",
          "Fear cuts deeper than swords",
          "Winter is coming",
          "When you play a game of thrones you\n spoil or you die",
          "If I look back I am lost",
          "Nothing burns like the cold",
	  "You know nothing John Snow",
          "Different roads sometimes lead to\n the same castle",
          "All dwarfs may be bastards, yet not\n all bastards need be dwarfs",	  
	};

        string[] spoilers = {
          "Lord Stark gets beheaded soon",
          "Long live King Joffrey",
          "Lord Snow will break his vows",
	  "A king in the north",
	  "Theon joins the Night's Watch",
	  "Bran will kill Hodor",
	  "Melisandre works with the\n white walkers",
	  "Tyrion is really a\n Targaryen",
	  "Arya will marry Theon",
	  "Ygritte is Sansa's mother",
	  "Bran learns to fly\n a dragon",
	  "Weddings can be nice",
	  "Cercei and Joffrey have\n an affair",
	  "Stannis will take the\n Iron Throne",
	  "Eddard will come back as\n a White Walker"
        };

	string randomSpoiler() {
	  int i = Random.Range(0, spoilers.Length);
	  return spoilers[i];
	}

	string currentSpoiler;

	void OnGUI() {
	  if (control.pause) {
	    int width = 1024;
	    int height = 768;
	    int centerY = height/2;

	    GUI.Box(new Rect(10, centerY-200,width-20,400), "Spoiler is coming");
	    GUI.Label(new Rect(20,centerY-170,width-40,300), currentSpoiler, style);
	    if (GUI.Button (new Rect (30,centerY+100,width-60,60), "I knew it!")) {
	      Time.timeScale=1.0f;
	      control.pause=false;
	    }
	  }
	}

	public void showSpoiler() {
	  currentSpoiler=randomSpoiler();
	  Time.timeScale=0.0f;
	  control.pause = true;
	}
}
