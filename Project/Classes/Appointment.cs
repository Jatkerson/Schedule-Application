using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Project
{
    public class Appointment
    {

        public int id { get; set; }
        public int userId { get; set; }
        public string type { get; set; }
        public string customerName { get; set; }
        public string start { get; set; }
        public string end { get; set; }

        public static List<Appointment> allAppointments = new List<Appointment>();


        public Appointment()
        {

        }


        public Appointment(int appointmentId, int appointmentUserId, string appointmentType, string appointmentCustomerName, string appointmentStart, string appointmentEnd)
        {
            id = appointmentId;
            userId = appointmentUserId;
            type = appointmentType;
            customerName = appointmentCustomerName;
            start = appointmentStart;
            end = appointmentEnd;
        }

    }
}
