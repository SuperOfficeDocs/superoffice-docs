---
title: POST Agents/ForeignSystem/AddDeviceByIdentifier
uid: v1ForeignSystemAgent_AddDeviceByIdentifier
---

# POST Agents/ForeignSystem/AddDeviceByIdentifier

```http
POST /api/v1/Agents/ForeignSystem/AddDeviceByIdentifier
```

Adds a new ForeignDevice with deviceName that belongs to the application with applicationName, with an optional device-specific identifier.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/AddDeviceByIdentifier?$select=name,department,category/id
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

ApplicationName, DeviceName, DeviceIdentifier

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/AddDeviceByIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Lebsack-Greenholt",
  "DeviceName": "Sawayn Inc and Sons",
  "DeviceIdentifier": "iste"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 913,
  "Name": "Bernhard-Kerluke",
  "CreatedDate": "1996-07-07T11:10:27.0794526+02:00",
  "UpdatedDate": "2013-09-01T11:10:27.0794526+02:00",
  "AssociateFullName": "Deborah Heller",
  "CreatedBy": "asperiores",
  "UpdatedBy": "magni",
  "DeviceIdentifier": "ut",
  "ForeignAppId": 366,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 772
    }
  }
}
```
