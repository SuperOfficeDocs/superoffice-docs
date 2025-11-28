```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 165,
  "UniqueIdentifier": "ticket-priority-calculator",
  "Name": "Ticket Priority Calculator",
  "Description": "Automatically calculates and updates ticket priority based on customer VIP status and urgency",
  "IncludeId": "priority-calc",
  "AccessKey": "api-key-67890",
  "HierarchyId": 816,
  "Source": "#setLanguageLevel 3;\nInteger priority = 3;\nif (customer.isVIP()) { priority = 1; }\nticket.setValue(\"priority\", priority.toString());",
  "SourceCode": "#setLanguageLevel 3;\nInteger priority = 3;\nif (customer.isVIP()) { priority = 1; }\nticket.setValue(\"priority\", priority.toString());",
  "ScriptType": "CRMScript",
  "HtmlOutput": 0,
  "Includes": [
    998,
    408
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 4,
      "Delta": 0,
      "IncludeId": "customer-utils",
      "IncludedFrom": [
        "priority-calc",
        "ticket-handler"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2023-04-29T10:10:59.549738+02:00",
  "RegisteredAssociateId": 786,
  "Updated": "2018-07-03T10:10:59.549738+02:00",
  "UpdatedAssociateId": 864,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 524
    }
  }
}
```
