using UnityEngine;

public class Nullable : MonoBehaviour
{
    private Camera _nullCamera;
    // Start is called before the first frame update
    void Start()
    {
        _nullCamera = null;
        Camera cameraTest = _nullCamera ? _nullCamera : Camera.main;
        Debug.Log(cameraTest);
    }

    
}
