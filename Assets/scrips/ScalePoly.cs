using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Collections;

public class ScalePoly : MonoBehaviour {

    private RectTransform m_transform = null;
    // private Image m_texture = null;
    private Vector2 m_originScale;
    [SerializeField] private int m_textureSize = 64;
   //  private WHAT, WHERE IS VBO :(:( m_shape = null;

	void Start ()
    {
	    if (m_transform == null)
        {
            m_transform = gameObject.GetComponent<RectTransform>();
        }
        //if (m_texture == null)
        //{
        //    m_texture = gameObject.GetComponent<Image>();
        //}

        m_originScale = m_transform.localScale;

    }
	
	void Update ()
    {
	    if (Input.touchCount > 0)
        {
            int amountInside = 0;
            float radius = ( m_textureSize * m_originScale.x ) / 2;
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Vector2.Distance(Input.touches[i].position, new Vector2(Screen.width / 2, Screen.height / 2)) < radius * transform.localScale.x)
                {
                    amountInside++;
                }
                m_transform.localScale = m_originScale * ( amountInside + 1 );
            }
        }
        else if (Input.GetButton("Jump"))
        {
            int amountInside = 3;
            m_transform.localScale = m_originScale * (amountInside + 1);
        }
        //else
        //{
        //    m_transform.localScale = m_originScale; //interpolate this nicely rite
        //}
        if ((( m_textureSize * m_originScale.y ) * m_transform.localScale.x > Screen.height) && ((m_textureSize * m_originScale.x) *m_transform.localScale.x > Screen.width))
        {
            // Application.Quit();
        }
        if ((Input.touchCount == 0) && (Input.GetButton("Jump") == false))
        {
            m_transform.localScale = m_originScale;
        }
    }
}
