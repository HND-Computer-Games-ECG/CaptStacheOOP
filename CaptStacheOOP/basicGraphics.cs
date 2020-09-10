using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptStacheOOP
{
    class Static2D
    {
        protected Texture2D txr;
        protected Rectangle bounds;

        // Constructor
        public Static2D(Texture2D art, int x, int y)
        {
            txr = art;
            bounds = new Rectangle(x, y, art.Width, art.Height);
        }

        public virtual void DrawMe(SpriteBatch sb)
        {
            sb.Draw(txr, bounds, Color.White);
        }
    }

    class Button2D : Static2D
    {
        private Texture2D txrOn;
        private bool lit;

        // Constructor
        public Button2D(Texture2D artPassive, Texture2D artActive, int x, int y) 
            : base (artPassive, x, y)
        {
            txrOn = artActive;
        }

        public void UpdateMe(Point mousePos)
        {
            if (bounds.Contains(mousePos))
                lit = true;
            else
                lit = false;
        }

        public override void DrawMe(SpriteBatch sb)
        {
            if (lit)
                sb.Draw(txrOn, bounds, Color.White);
            else
                sb.Draw(txr, bounds, Color.White);
        }
    }

    class AnimatedButton : Button2D
    {
        public AnimatedButton (Texture2D artPassive, Texture2D artActive, int x, int y, int frameCount)
            : base(artPassive, artActive, x, y) 
        {

        }

    }
}
