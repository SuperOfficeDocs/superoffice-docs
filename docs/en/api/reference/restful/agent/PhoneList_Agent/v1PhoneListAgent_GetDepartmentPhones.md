---
title: POST Agents/PhoneList/GetDepartmentPhones
uid: v1PhoneListAgent_GetDepartmentPhones
generated: true
---

# POST Agents/PhoneList/GetDepartmentPhones

```http
POST /api/v1/Agents/PhoneList/GetDepartmentPhones
```

Returns an array of phone list items with the in-parameter as restriction.


The in-parameter must be a valid department id (UserGroupId).






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/GetDepartmentPhones?$select=name,department,category/id
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

DepartmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DepartmentId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonDirectPhone | string | Person Direct Phone |
| PersonCellPhone | string | Person Cell Phone |
| PersonPrivatePhone | string | Person Private Phone |
| PersonFaxNumber | string | Actual phone number as eneterd by the user |
| PersonPagerNumber | string | Actual phone number as eneterd by the user |
| PersonEmail | string | The address itself |
| Id | int32 | The contact or person's id |
| Name | string | The contact or person's name |
| Tooltip | string |  |
| UniqueId | string | Property setting a unique id indicating if this is a person or contact |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/PhoneList/GetDepartmentPhones
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DepartmentId": 412
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonDirectPhone": "611-543-3934",
    "PersonCellPhone": "085.559.1077",
    "PersonPrivatePhone": "1-941-537-4524 x3558",
    "PersonFaxNumber": "1003440",
    "PersonPagerNumber": "269421",
    "PersonEmail": "shyanne@cartwrighthettinger.uk",
    "Id": 570,
    "Name": "Aufderhar, Hauck and Cummings",
    "Tooltip": "quidem",
    "UniqueId": "dolorem",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 639
      }
    }
  }
]
```