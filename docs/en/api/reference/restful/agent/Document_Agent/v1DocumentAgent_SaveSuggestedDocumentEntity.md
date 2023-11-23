---
title: POST Agents/Document/SaveSuggestedDocumentEntity
uid: v1DocumentAgent_SaveSuggestedDocumentEntity
generated: true
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
| SuggestedDocumentId | Integer | Primary key |
| Name | String | Item name, visible in Guide |
| Tooltip | String | Tooltip / description |
| Rank | Integer | Rank, controls rank of non-instantiated items in Guide |
| DoctmplId | Integer | Type of the suggested document |
| Header | String | Suggested 'header' |
| OurRef | String | Suggested 'our reference' |
| Deleted | Boolean | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DocTmpl | DocumentTemplate | Document template |
| ProjectTypeStatusLink | ProjectTypeStatusLink | Project type and project status link info |
| SaleTypeStageLink | SaleTypeStageLink | Sale type and stage link info. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SuggestedDocumentEntity

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
| DocTmpl | DocumentTemplate | Document template |
| ProjectTypeStatusLink | ProjectTypeStatusLink | Project type and project status link info |
| SaleTypeStageLink | SaleTypeStageLink | Sale type and stage link info. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Document/SaveSuggestedDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 81,
  "Name": "Nolan-Williamson",
  "Tooltip": "est",
  "Rank": 602,
  "DoctmplId": 232,
  "Header": "qui",
  "OurRef": "voluptatem",
  "Deleted": false,
  "DocTmpl": null,
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedDocumentId": 152,
  "Name": "Witting, Aufderhar and Emard",
  "Tooltip": "et",
  "Rank": 395,
  "DoctmplId": 766,
  "Header": "culpa",
  "OurRef": "itaque",
  "Deleted": false,
  "DocTmpl": null,
  "ProjectTypeStatusLink": null,
  "SaleTypeStageLink": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 368
    }
  }
}
```