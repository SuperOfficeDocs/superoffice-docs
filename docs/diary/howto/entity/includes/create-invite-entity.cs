using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Appointment
  Appointment appointmentOne = Appointment.CreateNew();
  appointmentOne.SetDefaults();
  appointmentOne.AlldayEvent = 1;
  appointmentOne.DoBy = DateTime.Now.AddHours(8);
  appointmentOne.Task = TaskRow.GetFromIdxTaskId(14);
  appointmentOne.AppointmentText = TextRow.CreateNew();
  appointmentOne.AppointmentText.Text = "This is a Project Meeting";

  //Retrieve a person to invite
  Person invitee = Person.GetFromIdxPersonId(5);

  //Add participants to the Appointment
  SuperOffice.CRM.Services.ParticipantInfo[] participants = new SuperOffice.CRM.Services.ParticipantInfo[1];
  participants[0] = new SuperOffice.CRM.Services.ParticipantInfo();

  //Set the properties of the participant
  participants[0].AssociateId = invitee.AssociateId;
  participants[0].PersonId = invitee.PersonId;
  participants[0].SendEmail = false;
  RecurrenceUpdateMode recurrenceMode = RecurrenceUpdateMode.OnlyThis;

  //Add the appointment to the appointmentMatrix
  AppointmentMatrix appType = new AppointmentMatrix(appointmentOne, recurrenceMode);
  appType.AddParticipant(participants);

  //Save the appointment
  appType.Save();
}