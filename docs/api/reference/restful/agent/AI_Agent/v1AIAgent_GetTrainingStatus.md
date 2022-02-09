---
title: POST Agents/AI/GetTrainingStatus
id: v1AIAgent_GetTrainingStatus
---

# POST Agents/AI/GetTrainingStatus

```http
POST /api/v1/Agents/AI/GetTrainingStatus
```

Calling the HugoAI endpoint to fetch the current training status.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/AI/GetTrainingStatus?$select=name,department,category/id
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

Carrier to describe the current categorization training status for a tenant in HugoAI



Carrier object for CategorizationStatusResponse.
Services for the CategorizationStatusResponse Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAIAgent">AI Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContextIdentifier | string | Contextidentifier to identify customer |
| Status | string | Determines if a training is running, finished or unavailable |
| CurrentModel |  | Current model information |
| PreviousModel |  | Previous model information |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/AI/GetTrainingStatus
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContextIdentifier": "error",
  "Status": "ea",
  "CurrentModel": {
    "ModelBuiltDateTime": "2011-02-25T18:28:47.671818+01:00",
    "Accuracy": 10806.032,
    "TicketCountForTraining": 166,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 975
      }
    }
  },
  "PreviousModel": {
    "ModelBuiltDateTime": "2004-10-24T18:28:47.6728179+02:00",
    "Accuracy": 4563.104,
    "TicketCountForTraining": 765,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 457
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
      "FieldLength": 802
    }
  }
}
```