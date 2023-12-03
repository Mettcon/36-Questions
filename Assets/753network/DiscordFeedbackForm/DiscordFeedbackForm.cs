// Discord Feedback Form v2.0 - Made by 753
// https://discord.gg/fGSneSe - 753.network

#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace DiscordAnalytics
{
    [CustomEditor(typeof(DiscordFeedbackForm))]
    class DiscordFeedbackFormHelperEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUILayout.Space(8);
            ((DiscordFeedbackForm)target).webhookURL = EditorGUILayout.TextField("Webhook URL", ((DiscordFeedbackForm)target).webhookURL);
            GUILayout.Space(8);

            if (GUILayout.Button("Generate Feedback Form"))
            {
                Debug.Log("Generating Discord Feedback Form!");
                ((DiscordFeedbackForm)target).Generate();
            }
        }
    }

    public class DiscordFeedbackForm : MonoBehaviour
    {
        public string webhookURL;
        public InputField webRequester;

        const string apiURL = "https://create-react-app.x753.vercel.app/api/udon1?";

        public void Generate()
        {
            try
            {
                if (!webhookURL.Contains("/webhooks/"))
                {
                    EditorUtility.DisplayDialog("Error Generating Discord Feedback Form", "A valid webhook URL is required.", "Close");
                    return;
                }

                if (PrefabUtility.IsPartOfAnyPrefab(gameObject))
                {
                    PrefabUtility.UnpackPrefabInstance(gameObject, PrefabUnpackMode.Completely, InteractionMode.AutomatedAction);
                }

                this.transform.Find("APIURL").GetComponent<Text>().text = apiURL + webhookURL.Substring(webhookURL.IndexOf("/webhooks/")+10) + "~";

                // Finished, destroy the DiscordFeedbackForm script
                Debug.Log("Successfully Generated Discord Feedback Form!");
                DestroyImmediate(this);
            }
            catch (Exception e)
            {
                EditorUtility.DisplayDialog("Error Generating Discord Feedback Form", "An unknown error has occurred. Error: " + e.Data, "Close");
            }
        }
    }
}
#endif