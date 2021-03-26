---
title: POST Agents/Quote/GetConnectionStartupResponse
id: v1QuoteAgent_GetConnectionStartupResponse
---

# POST Agents/Quote/GetConnectionStartupResponse

```http
POST /api/v1/Agents/Quote/GetConnectionStartupResponse
```

Returns the PluginResponseInfo for the connection initialization.

Does not initialize the connection, just returns what happened when initialize was called.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetConnectionStartupResponse?$select=name,department,category/id
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

QuoteConnectionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteConnectionId | int32 |  |


## Response: object

PluginResponse exists to be able to respond with more than just a true/false, but also an explanation. Such an explanation can be displayed on for instance a disabled “Place Order” button.



Carrier object for PluginResponse.
Services for the PluginResponse Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well. |
| UserExplanation | string | A localized explanation to the answer. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| Changes |  | Tablename/recordid of data changed by this method, that the client may need to reload |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/GetConnectionStartupResponse
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteConnectionId": 191
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "aut",
  "TechExplanation": "excepturi",
  "ErrorCode": "quia",
  "Changes": {
    "AddedRecords": [
      {},
      {}
    ],
    "UpdatedRecords": [
      {},
      {}
    ],
    "DeletedRecords": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 619
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "evolve sexy models"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "syndicate synergistic vortals"
      },
      "FieldType": "System.String",
      "FieldLength": 945
    }
  }
}
```