using System;

namespace VetCare_Manager
{
	public class Pet
	{
		public string? Imie { get; set; }
		public string? Rasa { get; set; }
		public string? Gatunek { get; set; }
		public DateTime DataUrodzenia { get; set; }
		public int OwnerId { get; set; }
	}
}