```http!
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTaskHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 780,
  "IncludeProjectAppointments": false,
  "StartTime": "2008-09-09T10:10:58.3379359+02:00",
  "EndTime": "2000-10-12T10:10:58.3379359+02:00",
  "Count": 681,
  "TaskHeadingId": 116
}
```