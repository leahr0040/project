using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class PropertyOwnerBL
    {
        public static bool AddPropertyOwner(PropertyOwnerDTO po)
        {

            PropertiesOwner poDal = PropertyOwnerDTO.ToDal(po);
            return PropertyOwnerDAL.AddPropertyOwner(poDal);
        }
        public static bool UpdatePropertyOwner(PropertyOwnerDTO po)
        {
            using (ArgamanExpressEntities db = new ArgamanExpressEntities())
            {
                PropertiesOwner pro = db.PropertiesOwners.Find(po.OwnerID);
                pro.OwnerID = p.OwnerID;
                pro.CityID = p.CityID;
                this.CityName = p.CityName;
                this.StreetID = p.StreetID;
                this.StreetName = p.StreetName;
                this.Number = p.Number;
                this.Size = p.Size;
                this.Floor = p.Floor;
                this.IsDivided = p.IsDivided;
                this.ManagmentPayment = p.ManagmentPayment;
                this.IsPaid = p.IsPaid;
                this.IsExclusivity = p.IsExclusivity;
                this.ExclusivityID = p.ExclusivityID;
                this.IsWarranty = p.IsWarranty;
                this.IsRented = p.IsRented;
                this.RoomsNum = p.RoomsNum;
                this.ApartmentNum = p.ApartmentNum;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public static bool DeletPropertyOwner(PropertyOwnerDTO po)
        {

            PropertiesOwner poDal = PropertyOwnerDTO.ToDal(po);
            return PropertyOwnerDAL.DeletePropertyOwner(poDal);
        }
        public static List<PropertyOwnerDTO> Search(string OwnerFirstName, string OwnerLastName, string Phone, string Email)
        {
            using (ArgamanExpressEntities db = new ArgamanExpressEntities())
            {
                List<PropertiesOwner> po;
                po = (from p in db.PropertiesOwners select p).ToList();
                if (OwnerFirstName != null)
                    po = (from p in po where p.OwnerFirstName.Contains(OwnerFirstName) select p).ToList();
                if (OwnerLastName != null)
                    po = (from p in po where p.OwnerLastName.Contains(OwnerLastName) select p).ToList();
                if (Phone != null)
                    po = (from p in po where p.Phone.Contains(Phone) select p).ToList();
                if (Email != null)
                    po = (from p in po where p.Email.Contains(Email) select p).ToList();

                List<PropertyOwnerDTO> podto = new List<PropertyOwnerDTO>();
                foreach (PropertiesOwner p in po)
                    podto.Add(new PropertyOwnerDTO(p));
                return podto;
            }
            return null;
        }
       
    }
}
