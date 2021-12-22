using System.Collections;
using UnityEngine;
using ThunderRoad;

namespace InstantSpellWheel
{
    public class InstantSpellWheel : LevelModule
    {
        private float sizeFadeDuration = 0.0f;

        public override IEnumerator OnLoadCoroutine()
        {
            foreach (var effect in Catalog.GetAllID(Catalog.Category.Effect))
                if (effect.Contains("Orb"))
                    foreach (var module in Catalog.GetData<EffectData>(effect).modules)
                        if (module is EffectModuleMesh mesh)
                            mesh.sizeFadeDuration = sizeFadeDuration;
            Debug.Log("(Instant Spell Wheel) Loaded successfully!");
            return base.OnLoadCoroutine();
        }
    }
}