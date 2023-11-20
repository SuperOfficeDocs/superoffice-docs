---
title: POST Agents/ForeignSystem/SaveDeviceByIdentifier
uid: v1ForeignSystemAgent_SaveDeviceByIdentifier
generated: true
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
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |
| ForeignDevice | ForeignDevice | Saves a foreign device belonging to the ForeignDevice and application name specified. <para /> Carrier object for ForeignDevice. Services for the ForeignDevice Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |

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
POST /api/v1/Agents/ForeignSystem/SaveDeviceByIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Gleason-Hills",
  "DeviceName": "Weissnat Group",
  "DeviceIdentifier": "est",
  "ForeignDevice": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ForeignDeviceId": 338,
  "Name": "Sipes Group",
  "CreatedDate": "2013-02-05T13:38:13.623981+01:00",
  "UpdatedDate": "2015-09-13T13:38:13.623981+02:00",
  "AssociateFullName": "Carolyn Orn",
  "CreatedBy": "rem",
  "UpdatedBy": "veritatis",
  "DeviceIdentifier": "atque",
  "ForeignAppId": 755,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 616
    }
  }
}
```