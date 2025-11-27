```http!
POST /api/v1/Agents/Appointment/SaveWithCustomInvitation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": null,
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": false,
  "SmtpEMailConnectionInfo": null,
  "ImapEMailConnectionInfo": null,
  "EmailBody": "tobin.grady@haagritchie.uk",
  "Subject": "pariatur",
  "TemplateLanguage": "iste"
}
```