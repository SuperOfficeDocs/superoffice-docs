---
title: PUT ForeignApp/{id}
uid: v1ForeignAppEntity_PutForeignAppEntity
generated: true
---

# PUT ForeignApp/{id}

```http
PUT /api/v1/ForeignApp/{id}
```

Updates the existing ForeignAppEntity






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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 67,
  "Name": "Wuckert, Schiller and Turcotte",
  "CreatedDate": "2001-03-13T14:13:48.8836985+01:00",
  "UpdatedDate": "2017-10-12T14:13:48.8836985+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 902,
      "Name": "Wilderman, Gottlieb and VonRueden",
      "CreatedDate": "2017-01-05T14:13:48.8836985+01:00",
      "UpdatedDate": "2008-10-12T14:13:48.8836985+02:00",
      "AssociateFullName": "Prof. Jamie Sammy Stanton",
      "CreatedBy": "temporibus",
      "UpdatedBy": "deserunt",
      "DeviceIdentifier": "eveniet",
      "ForeignAppId": 566
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 ForeignAppEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 923,
  "Name": "Bode, Pouros and Sanford",
  "CreatedDate": "2011-08-14T14:13:48.8836985+02:00",
  "UpdatedDate": "2019-01-01T14:13:48.8836985+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 982,
      "Name": "Buckridge, Monahan and Jewess",
      "CreatedDate": "2002-06-15T14:13:48.8836985+02:00",
      "UpdatedDate": "2025-02-24T14:13:48.8836985+01:00",
      "AssociateFullName": "Kari Wyman",
      "CreatedBy": "ipsa",
      "UpdatedBy": "mollitia",
      "DeviceIdentifier": "eaque",
      "ForeignAppId": 498,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 719
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```