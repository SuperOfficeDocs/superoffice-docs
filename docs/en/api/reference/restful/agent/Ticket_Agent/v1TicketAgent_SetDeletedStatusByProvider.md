---
title: POST Agents/Ticket/SetDeletedStatusByProvider
uid: v1TicketAgent_SetDeletedStatusByProvider
---

# POST Agents/Ticket/SetDeletedStatusByProvider

```http
POST /api/v1/Agents/Ticket/SetDeletedStatusByProvider
```

Sets tickets' status to Deleted.


After a grace period these tickets will be deleted by a background job.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/SetDeletedStatusByProvider?$select=name,department,category/id
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

ProviderName, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProviderName | String |  |
| Restrictions | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array


## Sample request

```http!
POST /api/v1/Agents/Ticket/SetDeletedStatusByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Little-Schiller",
  "Restrictions": [
    {
      "Name": "Wehner, Wiza and Barton",
      "Operator": "aspernatur",
      "Values": [
        "fugiat",
        "vel"
      ],
      "DisplayValues": [
        "cupiditate",
        "sequi"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 953,
      "InterOperator": "And",
      "UniqueHash": 258
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  796,
  5
]
```