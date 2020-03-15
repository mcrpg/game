using System;
using System.Drawing;

namespace game.Assets.Infrastructure.Utils
{
	public class ChatColorUtil
	{
		public static string UtilFunction1(R, G, B : integer)
		{
			Color color = Color.FromArgb(R, G, B);

			return new UtilFunction1( "["+color+"("+R+","+G+","+B")]" );
		}

		public static string UtilFunction2(color : System.Drawing.Color)
		{
			// Вставьте сюда свой код,я не ебу что тут быть должно
			
			return new UtilFunction2( "["+color+"("+R+","+G+","+B")]" );
		}

		public static string UtilFunction3("[color(R,G,B)]" : string)
		{
			// И сюда

			return System.Drawing.Color;
		}
	}
}