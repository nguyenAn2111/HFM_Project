using System.Data;
using System;


namespace Hospital_Test.Models
{
    public class Repair
    {
        public string repair_id { get; set; }
        public DateTime repair_broken { get; set; }
        public int repair_priority { get; set; }
        public DateTime repair_date { get; set; }
        public DateTime repair_update_date { get; set; }
        public int repair_update_status { get; set; }
        public string repair_note { get; set; }
        public byte[] repair_picture { get; set; }
        public string repair_update_note { get; set; }
        public string FK_contact_id { get; set; }
        public string FK_room_id { get; set; }
        public string FK_device_id { get; set; }
        public string FK_status_id { get; set; }
        public string FK_finance_id { get; set; }

    }
}
