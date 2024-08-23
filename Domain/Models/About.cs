﻿using System;
using Domain.Common;

namespace Domain.Models
{
	public class About : BaseEntity
	{
		public string SinceDay { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Advantage1 { get; set; }
        public string Advantage2 { get; set; }
        public string Advantage3 { get; set; }
		public List<AboutImage> AboutImages { get; set; }
	}
}
