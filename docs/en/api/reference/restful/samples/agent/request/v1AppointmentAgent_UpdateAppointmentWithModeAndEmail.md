```http!
POST /api/v1/Agents/Appointment/UpdateAppointmentWithModeAndEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Id": 485,
  "StartTime": "2015-05-10T10:10:58.3811066+02:00",
  "EndTime": "2008-09-23T10:10:58.3811066+02:00",
  "Status": "Assignment",
  "Type": "BookingForChecklist",
  "AssociateId": 207,
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": true,
  "SmtpEMailConnectionInfo": null,
  "ImapEMailConnectionInfo": null
}
```