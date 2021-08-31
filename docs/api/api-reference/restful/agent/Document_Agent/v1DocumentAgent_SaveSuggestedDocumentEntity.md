---
title: SaveSuggestedDocumentEntity
id: v1DocumentAgent_SaveSuggestedDocumentEntity
---

# SaveSuggestedDocumentEntity

```http
POST /api/v1/Agents/Document/SaveSuggestedDocumentEntity
```

Updates the existing SuggestedDocumentEntity or creates a new SuggestedDocumentEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The SuggestedDocumentEntity to be saved. 

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
POST /api/v1/Agents/Document/SaveSuggestedDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 220,
  "Name": "Gleason, Carroll and O'Conner",
  "Tooltip": "libero",
  "Rank": 732,
  "DoctmplId": 729,
  "Header": "ullam",
  "OurRef": "quia",
  "Deleted": false,
  "DocTmpl": {
    "DocumentTemplateId": 215,
    "Name": "Wiegand, Mayer and Haley",
    "Tooltip": "aut",
    "SaveInDb": 886,
    "Filename": "et",
    "DefaultOref": "sit",
    "RecordType": "Appointment",
    "Deleted": 28,
    "Direction": "Incoming",
    "AutoeventId": 717,
    "QuoteDocType": "ConfirmationLines"
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 897,
    "ProjTypeId": 673,
    "ProjTypeName": "Kozey, Lind and Kshlerin",
    "ProjTypeTooltip": "illo",
    "ProjStatusId": 64,
    "ProjStatusName": "Bayer, Effertz and West",
    "ProjStatusTooltip": "sapiente"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 90,
    "SaleTypeId": 427,
    "SaleTypeName": "Larson LLC",
    "SaleTypeTooltip": "quia",
    "ProbId": 67,
    "ProbName": "Harris Group",
    "ProbTooltip": "at",
    "Probability": 469
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 485,
  "Name": "Denesik LLC",
  "Tooltip": "itaque",
  "Rank": 500,
  "DoctmplId": 544,
  "Header": "deleniti",
  "OurRef": "voluptatum",
  "Deleted": false,
  "DocTmpl": {
    "DocumentTemplateId": 216,
    "Name": "Gleichner-Pagac",
    "Tooltip": "laudantium",
    "SaveInDb": 838,
    "Filename": "dolor",
    "DefaultOref": "culpa",
    "RecordType": "Appointment",
    "Deleted": 568,
    "Direction": "Incoming",
    "AutoeventId": 863,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 482
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 157,
    "ProjTypeId": 890,
    "ProjTypeName": "Pfeffer LLC",
    "ProjTypeTooltip": "numquam",
    "ProjStatusId": 335,
    "ProjStatusName": "Erdman, Olson and Dach",
    "ProjStatusTooltip": "nostrum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 865
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 979,
    "SaleTypeId": 964,
    "SaleTypeName": "Wehner Group",
    "SaleTypeTooltip": "id",
    "ProbId": 331,
    "ProbName": "Nikolaus, Nicolas and Hauck",
    "ProbTooltip": "exercitationem",
    "Probability": 428,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 169
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
      "FieldLength": 551
    }
  }
}
```