using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    [SerializeField]private GameObject playerObject;
    private Vector3 _cameraOffset = new  Vector3(0f, 1f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerObject.transform.position + _cameraOffset;
    }
}