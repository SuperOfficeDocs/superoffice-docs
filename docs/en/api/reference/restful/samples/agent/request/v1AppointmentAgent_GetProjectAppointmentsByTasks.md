```http!
POST /api/v1/Agents/Appointment/GetProjectAppointmentsByTasks
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 34,
  "StartTime": "2023-03-11T10:10:58.3439353+01:00",
  "EndTime": "2020-05-03T10:10:58.3439353+02:00",
  "Count": 659,
  "TaskIds": [
    806,
    29
  ]
}
```