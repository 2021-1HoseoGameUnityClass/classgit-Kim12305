using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public GameObject A;  //A��� GameObject���� ����
    Transform AT;
    void Start()
    {
        AT = A.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(AT.position.x, AT.position.y, transform.position.z);
    }
}
