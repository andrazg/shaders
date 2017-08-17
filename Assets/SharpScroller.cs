using UnityEngine;

public class SharpScroller : MonoBehaviour {

    public Renderer rend;
    public float speed = 1f;


	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	void Update () {
       rend.material.mainTextureOffset = new Vector2(speed * Time.time, 0);
        //isto je oboje
    //    rend.material.SetTextureOffset("_MainTex", new Vector2(2 * Time.time, 0));
    }
}
