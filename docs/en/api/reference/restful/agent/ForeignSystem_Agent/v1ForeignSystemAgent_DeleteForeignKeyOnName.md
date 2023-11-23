---
title: POST Agents/ForeignSystem/DeleteForeignKeyOnName
uid: v1ForeignSystemAgent_DeleteForeignKeyOnName
generated: true
---

# POST Agents/ForeignSystem/DeleteForeignKeyOnName

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignKeyOnName
```

Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified.


Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignKeyOnName?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ApplicationName, DeviceName, DeviceIdentifier, KeyName, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |
| KeyName | String |  |
| TableName | String |  |
| RecordId | Integer |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/DeleteForeignKeyOnName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Carroll-Tromp",
  "DeviceName": "Kilback Group",
  "DeviceIdentifier": "et",
  "KeyName": "Rolfson, Connelly and Gusikowski",
  "TableName": "Cummerata-Orn",
  "RecordId": 447
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```