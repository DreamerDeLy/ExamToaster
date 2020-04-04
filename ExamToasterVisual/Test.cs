using System;
using System.Collections.Generic;

namespace ExamToasterVisual
{
	public class Variant
	{
		public string title { get; set; }
		public string description { get; set; }
		public double rating { get; set; }
	}

	public class Question
	{
		public string title { get; set; }
		public string text { get; set; }
		public string image { get; set; }
		public bool multiply { get; set; }
		public List<Variant> variants { get; set; }
	}

	public class Rating
	{
		public string title { get; set; }
		public double rating { get; set; }
		public string image { get; set; }
	}

	public class Test
	{
		public string title { get; set; }
		public string description { get; set; }
		public string author { get; set; }
		public string image { get; set; }
		public List<Question> questions { get; set; }
		public List<Rating> ratings { get; set; }
	}
}
