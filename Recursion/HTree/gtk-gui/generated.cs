//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recursion.HTree {
    
    
    internal class Gui {
        
        private static bool initialized;
        
#pragma warning disable 436
        
        public static void Build(object cobj, System.Type type) {
            global::Recursion.HTree.Gui.Build(cobj, type.FullName);
        }
        
        public static void Build(object cobj, string id) {
        }
        
        internal static void Initialize(Gtk.Widget iconRenderer) {
            if ((Gui.initialized == false)) {
                Gui.initialized = true;
            }
        }
    }
    
    internal class ActionGroups {
        
        public static Gtk.ActionGroup GetActionGroup(System.Type type) {
            return ActionGroups.GetActionGroup(type.FullName);
        }
        
        public static Gtk.ActionGroup GetActionGroup(string name) {
            return null;
        }
    }
}
