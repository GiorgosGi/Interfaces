﻿using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    class MotorBike : AutoMobile, IAutoMobileActions, IMotorBikeActions
    {
		
		public MotorBike()
		{

		}

		public MotorBike(bool IsOn)
		{
			this.IsOn = IsOn;
		}

		public void SteerLeft()
		{
			Console.WriteLine("The motorbike is steering left");
		}

		public void Break()
		{
			Console.WriteLine("The motorbike is breaking");
		}

		public void SteerRight()
		{
			Console.WriteLine("The motorbike is steering right");
		}

		public void Steer(bool steerLeft)
		{
            if (steerLeft)
            {
				Console.WriteLine("The motorbike is steering left");
			}
		}
	}
}
