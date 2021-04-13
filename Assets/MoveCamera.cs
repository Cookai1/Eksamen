using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;

    void Update() {
        transform.position = player.transform.position;
    }
    int zoom = 20;
    int normal = 31;
    float smooth = 5;

    private bool isZoomed = false;
    private bool notZoomed = false;

    void Zoom()
    {

  
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isZoomed = !isZoomed;
        }

        if (isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            notZoomed = !notZoomed;
        }

        if (notZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
    }
}
