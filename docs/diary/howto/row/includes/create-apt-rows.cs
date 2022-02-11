using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Instantiate a AppointmentRow Type
  AppointmentRow newAppointment = AppointmentRow.CreateNew();

  //Set Default values to the Appointment Row
  newAppointment.SetDefaults();

  //Assign values to the instantiated AppointmentRow
  newAppointment.Location = "Seminar Room 661";
  newAppointment.ContactId = 20;
  newAppointment.PersonId = 10;
  newAppointment.Alarm = 1254;
  newAppointment.DoBy = new DateTime(2007, 3, 31);
  newAppointment.HasAlarm = 1;

  //Instantiate an AppointmentRows type class
  AppointmentRows newAppRows = AppointmentRows.CreateNew();

  //Adding the created Contacted to the Collection
  newAppRows.Add(newAppointment);

  //Saving the ContactRows Collection
  newAppRows.Save();