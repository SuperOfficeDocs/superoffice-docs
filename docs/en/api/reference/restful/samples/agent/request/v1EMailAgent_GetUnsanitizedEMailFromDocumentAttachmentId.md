```http!
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocId": 543,
  "AttachmentIds": [
    "beatae",
    "et"
  ],
  "IncludeAttachments": false
}
```