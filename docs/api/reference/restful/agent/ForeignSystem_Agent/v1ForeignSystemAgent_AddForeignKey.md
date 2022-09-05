---
title: POST Agents/ForeignSystem/AddForeignKey
uid: v1ForeignSystemAgent_AddForeignKey
---

# POST Agents/ForeignSystem/AddForeignKey

```http
POST /api/v1/Agents/ForeignSystem/AddForeignKey
```

Add a new key belonging to the ForeignApp and ForeignDevice specified.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/ForeignSystem/AddForeignKey?$select=name,department,category/id
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
| ForeignKey |  | Carrier object for ForeignKey. Services for the ForeignKey Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IForeignSystemAgent">ForeignSystem Agent</see>. |
| ApplicationName | string |  |
| DeviceName | string |  |
| DeviceIdentifier | string |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
POST /api/v1/Agents/ForeignSystem/AddForeignKey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ForeignKey": null,
  "ApplicationName": "Oberbrunner, Blick and Larson",
  "DeviceName": "Green LLC",
  "DeviceIdentifier": "itaque"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Key": "officiis",
  "Value": "aut",
  "RecordId": 985,
  "CreatedDate": "1997-05-02T11:10:27.084458+02:00",
  "UpdatedDate": "2013-11-12T11:10:27.084458+01:00",
  "UpdatedBy": "nihil",
  "CreatedBy": "rem",
  "TableName": "Labadie-Friesen",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 399
    }
  }
}
```