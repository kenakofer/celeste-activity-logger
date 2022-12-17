using System;

namespace Celeste.Mod.ActivityLogger {
    public class ActivityLoggerModule : EverestModule {
        
        public static ActivityLoggerModule Instance;

        public ActivityLoggerModule() {
            Instance = this;
        }

        public override void Load() {
        }

        public override void Unload() {
        }

    }
}
