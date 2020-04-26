using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class PulseMaterial : MonoBehaviour
{
    public float speed = 1.0f;
    public float magnitude = 1.0f;
    public float offset = 0.0f;

    private Renderer _render;
    private Material _mat;
    private Color _orgCol;
    private Color _transparentColor;

    private float i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _render = this.GetComponent<Renderer>();
        _mat = _render.material;
        _orgCol = _mat.color;
        _transparentColor = _orgCol;
        _transparentColor.a = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        i += Time.deltaTime;
        float t = Mathf.Sin( i * speed ) * magnitude - offset;
        Mathf.Clamp01(t);
        _mat.color = Color.Lerp(_transparentColor, _orgCol, t);
        _render.material = _mat;
    }
}
