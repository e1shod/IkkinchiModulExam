using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ConsoleApp1
{
    internal class PhoneService
    {
        public List<Phone> Phones = new List<Phone>();

        public Guid AddPhone(Phone phone)
        {
            phone.PhoneId = Guid.NewGuid();
            Phones.Add(phone);
            return phone.PhoneId;
        }

        public Guid DeletePhone(Guid phoneId)
        {
            Phone phone = null;

            foreach (var p in Phones)
            {
                if (p.PhoneId == phoneId)
                {
                    phone = p;
                    break;
                }
            }

            if (phone != null)
            {
                Phones.Remove(phone);
                return phoneId;
            }

            return Guid.Empty;
        }

        public List<Phone> GetAllPhone()
        {
            return Phones;
        }

        public void UpdatePhone(Phone updatedPhone)
        {
            Phone existingPhone = null;

            foreach (var p in Phones)
            {
                if (p.PhoneId == updatedPhone.PhoneId)
                {
                    existingPhone = p;
                    break;
                }
            }

            if (existingPhone != null)
            {
                existingPhone.Name = updatedPhone.Name;
                existingPhone.Model = updatedPhone.Model;
                existingPhone.Color = updatedPhone.Color;
                existingPhone.Price = updatedPhone.Price;
            }
        }

        public Phone GetPhoneById(Guid phoneId)
        {
            Phone phone = null;

            foreach (var p in Phones)
            {
                if (p.PhoneId == phoneId)
                {
                    phone = p;
                    break;
                }
            }

            return phone;
        }

    }
}
