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
  "SuggestedDocumentId": 950,
  "Name": "Howell LLC",
  "Tooltip": "aut",
  "Rank": 584,
  "DoctmplId": 653,
  "Header": "neque",
  "OurRef": "eos",
  "Deleted": false,
  "DocTmpl": {
    "DocumentTemplateId": 579,
    "Name": "Rempel, Nitzsche and Hammes",
    "Tooltip": "optio",
    "SaveInDb": 529,
    "Filename": "deleniti",
    "DefaultOref": "quaerat",
    "RecordType": "Appointment",
    "Deleted": 824,
    "Direction": "Incoming",
    "AutoeventId": 946,
    "QuoteDocType": "ConfirmationLines"
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 168,
    "ProjTypeId": 509,
    "ProjTypeName": "Feil-Parisian",
    "ProjTypeTooltip": "aliquid",
    "ProjStatusId": 796,
    "ProjStatusName": "Blanda, Mann and Klocko",
    "ProjStatusTooltip": "consequatur"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 980,
    "SaleTypeId": 6,
    "SaleTypeName": "Conn Group",
    "SaleTypeTooltip": "eos",
    "ProbId": 518,
    "ProbName": "Lind LLC",
    "ProbTooltip": "libero",
    "Probability": 290
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 547,
  "Name": "Monahan Group",
  "Tooltip": "soluta",
  "Rank": 570,
  "DoctmplId": 136,
  "Header": "eveniet",
  "OurRef": "tempora",
  "Deleted": true,
  "DocTmpl": {
    "DocumentTemplateId": 760,
    "Name": "Boehm, Bailey and Daniel",
    "Tooltip": "doloribus",
    "SaveInDb": 414,
    "Filename": "velit",
    "DefaultOref": "nihil",
    "RecordType": "Appointment",
    "Deleted": 982,
    "Direction": "Incoming",
    "AutoeventId": 824,
    "QuoteDocType": "ConfirmationLines",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 400,
    "ProjTypeId": 736,
    "ProjTypeName": "Murray, Senger and Klocko",
    "ProjTypeTooltip": "eligendi",
    "ProjStatusId": 230,
    "ProjStatusName": "Cruickshank-Abshire",
    "ProjStatusTooltip": "libero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 968
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 848,
    "SaleTypeId": 614,
    "SaleTypeName": "Rau Group",
    "SaleTypeTooltip": "aut",
    "ProbId": 113,
    "ProbName": "McGlynn, Hagenes and Kulas",
    "ProbTooltip": "et",
    "Probability": 707,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 216
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
      "FieldLength": 602
    }
  }
}
```