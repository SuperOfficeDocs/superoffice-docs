---
title: GET Project/{id}/Simple
uid: v1ProjectEntity_Simple
---

# GET Project/{id}/Simple

```http
GET /api/v1/Project/{id}/Simple
```

A simple Project object.


This is a simpler, smaller variation of the full ProjectEntity. Calls the Project agent service GetProject.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Project to return. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

ProjectEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity found. |
| 404 | Not Found. |

### Response body: Project

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
GET /api/v1/Project/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 137,
  "Name": "Ernser Inc and Sons",
  "Description": "Triple-buffered tertiary internet solution",
  "URL": "http://www.example.com/",
  "Type": "voluptatem",
  "AssociateId": 421,
  "AssociateFullName": "Hipolito Esperanza Wuckert DVM",
  "TypeId": 605,
  "Updated": "2021-07-09T15:29:29.9931602+02:00",
  "StatusId": 440,
  "Status": "dolores",
  "TextId": 231,
  "PublishTo": "2006-06-12T15:29:29.9931602+02:00",
  "PublishFrom": "2022-01-22T15:29:29.9931602+01:00",
  "IsPublished": false,
  "URLName": "http://www.example.com/",
  "ProjectNumber": "373790",
  "ActiveErpLinks": 309,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 944
    }
  }
}
```