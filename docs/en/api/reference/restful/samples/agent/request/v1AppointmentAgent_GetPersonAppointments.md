```http!
POST /api/v1/Agents/Appointment/GetPersonAppointments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 840,
  "IncludeProjectAppointments": false,
  "StartTime": "1998-07-01T10:10:58.9276542+02:00",
  "EndTime": "2020-09-03T10:10:58.9276542+02:00",
  "Count": 832
}
```