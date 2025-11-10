```http!
POST /api/v1/Agents/Appointment/GetPersonAppointmentsByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 583,
  "IncludeProjectAppointments": true,
  "StartTime": "2020-05-19T10:10:58.9276542+02:00",
  "EndTime": "2002-02-26T10:10:58.9276542+01:00",
  "Count": 861,
  "AppointmentType": "BookingForChecklist"
}
```