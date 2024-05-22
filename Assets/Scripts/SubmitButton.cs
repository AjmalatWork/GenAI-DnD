using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour
{
    public TextMeshProUGUI narrativeText;
    public TMP_InputField playerInput;

    Button submitButton;
    bool first = true;

    private void Awake()
    {
        submitButton = GetComponent<Button>();
        submitButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        
        string playerResponse = playerInput.text;
        playerInput.text = "";
        string coloredPlayerResponse = AddColor(playerResponse, Constants.Green);        
        narrativeText.text += "\n" + coloredPlayerResponse;

        if (first)
        {
            string prompt = Constants.startPrompt + playerResponse;
            GetResponseFromGemini(prompt);
            first = false;
        }
        else
        {
            string prompt = Constants.recallPrompt + narrativeText.text;            
            GetResponseFromGemini(prompt);
        }

    }

    string AddColor(string text, string colorHex)
    {
        text = $"<color={colorHex}>{text}</color>";
        return text;
    }

    async Task<string> CallGeminiAPI(string prompt)
    {
        string url = $"{Constants.apiURL}{Constants.apiKey}";

        var jsonBody = $"{{\"contents\":[{{\"parts\":[{{\"text\":\"{prompt}\"}}]}}]}}";
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        try
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();  // Throw exception for non-200 codes
                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }

        }
        catch(Exception ex)
        {
            Debug.LogException(ex);
            return null;
        }
    }

    public async void GetResponseFromGemini(string prompt)
    {
        string responseString = await CallGeminiAPI(prompt);
        
        if (responseString != null)
        {
            Root root = JsonUtility.FromJson<Root>(responseString);
            string reponseText = root.candidates[0].content.parts[0].text;
            Debug.Log(reponseText);
            narrativeText.text += "\n" + reponseText;
        }
            
    }

}
