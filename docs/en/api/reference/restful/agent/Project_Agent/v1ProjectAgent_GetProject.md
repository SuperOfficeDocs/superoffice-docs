---
title: POST Agents/Project/GetProject
uid: v1ProjectAgent_GetProject
---

# POST Agents/Project/GetProject

```http
POST /api/v1/Agents/Project/GetProject
```

Gets a Project object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProject?projectId=800
POST /api/v1/Agents/Project/GetProject?$select=name,department,category/id
```


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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/GetProject
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 248,
  "Name": "Ritchie, Nitzsche and Rutherford",
  "Description": "Automated analyzing monitoring",
  "URL": "http://www.example.com/",
  "Type": "facilis",
  "AssociateId": 449,
  "AssociateFullName": "Audra Pfeffer",
  "TypeId": 353,
  "Updated": "2006-09-09T02:49:44.952838+02:00",
  "StatusId": 441,
  "Status": "repellendus",
  "TextId": 982,
  "PublishTo": "2006-01-15T02:49:44.952838+01:00",
  "PublishFrom": "2011-08-16T02:49:44.952838+02:00",
  "IsPublished": true,
  "URLName": "http://www.example.com/",
  "ProjectNumber": "909449",
  "ActiveErpLinks": 452,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 66
    }
  }
}
```