```http!
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTask
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 24,
  "IncludeProjectAppointments": false,
  "StartTime": "2004-05-21T10:10:58.3309211+02:00",
  "EndTime": "2009-11-01T10:10:58.3309211+01:00",
  "Count": 795,
  "TaskId": 816
}
```