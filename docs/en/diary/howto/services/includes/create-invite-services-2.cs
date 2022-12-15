using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the appointment agent
  using(AppointmentAgent myAgent = new AppointmentAgent())
  {
    //create a default appointment
    AppointmentEntity myAppointment = myAgent.CreateDefaultAppointmentEntity();

    //set the start date and time
    myAppointment.StartDate = System.Convert.ToDateTime("08/08/2007 3:00:00 PM");

    //set the end date and time
    myAppointment.EndDate = System.Convert.ToDateTime("08/08/2007 5:00:00PM");

    //set a description
    myAppointment.Description = "Team Meeting";

    //create a participant array object
    ParticipantInfo[] myParticipantArray = new ParticipantInfo[3];

    //set the associate id of the participant
    myParticipantArray[0] = new ParticipantInfo();
    myParticipantArray[0].AssociateId = 17;

    //Book resource for the appointment. this can be a meeting room, projector etc...
    myParticipantArray[1] = new ParticipantInfo();
    myParticipantArray[1].AssociateId = 41;

    //add person who is from another contact
    myParticipantArray[2] = new ParticipantInfo();
    myParticipantArray[2].PersonId = 42;

    //set the array to the participants property
    myAppointment.Participants = myParticipantArray;
    //save the appointment
    myAgent.Save(myAppointment,
      SuperOffice.Data.RecurrenceUpdateMode.OnlyThis,false,null,null);
  }
}