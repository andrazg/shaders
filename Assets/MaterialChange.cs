using UnityEngine;

public class MaterialChange : MonoBehaviour
{


    public Material material;
    public Material enemy;
    Color[] colors = new Color[4];
    int index = 0;
    public TextMesh resultMesh;
    int result;
    Vector3 rise;
    int scaleTimer;
    int scaleTimer2;
    
    void Start()
    {
        scaleTimer = 0;
        scaleTimer2 = 0;
        rise = new Vector3(0.1f, 0.1f, 0.1f);
        result = 0;
        colors[0] = Color.yellow;
        colors[1] = Color.magenta;
        colors[2] = Color.green;
        colors[3] = Color.blue;
        material.color = colors[Random.Range(1, 4)];
    }

    void Update()
    {

        resultMesh.text = "Result: " + result.ToString();

        if (scaleTimer > 0)
        {
            if (scaleTimer2 > 0)
            {
                gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale += rise + rise / 2,
                                                                      gameObject.transform.localScale,
                                                                      Time.deltaTime);
                scaleTimer2--;
            }
            else
            {
                gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale -= rise / 2,
                                                                      gameObject.transform.localScale,
                                                                      Time.deltaTime);
                scaleTimer--;
            }
        }
       


        if (Application.isMobilePlatform)
        {
            if (Input.touchCount > 0)
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


        if (Application.isEditor)
        {
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
            }
        }
    }

    void OnTriggerExit(Collider coll)
    {
        Debug.Log("enter");
        if (coll.gameObject.tag == "enemy")
        {
            if (material.color == enemy.color)
            {
                result += 1;
            }
            else
            {
                result -= 1;
                scaleTimer = 3;
                scaleTimer2 = 4;

            }
        }
    }
}
