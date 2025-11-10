```http!
POST /api/v1/Agents/List/SaveTicketPriorityEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketPriorityId": 1002,
  "Name": "Schmidt, Breitenberg and Tromp",
  "Status": "Deleted",
  "Flags": "AlertSchedule",
  "SortOrder": 1001,
  "TicketRead": "Continue",
  "ChangedOwner": "Continue",
  "TicketNewinfo": "Continue",
  "TicketClosed": "Continue",
  "TicketChangedPriority": "Continue",
  "TicketNew": "Continue",
  "Deadline": 724,
  "MonStart": "2021-03-03T10:11:00.2679033+01:00",
  "MonStop": "2014-08-05T10:11:00.2679033+02:00",
  "TueStart": "2007-04-21T10:11:00.2679033+02:00",
  "TueStop": "2023-04-23T10:11:00.2679033+02:00",
  "WedStart": "2011-06-20T10:11:00.2679033+02:00",
  "WedStop": "2007-08-16T10:11:00.2679033+02:00",
  "ThuStart": "2023-02-22T10:11:00.2679033+01:00",
  "ThuStop": "2005-05-27T10:11:00.2679033+02:00",
  "FriStart": "2013-11-09T10:11:00.2679033+01:00",
  "FriStop": "2008-02-12T10:11:00.2679033+01:00",
  "SatStart": "2023-08-03T10:11:00.2679033+02:00",
  "SatStop": "2017-04-04T10:11:00.2679033+02:00",
  "SunStart": "2024-04-15T10:11:00.2679033+02:00",
  "SunStop": "2014-01-11T10:11:00.2679033+01:00",
  "NonDates": [
    "quia",
    "magnam"
  ],
  "EscalationLevels": [
    {
      "TicketAlertId": 842,
      "AlertLevel": 457,
      "AlertTimeout": 660,
      "Action": 387,
      "DelegateTo": 368,
      "ScriptId": 204,
      "EmailTo": "shaniya.davis@hermann.com",
      "SmsTo": "maxime",
      "ReplyTemplateIdCustomer": 985,
      "ReplyTemplateIdUser": 454,
      "ReplyTemplateIdCatmast": 592,
      "ReplyTemplateIdEmail": 58,
      "RtiCustomerSms": 383,
      "ReplyTemplateIdUserSms": 565,
      "ReplyTemplateIdCatmastSms": 863,
      "ReplyTemplateIdSms": 805
    }
  ]
}
```