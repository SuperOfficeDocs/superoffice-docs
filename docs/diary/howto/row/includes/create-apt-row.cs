using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiate a AppointmentRow Type
  AppointmentRow newAppointment = AppointmentRow.CreateNew();

  //Set Default values to the AppointmentRow
  newAppointment.SetDefaults();

  //Assign values to the instantiated AppointmentRow
  newAppointment.Location = "Seminar Room 663";
  newAppointment.ContactId = 20;
  newAppointment.PersonId = 10;
  newAppointment.Alarm = 1254;
  newAppointment.DoBy = new DateTime(2007, 3, 31);
  newAppointment.HasAlarm = 1;

  //Saving the created AppointmentRow
  newAppointment.Save();
}