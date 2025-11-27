```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "CanSupportMultiUse": false,
    "DefaultShowInGui": true,
    "DefaultShowInSelector": true,
    "IsActive": true,
    "Key": "contact.business",
    "ValueType": "listItem",
    "Mandatory": false,
    "EncodedDisplayName": "Business",
    "EncodedDisplayDescription": "Contact business/industry classification",
    "IconHint": "business",
    "ControlInfos": [
      {
        "Type": "listbox",
        "Label": "Select business",
        "Dimension": 1,
        "ListProviderName": "business",
        "ListProviderExtraInfo": "",
        "ListProviderPrimaryKeyName": "BusinessList",
        "ListLeadText": "Choose business/industry",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 253
          }
        }
      }
    ],
    "EncodedDataCaption": "Business",
    "EncodedDataCaptionDescription": "Classify contacts by industry sector",
    "CurrentOperationType": "set",
    "Values": [
      "10",
      "15"
    ],
    "DisplayValues": [
      "Technology",
      "Manufacturing"
    ],
    "OperationInfos": [
      {
        "Key": "set",
        "EncodedDisplayName": "Set value",
        "EncodedLeadTexts": [
          "Set business to",
          "Change business to"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 488
          }
        }
      },
      {
        "Key": "clear",
        "EncodedDisplayName": "Clear value",
        "EncodedLeadTexts": [
          "Clear business",
          "Remove business classification"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 50
          }
        }
      }
    ]
  }
]
```
