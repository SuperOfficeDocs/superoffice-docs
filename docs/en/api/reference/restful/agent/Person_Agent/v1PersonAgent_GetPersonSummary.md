---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 766,
  "Limit": 130
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 861,
      "TicketStatus": 580,
      "Title": "magnam",
      "Registered": "2013-08-05T14:28:22.196011+02:00",
      "IconHint": "reiciendis"
    },
    {
      "TicketId": 861,
      "TicketStatus": 580,
      "Title": "magnam",
      "Registered": "2013-08-05T14:28:22.196011+02:00",
      "IconHint": "reiciendis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 587,
      "DocumentId": 872,
      "Date": "2013-04-29T14:28:22.196011+02:00",
      "Description": "Reduced eco-centric projection",
      "Completed": "Completed",
      "Registered": "2025-02-11T14:28:22.196011+01:00"
    },
    {
      "AppointmentId": 587,
      "DocumentId": 872,
      "Date": "2013-04-29T14:28:22.196011+02:00",
      "Description": "Reduced eco-centric projection",
      "Completed": "Completed",
      "Registered": "2025-02-11T14:28:22.196011+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 750,
      "DocumentId": 718,
      "Date": "2018-10-26T14:28:22.196011+02:00",
      "Description": "Adaptive uniform challenge",
      "Completed": "Completed",
      "Registered": "2011-11-20T14:28:22.196011+01:00"
    },
    {
      "AppointmentId": 750,
      "DocumentId": 718,
      "Date": "2018-10-26T14:28:22.196011+02:00",
      "Description": "Adaptive uniform challenge",
      "Completed": "Completed",
      "Registered": "2011-11-20T14:28:22.196011+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 544,
      "SaleDate": "2007-07-13T14:28:22.196011+02:00",
      "Probability": 458,
      "Heading": "ut",
      "Amount": 7443.25,
      "Currency": "distinctio",
      "AmountInBaseCurrency": 20580.978,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2008-04-14T14:28:22.196011+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 741,
      "Name": "Weissnat, Wilderman and Bradtke",
      "CompanyName": "Renner-O'Kon",
      "FirstMessage": "amet",
      "LastMessage": "sunt",
      "WhenRequested": "2012-08-30T14:28:22.196011+02:00",
      "WhenEnded": "2007-10-15T14:28:22.196011+02:00"
    }
  ]
}
```