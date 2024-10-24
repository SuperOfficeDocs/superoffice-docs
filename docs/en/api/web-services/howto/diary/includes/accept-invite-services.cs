using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Services;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Createing an instance of the Appointment Agent
  using(AppointmentAgent newAppAgt = new AppointmentAgent())
  {
    //Accepting the invitation
    AppointmentEntity newAppEnt = newAppAgt.Accept(150,SuperOffice.Data.RecurrenceUpdateMode.OnlyThis);
  }
}