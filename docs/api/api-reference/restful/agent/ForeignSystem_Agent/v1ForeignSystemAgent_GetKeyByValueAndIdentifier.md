---
title: POST Agents/ForeignSystem/GetKeyByValueAndIdentifier
id: v1ForeignSystemAgent_GetKeyByValueAndIdentifier
---

# POST Agents/ForeignSystem/GetKeyByValueAndIdentifier

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier
```

Get a foreignkey based on its name and value, that belongs to the specified deviceId, device, and application.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier?$select=name,department,category/id
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

ApplicationName, DeviceName, DeviceIdentifier, KeyName, KeyValue, TableName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |
| KeyName | string |  |
| KeyValue | string |  |
| TableName | string |  |


## Response: object

Carrier object for ForeignKey.
Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Key | string | Subkey (optional) |
| Value | string | Key value |
| RecordId | int32 | Record in the referenced table |
| CreatedDate | date-time | Registered when  in UTC. |
| UpdatedDate | date-time | Last updated when  in UTC. |
| UpdatedBy | string | Name of the person that last updated the foreign key |
| CreatedBy | string | Name of the person that created the foreign key |
| TableName | string | Table name, transformed to and from numeric table id by the service layer |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/ForeignSystem/GetKeyByValueAndIdentifier
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ApplicationName": "Wisoky-O'Conner",
  "DeviceName": "Volkman, Leannon and Mitchell",
  "DeviceIdentifier": "quasi",
  "KeyName": "Prohaska, Stracke and Herman",
  "KeyValue": "suscipit",
  "TableName": "Hansen, Haley and Legros"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "sunt",
  "Value": "ut",
  "RecordId": 657,
  "CreatedDate": "1999-02-28T18:28:49.2171189+01:00",
  "UpdatedDate": "2015-02-12T18:28:49.2171189+01:00",
  "UpdatedBy": "facilis",
  "CreatedBy": "labore",
  "TableName": "Smitham, Rempel and Osinski",
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
      "FieldLength": 259
    }
  }
}
```