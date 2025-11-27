```http!
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailId": 551,
  "AttachmentIds": [
    "commodi",
    "nobis"
  ],
  "IncludeAttachments": false
}
```