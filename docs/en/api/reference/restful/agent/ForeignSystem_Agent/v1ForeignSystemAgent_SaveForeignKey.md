---
title: POST Agents/ForeignSystem/SaveForeignKey
uid: v1ForeignSystemAgent_SaveForeignKey
generated: true
---

# POST Agents/ForeignSystem/SaveForeignKey

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignKey
```

Saves a key belonging to the ForeignApp and ForeignDevice specified.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/SaveForeignKey?$select=name,department,category/id
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

ForeignKey, ApplicationName, DeviceName, DeviceIdentifier 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ForeignKey | ForeignKey | Carrier object for ForeignKey. Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |
| ApplicationName | String |  |
| DeviceName | String |  |
| DeviceIdentifier | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ForeignKey

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/SaveForeignKey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignKey": null,
  "ApplicationName": "O'Hara, Roob and Rogahn",
  "DeviceName": "Smith, Hagenes and Morissette",
  "DeviceIdentifier": "quas"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "soluta",
  "Value": "et",
  "RecordId": 483,
  "CreatedDate": "2002-01-15T03:45:23.4829546+01:00",
  "UpdatedDate": "2021-05-31T03:45:23.4829546+02:00",
  "UpdatedBy": "itaque",
  "CreatedBy": "distinctio",
  "TableName": "Kulas, Kilback and Bins",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 34
    }
  }
}
```