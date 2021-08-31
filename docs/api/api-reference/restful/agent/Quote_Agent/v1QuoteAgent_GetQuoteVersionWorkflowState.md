---
title: GetQuoteVersionWorkflowState
id: v1QuoteAgent_GetQuoteVersionWorkflowState
---

# GetQuoteVersionWorkflowState

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowState
```

Get all button states for the Quote version dialog.

Packages ImageState, Button states and status info into one call. Collects most important warnings/errors from across all quotelines/alternatives in this quote version.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowState?$select=name,department,category/id
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
POST /api/v1/Agents/Quote/GetQuoteVersionWorkflowState
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 55,
  "QuoteAlternativeId": 105
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ActionButtons": [
    {
      "Action": "Approve",
      "ImageHint": "id",
      "DisplayText": "nobis",
      "TooltipText": "eaque",
      "Enabled": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate next-generation e-markets"
          },
          "FieldType": "System.String",
          "FieldLength": 107
        }
      }
    }
  ],
  "StateImage": {
    "Action": "Approve",
    "ImageHint": "sunt",
    "DisplayText": "amet",
    "TooltipText": "nisi",
    "Enabled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 487
      }
    }
  },
  "UpdatePricesButton": {
    "Action": "Approve",
    "ImageHint": "velit",
    "DisplayText": "ipsum",
    "TooltipText": "et",
    "Enabled": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 322
      }
    }
  },
  "Status": {
    "Status": "Error",
    "IconHint": "qui",
    "DisplayMessage": "maxime",
    "DisplayTooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 578
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
      "FieldLength": 584
    }
  }
}
```