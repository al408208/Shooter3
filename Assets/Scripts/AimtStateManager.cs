using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AimtStateManager : MonoBehaviour
{
    [SerializeField] float mouseSense=1;
    float xAxis,yAxis;
    [SerializeField] Transform camFollowPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xAxis+=Input.GetAxisRaw("Mouse X")*mouseSense;
        yAxis-=Input.GetAxisRaw("Mouse Y")*mouseSense;
        yAxis=Mathf.Clamp(yAxis,-80,80);
        //yAxis.Update(Time.deltaTime);
    }

    private void LateUpdate(){
        camFollowPos.localEulerAngles= new Vector3(yAxis,camFollowPos.localEulerAngles.y,camFollowPos.localEulerAngles.z);
        transform.eulerAngles=new Vector3(transform.eulerAngles.x,xAxis,transform.eulerAngles.z);
    }
}
