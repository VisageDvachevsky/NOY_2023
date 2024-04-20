using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DataTransfer : MonoBehaviour
{
    private float g;
    private float mass;

    public void OnButtonClick()
    {
        GameObject[] massInputs = GameObject.FindGameObjectsWithTag("MassInput");
        foreach (GameObject inputField in massInputs)
        {
            TMP_InputField tmpInput = inputField.GetComponent<TMP_InputField>();
            if (tmpInput != null)
            {
                if (float.TryParse(tmpInput.text, out float parsedMass))
                {
                    mass = parsedMass;
                }
                else
                {
                    Debug.LogError("Failed to parse mass value!");
                }
            }
        }

        GameObject[] radiusInputs = GameObject.FindGameObjectsWithTag("RadiusInput");
        float radius = 0f;
        foreach (GameObject inputField in radiusInputs)
        {
            TMP_InputField tmpInput = inputField.GetComponent<TMP_InputField>();
            if (tmpInput != null)
            {
                if (float.TryParse(tmpInput.text, out float parsedRadius))
                {
                    radius = parsedRadius;
                }
                else
                {
                    Debug.LogError("Failed to parse radius value!");
                }
            }
        }

        const float G = 6.67430e-11f;
        g = G * mass * 1e21f / (radius*radius * 1e6f);

        PlayerPrefs.SetFloat("Gravity", g);
        PlayerPrefs.SetFloat("Mass", mass);
        PlayerPrefs.SetFloat("Radius", radius);
        SceneManager.LoadScene("Custom");
        DontDestroyOnLoad(gameObject);
    }
}
