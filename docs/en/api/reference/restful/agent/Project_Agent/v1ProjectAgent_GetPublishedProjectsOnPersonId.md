---
title: POST Agents/Project/GetPublishedProjectsOnPersonId
uid: v1ProjectAgent_GetPublishedProjectsOnPersonId
generated: true
---

# POST Agents/Project/GetPublishedProjectsOnPersonId

```http
POST /api/v1/Agents/Project/GetPublishedProjectsOnPersonId
```

Get published projects where person  is a member







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetPublishedProjectsOnPersonId?$select=name,department,category/id
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

PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| Description | string | The projects description |
| URL | string | URL address |
| Type | string | The project type. |
| AssociateId | int32 | The project owner id (associate id) |
| AssociateFullName | string | The project owner |
| TypeId | int32 |  |
| Updated | date-time | Last updated date  in UTC. |
| StatusId | int32 | The projects status id |
| Status | string | The projects status |
| TextId | int32 | The id of the description |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool |  |
| URLName | string | Visible field |
| ProjectNumber | string | Automatically generated number |
| ActiveErpLinks | int32 | The number of active erp links |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/GetPublishedProjectsOnPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 941
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ProjectId": 405,
    "Name": "Gerlach, O'Kon and Gutkowski",
    "Description": "Front-line optimizing algorithm",
    "URL": "http://www.example.com/",
    "Type": "voluptatibus",
    "AssociateId": 537,
    "AssociateFullName": "Amber Beatty",
    "TypeId": 880,
    "Updated": "2023-02-04T13:28:23.491777+01:00",
    "StatusId": 143,
    "Status": "at",
    "TextId": 429,
    "PublishTo": "2021-08-16T13:28:23.491777+02:00",
    "PublishFrom": "2017-11-07T13:28:23.491777+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "938932",
    "ActiveErpLinks": 612,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 486
      }
    }
  }
]
```