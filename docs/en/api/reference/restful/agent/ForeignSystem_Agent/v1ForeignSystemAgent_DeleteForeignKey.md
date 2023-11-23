---
title: POST Agents/ForeignSystem/DeleteForeignKey
uid: v1ForeignSystemAgent_DeleteForeignKey
generated: true
---

# POST Agents/ForeignSystem/DeleteForeignKey

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignKey
```

Deletes all specified occurrences of a key, belonging to the ForeignApp and ForeignDevice, table and record specified.


Specifying a blank table name will delete ALL keys of the given name; specifying a recordId of 0 will delete ALL keys of the given name for the given table.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/DeleteForeignKey?$select=name,department,category/id
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

ForeignKey, ApplicationName, DeviceName, DeviceIdentifier, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignKey | ForeignKey | Carrier object for ForeignKey. Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |
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
POST /api/v1/Agents/ForeignSystem/DeleteForeignKey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignKey": null,
  "ApplicationName": "Kassulke, McKenzie and Roob",
  "DeviceName": "Fahey Group",
  "DeviceIdentifier": "nostrum",
  "TableName": "Fahey, Simonis and Beatty",
  "RecordId": 736
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```