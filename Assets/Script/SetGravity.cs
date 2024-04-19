using UnityEngine;

public class SetGravity : MonoBehaviour
{
    void Start()
    {
        float gravity = PlayerPrefs.GetFloat("Gravity", 9.81f); 

        Physics.gravity = new Vector3(0, -gravity, 0);
    }
}
