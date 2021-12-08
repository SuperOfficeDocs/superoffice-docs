public class AjaxDemo
{
  public string CreateFollowUp()
  {
    SaleEntity sale = AgentFactory.GetSaleAgent().GetSaleEntity(SuperStateManager.GetCurrentId("sale"));
    if (sale != null)
    {
      AppointmentAgent agent = new AppointmentAgent();
      AppointmentEntity app = agent.CreateDefaultAppointmentEntityByType(SuperOffice.Data.TaskType.Appointment);
      app.Contact = sale.Contact;
      app.Person = sale.Person;
      app.Associate = sale.Associate;
      app.Description = "Sample Follow-up from Sale "+ sale.SaleId;
      app.StartDate = DateTime.Today.AddDays(7);
      app.EndDate = app.StartDate;
      app = agent.SaveAppointmentEntity(app);
      return app.AppointmentId.ToString();
    }
    else
      return String.Empty;
  }
}