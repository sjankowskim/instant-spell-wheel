using ThunderRoad;

namespace InstantSpellWheel
{
    public class InstantSpellWheel : ThunderScript
    {
        public override void ScriptLoaded(ModManager.ModData modData)
        {
            base.ScriptLoaded(modData);
            foreach (var effect in Catalog.GetAllID(Category.Effect))
                if (effect.Contains("Orb"))
                    foreach (var module in Catalog.GetData<EffectData>(effect).modules)
                        if (module is EffectModuleMesh mesh)
                            mesh.sizeFadeDuration = 0.0f;
        }
    }
}