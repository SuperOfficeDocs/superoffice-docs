```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "CanSupportMultiUse": false,
    "DefaultShowInGui": true,
    "DefaultShowInSelector": true,
    "IsActive": true,
    "Key": "contact.name",
    "ValueType": "string",
    "Mandatory": true,
    "EncodedDisplayName": "Company Name",
    "EncodedDisplayDescription": "The name of the contact/company",
    "IconHint": "company",
    "ControlInfos": [
      {
        "Type": "textbox",
        "Label": "Company name",
        "Dimension": 1,
        "ListProviderName": "",
        "ListProviderExtraInfo": "",
        "ListProviderPrimaryKeyName": "",
        "ListLeadText": "Enter company name",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 161
          }
        }
      }
    ],
    "EncodedDataCaption": "Company Name",
    "EncodedDataCaptionDescription": "Required field for contact identification",
    "CurrentOperationType": "set",
    "Values": [
      "Acme Corporation",
      "TechVision Solutions"
    ],
    "DisplayValues": [
      "Acme Corporation",
      "TechVision Solutions"
    ],
    "OperationInfos": [
      {
        "Key": "set",
        "EncodedDisplayName": "Set value",
        "EncodedLeadTexts": [
          "Set company name to",
          "Change company name to"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 338
          }
        }
      },
      {
        "Key": "append",
        "EncodedDisplayName": "Append text",
        "EncodedLeadTexts": [
          "Append to company name",
          "Add text to company name"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 255
          }
        }
      }
    ]
  }
]
```
