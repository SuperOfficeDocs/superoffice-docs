---
title: POST Agents/Quote/GetQuoteVersionWorkflowButtonStates
uid: v1QuoteAgent_GetQuoteVersionWorkflowButtonStates
generated: true
---

# POST Agents/Quote/GetQuoteVersionWorkflowButtonStates

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowButtonStates
```

Get all button states for the Quote version dialog.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowButtonStates?$select=name,department,category/id
```


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

## Request Body: request 

QuoteVersionId, QuoteAlternativeId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | Integer |  |
| QuoteAlternativeId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuoteVersionWorkflowState

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActionButtons | array | Array of visible buttons with defined actions in the quote verson dialog. |
| StateImage | QuoteVersionButtonState | Information about the state image for the current quote version. |
| UpdatePricesButton | QuoteVersionButtonState | Information about the action for the update prices button. |
| Status | QuoteVersionStatusInformation | Status information for the Quote Version. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowButtonStates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 897,
  "QuoteAlternativeId": 891
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ActionButtons": [
    {
      "Action": "Approve",
      "ImageHint": "repudiandae",
      "DisplayText": "saepe",
      "TooltipText": "non",
      "Enabled": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "StateImage": null,
  "UpdatePricesButton": null,
  "Status": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 909
    }
  }
}
```