using UnityEngine;

public class Demo : MonoBehaviour
{

	public void button1Clicked ()
	{
		Toast.Instance.Show ("Hello");
	}

	public void button2Clicked ()
	{
		Toast.Instance.Show ("Hello 2s", 2f);
	}

	public void button3Clicked ()
	{
		Toast.Instance.Show ("Hello 2s color:magenta", 3f, Toast.ToastColor.Magenta);
	}
}
