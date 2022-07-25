---
title: POST Agents/Selection/GetRecipientStatistics
id: v1SelectionAgent_GetRecipientStatistics
---

# POST Agents/Selection/GetRecipientStatistics

```http
POST /api/v1/Agents/Selection/GetRecipientStatistics
```

Returns a RecipientStatistics object with a count of addresses, emailaddresses and emailaddresses.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GetRecipientStatistics?$select=name,department,category/id
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

SelectionId

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |

## Response: object

Class representing a RecipientStatistics carrier used for counting attributes on selection members.

Carrier object for RecipientStatistics.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Total | int32 | Total number of members. |
| ValidPostalAddresses | int32 | Number of members with a valid postal address. |
| ValidEmailAddresses | int32 | Number of members with a valid email address. |
| ValidFaxNumbers | int32 | Number of members with a valid fax number. |
| NoAddresses | int32 | Number of members with an invalid address. |
| NoFaxOrEmails | int32 | Number of members with no fax or email address. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Selection/GetRecipientStatistics
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 253
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Total": 888,
  "ValidPostalAddresses": 737,
  "ValidEmailAddresses": 546,
  "ValidFaxNumbers": 680,
  "NoAddresses": 810,
  "NoFaxOrEmails": 252,
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
      "FieldType": "System.String",
      "FieldLength": 908
    }
  }
}
```
