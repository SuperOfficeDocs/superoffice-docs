---
title: POST Agents/PhoneList/GetContactPhones
uid: v1PhoneListAgent_GetContactPhones
---

# POST Agents/PhoneList/GetContactPhones

```http
POST /api/v1/Agents/PhoneList/GetContactPhones
```

Returns an array of phone list items for all the persons belonging to a contact (company).

The in-parameter must be a valid contact-id.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/GetContactPhones?$select=name,department,category/id
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

ContactId

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/PhoneList/GetContactPhones
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 754
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonDirectPhone": "(214)776-8656 x2883",
    "PersonCellPhone": "(261)916-4810 x4701",
    "PersonPrivatePhone": "692-903-5226 x5262",
    "PersonFaxNumber": "349126",
    "PersonPagerNumber": "1018798",
    "PersonEmail": "edwin_schimmel@wunsch.info",
    "Id": 365,
    "Name": "Cruickshank-McLaughlin",
    "Tooltip": "cum",
    "UniqueId": "aut",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 774
      }
    }
  }
]
```
