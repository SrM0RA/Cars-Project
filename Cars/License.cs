using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class License
    {

        public int keyCode { get; set; }
        public string type { get; set; }
        public DateOnly initialDate { get; set; }
        public DateOnly expirationDate { get; set; }
        public bool status = false;

        public DateOnly today = new DateOnly(2022, 09, 14);

        public License createLicense(string typeParameter, DateOnly initialDateParameter, DateOnly expirationDateParameter)
        {
            License licenseTuned = new License();
            licenseTuned.type = typeParameter;
            licenseTuned.initialDate = initialDateParameter;
            licenseTuned.expirationDate = expirationDateParameter;
            if (licenseTuned.expirationDate >= today)
            {
                licenseTuned.status = true;
            }

            return licenseTuned;
        }
        public bool validA(License lic)
        {
            if (lic.expirationDate > today)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}