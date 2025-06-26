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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 576,
  "Limit": 193
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
      "TicketId": 930,
      "TicketStatus": 823,
      "Title": "blanditiis",
      "Registered": "2000-11-07T03:45:23.7173227+01:00",
      "IconHint": "est"
    },
    {
      "TicketId": 930,
      "TicketStatus": 823,
      "Title": "blanditiis",
      "Registered": "2000-11-07T03:45:23.7173227+01:00",
      "IconHint": "est"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 526,
      "DocumentId": 707,
      "Date": "1998-02-11T03:45:23.7173227+01:00",
      "Description": "Integrated human-resource knowledge user",
      "Completed": "Completed",
      "Registered": "2019-07-24T03:45:23.7173227+02:00"
    },
    {
      "AppointmentId": 526,
      "DocumentId": 707,
      "Date": "1998-02-11T03:45:23.7173227+01:00",
      "Description": "Integrated human-resource knowledge user",
      "Completed": "Completed",
      "Registered": "2019-07-24T03:45:23.7173227+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 361,
      "DocumentId": 874,
      "Date": "2011-05-19T03:45:23.7173227+02:00",
      "Description": "Customizable disintermediate focus group",
      "Completed": "Completed",
      "Registered": "1998-08-21T03:45:23.7173227+02:00"
    },
    {
      "AppointmentId": 361,
      "DocumentId": 874,
      "Date": "2011-05-19T03:45:23.7173227+02:00",
      "Description": "Customizable disintermediate focus group",
      "Completed": "Completed",
      "Registered": "1998-08-21T03:45:23.7173227+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 78,
      "SaleDate": "2016-05-03T03:45:23.7173227+02:00",
      "Probability": 928,
      "Heading": "quasi",
      "Amount": 4647.722,
      "Currency": "nam",
      "AmountInBaseCurrency": 24407.592,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-02-12T03:45:23.7173227+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 255,
      "Name": "Hansen Inc and Sons",
      "CompanyName": "Murphy, Wolf and Lubowitz",
      "FirstMessage": "tenetur",
      "LastMessage": "et",
      "WhenRequested": "2002-03-03T03:45:23.7173227+01:00",
      "WhenEnded": "2020-10-18T03:45:23.7173227+02:00"
    }
  ]
}
```