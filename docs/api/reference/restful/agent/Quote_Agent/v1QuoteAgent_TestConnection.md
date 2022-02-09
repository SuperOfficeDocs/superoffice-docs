---
title: POST Agents/Quote/TestConnection
id: v1QuoteAgent_TestConnection
---

# POST Agents/Quote/TestConnection

```http
POST /api/v1/Agents/Quote/TestConnection
```

Used by the Admin clients.

Testing if the connection data is sufficient to get a connection with the ERP system. The Connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet. TestConnection is called without InitializeConnector being called first.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/TestConnection?$select=name,department,category/id
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

ConnectorName, ConnectionData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectorName | string |  |
| ConnectionData | object |  |


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
POST /api/v1/Agents/Quote/TestConnection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectorName": "Schmeler Group",
  "ConnectionData": {
    "ConnectionData1": "et",
    "ConnectionData2": "voluptates"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "voluptatibus",
  "TechExplanation": "ab",
  "ErrorCode": "a",
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
        "FieldLength": 641
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
      "FieldLength": 257
    }
  }
}
```