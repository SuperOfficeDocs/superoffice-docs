using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Create an Appointment Entity
  Appointment newAppointment = Appointment.CreateNew();

  //Setting the Default values for the Appointment
  newAppointment.SetDefaults();

  //Assigning values to the individual properties of the Appointment Entity
  //Assigning basic properties to the Appointment
  newAppointment.Location = "Seminar Room 662";
  newAppointment.EndDate = new DateTime(2007, 3, 4);
  newAppointment.Status = SuperOffice.Data.AppointmentStatus.NotStarted;
  newAppointment.Private = SuperOffice.Data.AppointmentPrivate.Public;
  newAppointment.HasAlarm = 1;
  newAppointment.Alarm = 5;

  //Assigning a Row type property to the Appointment Entity
  newAppointment.Associate = SuperOffice.CRM.Rows.AssociateRow.GetFromIdxAssociateId(100);

  //Assigning an Entity type property to the Appointment
  newAppointment.Contact = Contact.GetFromIdxContactId(20);
  newAppointment.Person = Person.GetFromIdxPersonId(10);

  //Instantiating the Appointment Collection
  AppointmentCollection newAppCol = AppointmentCollection.CreateNew();

  //Adding the Contact Entity to the Collection and Saving the Collection
  newAppCol.Add(newAppointment);
  newAppCol.Save();
}