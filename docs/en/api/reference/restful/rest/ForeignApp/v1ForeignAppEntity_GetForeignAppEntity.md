---
title: GET ForeignApp/{id}
uid: v1ForeignAppEntity_GetForeignAppEntity
generated: true
---

# GET ForeignApp/{id}

```http
GET /api/v1/ForeignApp/{id}
```

Gets a ForeignAppEntity object.


Calls the ForeignSystem agent service GetForeignAppEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ForeignAppEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/ForeignApp/{id}?$select=name,department,category/id
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

ForeignAppEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ForeignAppEntity found. |
| 304 | ForeignAppEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ForeignAppEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | int32 | Primary key |
| Name | string | Name of foreign application |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | array | The devices that belong to this foreign app. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 ForeignAppEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 30 Dec 2008 13:57:18 G12T

{
  "ForeignAppId": 227,
  "Name": "Towne, Daniel and Howell",
  "CreatedDate": "2022-12-06T13:57:18.7953465+01:00",
  "UpdatedDate": "2008-12-30T13:57:18.7953465+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 687,
      "Name": "Emmerich LLC",
      "CreatedDate": "2005-08-28T13:57:18.8109737+02:00",
      "UpdatedDate": "2019-06-27T13:57:18.8109737+02:00",
      "AssociateFullName": "Flossie Delmer Grant MD",
      "CreatedBy": "odio",
      "UpdatedBy": "cum",
      "DeviceIdentifier": "voluptatem",
      "ForeignAppId": 596,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 295
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```