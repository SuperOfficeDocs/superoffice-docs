---
title: POST Agents/ErpSync/GetConnection
uid: v1ErpSyncAgent_GetConnection
---

# POST Agents/ErpSync/GetConnection

```http
POST /api/v1/Agents/ErpSync/GetConnection
```

Returns the specified connection.

## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/GetConnection?$select=name,department,category/id
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

ErpConnectionId

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| ErpConnectionId | int32 | Primary key |
| ErpConnectorId | int32 | The connector that this connection should call |
| DisplayName | string | Connection name shown to user; multi-language support |
| DisplayDescription | string | Tooltip/description shown to user; multi-language support |
| Active | bool | Is this connection currently active |
| ConnectionId | string | The GUID that uniquely identifies this connection; passed to the Connector in every call |
| MostRecentTimestamp | string | Datetime, transaction number or other identification of the point in time of the most-recently seen actor in the ERP system |
| ConfigFields | object | The config fields needed to establish a connection to the connector |
| Deleted | bool | If true, the connection has been deleted and should not be shown to the users. |
| AllAccess | bool | Is this connection accessible to everyone?  If not, then the ErpConnectionAccess table tells us who can access it |
| UserGroupAccessIds | array | Array of ids containing usergroups that will have access to this connection. |
| AssociateAccessIds | array | Array of ids containing associates that will have access to this connection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/GetConnection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 825
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 631,
  "ErpConnectorId": 578,
  "DisplayName": "Bergnaum, Johnson and Pacocha",
  "DisplayDescription": "Team-oriented fault-tolerant matrix",
  "Active": false,
  "ConnectionId": "accusamus",
  "MostRecentTimestamp": "maiores",
  "ConfigFields": {
    "ConfigFields1": "molestiae",
    "ConfigFields2": "voluptatibus"
  },
  "Deleted": true,
  "AllAccess": false,
  "UserGroupAccessIds": [
    842,
    416
  ],
  "AssociateAccessIds": [
    575,
    3
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 883
    }
  }
}
```
