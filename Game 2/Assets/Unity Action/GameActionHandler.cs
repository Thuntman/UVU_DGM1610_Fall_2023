using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
	public GameAction gameActionObj;
	public UnityEvent onRaiseEvent;

	private void Star()
	{
		gameActionObj.raise += Raise;
	}
	
	private void Raise()
	{
		onRaiseEvent.Invoke();
	}
}
