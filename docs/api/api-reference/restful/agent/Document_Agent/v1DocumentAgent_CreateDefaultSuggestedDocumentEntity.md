---
title: POST Agents/Document/CreateDefaultSuggestedDocumentEntity
id: v1DocumentAgent_CreateDefaultSuggestedDocumentEntity
---

# POST Agents/Document/CreateDefaultSuggestedDocumentEntity

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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 927,
  "Name": "Davis LLC",
  "Tooltip": "eos",
  "Rank": 712,
  "DoctmplId": 838,
  "Header": "dolor",
  "OurRef": "et",
  "Deleted": true,
  "DocTmpl": {
    "DocumentTemplateId": 586,
    "Name": "Wintheiser-Larkin",
    "Tooltip": "reiciendis",
    "SaveInDb": 525,
    "Filename": "molestias",
    "DefaultOref": "sint",
    "RecordType": "Appointment",
    "Deleted": 985,
    "Direction": "Incoming",
    "AutoeventId": 275,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 930
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 213,
    "ProjTypeId": 659,
    "ProjTypeName": "Stiedemann, Funk and Hane",
    "ProjTypeTooltip": "delectus",
    "ProjStatusId": 807,
    "ProjStatusName": "Wuckert-Lindgren",
    "ProjStatusTooltip": "voluptatibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate one-to-one infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 35
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 270,
    "SaleTypeId": 419,
    "SaleTypeName": "O'Reilly Inc and Sons",
    "SaleTypeTooltip": "nobis",
    "ProbId": 438,
    "ProbName": "Schmitt Inc and Sons",
    "ProbTooltip": "est",
    "Probability": 812,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 265
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
      "FieldLength": 913
    }
  }
}
```