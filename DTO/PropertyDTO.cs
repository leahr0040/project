using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
  public class PropertyDTO
    {
        public int PropertyID { get; set; }
        public int OwnerID { get; set; }
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StreetID { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public Nullable<double> Size { get; set; }
        public Nullable<int> Floor { get; set; }
        public bool IsDivided { get; set; }
        public Nullable<double> ManagmentPayment { get; set; }
        public bool IsPaid { get; set; }
        public bool IsExclusivity { get; set; }
        public Nullable<int> ExclusivityID { get; set; }
        public bool IsWarranty { get; set; }
        public Nullable<bool> IsRented { get; set; }
        public Nullable<double> RoomsNum { get; set; }
        public Nullable<int> ApartmentNum { get; set; }

        public PropertyDTO()
        {

        }

        public PropertyDTO(Property p)
        {
           this.PropertyID =p.PropertyID;
            this.OwnerID =p.OwnerID;
            this.CityID =p.CityID;
            this.CityName =p.CityName;
            this.StreetID =p.StreetID;
            this.StreetName =p.StreetName;
            this.Number =p.Number;
            this.Size =p.Size;
            this.Floor =p.Floor;
            this.IsDivided =p.IsDivided;
            this.ManagmentPayment =p.ManagmentPayment;
            this.IsPaid =p.IsPaid;
            this.IsExclusivity =p.IsExclusivity;
            this.ExclusivityID =p.ExclusivityID;
            this.IsWarranty =p.IsWarranty;
            this.IsRented =p.IsRented;
            this.RoomsNum =p.RoomsNum;
            this.ApartmentNum =p.ApartmentNum;
        }
        
    }
}
