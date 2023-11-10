using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class ObjectBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
	
	private void Start()
	{
		rendererObj = GetComponent<SpriteRenderer>();
	}
	public void ChangeRendererColor(ColorID obj)
	{
		rendererObj.color = obj.value;
	}

}
