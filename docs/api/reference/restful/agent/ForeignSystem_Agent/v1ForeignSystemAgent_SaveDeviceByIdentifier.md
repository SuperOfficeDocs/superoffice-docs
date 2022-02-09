---
title: POST Agents/ForeignSystem/SaveDeviceByIdentifier
id: v1ForeignSystemAgent_SaveDeviceByIdentifier
---

# POST Agents/ForeignSystem/SaveDeviceByIdentifier

```http
POST /api/v1/Agents/ForeignSystem/SaveDeviceByIdentifier
```

Updates a ForeignDevice with deviceName that belongs to the application with applicationName.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/SaveDeviceByIdentifier?$select=name,department,category/id
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

ApplicationName, DeviceName, DeviceIdentifier, ForeignDevice 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |
| ForeignDevice |  | Saves a foreign device belonging to the ForeignDevice and application name specified. <para /> Carrier object for ForeignDevice. Services for the ForeignDevice Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |


## Response: object

Saves a foreign device belonging to the ForeignDevice and application name specified.



Carrier object for ForeignDevice.
Services for the ForeignDevice Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/SaveDeviceByIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Toy-Rutherford",
  "DeviceName": "Haag Inc and Sons",
  "DeviceIdentifier": "ab",
  "ForeignDevice": {
    "ForeignDeviceId": 327,
    "Name": "Gutkowski-Boehm",
    "CreatedDate": "2000-07-20T18:28:49.210088+02:00",
    "UpdatedDate": "2004-11-09T18:28:49.210088+01:00",
    "AssociateFullName": "Elton Hettinger",
    "CreatedBy": "non",
    "UpdatedBy": "consequatur",
    "DeviceIdentifier": "et",
    "ForeignAppId": 220
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 757,
  "Name": "Hessel, Brakus and White",
  "CreatedDate": "2012-03-31T18:28:49.2110989+02:00",
  "UpdatedDate": "2007-09-05T18:28:49.2110989+02:00",
  "AssociateFullName": "Audreanne Gislason",
  "CreatedBy": "atque",
  "UpdatedBy": "ullam",
  "DeviceIdentifier": "itaque",
  "ForeignAppId": 602,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 349
    }
  }
}
```