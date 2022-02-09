---
title: POST Agents/PhoneList/Search
id: v1PhoneListAgent_Search
---

# POST Agents/PhoneList/Search

```http
POST /api/v1/Agents/PhoneList/Search
```

Searching the phone list.

Using default search preferences or the preferences already set by the PhoneListPreferences Service





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/PhoneList/Search?$select=name,department,category/id
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

SearchString 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SearchString | string |  |


## Response: array



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

## Sample Request

```http!
POST /api/v1/Agents/PhoneList/Search
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SearchString": "itaque"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "PersonDirectPhone": "320-812-5060 x6484",
    "PersonCellPhone": "(706)183-4882",
    "PersonPrivatePhone": "787.236.1473 x223",
    "PersonFaxNumber": "936887",
    "PersonPagerNumber": "299388",
    "PersonEmail": "marquis@kemmerfritsch.biz",
    "Id": 989,
    "Name": "Hayes, Bernier and Senger",
    "Tooltip": "dolorem",
    "UniqueId": "aspernatur",
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
        "FieldLength": 481
      }
    }
  }
]
```