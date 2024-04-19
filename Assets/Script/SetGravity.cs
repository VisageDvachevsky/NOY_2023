using UnityEngine;
using TMPro;

public class SetGravity : MonoBehaviour
{
    void Start()
    {
        float gravity = PlayerPrefs.GetFloat("Gravity", 9.81f);
        Physics.gravity = new Vector3(0, -gravity, 0);

        float mass = PlayerPrefs.GetFloat("Mass", 0f); 
        float radius = PlayerPrefs.GetFloat("Radius", 0f); 

        TMP_Text gText = GameObject.FindGameObjectWithTag("g_text").GetComponent<TMP_Text>();
        TMP_Text massText = GameObject.FindGameObjectWithTag("mass_text").GetComponent<TMP_Text>();
        TMP_Text radiusText = GameObject.FindGameObjectWithTag("radius_text").GetComponent<TMP_Text>();

        gText.text = "g: " + gravity.ToString("F2") + " м/с^2";
        massText.text = "Масса: " + mass.ToString("F2") + " секстильонов тонн";
        radiusText.text = "Радиус: " + radius.ToString("F2") + " км";
    }
}
