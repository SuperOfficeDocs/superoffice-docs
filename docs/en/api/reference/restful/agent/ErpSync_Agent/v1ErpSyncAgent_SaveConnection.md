---
title: POST Agents/ErpSync/SaveConnection
uid: v1ErpSyncAgent_SaveConnection
generated: true
---

# POST Agents/ErpSync/SaveConnection

```http
POST /api/v1/Agents/ErpSync/SaveConnection
```

Saves a connection to the database.


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ErpSync/SaveConnection?$select=name,department,category/id
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
| Connection | ErpConnection | Information about a connection to the ERP system. <para /> Carrier object for ErpConnection. Services for the ErpConnection Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IErpSyncAgent">ErpSync Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ErpConnection

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ErpSync/SaveConnection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Connection": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ErpConnectionId": 107,
  "ErpConnectorId": 829,
  "DisplayName": "Schmidt Group",
  "DisplayDescription": "Horizontal demand-driven contingency",
  "Active": true,
  "ConnectionId": "minus",
  "MostRecentTimestamp": "cupiditate",
  "ConfigFields": {
    "ConfigFields1": "qui",
    "ConfigFields2": "non"
  },
  "Deleted": true,
  "AllAccess": true,
  "UserGroupAccessIds": [
    702,
    918
  ],
  "AssociateAccessIds": [
    729,
    700
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 178
    }
  }
}
```