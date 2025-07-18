using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitchController : MonoBehaviour
{
    [SerializeField] List<CinemachineVirtualCamera> cameras;

    void Start()
    {
        ActiveCamera(0);
    }
    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < cameras.Count; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActiveCamera(i);
            }
        }
    }
    
    private void ActiveCamera(int index)
    {
        if(index < 0 ||index >= cameras.Count)
        {
            Debug.LogError("Kamera bulunamadı");
            return;
        }
        for(int i = 0; i < cameras.Count; i++)
        {
            cameras[i].Priority = (i == index) ? 10 : 0;
        }
    }
}
