using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CaptStacheOOP
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Static2D background;
        private Button2D newGame;
        private Button2D loadGame;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            background = new Static2D(Content.Load<Texture2D>("GFX\\background"), 0, 0);
            newGame = new Button2D(Content.Load<Texture2D>("GFX\\MM\\newgame"),
                                    Content.Load<Texture2D>("GFX\\MM\\mo_newgame"), 0, 0);
            loadGame = new Button2D(Content.Load<Texture2D>("GFX\\MM\\loadgame"),
                                    Content.Load<Texture2D>("GFX\\MM\\mo_loadgame"), 0, 100);
        }

        protected override void Update(GameTime gameTime)
        {
            newGame.UpdateMe(Mouse.GetState().Position);
            loadGame.UpdateMe(Mouse.GetState().Position);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            background.DrawMe(_spriteBatch);
            newGame.DrawMe(_spriteBatch);
            loadGame.DrawMe(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
