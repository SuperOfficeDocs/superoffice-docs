```http!
POST /api/v1/Agents/Appointment/GetProjectMemberAppointmentsByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 595,
  "StartTime": "2010-10-15T10:10:58.3269342+02:00",
  "EndTime": "2011-12-04T10:10:58.3269342+01:00",
  "Count": 48,
  "AppointmentType": "BookingForChecklist"
}
```