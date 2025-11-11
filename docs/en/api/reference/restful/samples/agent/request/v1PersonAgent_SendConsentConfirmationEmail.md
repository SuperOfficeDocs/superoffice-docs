```http!
POST /api/v1/Agents/Person/SendConsentConfirmationEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 856,
  "EmailAddress": "cristobal@stoltenberg.ca",
  "EmailTemplateId": 997,
  "CultureLcidId": 9,
  "Subject": "quae"
}
```