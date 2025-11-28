```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ArchiveColumnInfo": [
    {
      "DisplayName": "Contact ID",
      "DisplayTooltip": "Unique identifier for the contact",
      "DisplayType": "int",
      "CanOrderBy": true,
      "Name": "contactId",
      "CanRestrictBy": true,
      "RestrictionType": "int",
      "RestrictionListName": "",
      "IsVisible": true,
      "ExtraInfo": "contact.contact_id",
      "Width": "80",
      "IconHint": "id",
      "HeadingIconHint": "number"
    }
  ],
  "ArchiveEntityInfo": [
    {
      "Id": 658,
      "Name": "Appointment",
      "ToolTip": "Calendar appointments and meetings",
      "Deleted": false,
      "Rank": 1,
      "Type": "ArchiveProvider",
      "ColorBlock": 864,
      "IconHint": "appointment",
      "Selected": true,
      "LastChanged": "2024-11-20T10:00:00+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "AppointmentArchive",
      "StyleHint": "entity",
      "Hidden": false,
      "FullName": "Appointment Archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "ArchiveOrderByInfo": [
    {
      "Name": "date",
      "Direction": "DESC"
    },
    {
      "Name": "time",
      "Direction": "ASC"
    }
  ],
  "OwnerKeys": "appointment=139,person=456",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 536
    }
  }
}
```
