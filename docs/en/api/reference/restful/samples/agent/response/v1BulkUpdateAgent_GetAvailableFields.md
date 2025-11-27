```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "CanSupportMultiUse": false,
    "DefaultShowInGui": true,
    "DefaultShowInSelector": true,
    "IsActive": true,
    "Key": "contact.category",
    "ValueType": "listItem",
    "Mandatory": false,
    "EncodedDisplayName": "Category",
    "EncodedDisplayDescription": "Contact category classification",
    "IconHint": "category",
    "ControlInfos": [
      {
        "Type": "listbox",
        "Label": "Select category",
        "Dimension": 1,
        "ListProviderName": "category",
        "ListProviderExtraInfo": "",
        "ListProviderPrimaryKeyName": "CategoryList",
        "ListLeadText": "Choose contact category",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 950
          }
        }
      }
    ],
    "EncodedDataCaption": "Category",
    "EncodedDataCaptionDescription": "Categorize contacts for reporting and filtering",
    "CurrentOperationType": "set",
    "Values": [
      "1",
      "2"
    ],
    "DisplayValues": [
      "Customer",
      "Prospect"
    ],
    "OperationInfos": [
      {
        "Key": "set",
        "EncodedDisplayName": "Set value",
        "EncodedLeadTexts": [
          "Set category to",
          "Change category to"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 535
          }
        }
      },
      {
        "Key": "clear",
        "EncodedDisplayName": "Clear value",
        "EncodedLeadTexts": [
          "Clear category",
          "Remove category"
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
