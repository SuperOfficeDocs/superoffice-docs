---
title: POST Agents/PhoneList/GetFavoritesPhones
uid: v1PhoneListAgent_GetFavoritesPhones
generated: true
---

# POST Agents/PhoneList/GetFavoritesPhones

```http
POST /api/v1/Agents/PhoneList/GetFavoritesPhones
```

Returns an array of phone list items with the Contacts in the users favorites dropdown list.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/GetFavoritesPhones?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/PhoneList/GetFavoritesPhones
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonDirectPhone": "(693)986-3321 x63121",
    "PersonCellPhone": "511-069-6860 x3557",
    "PersonPrivatePhone": "1-501-132-8531 x3331",
    "PersonFaxNumber": "1197647",
    "PersonPagerNumber": "881701",
    "PersonEmail": "jerad.kreiger@rodriguez.name",
    "Id": 406,
    "Name": "Trantow-McClure",
    "Tooltip": "iusto",
    "UniqueId": "vero",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 654
      }
    }
  }
]
```