﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Ratings
{
	public class Rating
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid ProductId { get; set; }
		public DateTime Timestamp { get; set; }
		public string LocationName { get; set; }
		public int RatingValue { get; set; }
		public string UserNotes { get; set; }
	}
}
