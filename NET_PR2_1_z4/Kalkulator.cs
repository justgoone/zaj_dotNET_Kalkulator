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
			wynik = "0",
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
			if (wynik == "0")
				if (cyfra == "0")
					return;
				else
					Wynik = cyfra;
			else
				Wynik += cyfra;
		}

		internal void WprowadźPrzecinek()
		{
			if (wynik.Contains(','))
				return;
			else
				Wynik += ',';
		}

		internal void ZmieńZnak()
		{
			if (wynik == "0")
				return;
			else if (wynik[0] == '-')
				Wynik = wynik.Substring(1);
			else
				Wynik = '-' + wynik;
		}

		internal void KasujZnak()
		{
			if (wynik == "0")
				return;
			else if (
				wynik.Length == 1
				|| (wynik.Length == 2 && wynik[0] == '-')
				|| wynik == "-0,"
				)
				Wynik = "0";
			else
				Wynik = wynik.Substring(0, wynik.Length - 1);
		}

		internal void CzyśćWszystko()
		{
			CzyśćWynik();
		}

		internal void CzyśćWynik()
		{
			Wynik = "0";
		}
	}
}
