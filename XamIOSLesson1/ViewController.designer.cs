// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamIOSLesson1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BotonAccion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BotonLimpiar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelMensaje { get; set; }

        [Action ("BotonAccion_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BotonAccion_TouchUpInside (UIKit.UIButton sender);

        [Action ("BotonLimpiar_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BotonLimpiar_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BotonAccion != null) {
                BotonAccion.Dispose ();
                BotonAccion = null;
            }

            if (BotonLimpiar != null) {
                BotonLimpiar.Dispose ();
                BotonLimpiar = null;
            }

            if (LabelMensaje != null) {
                LabelMensaje.Dispose ();
                LabelMensaje = null;
            }
        }
    }
}