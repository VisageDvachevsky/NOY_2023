using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DataTransfer : MonoBehaviour
{
    private float g;

    public void OnButtonClick()
    {
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

        GameObject[] massInputs = GameObject.FindGameObjectsWithTag("MassInput");
        float mass = 0f;
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


        const float G = 6.67430e-11f; 
        g = G * (mass / (radius * radius));

        PlayerPrefs.SetFloat("Gravity", g);

        SceneManager.LoadScene("Custom");
        DontDestroyOnLoad(gameObject);
    }
}
