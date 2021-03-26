---
title: POST Agents/Quote/GetAllAvailableQuoteConnectionsWithPriceLists
id: v1QuoteAgent_GetAllAvailableQuoteConnectionsWithPriceLists
---

# POST Agents/Quote/GetAllAvailableQuoteConnectionsWithPriceLists

```http
POST /api/v1/Agents/Quote/GetAllAvailableQuoteConnectionsWithPriceLists
```

Get all available connections.

Some installed connections may not be available to the user. Includes pricelists for the connection. This is a heavy call





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GetAllAvailableQuoteConnectionsWithPriceLists?$select=name,department,category/id
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/Quote/GetAllAvailableQuoteConnectionsWithPriceLists
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "QuoteConnectionId": 560,
    "ERPName": "Halvorson-Rodriguez",
    "DisplayName": "Friesen, Waters and Hermiston",
    "DisplayDescription": "Grass-roots explicit open architecture",
    "Rank": 263,
    "ConnectorName": "Balistreri, Hackett and Hermiston",
    "ErpConnectionId": 784,
    "ExtraData": "facilis",
    "IsAvailable": true,
    "InitializeResponse": {
      "IsOk": false,
      "UserExplanation": "temporibus",
      "TechExplanation": "et",
      "ErrorCode": "qui",
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 634
        }
      }
    },
    "PriceLists": [
      {
        "PriceListId": 598,
        "ERPPriceListKey": "fuga",
        "QuoteConnectionId": 45,
        "Name": "Macejkovic-Roberts",
        "Description": "Operative zero defect projection",
        "Currency": "inventore",
        "CurrencyName": "McLaughlin, McGlynn and Denesik",
        "ValidFrom": "2005-06-30T16:48:30.465943+02:00",
        "ValidTo": "2003-09-09T16:48:30.465943+02:00",
        "IsActive": false,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "redefine impactful ROI"
            },
            "FieldType": "System.Int32",
            "FieldLength": 648
          }
        }
      }
    ],
    "AllAccess": true,
    "Deleted": true,
    "UserGroupAccessIds": [
      625,
      525
    ],
    "AssociateAccessIds": [
      843,
      34
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
        "FieldType": "System.Int32",
        "FieldLength": 983
      }
    }
  }
]
```