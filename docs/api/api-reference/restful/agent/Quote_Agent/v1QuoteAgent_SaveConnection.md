---
title: POST Agents/Quote/SaveConnection
id: v1QuoteAgent_SaveConnection
---

# POST Agents/Quote/SaveConnection

```http
POST /api/v1/Agents/Quote/SaveConnection
```

Saves a connection to the database.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveConnection?$select=name,department,category/id
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

Connection 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Connection |  | Information about a connection to the ERP system. <para /> Carrier object for QuoteConnection. Services for the QuoteConnection Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>. |


## Response: object

Information about a connection to the ERP system.



Carrier object for QuoteConnection.
Services for the QuoteConnection Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteConnectionId | int32 | Primary key |
| ERPName | string | Name of the ERP system (programmatic). |
| DisplayName | string | Connection name shown to user; multi-language support. The name of the connector to display in a list so that the users can choose between them. Typically the name of the client, with maybe the ERP system in parenthesis. |
| DisplayDescription | string | Tooltip/description shown to user; multi-language support. Any other info available that would make an uncertain user chose the right connector. Typically, used for tooltip. |
| Rank | int32 | Rank order |
| ConnectorName | string | Programmatic name of the Connector plugin that implements this kind of connection |
| ErpConnectionId | int32 | The ERP Connection that this Quote connection is an extension of |
| ExtraData | string | Optional extra data, in XML format, for configuring the connector. Connector-specific! |
| IsAvailable | bool | Whether or not the specified connection is available. Typically, without network access the availability is false. |
| InitializeResponse |  | Status and Error message when the system called the connector Initialize method. Null if the connector has not been initialized yet. |
| PriceLists | array | The PriceLists that this connection offers. |
| AllAccess | bool | Is this connection accessible to everyone?  If not, then the QuoteConnectionAccess table tells us who can access it. |
| Deleted | bool | If set, then this is a row that has been 'deleted'; we do not physically delete rows to avoid disaster. |
| UserGroupAccessIds | array | Array of ids containing usergroups that will have access to this connection. |
| AssociateAccessIds | array | Array of ids containing associates that will have access to this connection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/SaveConnection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Connection": {
    "QuoteConnectionId": 471,
    "ERPName": "Mueller, Goyette and Sanford",
    "DisplayName": "Schultz-Dickens",
    "DisplayDescription": "Customer-focused modular time-frame",
    "Rank": 571,
    "ConnectorName": "Yost-Blanda",
    "ErpConnectionId": 135,
    "ExtraData": "quo",
    "IsAvailable": true,
    "InitializeResponse": {},
    "PriceLists": [
      {},
      {}
    ],
    "AllAccess": true,
    "Deleted": true,
    "UserGroupAccessIds": [
      351,
      647
    ],
    "AssociateAccessIds": [
      633,
      724
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteConnectionId": 768,
  "ERPName": "Christiansen-Mraz",
  "DisplayName": "Willms Inc and Sons",
  "DisplayDescription": "Object-based solution-oriented analyzer",
  "Rank": 812,
  "ConnectorName": "Gislason Group",
  "ErpConnectionId": 876,
  "ExtraData": "dolores",
  "IsAvailable": false,
  "InitializeResponse": {
    "IsOk": false,
    "UserExplanation": "neque",
    "TechExplanation": "ullam",
    "ErrorCode": "eligendi",
    "Changes": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 759
      }
    }
  },
  "PriceLists": [
    {
      "PriceListId": 390,
      "ERPPriceListKey": "quia",
      "QuoteConnectionId": 804,
      "Name": "Harris-Zulauf",
      "Description": "Team-oriented directional interface",
      "Currency": "quidem",
      "CurrencyName": "Cassin-Yost",
      "ValidFrom": "2004-04-13T18:28:49.9411372+02:00",
      "ValidTo": "2002-08-19T18:28:49.9411372+02:00",
      "IsActive": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 677
        }
      }
    }
  ],
  "AllAccess": false,
  "Deleted": true,
  "UserGroupAccessIds": [
    573,
    770
  ],
  "AssociateAccessIds": [
    605,
    68
  ],
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
      "FieldLength": 753
    }
  }
}
```