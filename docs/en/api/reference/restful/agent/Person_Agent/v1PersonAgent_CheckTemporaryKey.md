---
title: POST Agents/Person/CheckTemporaryKey
uid: v1PersonAgent_CheckTemporaryKey
generated: true
---

# POST Agents/Person/CheckTemporaryKey

```http
POST /api/v1/Agents/Person/CheckTemporaryKey
```

Check a temporary key for validity, and in case it is valid, return its domain, targetId and personId







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CheckTemporaryKey?$select=name,department,category/id
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

TemporaryKey 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TemporaryKey | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TemporaryKeyInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| Domain | string | The domain for this key. Unknown if key is not valid. |
| TargetId | int32 | The primary key of the entity this temporary key is for, dependent of dmain |
| PersonId | int32 | The person id this key is related to. May be null. |
| IsExpired | bool | Whether the key is expired or not. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/CheckTemporaryKey
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TemporaryKey": "debitis"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Domain": "ChangePasswordCustomerCenter",
  "TargetId": 237,
  "PersonId": 257,
  "IsExpired": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 697
    }
  }
}
```