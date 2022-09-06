---
title: POST Agents/Person/Merge
uid: v1PersonAgent_Merge
---

# POST Agents/Person/Merge

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
| Accept         | Content-type(s) you would like the response in:  |
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

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

Response body:

## Sample request

```http!
POST /api/v1/Agents/Person/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SourcePersonId": 893,
  "DestinationPersonId": 701,
  "MoveAfterDate": "2012-08-26T11:10:27.4624526+02:00",
  "DeleteSource": false,
  "ReplaceEmptyFieldsOnDestination": true
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```
