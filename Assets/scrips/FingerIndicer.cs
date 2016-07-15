using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FingerIndicer : MonoBehaviour
{

	[SerializeField] private Text m_text = null;

	void Start ()
	{
		if (m_text == null)
		{
			m_text = gameObject.GetComponent<Text> ();
		}
	}

	void Update ()
	{
		if (Input.touchCount > 0)
        {
            string text = string.Concat(Input.touchCount);
			m_text.text = text;  // cast from int manaannn
		}
        else if (Input.GetButton("Jump"))
        {
            string text = "3";
            m_text.text = text;  // cast from int manaannn
        }
		else
		{
			m_text.text = "0";
		}

	}
}