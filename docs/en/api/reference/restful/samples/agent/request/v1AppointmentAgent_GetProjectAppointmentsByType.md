```http!
POST /api/v1/Agents/Appointment/GetProjectAppointmentsByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 979,
  "StartTime": "2001-11-17T10:10:58.303636+01:00",
  "EndTime": "2005-03-29T10:10:58.303636+02:00",
  "Count": 410,
  "AppointmentType": "BookingForChecklist"
}
```