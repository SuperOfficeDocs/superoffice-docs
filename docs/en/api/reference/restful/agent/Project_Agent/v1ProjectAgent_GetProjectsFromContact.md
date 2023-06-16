---
title: POST Agents/Project/GetProjectsFromContact
uid: v1ProjectAgent_GetProjectsFromContact
generated: true
---

# POST Agents/Project/GetProjectsFromContact

```http
POST /api/v1/Agents/Project/GetProjectsFromContact
```

Returns all projects where the given contact has projectmembers.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectsFromContact?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Project/GetProjectsFromContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 917
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ProjectId": 874,
    "Name": "Grady Group",
    "Description": "Streamlined regional knowledge user",
    "URL": "http://www.example.com/",
    "Type": "voluptatem",
    "AssociateId": 17,
    "AssociateFullName": "Michael Zemlak",
    "TypeId": 43,
    "Updated": "2016-05-18T16:00:41.5707037+02:00",
    "StatusId": 634,
    "Status": "ut",
    "TextId": 915,
    "PublishTo": "2016-01-03T16:00:41.5707037+01:00",
    "PublishFrom": "2011-09-25T16:00:41.5707037+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "651573",
    "ActiveErpLinks": 481,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 765
      }
    }
  }
]
```