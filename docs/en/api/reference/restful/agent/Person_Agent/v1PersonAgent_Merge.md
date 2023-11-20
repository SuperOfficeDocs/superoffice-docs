---
title: POST Agents/Person/Merge
uid: v1PersonAgent_Merge
generated: true
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
| SourcePersonId | Integer |  |
| DestinationPersonId | Integer |  |
| MoveAfterDate | String |  |
| DeleteSource | Boolean |  |
| ReplaceEmptyFieldsOnDestination | Boolean |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Person/Merge
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourcePersonId": 148,
  "DestinationPersonId": 754,
  "MoveAfterDate": "2007-07-12T13:38:13.8116104+02:00",
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