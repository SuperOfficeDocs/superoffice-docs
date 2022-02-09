---
title: POST Agents/Document/GetSuggestedDocumentEntity
id: v1DocumentAgent_GetSuggestedDocumentEntity
---

# POST Agents/Document/GetSuggestedDocumentEntity

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
POST /api/v1/Agents/Document/GetSuggestedDocumentEntity?suggestedDocumentEntityId=468
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
  "SuggestedDocumentId": 494,
  "Name": "Kuphal Group",
  "Tooltip": "molestias",
  "Rank": 435,
  "DoctmplId": 649,
  "Header": "omnis",
  "OurRef": "quia",
  "Deleted": false,
  "DocTmpl": {
    "DocumentTemplateId": 303,
    "Name": "Grimes, Hickle and Gislason",
    "Tooltip": "vel",
    "SaveInDb": 516,
    "Filename": "harum",
    "DefaultOref": "dicta",
    "RecordType": "Appointment",
    "Deleted": 139,
    "Direction": "Incoming",
    "AutoeventId": 959,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 642
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 729,
    "ProjTypeId": 709,
    "ProjTypeName": "Eichmann-Cassin",
    "ProjTypeTooltip": "sed",
    "ProjStatusId": 783,
    "ProjStatusName": "Huels Group",
    "ProjStatusTooltip": "provident",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 195
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 115,
    "SaleTypeId": 457,
    "SaleTypeName": "Kovacek-VonRueden",
    "SaleTypeTooltip": "commodi",
    "ProbId": 888,
    "ProbName": "Hilll, Parker and Pfeffer",
    "ProbTooltip": "cum",
    "Probability": 192,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 214
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "enable sticky applications"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 338
    }
  }
}
```