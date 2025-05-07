using UnityEngine;

public class rotacion : MonoBehaviour
{
    public Vector3 velocidadRotacion = new Vector3(0, 0, 50); //

    void Update()
    {   
        transform.Rotate(velocidadRotacion * Time.deltaTime);
    }
}
