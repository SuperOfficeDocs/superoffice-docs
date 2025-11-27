```http!
POST /api/v1/Agents/Appointment/GetContactAppointmentsByTasks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 485,
  "StartTime": "2010-11-30T10:10:58.3622663+01:00",
  "EndTime": "2007-10-03T10:10:58.3622663+02:00",
  "Count": 362,
  "TaskIds": [
    112,
    972
  ]
}
```