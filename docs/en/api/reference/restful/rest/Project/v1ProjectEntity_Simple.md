---
title: GET Project/{id}/Simple
uid: v1ProjectEntity_Simple
generated: true
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 112,
  "Name": "Keebler-Gibson",
  "Description": "Sharable dynamic approach",
  "URL": "http://www.example.com/",
  "Type": "corrupti",
  "AssociateId": 65,
  "AssociateFullName": "Nikki Willms",
  "TypeId": 21,
  "Updated": "2007-09-06T03:45:28.5296817+02:00",
  "StatusId": 422,
  "Status": "consequatur",
  "TextId": 262,
  "PublishTo": "2023-01-07T03:45:28.5296817+01:00",
  "PublishFrom": "2016-07-21T03:45:28.5296817+02:00",
  "IsPublished": false,
  "URLName": "http://www.example.com/",
  "ProjectNumber": "1443718",
  "ActiveErpLinks": 411,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 150
    }
  }
}
```