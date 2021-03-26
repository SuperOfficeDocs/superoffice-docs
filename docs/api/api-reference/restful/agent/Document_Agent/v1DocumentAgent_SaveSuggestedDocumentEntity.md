---
title: POST Agents/Document/SaveSuggestedDocumentEntity
id: v1DocumentAgent_SaveSuggestedDocumentEntity
---

# POST Agents/Document/SaveSuggestedDocumentEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 973,
  "Name": "Abernathy Group",
  "Tooltip": "doloremque",
  "Rank": 496,
  "DoctmplId": 480,
  "Header": "saepe",
  "OurRef": "labore",
  "Deleted": true,
  "DocTmpl": {
    "DocumentTemplateId": 193,
    "Name": "Stokes, Walter and Leffler",
    "Tooltip": "vero",
    "SaveInDb": 809,
    "Filename": "molestias",
    "DefaultOref": "laborum",
    "RecordType": "Appointment",
    "Deleted": 406,
    "Direction": "Incoming",
    "AutoeventId": 618,
    "QuoteDocType": "ConfirmationLines"
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 477,
    "ProjTypeId": 854,
    "ProjTypeName": "Grant-Pouros",
    "ProjTypeTooltip": "laudantium",
    "ProjStatusId": 772,
    "ProjStatusName": "Gislason Inc and Sons",
    "ProjStatusTooltip": "numquam"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 794,
    "SaleTypeId": 869,
    "SaleTypeName": "Kuphal, Von and Gutmann",
    "SaleTypeTooltip": "odio",
    "ProbId": 32,
    "ProbName": "Yost, Braun and Hamill",
    "ProbTooltip": "fugiat",
    "Probability": 301
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 911,
  "Name": "Bernhard Inc and Sons",
  "Tooltip": "adipisci",
  "Rank": 696,
  "DoctmplId": 289,
  "Header": "consectetur",
  "OurRef": "harum",
  "Deleted": true,
  "DocTmpl": {
    "DocumentTemplateId": 101,
    "Name": "Kutch, Trantow and Waters",
    "Tooltip": "qui",
    "SaveInDb": 634,
    "Filename": "voluptatem",
    "DefaultOref": "aliquam",
    "RecordType": "Appointment",
    "Deleted": 601,
    "Direction": "Incoming",
    "AutoeventId": 57,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 464,
    "ProjTypeId": 177,
    "ProjTypeName": "Rice Inc and Sons",
    "ProjTypeTooltip": "veniam",
    "ProjStatusId": 858,
    "ProjStatusName": "Schroeder, Nicolas and Mraz",
    "ProjStatusTooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable virtual schemas"
        },
        "FieldType": "System.String",
        "FieldLength": 895
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 977,
    "SaleTypeId": 973,
    "SaleTypeName": "Toy, Durgan and Medhurst",
    "SaleTypeTooltip": "incidunt",
    "ProbId": 489,
    "ProbName": "Mayert-Bins",
    "ProbTooltip": "quidem",
    "Probability": 530,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate revolutionary infrastructures"
        },
        "FieldType": "System.String",
        "FieldLength": 997
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
      "FieldType": "System.Int32",
      "FieldLength": 235
    }
  }
}
```