---
title: GetSuggestedDocumentEntity
id: v1DocumentAgent_GetSuggestedDocumentEntity
---

# GetSuggestedDocumentEntity

```http
POST /api/v1/Agents/Document/GetSuggestedDocumentEntity
```

Gets a SuggestedDocumentEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| suggestedDocumentEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetSuggestedDocumentEntity?suggestedDocumentEntityId=61
POST /api/v1/Agents/Document/GetSuggestedDocumentEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Document/GetSuggestedDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 77,
  "Name": "Kreiger LLC",
  "Tooltip": "reiciendis",
  "Rank": 219,
  "DoctmplId": 357,
  "Header": "voluptas",
  "OurRef": "aut",
  "Deleted": false,
  "DocTmpl": {
    "DocumentTemplateId": 801,
    "Name": "Koelpin Group",
    "Tooltip": "magni",
    "SaveInDb": 979,
    "Filename": "dolore",
    "DefaultOref": "tempore",
    "RecordType": "Appointment",
    "Deleted": 540,
    "Direction": "Incoming",
    "AutoeventId": 337,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 367
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 56,
    "ProjTypeId": 751,
    "ProjTypeName": "Wisoky LLC",
    "ProjTypeTooltip": "blanditiis",
    "ProjStatusId": 863,
    "ProjStatusName": "Keeling Group",
    "ProjStatusTooltip": "dolores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 546
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 960,
    "SaleTypeId": 787,
    "SaleTypeName": "Williamson LLC",
    "SaleTypeTooltip": "in",
    "ProbId": 810,
    "ProbName": "Rutherford-Pacocha",
    "ProbTooltip": "omnis",
    "Probability": 103,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "scale cross-platform paradigms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 497
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "whiteboard leading-edge portals"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 410
    }
  }
}
```