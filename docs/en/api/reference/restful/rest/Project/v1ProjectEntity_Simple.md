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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/Project/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity found.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 533,
  "Name": "Goyette, Nienow and Prosacco",
  "Description": "Synchronised tangible hardware",
  "URL": "http://www.example.com/",
  "Type": "quod",
  "AssociateId": 596,
  "AssociateFullName": "Nasir Shanahan",
  "TypeId": 521,
  "Updated": "2020-01-16T17:37:39.0233044+01:00",
  "StatusId": 528,
  "Status": "veniam",
  "TextId": 500,
  "PublishTo": "2014-03-18T17:37:39.0233044+01:00",
  "PublishFrom": "2014-07-09T17:37:39.0233044+02:00",
  "IsPublished": true,
  "URLName": "http://www.example.com/",
  "ProjectNumber": "261007",
  "ActiveErpLinks": 486,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 782
    }
  }
}
```