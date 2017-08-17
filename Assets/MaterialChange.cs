using UnityEngine;

public class MaterialChange : MonoBehaviour {


    public Material material;
    Color[] colors = new Color[4];
    int index = 0;


	void Start () {
        colors[0] = Color.yellow;
        colors[1] = Color.magenta;
        colors[2] = Color.green;
        colors[3] = Color.blue;
        material.color = colors[Random.Range(1,4)];
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (index == 3)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            material.color = colors[index];
            Debug.Log("pressed");
            Debug.Log(colors[1]);
        }
	}
}
