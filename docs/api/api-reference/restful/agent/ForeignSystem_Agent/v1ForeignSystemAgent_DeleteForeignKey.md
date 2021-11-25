---
title: POST Agents/ForeignSystem/DeleteForeignKey
id: v1ForeignSystemAgent_DeleteForeignKey
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
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

ForeignKey, ApplicationName, DeviceName, DeviceIdentifier, TableName, RecordId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignKey |  | Carrier object for ForeignKey. Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |
| TableName | string |  |
| RecordId | int32 |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |