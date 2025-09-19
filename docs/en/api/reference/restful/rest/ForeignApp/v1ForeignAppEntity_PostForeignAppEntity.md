---
title: POST ForeignApp
uid: v1ForeignAppEntity_PostForeignAppEntity
generated: true
content_type: reference
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 449,
  "Name": "Crooks, McKenzie and Hand",
  "CreatedDate": "2016-12-14T03:41:58.7617712+01:00",
  "UpdatedDate": "2018-05-21T03:41:58.7617712+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 857,
      "Name": "Brekke, Hodkiewicz and Hand",
      "CreatedDate": "2017-12-26T03:41:58.7617712+01:00",
      "UpdatedDate": "1999-05-08T03:41:58.7617712+02:00",
      "AssociateFullName": "Lavonne Jast Jr.",
      "CreatedBy": "quis",
      "UpdatedBy": "quo",
      "DeviceIdentifier": "aut",
      "ForeignAppId": 96
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignAppId": 395,
  "Name": "Braun, Koss and Hirthe",
  "CreatedDate": "2008-03-04T03:41:58.7617712+01:00",
  "UpdatedDate": "2015-05-23T03:41:58.7617712+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Devices": [
    {
      "ForeignDeviceId": 246,
      "Name": "Quigley, Langworth and Ruecker",
      "CreatedDate": "2011-07-06T03:41:58.7617712+02:00",
      "UpdatedDate": "2003-06-16T03:41:58.7617712+02:00",
      "AssociateFullName": "Alivia Ward III",
      "CreatedBy": "asperiores",
      "UpdatedBy": "quos",
      "DeviceIdentifier": "voluptas",
      "ForeignAppId": 950,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 390
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 694
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```