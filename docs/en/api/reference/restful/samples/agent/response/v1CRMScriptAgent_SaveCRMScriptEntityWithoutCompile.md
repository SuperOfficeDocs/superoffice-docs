```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 864,
  "UniqueIdentifier": "contact-data-enrichment",
  "Name": "Contact Data Enrichment",
  "Description": "Enriches contact records with additional data from external sources",
  "IncludeId": "contact-enrich",
  "AccessKey": "api-key-24680",
  "HierarchyId": 108,
  "Source": "#setLanguageLevel 3;\nContact contact = getActiveContact();\nMap enrichedData = fetchExternalData(contact);\ncontact.setValue(\"industry\", enrichedData.get(\"industry\"));\ncontact.setValue(\"companySize\", enrichedData.get(\"size\"));",
  "SourceCode": "#setLanguageLevel 3;\nContact contact = getActiveContact();\nMap enrichedData = fetchExternalData(contact);\ncontact.setValue(\"industry\", enrichedData.get(\"industry\"));\ncontact.setValue(\"companySize\", enrichedData.get(\"size\"));",
  "ScriptType": "CRMScript",
  "HtmlOutput": 0,
  "Includes": [
    773,
    88
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 1,
      "LineNumberTo": 5,
      "Delta": 0,
      "IncludeId": "external-api-utils",
      "IncludedFrom": [
        "contact-enrich",
        "data-enrichment"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 339
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2000-09-18T10:10:59.5537413+02:00",
  "RegisteredAssociateId": 561,
  "Updated": "2011-11-16T10:10:59.5537413+01:00",
  "UpdatedAssociateId": 402,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 10
    }
  }
}
```
