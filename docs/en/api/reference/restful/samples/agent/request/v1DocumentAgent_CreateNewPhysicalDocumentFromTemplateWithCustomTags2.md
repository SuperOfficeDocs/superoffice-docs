```http!
POST /api/v1/Agents/Document/CreateNewPhysicalDocumentFromTemplateWithCustomTags2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 227,
  "PersonId": 57,
  "AppointmentId": 127,
  "DocumentId": 882,
  "SaleId": 227,
  "SelectionId": 555,
  "ProjectId": 8,
  "CustomTags": {
    "CustomTags1": "et",
    "CustomTags2": "laudantium"
  },
  "UiCulture": "voluptatem"
}
```