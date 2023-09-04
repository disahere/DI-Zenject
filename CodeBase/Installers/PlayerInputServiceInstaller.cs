using UnityEngine;
using Zenject;

namespace CodeBase.Installers
{
    public sealed class PlayerInputServiceInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInputService playerInputServicePrefab;
        public override void InstallBindings()
        {
            Container.
                Bind<IPlayerInputService>().
                To<PlayerInputService>().
                FromComponentsInNewPrefab(playerInputServicePrefab).
                AsSingle();

            Container.BindInterfacesTo<IPlayerInputService>();
            Container.BindInterfacesAndSelfTo<IPlayerInputService>();
        }
    }
}