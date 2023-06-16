---
title: POST ForeignApp
uid: v1ForeignAppEntity_PostForeignAppEntity
generated: true
---

# POST ForeignApp

```http
POST /api/v1/ForeignApp
```

Creates a new ForeignAppEntity


Calls the ForeignSystem agent service SaveForeignAppEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/ForeignApp?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/ForeignApp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 605,
  "Name": "Mann-Gerlach",
  "CreatedDate": "2002-06-20T16:00:47.9615771+02:00",
  "UpdatedDate": "2001-01-07T16:00:47.9615771+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 215,
      "Name": "Bogan LLC",
      "CreatedDate": "2007-04-18T16:00:47.9615771+02:00",
      "UpdatedDate": "2006-04-23T16:00:47.9615771+02:00",
      "AssociateFullName": "Ara Mueller",
      "CreatedBy": "animi",
      "UpdatedBy": "sunt",
      "DeviceIdentifier": "blanditiis",
      "ForeignAppId": 897
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 80,
  "Name": "Hyatt-Rice",
  "CreatedDate": "2020-07-01T16:00:47.9615771+02:00",
  "UpdatedDate": "2011-06-15T16:00:47.9615771+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 176,
      "Name": "Mohr, McLaughlin and Lang",
      "CreatedDate": "2003-12-18T16:00:47.9615771+01:00",
      "UpdatedDate": "2012-05-13T16:00:47.9615771+02:00",
      "AssociateFullName": "Victoria Deckow",
      "CreatedBy": "deleniti",
      "UpdatedBy": "in",
      "DeviceIdentifier": "eligendi",
      "ForeignAppId": 540,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 308
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 777
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```