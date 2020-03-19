using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Vector3[] Target;
    public Camera Cam;
    public bool zoomCamera;
    public float speed=5f;
    public float jumlah;
    public float penambahan;
    public bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        jumlah = 0f;
        penambahan = 2f;
        Cam = Camera.main;
        zoomCamera = false;
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            isPause = isPause==true?false:true;
        }
        if(zoomCamera){
            int i = (int) jumlah;
            if( i < 3){
                Debug.Log(i);
                Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize,10,speed*Time.deltaTime);
                Cam.transform.position = Vector3.Lerp(Cam.transform.position,Target[0], speed*Time.deltaTime);
            }else  if(isPause==true){
                
            }
            else{
                transform.position += new Vector3(.1f,0,0);
            }
            jumlah += penambahan*Time.deltaTime;
        }
    }
    public void OnMouseDown() {
        if (Input.GetKeyUp(KeyCode.Mouse0)){
            zoomCamera = true;
        }
    }
}
