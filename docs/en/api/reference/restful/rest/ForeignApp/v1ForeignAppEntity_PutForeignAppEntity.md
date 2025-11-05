---
title: PUT ForeignApp/{id}
uid: v1ForeignAppEntity_PutForeignAppEntity
generated: true
content_type: reference
---

# PUT ForeignApp/{id}

```http
PUT /api/v1/ForeignApp/{id}
```

Updates the existing ForeignAppEntity


NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ForeignAppEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/ForeignApp/{id}?$select=name,department,category/id
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

## Request Body: entity 

The ForeignAppEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignAppId | Integer | Primary key |
| Name | String | Name of foreign application |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the foreign application. |
| UpdatedBy | Associate | The person that last updated this foreign application. |
| Devices | Array | The devices that belong to this foreign app. |

## Response:

ForeignAppEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ForeignAppEntity updated. |
| 412 | Update stopped because ForeignAppEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/ForeignApp/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 784,
  "Name": "Rowe LLC",
  "CreatedDate": "2007-01-11T02:30:52.6474115+01:00",
  "UpdatedDate": "2019-06-29T02:30:52.6474115+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 60,
      "Name": "Schmidt-Satterfield",
      "CreatedDate": "2021-12-07T02:30:52.6474115+01:00",
      "UpdatedDate": "2005-04-18T02:30:52.6474115+02:00",
      "AssociateFullName": "Jamel Conn",
      "CreatedBy": "tenetur",
      "UpdatedBy": "laboriosam",
      "DeviceIdentifier": "inventore",
      "ForeignAppId": 980
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 251,
  "Name": "Shields-Schaefer",
  "CreatedDate": "2011-05-02T02:30:52.6474115+02:00",
  "UpdatedDate": "2006-07-19T02:30:52.6474115+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 999,
      "Name": "Cremin Group",
      "CreatedDate": "2024-01-01T02:30:52.6474115+01:00",
      "UpdatedDate": "2004-07-24T02:30:52.6474115+02:00",
      "AssociateFullName": "Jessika McGlynn",
      "CreatedBy": "explicabo",
      "UpdatedBy": "ut",
      "DeviceIdentifier": "amet",
      "ForeignAppId": 735,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 270
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 202
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```