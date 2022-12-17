using System;

namespace Celeste.Mod.activity-logger {
    public class activity-loggerModule : EverestModule {
        
        public static activity-loggerModule Instance;

        public activity-loggerModule() {
            Instance = this;
        }

        public override void Load() {
        }

        public override void Unload() {
        }

    }
}
