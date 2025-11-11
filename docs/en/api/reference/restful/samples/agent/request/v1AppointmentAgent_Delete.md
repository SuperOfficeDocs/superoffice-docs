```http!
POST /api/v1/Agents/Appointment/Delete
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 393,
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": false,
  "SmtpEMailConnectionInfo": null,
  "ImapEMailConnectionInfo": null
}
```