---
title: CreateDefaultSuggestedDocumentEntity
id: v1DocumentAgent_CreateDefaultSuggestedDocumentEntity
---

# CreateDefaultSuggestedDocumentEntity

```http
POST /api/v1/Agents/Document/CreateDefaultSuggestedDocumentEntity
```

Set default values into a new SuggestedDocumentEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Carrier object for SuggestedDocumentEntity.
Services for the SuggestedDocumentEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IDocumentAgent">Document Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedDocumentId | int32 | Primary key |
| Name | string | Item name, visible in Guide |
| Tooltip | string | Tooltip / description |
| Rank | int32 | Rank, controls rank of non-instantiated items in Guide |
| DoctmplId | int32 | Type of the suggested document |
| Header | string | Suggested 'header' |
| OurRef | string | Suggested 'our reference' |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DocTmpl |  | Document template |
| ProjectTypeStatusLink |  | Project type and project status link info |
| SaleTypeStageLink |  | Sale type and stage link info. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Document/CreateDefaultSuggestedDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 737,
  "Name": "Friesen-Kuhlman",
  "Tooltip": "officiis",
  "Rank": 622,
  "DoctmplId": 973,
  "Header": "quod",
  "OurRef": "itaque",
  "Deleted": true,
  "DocTmpl": {
    "DocumentTemplateId": 638,
    "Name": "Rolfson Group",
    "Tooltip": "ut",
    "SaveInDb": 90,
    "Filename": "ipsa",
    "DefaultOref": "et",
    "RecordType": "Appointment",
    "Deleted": 131,
    "Direction": "Incoming",
    "AutoeventId": 169,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 250
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 130,
    "ProjTypeId": 453,
    "ProjTypeName": "Kuhn-Hilpert",
    "ProjTypeTooltip": "quaerat",
    "ProjStatusId": 240,
    "ProjStatusName": "Senger, Dietrich and Fay",
    "ProjStatusTooltip": "voluptatum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 75
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 273,
    "SaleTypeId": 538,
    "SaleTypeName": "Walker-Pouros",
    "SaleTypeTooltip": "facere",
    "ProbId": 422,
    "ProbName": "Welch, Kirlin and Ryan",
    "ProbTooltip": "quia",
    "Probability": 369,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 194
    }
  }
}
```