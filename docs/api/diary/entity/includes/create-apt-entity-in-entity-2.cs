using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieving an Instance of another Entity
  Contact newContact = Contact.GetFromIdxContactId(10);

  //Create a new instance of the Appointment ot be added to the Collection
  newContact.Appointments.AddNew();

  //Set Deafult Values to the created Appointment
  newContact.Appointments[0].SetDefaults();

  //Assigning values to the individual properties of the Appointment Entity
  //Assigning basic properties to the Appointment
  newContact.Appointments[0].Location = "Seminar Room 664";
  newContact.Appointments[0].EndDate = new DateTime(2007, 3, 4);
  newContact.Appointments[0].Status = SuperOffice.Data.AppointmentStatus.NotStarted;
  newContact.Appointments[0].Private = SuperOffice.Data.AppointmentPrivate.Public;
  newContact.Appointments[0].HasAlarm = 1;
  newContact.Appointments[0].Alarm = 5;

  //Assigning a Row type property to the Appointment Entity
  newContact.Appointments[0].Associate = SuperOffice.CRM.Rows.AssociateRow.GetFromIdxAssociateId(100);

  //Assigning an Entity type property to the Appointment
  newContact.Appointments[0].Contact = Contact.GetFromIdxContactId(20);
  newContact.Appointments[0].Person = Person.GetFromIdxPersonId(10);

  //Saving the Updated Entity
  newContact.Save();
}