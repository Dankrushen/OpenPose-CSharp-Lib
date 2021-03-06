﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPose.Pose
{
	public abstract class KeyPoint
	{
		public double Score { get; protected set; }
		public BodyPoint BodyPoint { get; protected set; }

		public bool IsValid
		{
			get
			{
				return Score > 0;
			}
		}

		public double Yaw { get; protected set; }
		public double Pitch { get; protected set; }
		public double Roll { get; protected set; }
	}
}
