using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    public void SetCurrentColorRandomly()
    {
        if (colorIDList != null && colorIDList.Count > 0)
        {
            int randomIndex = Random.Range(0, colorIDList.Count);
            currentColor = colorIDList[randomIndex];
        }
        else
        {
            Debug.LogError("ColorIDList is empty or null. Unable to set currentColor.");
        }
    }
}