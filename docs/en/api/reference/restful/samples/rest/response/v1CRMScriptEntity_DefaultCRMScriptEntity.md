```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EjscriptId": 107,
  "UniqueIdentifier": "contact-validation-001",
  "Name": "Contact Validation Script",
  "Description": "Validates contact data before saving to database",
  "IncludeId": "common-functions",
  "AccessKey": "script-access-key-001",
  "HierarchyId": 124,
  "Source": "scripts/contact/validation.crmscript",
  "SourceCode": "// Contact validation script\nfunction validate() { return true; }",
  "ScriptType": "CRMScript",
  "HtmlOutput": 92,
  "Includes": [
    575,
    233
  ],
  "SourceMaps": [
    {
      "LineNumberFrom": 680,
      "LineNumberTo": 531,
      "Delta": 763,
      "IncludeId": "utility-module",
      "IncludedFrom": [
        "common-lib.crmscript",
        "utils.crmscript"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "ValidationResult": null,
  "Registered": "2006-04-26T14:34:01.8459763+02:00",
  "RegisteredAssociateId": 793,
  "Updated": "2014-06-23T14:34:01.8459763+02:00",
  "UpdatedAssociateId": 528,
  "BlockedVerbs": "BlockAll",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 821
    }
  }
}
```