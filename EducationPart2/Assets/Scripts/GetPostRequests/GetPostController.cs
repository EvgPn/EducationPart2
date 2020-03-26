using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetPostController : MonoBehaviour
{
    [SerializeField]
    private InputField _postInput = null; 

    public void SendPostRequest()
    {
        string message = _postInput.text;
        StartCoroutine(SendPR(message));
    }

    public void SendGetRequest()
    {
        StartCoroutine(SendGR());
    }

    IEnumerator SendPR(string message)
    {
        WWWForm form = new WWWForm();
        form.AddField("unitypost", message);
        using (UnityWebRequest www = UnityWebRequest.Post("https://postman-echo.com/post", form))
        {
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log("Response Text from the server = " + responseText);
            }
        }
    }

    IEnumerator SendGR()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("https://postman-echo.com/get?foo1=bar1"))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                string responseText = www.downloadHandler.text;
                Debug.Log("Response Text from the server = " + responseText);
            }
        }
    }
}
