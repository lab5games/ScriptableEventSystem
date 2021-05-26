
namespace Lab5Games.Events
{
    public interface IScriptableEventListener<T>
    {
        void OnEvent(T item);
    }
}
