public class MainController : Singleton<MainController>
{
    internal SceneManager SceneManager { get; private set; }

    public void Awake()
    {
        SceneManager = SceneManager.Instance;
    }
}
