
namespace Lab5Games.Events
{
    public class VoidRaiser : ScriptableEventRaiser<Void, VoidEvent>
    {
        public void Raise()
        {
            gameEvent.Raise();
        }
    }
}
