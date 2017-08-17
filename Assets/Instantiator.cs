using UnityEngine;

public class Instantiator : MonoBehaviour {
    Color[] colors = new Color[4];
    public GameObject killer;
    Vector3 instantPosition = new Vector3(0, 5, 0);
    float timer;
    float ratio;
    int indexCol;
    public Material killerMat;


	void Start () {
        indexCol = Random.Range(1, 4);
        timer = Time.time;
        ratio = 2;
        colors[0] = Color.yellow;
        colors[1] = Color.magenta;
        colors[2] = Color.green;
        colors[3] = Color.blue;


    }
	
	void Update () {
        if (Time.time > timer + ratio)
        {
            timer = Time.time;
            GameObject killer2 = Instantiate(killer, instantPosition, transform.rotation);
            killerMat.color = colors[Random.Range(1, 4)];
            Destroy(killer2, 3);
        }





	}
}
