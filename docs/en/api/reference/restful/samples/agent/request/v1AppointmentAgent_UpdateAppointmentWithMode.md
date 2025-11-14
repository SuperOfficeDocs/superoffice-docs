```http!
POST /api/v1/Agents/Appointment/UpdateAppointmentWithMode
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Id": 954,
  "StartTime": "2005-11-24T10:10:58.3811066+01:00",
  "EndTime": "2008-09-28T10:10:58.3811066+02:00",
  "Status": "Assignment",
  "Type": "BookingForChecklist",
  "AssociateId": 237,
  "UpdateMode": "OnlyThis"
}
```