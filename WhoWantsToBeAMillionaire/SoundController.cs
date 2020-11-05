using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WhoWantsToBeAMillionaire.Properties;

namespace WhoWantsToBeAMillionaire
{
	static class SoundController
	{
		public static SoundPlayer player { get; private set; }

		static SoundController()
		{
			player = new SoundPlayer();
			player.StreamChanged += Player_StreamChanged;
		}

		public static void StopSoundPlaying()
		{
			player.Stop();
		}

		public static void PlaySound(Stream soundToPlay)
		{
			player.Stream = soundToPlay;
			player.Play();
		}

		private static void Player_StreamChanged(object sender, EventArgs e)
		{
			StopSoundPlaying();
		}
	}
}
