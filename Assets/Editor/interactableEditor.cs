using UnityEditor;

[CustomEditor(typeof(interactable),true)]
public class interactableEditor : Editor
{
    public override void OnInspectorGUI()
        
    {
        interactable interactable = (interactable)target;
        if (target.GetType() == typeof(EventOnlyInteractable))
        {
            interactable.promptMessage = EditorGUILayout.TextField("Prompt Message",interactable.promptMessage);
            EditorGUILayout.HelpBox("can only use events", MessageType.Info);
            if (interactable.GetComponent<interactionEvents>() == null)
            {
                interactable.useEvents = true;
                interactable.gameObject.AddComponent<interactionEvents>();
            }
        }
        else
        {

            base.OnInspectorGUI();
            if (interactable.useEvents)
            {
                if (interactable.GetComponent<interactionEvents>() == null)
                {
                    interactable.gameObject.AddComponent<interactionEvents>();
                }
            }
            else
            {
                if ((interactable.GetComponent<interactionEvents>() != null))
                {
                    DestroyImmediate(interactable.GetComponent<interactionEvents>());
                }
            }
        }

    }
}
