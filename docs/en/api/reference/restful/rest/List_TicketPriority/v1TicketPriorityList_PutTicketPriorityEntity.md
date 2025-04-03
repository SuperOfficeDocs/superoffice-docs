---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
---

# PUT List/TicketPriority/Items/{id}

```http
PUT /api/v1/List/TicketPriority/Items/{id}
```

Updates the existing TicketPriorityEntity


Calls the List agent service SaveTicketPriorityEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TicketPriorityEntity to be saved. **Required** |



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

## Request Body: entity 

The details of TicketPriorityEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | Integer | The primary key (auto-incremented) |
| Name | String | The name of the priority. |
| Status | String | The status (normal/deleted) of the priority. |
| Flags | String | A bitmask of flags. |
| SortOrder | Integer | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | String | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | String | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | String | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | String | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | String | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | String | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | Integer | Deadline to add if escalated (minutes) |
| MonStart | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | String | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | String | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | String | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | String | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | String | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | String | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | String | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | String | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | String | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | String | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | String | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | String | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | String | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | Array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | Array | Escalation levels bound to the parent priority |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: TicketPriorityEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketPriorityId | int32 | The primary key (auto-incremented) |
| Name | string | The name of the priority. |
| Status | string | The status (normal/deleted) of the priority. |
| Flags | string | A bitmask of flags. |
| SortOrder | int32 | Indicates the sort order for this priority. 1 is first, 100 is last |
| TicketRead | string | This field indicates what to do with the escalation chain when the request is read |
| ChangedOwner | string | This field indicates what to do with the escalation chain when the request changes owner (manually) |
| TicketNewinfo | string | This field indicates what to do with the escalation chain when the request gets new info |
| TicketClosed | string | This field indicates what to do with the escalation chain when the request is closed |
| TicketChangedPriority | string | This field indicates what to do with the escalation chain when the request is changed into this priority |
| TicketNew | string | This field indicates what to do with the escalation chain when a new request is registered |
| Deadline | int32 | Deadline to add if escalated (minutes) |
| MonStart | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| MonStop | date-time | The work hour start for Mondays. Note that only the time part of the DateTime is used |
| TueStart | date-time | The work hour start for Tuesdays. Note that only the time part of the DateTime is used |
| TueStop | date-time | The work hour stop for Tuesdays. Note that only the time part of the DateTime is used |
| WedStart | date-time | The work hour start for Wednesdays. Note that only the time part of the DateTime is used |
| WedStop | date-time | The work hour stop for Wednesdays. Note that only the time part of the DateTime is used |
| ThuStart | date-time | The work hour start for Thursdays. Note that only the time part of the DateTime is used |
| ThuStop | date-time | The work hour stop for Thursdays. Note that only the time part of the DateTime is used |
| FriStart | date-time | The work hour start for Fridays. Note that only the time part of the DateTime is used |
| FriStop | date-time | The work hour stop for Fridays. Note that only the time part of the DateTime is used |
| SatStart | date-time | The work hour start for Saturdays. Note that only the time part of the DateTime is used |
| SatStop | date-time | The work hour stop for Saturdays. Note that only the time part of the DateTime is used |
| SunStart | date-time | The work hour start for Sundays. Note that only the time part of the DateTime is used |
| SunStop | date-time | The work hour stop for Sundays. Note that only the time part of the DateTime is used |
| NonDates | array | Dates which the escalation time should not be running. Note that only the day of the year (day and month) is used. So the year and time part is not used even if this is a DateTime. Exception - it IS possible to include a year here, for dates that should not repeat every year |
| EscalationLevels | array | Escalation levels bound to the parent priority |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/TicketPriority/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 648,
  "Name": "Lebsack-Nicolas",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 902,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 992,
  "MonStart": "2003-04-24T14:28:27.7895346+02:00",
  "MonStop": "2020-02-06T14:28:27.7895346+01:00",
  "TueStart": "2017-05-18T14:28:27.7895346+02:00",
  "TueStop": "2002-12-22T14:28:27.7895346+01:00",
  "WedStart": "2024-05-31T14:28:27.7895346+02:00",
  "WedStop": "2019-09-24T14:28:27.7895346+02:00",
  "ThuStart": "2014-02-19T14:28:27.7895346+01:00",
  "ThuStop": "2011-11-01T14:28:27.7895346+01:00",
  "FriStart": "2008-12-17T14:28:27.7895346+01:00",
  "FriStop": "2011-04-07T14:28:27.7895346+02:00",
  "SatStart": "2005-04-23T14:28:27.7895346+02:00",
  "SatStop": "2006-10-09T14:28:27.7895346+02:00",
  "SunStart": "2006-06-25T14:28:27.7895346+02:00",
  "SunStop": "2003-07-19T14:28:27.7895346+02:00",
  "NonDates": [
    "occaecati",
    "iste"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 298,
      "AlertLevel": 764,
      "AlertTimeout": 993,
      "Action": 689,
      "DelegateTo": 384,
      "ScriptId": 989,
      "EmailTo": "shanie@fritschpollich.biz",
      "SmsTo": "provident",
      "ReplyTemplateIdCustomer": 659,
      "ReplyTemplateIdUser": 980,
      "ReplyTemplateIdCatmast": 705,
      "ReplyTemplateIdEmail": 719,
      "RtiCustomerSms": 97,
      "ReplyTemplateIdUserSms": 330,
      "ReplyTemplateIdCatmastSms": 352,
      "ReplyTemplateIdSms": 171
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 661,
  "Name": "Ratke Group",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 890,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 45,
  "MonStart": "2025-03-06T14:28:27.805165+01:00",
  "MonStop": "2005-10-18T14:28:27.805165+02:00",
  "TueStart": "2023-04-19T14:28:27.805165+02:00",
  "TueStop": "2002-08-06T14:28:27.805165+02:00",
  "WedStart": "2009-08-31T14:28:27.805165+02:00",
  "WedStop": "2000-02-24T14:28:27.805165+01:00",
  "ThuStart": "2019-07-22T14:28:27.805165+02:00",
  "ThuStop": "2005-03-19T14:28:27.805165+01:00",
  "FriStart": "2003-03-04T14:28:27.805165+01:00",
  "FriStop": "2022-03-15T14:28:27.805165+01:00",
  "SatStart": "2004-09-17T14:28:27.805165+02:00",
  "SatStop": "2021-07-09T14:28:27.805165+02:00",
  "SunStart": "2012-07-15T14:28:27.805165+02:00",
  "SunStop": "1999-12-19T14:28:27.805165+01:00",
  "NonDates": [
    "saepe",
    "expedita"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 873,
      "AlertLevel": 293,
      "AlertTimeout": 712,
      "Action": 813,
      "DelegateTo": 448,
      "ScriptId": 690,
      "EmailTo": "rosie@quigleymclaughlin.co.uk",
      "SmsTo": "facere",
      "ReplyTemplateIdCustomer": 272,
      "ReplyTemplateIdUser": 903,
      "ReplyTemplateIdCatmast": 403,
      "ReplyTemplateIdEmail": 79,
      "RtiCustomerSms": 6,
      "ReplyTemplateIdUserSms": 67,
      "ReplyTemplateIdCatmastSms": 63,
      "ReplyTemplateIdSms": 248,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 176
    }
  }
}
```