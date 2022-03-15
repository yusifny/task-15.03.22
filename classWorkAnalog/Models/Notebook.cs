using System;
namespace classWorkAnalog.Models
{
    public class Notebook : Product
    {
        public string brandname;
        public string model;
        public int ram;
        public int storage;

        public Notebook(string brandname, string model, int ram, int storage, int price, int count) : base(price, count)
        {
            this.brandname = brandname;
            this.model = model;
            this.ram = ram;
            this.storage = storage;

        }
        public void GetInfo()
        {
            Console.WriteLine($"brand name:{brandname}\nmodel:{model}\nram:{ram}\nstorage:{storage}\nprice:{price}\ncount:{count}");
        }

    }
}