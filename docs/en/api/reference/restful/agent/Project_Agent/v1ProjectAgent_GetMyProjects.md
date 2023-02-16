---
title: POST Agents/Project/GetMyProjects
uid: v1ProjectAgent_GetMyProjects
---

# POST Agents/Project/GetMyProjects

```http
POST /api/v1/Agents/Project/GetMyProjects
```

Returning the projects belonging to an associate.


If memberProjects is false only the projects where the associate is project responsible is returned, otherwise both the projects where the associate is project responsible and project member is returned.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetMyProjects?$select=name,department,category/id
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

IncludeMemberProjects 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IncludeMemberProjects | Boolean |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/GetMyProjects
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "IncludeMemberProjects": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ProjectId": 745,
    "Name": "Daniel, Waelchi and Stiedemann",
    "Description": "Vision-oriented systemic strategy",
    "URL": "http://www.example.com/",
    "Type": "pariatur",
    "AssociateId": 288,
    "AssociateFullName": "Amparo Brakus",
    "TypeId": 571,
    "Updated": "2018-11-25T14:19:03.9688343+01:00",
    "StatusId": 169,
    "Status": "ullam",
    "TextId": 921,
    "PublishTo": "2009-04-16T14:19:03.9688343+02:00",
    "PublishFrom": "1997-01-04T14:19:03.9688343+01:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1102342",
    "ActiveErpLinks": 614,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 914
      }
    }
  }
]
```