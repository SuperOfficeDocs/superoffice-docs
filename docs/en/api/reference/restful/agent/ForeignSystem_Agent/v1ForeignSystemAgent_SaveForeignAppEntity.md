---
title: POST Agents/ForeignSystem/SaveForeignAppEntity
uid: v1ForeignSystemAgent_SaveForeignAppEntity
generated: true
---

# POST Agents/ForeignSystem/SaveForeignAppEntity

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
```

Updates the existing ForeignAppEntity or creates a new ForeignAppEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignAppEntity

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

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignAppEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 985,
  "Name": "Kutch-Goldner",
  "CreatedDate": "2022-06-30T12:01:27.9002891+02:00",
  "UpdatedDate": "2021-07-28T12:01:27.9002891+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 884,
      "Name": "Halvorson, Walker and Lehner",
      "CreatedDate": "2003-06-03T12:01:27.9002891+02:00",
      "UpdatedDate": "2016-03-07T12:01:27.9002891+01:00",
      "AssociateFullName": "Erick Lindgren",
      "CreatedBy": "velit",
      "UpdatedBy": "fuga",
      "DeviceIdentifier": "ut",
      "ForeignAppId": 298
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 888,
  "Name": "Larkin, Murazik and Senger",
  "CreatedDate": "1999-02-02T12:01:27.9002891+01:00",
  "UpdatedDate": "2023-12-02T12:01:27.9002891+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 852,
      "Name": "Fahey LLC",
      "CreatedDate": "2011-10-15T12:01:27.9002891+02:00",
      "UpdatedDate": "2010-02-06T12:01:27.9002891+01:00",
      "AssociateFullName": "Rosendo Lockman DVM",
      "CreatedBy": "eveniet",
      "UpdatedBy": "ratione",
      "DeviceIdentifier": "porro",
      "ForeignAppId": 340,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 67
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 815
    }
  }
}
```