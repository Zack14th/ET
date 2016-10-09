﻿namespace Base
{
	public sealed class UI: Entity
	{
		public Entity Scene { get; set; }

		public UIType UIType { get; set; }

		public string Name { get; }
		
		public override void Dispose()
		{
			if (this.Id == 0)
			{
				return;
			}

			base.Dispose();
		}
	}
}