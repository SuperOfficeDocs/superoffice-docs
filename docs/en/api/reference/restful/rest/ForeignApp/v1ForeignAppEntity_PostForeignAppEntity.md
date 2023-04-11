---
title: POST ForeignApp
uid: v1ForeignAppEntity_PostForeignAppEntity
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 585,
  "Name": "Wuckert, Rosenbaum and Cruickshank",
  "CreatedDate": "2017-03-08T15:29:29.7551997+01:00",
  "UpdatedDate": "2003-12-07T15:29:29.7551997+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 350,
      "Name": "Sauer LLC",
      "CreatedDate": "2023-01-20T15:29:29.7557007+01:00",
      "UpdatedDate": "2018-02-07T15:29:29.7557007+01:00",
      "AssociateFullName": "Gisselle Geovany Gottlieb IV",
      "CreatedBy": "hic",
      "UpdatedBy": "dolor",
      "DeviceIdentifier": "delectus",
      "ForeignAppId": 824
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 174,
  "Name": "Kohler, Gerhold and Bayer",
  "CreatedDate": "2009-07-10T15:29:29.7572001+02:00",
  "UpdatedDate": "2008-04-02T15:29:29.7572001+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 15,
      "Name": "Fisher Group",
      "CreatedDate": "2017-11-24T15:29:29.7576988+01:00",
      "UpdatedDate": "2023-01-15T15:29:29.7576988+01:00",
      "AssociateFullName": "Ms. Irwin Harber",
      "CreatedBy": "debitis",
      "UpdatedBy": "omnis",
      "DeviceIdentifier": "eum",
      "ForeignAppId": 588,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 954
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```