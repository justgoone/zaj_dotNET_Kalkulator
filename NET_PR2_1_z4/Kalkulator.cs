using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_PR2_1_z4
{
	class Kalkulator : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private string
			wynik,
			działanie
			;

		public string Wynik {
			get => wynik;
			set {
				wynik = value;
				PropertyChanged?.Invoke(
					this,
					new PropertyChangedEventArgs("Wynik")
					);
			}
		}
		public string Działanie {
			get => działanie;
			set
			{
				działanie = value;
				PropertyChanged?.Invoke(
					this,
					new PropertyChangedEventArgs("Działanie")
					);
			}
		}

		internal void WprowadźCyfrę(string? cyfra)
		{
			Wynik += cyfra;
		}
	}
}
