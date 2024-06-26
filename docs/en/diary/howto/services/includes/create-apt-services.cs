using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create an appointment agent
  using(AppointmentAgent appointmentAgent = new AppointmentAgent())
  {
    //Create an appointment entity through the appointment agent
    AppointmentEntity myAppointment = appointmentAgent.CreateDefaultAppointmentEntityByTypeAndAssociate(SuperOffice.Data.TaskType.Appointment, 103);

    //Assign values to some of the properties of the appointment
    myAppointment.Location = "5th Floor,Seminar Room";
    myAppointment.AlarmLeadTime = TimeSpan.FromMinutes(10.00);
    myAppointment.StartDate = DateTime.Today.AddDays(5);
    myAppointment.EndDate = DateTime.Today.AddDays(5);
    myAppointment.HasAlarm = true;
    myAppointment.Description = "this is a new appointment";
    myAppointment.AlldayEvent = true;

    //Save the newly created appointment in the database
    appointmentAgent.SaveAppointmentEntity(myAppointment);
  }
}