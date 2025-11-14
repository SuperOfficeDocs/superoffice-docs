```http!
POST /api/v1/Agents/Appointment/GetContactAppointmentsByType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 442,
  "StartTime": "2019-09-13T10:10:58.3209343+02:00",
  "EndTime": "2021-02-06T10:10:58.3209343+01:00",
  "Count": 22,
  "AppointmentType": "BookingForChecklist"
}
```