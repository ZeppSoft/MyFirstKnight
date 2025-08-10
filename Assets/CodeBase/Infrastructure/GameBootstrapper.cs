using UnityEngine;

namespace CodeBase.Infrastructure
{
    /// <summary>
    /// The GameBootstrapper class is responsible for initializing the game.
    /// It is executed once before the first Update call after the MonoBehaviour is created.
    /// </summary>
    public class GameBootstrapper : MonoBehaviour
    {
        private Game _game;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Awake()
        {
            _game = new Game();
            // Prevent this GameBootstrapper instance from being destroyed when loading a new scene
            DontDestroyOnLoad(this);
        }
    }
}
