using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police
{
    internal class LicencePlate
    {
		private string plate;
		private void SetPlate(string plate) => this.plate = plate.Length < 10 ? plate : "Wrong format";
		public string Plate
		{
			get => plate;
			set => SetPlate(value);
		}
        public LicencePlate(string Plate) => this.plate = Plate;
        public override string ToString() => plate;
	     
	}
}
