```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "UniqueIdentifier": "customer-welcome-email",
  "Name": "Customer Welcome Email",
  "Description": "Sends a welcome email to new customers with onboarding information",
  "IncludeId": "welcome-email",
  "Source": "#setLanguageLevel 3;\nCustomer customer = getActiveCustomer();\nString email = customer.getValue(\"email\");\nEmail().send(email, \"Welcome to SuperOffice\", getWelcomeEmailBody());",
  "Registered": "2024-02-15T10:30:00+01:00",
  "RegisteredBy": "John Anderson",
  "Updated": "2024-11-25T16:20:00+01:00",
  "UpdatedBy": "Sarah Johnson",
  "Path": "/scripts/customer/welcome-email",
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 925
    }
  }
}
```
