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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 875,
  "Limit": 122
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
      "TicketId": 65,
      "TicketStatus": 973,
      "Title": "sunt",
      "Registered": "2017-08-20T14:13:40.9065216+02:00",
      "IconHint": "similique"
    },
    {
      "TicketId": 65,
      "TicketStatus": 973,
      "Title": "sunt",
      "Registered": "2017-08-20T14:13:40.9065216+02:00",
      "IconHint": "similique"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 128,
      "DocumentId": 205,
      "Date": "2009-12-15T14:13:40.9065216+01:00",
      "Description": "Profound human-resource software",
      "Completed": "Completed",
      "Registered": "2023-04-18T14:13:40.9065216+02:00"
    },
    {
      "AppointmentId": 128,
      "DocumentId": 205,
      "Date": "2009-12-15T14:13:40.9065216+01:00",
      "Description": "Profound human-resource software",
      "Completed": "Completed",
      "Registered": "2023-04-18T14:13:40.9065216+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 561,
      "DocumentId": 453,
      "Date": "2014-11-19T14:13:40.9065216+01:00",
      "Description": "Total encompassing focus group",
      "Completed": "Completed",
      "Registered": "2018-12-28T14:13:40.9065216+01:00"
    },
    {
      "AppointmentId": 561,
      "DocumentId": 453,
      "Date": "2014-11-19T14:13:40.9065216+01:00",
      "Description": "Total encompassing focus group",
      "Completed": "Completed",
      "Registered": "2018-12-28T14:13:40.9065216+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 686,
      "SaleDate": "2008-01-19T14:13:40.9065216+01:00",
      "Probability": 285,
      "Heading": "culpa",
      "Amount": 17161.784,
      "Currency": "ipsam",
      "AmountInBaseCurrency": 10038.202,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2011-03-07T14:13:40.9065216+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 230,
      "Name": "Hudson, Ankunding and Botsford",
      "CompanyName": "Jenkins, Funk and Hermann",
      "FirstMessage": "dolores",
      "LastMessage": "ex",
      "WhenRequested": "2011-01-05T14:13:40.9065216+01:00",
      "WhenEnded": "2017-07-30T14:13:40.9065216+02:00"
    }
  ]
}
```