---
title: PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
uid: v1ForeignAppEntity_SaveDeviceByIdentifier
generated: true
---

# PUT ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}

```http
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
```

Updates a ForeignDevice with deviceName that belongs to the application with applicationName.






| Path Part | Type | Description |
|-----------|------|-------------|
| applicationName | string | The name of the foreign application. **Required** |
| deviceName | string | The name of the foreign device. **Required** |
| deviceIdentifier | string | Unique id of device (Palm pilot device ID, version number, etc) **Required** |



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

## Request Body: foreignDevice 

Foreign device to save. Can be null if adding new device. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignDeviceId | Integer | Primary key |
| Name | String | Name of device |
| CreatedDate | String | Registered when  in UTC. |
| UpdatedDate | String | Last updated when  in UTC. |
| AssociateFullName | String | The person owning the Foreign Device |
| CreatedBy | String | The person that created the device. |
| UpdatedBy | String | The person that last updated this device. |
| DeviceIdentifier | String | Optional unique id of device (Palm pilot device ID, etc) |
| ForeignAppId | Integer | Reference to foregin application (device type) |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignDevice

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignDeviceId | int32 | Primary key |
| Name | string | Name of device |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| AssociateFullName | string | The person owning the Foreign Device |
| CreatedBy | string | The person that created the device. |
| UpdatedBy | string | The person that last updated this device. |
| DeviceIdentifier | string | Optional unique id of device (Palm pilot device ID, etc) |
| ForeignAppId | int32 | Reference to foregin application (device type) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/ForeignApp/{applicationName}/{deviceName}/{deviceIdentifier}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 72,
  "Name": "Watsica, Lebsack and Sipes",
  "CreatedDate": "2020-10-26T13:57:18.8109737+01:00",
  "UpdatedDate": "2001-11-23T13:57:18.8109737+01:00",
  "AssociateFullName": "Prof. Eloise Shanie Ebert I",
  "CreatedBy": "sapiente",
  "UpdatedBy": "quidem",
  "DeviceIdentifier": "cum",
  "ForeignAppId": 488
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 75,
  "Name": "Stiedemann, Deckow and Weber",
  "CreatedDate": "1998-03-06T13:57:18.8109737+01:00",
  "UpdatedDate": "2011-08-29T13:57:18.8109737+02:00",
  "AssociateFullName": "Zander Schimmel",
  "CreatedBy": "temporibus",
  "UpdatedBy": "qui",
  "DeviceIdentifier": "consequatur",
  "ForeignAppId": 393,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 245
    }
  }
}
```