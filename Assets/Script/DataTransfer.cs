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
                    mass = parsedMass * 1e-21f;
                }
                else
                {
                    Debug.LogError("Failed to parse mass value!");
                }
            }
        }

        const float G = 6.67430e-11f;
        g = G * mass;

        PlayerPrefs.SetFloat("Gravity", g);
        PlayerPrefs.SetFloat("Mass", mass);

        SceneManager.LoadScene("Custom");
        DontDestroyOnLoad(gameObject);
    }
}
