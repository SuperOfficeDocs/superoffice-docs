using SuperOffice.CRM.Services;
using SuperOffice;

using (SoSession newSession = SoSession.Authenticate("user", "pass"))
{
  // Create the AppointmentAgent
  IAppointmentAgent agent = new AppointmentAgent();

  // Create an AppointmentEntity
  AppointmentEntity recurringAppointment = agent.CreateDefaultAppointmentEntity();

  // Set the appointment text
  recurringAppointment.Description = "This is a recurring appointment..";

  // Set the appointment contact
  IContactAgent contactAgent = new ContactAgent();
  recurringAppointment.Contact=contactAgent.GetContact(2);

  // Set the appointment duration
  DateTime tomorrow = DateTime.Today.AddDays(1);
  DateTime startTime = new DateTime(tomorrow.Year, tomorrow.Month, tomorrow.Day, 14, 00, 00);
  DateTime endTime = startTime.AddHours(1);

  // Date + start time planned
  recurringAppointment.StartDate = startTime;

  // Date + end time planned
  recurringAppointment.EndDate = endTime;

  // Set the recurrence information as to every working day for 8 days starting from tomorrow
  RecurrenceInfo recurrenceInfo = recurringAppointment.Recurrence;
  recurrenceInfo.Pattern = SuperOffice.Data.RecurrencePattern.Daily;
  recurrenceInfo.DayPattern = new RecurrenceDayPattern();
  recurrenceInfo.DayPattern.Pattern = SuperOffice.Data.RecurrenceDailyPattern.EveryWorkday;

  // recurrence start and end dates
  recurrenceInfo.StartDate = tomorrow;
  recurrenceInfo.RecurrenceCounter = 8;
  recurrenceInfo.RecurrenceEndType = SuperOffice.Data.RecurrenceEndType.Counter;

  // Calculate the days according to the recurrence pattern
  agent.CalculateDays(recurringAppointment);
  recurringAppointment.Recurrence = recurrenceInfo;

  // Save the recurrent appointment
  agent.SaveAppointmentEntity(recurringAppointment);
}