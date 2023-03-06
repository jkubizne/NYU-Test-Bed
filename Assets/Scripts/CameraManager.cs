using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    [System.Serializable]
    public struct View
    {
        public Camera activeCamera;
        public string label;
    }

    public View[] views = new View[6];

    private int pointer = 0;

    [SerializeField]
    //[Header("Text Styles")]
    [Tooltip("Defines the syle for the text shown below each view")]
    public GUIStyle style = new GUIStyle();

    private void Start()
    {
        setActiveCamera(pointer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            pointer = 0;
            setActiveCamera(pointer);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            pointer = 1;
            setActiveCamera(pointer);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            pointer = 2;
            setActiveCamera(pointer);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            pointer = 3;
            setActiveCamera(pointer);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            pointer = 4;
            setActiveCamera(pointer);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            pointer = 5;
            setActiveCamera(pointer);
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 50, 200, 50), views[pointer].label, style);
    }

    private void setActiveCamera(int index)
    {
        for (int i = 0; i < views.Length; i++)
        {
            views[i].activeCamera.gameObject.SetActive(false);
        }

        views[index].activeCamera.gameObject.SetActive(true);
    }
}
