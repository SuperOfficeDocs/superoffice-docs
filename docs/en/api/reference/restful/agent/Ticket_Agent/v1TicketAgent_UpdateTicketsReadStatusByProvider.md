---
title: POST Agents/Ticket/UpdateTicketsReadStatusByProvider
uid: v1TicketAgent_UpdateTicketsReadStatusByProvider
---

# POST Agents/Ticket/UpdateTicketsReadStatusByProvider

```http
POST /api/v1/Agents/Ticket/UpdateTicketsReadStatusByProvider
```

This method changes multiple tickets' read status







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/UpdateTicketsReadStatusByProvider?$select=name,department,category/id
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

Provider, Restrictions, NewStatus 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Provider | String |  |
| Restrictions | Array |  |
| NewStatus | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array


## Sample request

```http!
POST /api/v1/Agents/Ticket/UpdateTicketsReadStatusByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Provider": "enim",
  "Restrictions": [
    {
      "Name": "Gutkowski Inc and Sons",
      "Operator": "ratione",
      "Values": [
        "distinctio",
        "ut"
      ],
      "DisplayValues": [
        "repellendus",
        "et"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 275,
      "InterOperator": "And",
      "UniqueHash": 13
    }
  ],
  "NewStatus": "Green"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  968,
  686
]
```