using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Lists;
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
//create an instance of the InvitationProvider
  IArchiveProvider myInvitationProvider = new InvitationProvider();

  //set the order by rule we want
  myInvitationProvider.SetOrderBy(
    new ArchiveOrderByInfo("appointmentId", SuperOffice.Util.OrderBySortType.DESC));

  //set the columns we want to retrieve
  myInvitationProvider.SetDesiredColumns("appointmentId");

  //set the page size limit it close the results that we might get
  myInvitationProvider.SetPagingInfo(100, 0);

  //add the restriction we want
  myInvitationProvider.SetRestriction( 
    new ArchiveRestrictionInfo("associateId", "=", "17"),
    new ArchiveRestrictionInfo("date",">",DateTime.Today.ToString());

  //lets execute the provider and loop through the results when we get 
  //the first one we are going out of the loop
  int appID = 0;
  foreach (ArchiveRow row in myInvitationProvider.GetRows())
  {
    appID = System.Convert.ToInt32(SuperOffice.CRM.Globalization.CultureDataFormatter.LocalizeEncoded(row.GetDisplayValue("appointmentId")));
    break;
  }
  //create a appointment matrix for the appointment that we got
  AppointmentMatrix myAppMatrix = new AppointmentMatrix(appID, SuperOffice.Data.RecurrenceUpdateMode.OnlyThis);

  //and we accept finally
  myAppMatrix.Accept();
}