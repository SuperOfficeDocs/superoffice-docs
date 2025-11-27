```http!
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByTasks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 814,
  "IncludeProjectAppointments": false,
  "StartTime": "2016-12-10T10:10:58.3349354+01:00",
  "EndTime": "2015-03-14T10:10:58.3349354+01:00",
  "Count": 886,
  "TaskIds": [
    472,
    768
  ]
}
```