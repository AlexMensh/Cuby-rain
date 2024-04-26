using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CubeChanger))]
public class Cube : MonoBehaviour
{
    [SerializeField] private float _cubeLifetimeMin;
    [SerializeField] private float _cubeLifetimeMax;

    private CubeChanger _cubeChanger;
    private bool _isColorChanged = false;


    private void Start()
    {
        _cubeChanger = GetComponent<CubeChanger>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ground>() && _isColorChanged == false)
        {
            _cubeChanger.ColorChange();
            _isColorChanged = true;
            StartCoroutine(LifetimeCount());
        }
    }

    private IEnumerator LifetimeCount()
    {
        WaitForSeconds destroyDelay = new WaitForSeconds(Random.Range(_cubeLifetimeMin, _cubeLifetimeMax));

        yield return destroyDelay;

        Destroy(gameObject);
    }
}