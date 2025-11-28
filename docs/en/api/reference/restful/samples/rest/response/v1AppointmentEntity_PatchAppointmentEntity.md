```http_
HTTP/1.1 200 AppointmentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "Associate": null,
  "Contact": null,
  "CreatedBy": null,
  "UpdatedBy": null,
  "CreatedDate": "2017-04-27T14:34:01.485407+02:00",
  "AppointmentId": 982,
  "Description": "Follow-up meeting to discuss implementation progress and address any technical questions.",
  "Title": "Implementation Follow-up - TechStart Inc",
  "Agenda": "1. Review progress since last meeting\n2. Address technical questions\n3. Discuss timeline adjustments\n4. Plan next steps",
  "InternalNotes": "Customer requested additional integration support. Prepare API documentation.",
  "StartDate": "2024-12-18T11:00:00+01:00",
  "EndDate": "2024-12-18T12:00:00+01:00",
  "InvitedPerson": null,
  "Person": null,
  "MotherId": 214,
  "Priority": null,
  "Private": "PrivateGroup",
  "Project": null,
  "Type": "BookingForChecklist",
  "UpdatedDate": "2019-10-11T14:34:01.4871551+02:00",
  "Completed": "Completed",
  "ActiveLinks": 690,
  "Links": [
    {
      "EntityName": "Quitzon-Nader",
      "Id": 652,
      "Description": "Link to implementation checklist",
      "ExtraInfo": "ipsa",
      "LinkId": 235,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    }
  ],
  "AlarmLeadTime": "PT15M",
  "HasAlarm": true,
  "ColorIndex": 809,
  "IsFree": false,
  "IsAlldayEvent": false,
  "LagTime": "PT0M",
  "LeadTime": "PT10M",
  "Location": "Google Meet",
  "RejectCounter": 0,
  "RejectReason": "",
  "Recurrence": null,
  "Participants": [
    {
      "AssociateId": 123,
      "PersonId": 862,
      "ContactId": 130,
      "EmailId": 527,
      "SendEmail": false,
      "InvitationStatus": "Accepted",
      "EmailAddress": "david.tech@techstart.io",
      "Description": "CTO at TechStart Inc"
    }
  ],
  "AssignmentStatus": "Assigning",
  "InvitationStatus": "Accepted",
  "BookingType": "None",
  "ActiveDate": "2015-11-15T14:34:01.4891619+01:00",
  "HasConflict": false,
  "AssignedBy": null,
  "MotherAssociate": null,
  "Task": null,
  "PreferredTZLocation": 262,
  "PreferredTZLocationData": null,
  "Sale": null,
  "SuggestedAppointmentId": 929,
  "IsMileStone": false,
  "CautionWarning": "ExternalParticipantsDateTimeMismatch",
  "OwnedExternally": "Google",
  "JoinVideomeetUrl": "https://meet.google.com/abc-defg-hij",
  "CentralserviceVideomeetId": "abc-defg-hij",
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "Implementation",
    "ExtraFields2": "In progress"
  },
  "CustomFields": {
    "CustomFields1": "Technical",
    "CustomFields2": "Support"
  },
  "PublishEventDate": "2009-01-31T14:34:01.4916331+01:00",
  "PublishTo": "2004-03-17T14:34:01.4916331+01:00",
  "PublishFrom": "2003-07-10T14:34:01.4916331+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 102,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    },
    {
      "VisibleId": 102,
      "Visibility": "All",
      "DisplayValue": "All users",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 604
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 353
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```