using System.Data;
using System;


namespace Hospital_Test.Models
{
    public class Maintain
    {
        public string maintain_id { get; set; }
        public DateTime maintain_date { get; set; }
        public string maintain_maintenance { get; set; }
        public string maintain_maintenance_phone { get; set; }
        public string maintain_delivery { get; set; }
        public string maintain_delivery_phone { get; set; }
        public string FK_device_id { get; set; }
        public string FK_status_id { get; set; }
        public string FK_room_id { get; set; }
        public string FK_finace_id { get; set; }
        public string FK_contact_id { get; set; }

    }
}
