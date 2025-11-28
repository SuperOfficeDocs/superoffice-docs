```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 327,
  "UniqueIdentifier": "email-notification-handler",
  "Name": "Email Notification Handler",
  "Description": "Sends automated email notifications when new tickets are created",
  "IncludeId": "email-handler",
  "AccessKey": "api-key-12345",
  "HierarchyId": 293,
  "Source": "#setLanguageLevel 3;\nString recipientEmail = getVariable(\"recipientEmail\");\nEmail().send(recipientEmail, \"New Ticket\", \"A new ticket has been created\");",
  "SourceCode": "#setLanguageLevel 3;\nString recipientEmail = getVariable(\"recipientEmail\");\nEmail().send(recipientEmail, \"New Ticket\", \"A new ticket has been created\");",
  "ScriptType": "CRMScript",
  "HtmlOutput": 0,
  "Includes": [
    55,
    554
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 3,
      "Delta": 0,
      "IncludeId": "email-utils",
      "IncludedFrom": [
        "email-handler",
        "notification-system"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 727
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "1998-08-30T10:10:59.5507377+02:00",
  "RegisteredAssociateId": 987,
  "Updated": "2003-02-11T10:10:59.5507377+01:00",
  "UpdatedAssociateId": 140,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 904
    }
  }
}
```
