```http!
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 590,
  "PersonId": 722,
  "AppointmentId": 730,
  "DocumentId": 711,
  "SaleId": 841,
  "SelectionId": 44,
  "ProjectId": 172,
  "CustomTags": [
    "sed",
    "ab"
  ],
  "CustomValues": [
    "consequatur",
    "error"
  ],
  "UiCulture": "dolores"
}
```