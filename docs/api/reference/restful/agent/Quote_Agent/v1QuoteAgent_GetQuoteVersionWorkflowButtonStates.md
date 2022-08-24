---
title: POST Agents/Quote/GetQuoteVersionWorkflowButtonStates
id: v1QuoteAgent_GetQuoteVersionWorkflowButtonStates
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
| QuoteVersionId | int32 |  |
| QuoteAlternativeId | int32 |  |

## Response: object

Information about possible button actions for the quote version dialog.

Carrier object for QuoteVersionWorkflowState.
Services for the QuoteVersionWorkflowState Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActionButtons | array | Array of visible buttons with defined actions in the quote verson dialog. |
| StateImage |  | Information about the state image for the current quote version. |
| UpdatePricesButton |  | Information about the action for the update prices button. |
| Status |  | Status information for the Quote Version. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowButtonStates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 249,
  "QuoteAlternativeId": 950
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ActionButtons": [
    {
      "Action": "Approve",
      "ImageHint": "repellat",
      "DisplayText": "maxime",
      "TooltipText": "rerum",
      "Enabled": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 84
        }
      }
    }
  ],
  "StateImage": {
    "Action": "Approve",
    "ImageHint": "sint",
    "DisplayText": "dolor",
    "TooltipText": "ut",
    "Enabled": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 333
      }
    }
  },
  "UpdatePricesButton": {
    "Action": "Approve",
    "ImageHint": "vel",
    "DisplayText": "quas",
    "TooltipText": "pariatur",
    "Enabled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 429
      }
    }
  },
  "Status": {
    "Status": "Error",
    "IconHint": "architecto",
    "DisplayMessage": "quasi",
    "DisplayTooltip": "magni",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 903
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
      "FieldLength": 10
    }
  }
}
```
