using Zenject;
using UnityEngine;

namespace CodeBase.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject player;
        [SerializeField] private Transform playerSpawnTransform;
        
        public override void InstallBindings()
        {
            var playerInstance =
                Container.InstantiatePrefabForComponent<GameObject>(
                    player, playerSpawnTransform.position, Quaternion.identity, null);

            Container.
                Bind<GameObject>().
                FromInstance(playerInstance).
                AsSingle().
                NonLazy();
            Container.
                QueueForInject(playerInstance);
        }
    }
}