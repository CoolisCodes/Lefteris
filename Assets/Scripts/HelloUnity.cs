using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    public int Yamount = 0;
    public float Zamount = 0;

    public Transform myTransform;

    public ClassicClass classic;


    private void OnEnable()
    {
        // Debug.Log("Enabled");
    }

    private void OnDisable()
    {
        //Debug.Log("Disabled");
    }

    private void Awake()
    {
        //Debug.Log("Application Awake");

        myTransform = GetComponent<Transform>();


        Debug.Log(Singleton.instance.gameDifficultyLevel);
    }

    private void Start()
    {
        //Debug.Log("Application Started");
    }

    private void Update()
    {
        //Debug.Log("Updated");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myTransform.position = new Vector3(0, myTransform.position.y + Yamount, 0);
        }
    }
}
