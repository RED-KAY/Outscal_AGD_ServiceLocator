using UnityEngine;

/**  This script demonstrates implementation of the Observer Pattern.
  *  If you're interested in learning about Observer Pattern, 
  *  you can find a dedicated course on Outscal's website.
  *  Link: https://outscal.com/courses
  **/

namespace ServiceLocator.Events
{
    public class EventService : MonoBehaviour
    {
        public GameEventController<int> OnMapSelected { get; private set; }

        private static EventService instance;
        public static EventService Instance {  get { return instance; } }

        private void Awake()
        {
            OnMapSelected = new GameEventController<int>();

            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Debug.LogError("Trying to create another" + this.GetType().ToString() + " singleton!");
                Destroy(this.gameObject);
            }
        }
        
    }
}