using VContainer;
using VContainer.Unity;

public class RootLifetimeScope : LifetimeScope
{
    public BattleViewWithDI battle;
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<BattlePresenterWithDI>();
        builder.Register<ModelWithDI>(Lifetime.Singleton);
        builder.RegisterComponent(battle);
    }
}
