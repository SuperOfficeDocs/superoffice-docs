---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 716,
  "Limit": 228
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 763,
      "TicketStatus": 926,
      "Title": "occaecati",
      "Registered": "2016-09-03T14:19:03.0574043+02:00",
      "IconHint": "exercitationem"
    },
    {
      "TicketId": 763,
      "TicketStatus": 926,
      "Title": "occaecati",
      "Registered": "2016-09-03T14:19:03.0574043+02:00",
      "IconHint": "exercitationem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 181,
      "DocumentId": 757,
      "Date": "2012-07-20T14:19:03.0574043+02:00",
      "Description": "Quality-focused 24/7 time-frame",
      "Completed": "Completed",
      "Registered": "1999-06-05T14:19:03.0574043+02:00"
    },
    {
      "AppointmentId": 181,
      "DocumentId": 757,
      "Date": "2012-07-20T14:19:03.0574043+02:00",
      "Description": "Quality-focused 24/7 time-frame",
      "Completed": "Completed",
      "Registered": "1999-06-05T14:19:03.0574043+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 367,
      "DocumentId": 633,
      "Date": "2014-07-23T14:19:03.0574043+02:00",
      "Description": "Versatile modular knowledge base",
      "Completed": "Completed",
      "Registered": "2018-03-28T14:19:03.0574043+02:00"
    },
    {
      "AppointmentId": 367,
      "DocumentId": 633,
      "Date": "2014-07-23T14:19:03.0574043+02:00",
      "Description": "Versatile modular knowledge base",
      "Completed": "Completed",
      "Registered": "2018-03-28T14:19:03.0574043+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 985,
      "SaleDate": "2015-11-16T14:19:03.0574043+01:00",
      "Probability": 854,
      "Heading": "sapiente",
      "Amount": 235.04999999999998,
      "Currency": "error",
      "AmountInBaseCurrency": 5356.0059999999994,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-10-08T14:19:03.0574043+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 843,
      "Name": "Lynch-Stoltenberg",
      "CompanyName": "Howell-Hammes",
      "FirstMessage": "doloremque",
      "LastMessage": "quam",
      "WhenRequested": "2020-12-21T14:19:03.0574043+01:00",
      "WhenEnded": "2000-08-28T14:19:03.0574043+02:00"
    }
  ]
}
```