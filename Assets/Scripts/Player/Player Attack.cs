using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float _impactDistance;
    [SerializeField] private Animator _animator;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            _animator.SetTrigger("Attack");
            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(ray, out hit, _impactDistance))
            {
                if(hit.transform.tag == "Sheep")
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
