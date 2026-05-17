namespace Spellcast.Presentation.Screens
{
    public abstract class Router : InjectableMonoBehaviour
    {
        private View? currentView;
        
        protected void SwitchTo(View view)
        {
            currentView?.Close();
            
            currentView = view;

            currentView!.Open();
        }

        // TODO: Come up with better name and logic
        protected void Hide()
        {
            currentView?.Close();
            
            currentView = null;
        }
    }
}
