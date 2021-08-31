---
title: Merge
id: v1PersonAgent_Merge
---

# Merge

```http
POST /api/v1/Agents/Person/Merge
```

Merge two persons.

The destination person will remain. You must specify the date after which activities will be moved along with the person.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/Merge?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

SourcePersonId, DestinationPersonId, MoveAfterDate, DeleteSource, ReplaceEmptyFieldsOnDestination 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourcePersonId | int32 |  |
| DestinationPersonId | int32 |  |
| MoveAfterDate | date-time |  |
| DeleteSource | bool |  |
| ReplaceEmptyFieldsOnDestination | bool |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |