using UnityEngine;

namespace Delegates_and_Events.Scripts.Delegates
{
    public class DelegatesExample : MonoBehaviour
    {
        private delegate void DelegateTest(int a);

        private void Start()
        {
            DelegateTest test = Plus;
            
            Debug.Log(test);

            SetValue(Plus);
        }

        private void Plus(int a)
        {
            a =+ 2;
        }

        private void SetValue(DelegateTest test)
        {
            test(10);
        }
    }
}
