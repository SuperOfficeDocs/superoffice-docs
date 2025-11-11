```http!
POST /api/v1/Agents/Document/SubstituteTemplateVariablesWithCustomTags
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Source": "inventore",
  "GeneratorEncoding": "Html",
  "CustomTags": [
    "eaque",
    "quibusdam"
  ],
  "CustomValues": [
    "culpa",
    "qui"
  ],
  "ContactId": 99,
  "PersonId": 924,
  "AppointmentId": 941,
  "DocumentId": 206,
  "SaleId": 671,
  "SelectionId": 649,
  "ProjectId": 834,
  "CultureName": "sv"
}
```