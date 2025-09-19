---
title: PUT List/TicketPriority/Items/{id}
uid: v1TicketPriorityList_PutTicketPriorityEntity
generated: true
content_type: reference
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 13,
  "Name": "Kilback LLC",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 18,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 809,
  "MonStart": "2005-11-01T03:41:59.6367262+01:00",
  "MonStop": "2017-12-20T03:41:59.6367262+01:00",
  "TueStart": "2018-10-16T03:41:59.6367262+02:00",
  "TueStop": "2009-01-01T03:41:59.6367262+01:00",
  "WedStart": "2016-06-05T03:41:59.6367262+02:00",
  "WedStop": "2007-06-07T03:41:59.6367262+02:00",
  "ThuStart": "2003-11-16T03:41:59.6367262+01:00",
  "ThuStop": "2013-09-20T03:41:59.6367262+02:00",
  "FriStart": "2011-10-23T03:41:59.6367262+02:00",
  "FriStop": "2010-09-07T03:41:59.6367262+02:00",
  "SatStart": "2013-03-02T03:41:59.6367262+01:00",
  "SatStop": "2005-11-29T03:41:59.6367262+01:00",
  "SunStart": "2016-01-10T03:41:59.6367262+01:00",
  "SunStop": "2007-07-22T03:41:59.6367262+02:00",
  "NonDates": [
    "aut",
    "necessitatibus"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 278,
      "AlertLevel": 779,
      "AlertTimeout": 623,
      "Action": 411,
      "DelegateTo": 95,
      "ScriptId": 923,
      "EmailTo": "caleigh@stokesklein.ca",
      "SmsTo": "sunt",
      "ReplyTemplateIdCustomer": 964,
      "ReplyTemplateIdUser": 768,
      "ReplyTemplateIdCatmast": 300,
      "ReplyTemplateIdEmail": 245,
      "RtiCustomerSms": 44,
      "ReplyTemplateIdUserSms": 883,
      "ReplyTemplateIdCatmastSms": 296,
      "ReplyTemplateIdSms": 956
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 519,
  "Name": "Kassulke-Sanford",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 884,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 161,
  "MonStart": "2021-01-21T03:41:59.6367262+01:00",
  "MonStop": "2004-11-02T03:41:59.6367262+01:00",
  "TueStart": "2016-06-13T03:41:59.6367262+02:00",
  "TueStop": "2006-10-26T03:41:59.6367262+02:00",
  "WedStart": "2018-12-10T03:41:59.6367262+01:00",
  "WedStop": "2017-11-02T03:41:59.6367262+01:00",
  "ThuStart": "2012-11-22T03:41:59.6367262+01:00",
  "ThuStop": "2020-01-07T03:41:59.6367262+01:00",
  "FriStart": "2020-09-14T03:41:59.6367262+02:00",
  "FriStop": "2000-04-18T03:41:59.6367262+02:00",
  "SatStart": "2023-02-20T03:41:59.6367262+01:00",
  "SatStop": "2013-12-30T03:41:59.6367262+01:00",
  "SunStart": "2016-05-02T03:41:59.6367262+02:00",
  "SunStop": "2003-03-11T03:41:59.6367262+01:00",
  "NonDates": [
    "accusantium",
    "nihil"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 314,
      "AlertLevel": 589,
      "AlertTimeout": 927,
      "Action": 302,
      "DelegateTo": 353,
      "ScriptId": 792,
      "EmailTo": "brandy@kohler.uk",
      "SmsTo": "omnis",
      "ReplyTemplateIdCustomer": 192,
      "ReplyTemplateIdUser": 662,
      "ReplyTemplateIdCatmast": 617,
      "ReplyTemplateIdEmail": 992,
      "RtiCustomerSms": 216,
      "ReplyTemplateIdUserSms": 695,
      "ReplyTemplateIdCatmastSms": 436,
      "ReplyTemplateIdSms": 770,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 987
    }
  }
}
```