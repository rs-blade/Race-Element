﻿using ACCManager.HUD.Overlay.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCManager.HUD.ACC.Overlays.OverlayDamage
{
    internal sealed class DamageOverlay : AbstractOverlay
    {
        public DamageOverlay(Rectangle rectangle) : base(rectangle, "Damage")
        {
            this.Width = 150;
            this.Height = 300;
        }

        public override bool ShouldRender() => DefaultShouldRender();

        public override void BeforeStart()
        {
        }

        public override void BeforeStop()
        {
        }

        public override void Render(Graphics g)
        {
        }

    }
}