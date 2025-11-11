```http!
POST /api/v1/Agents/Document/SubstituteTemplateVariablesWithCustomTags2
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Source": "ipsa",
  "GeneratorEncoding": "Html",
  "CustomTags": {
    "CustomTags1": "vel",
    "CustomTags2": "dolorum"
  },
  "ContactId": 236,
  "PersonId": 735,
  "AppointmentId": 91,
  "DocumentId": 825,
  "SaleId": 536,
  "SelectionId": 520,
  "ProjectId": 521,
  "CultureName": "sv"
}
```