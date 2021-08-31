---
title: POST Sale/Validate
id: v1SaleEntity_ValidateSaleEntity
---

# POST Sale/Validate

```http
POST /api/v1/Sale/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: saleEntity  

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Sale/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 93,
    "StartDate": "1996-03-21T15:05:42.7006704+01:00",
    "EndDate": "2019-06-16T15:05:42.7006704+02:00",
    "Type": "BookingForChecklist",
    "Task": "perspiciatis",
    "AssociateFullName": "Rhianna Abernathy",
    "ContactName": "Rosenbaum-Reinger",
    "Description": "Distributed analyzing open system",
    "PersonFullName": "Pascale Miller",
    "PersonId": 756,
    "ContactId": 314,
    "ProjectId": 526,
    "ProjectName": "Schultz, Steuber and Denesik",
    "IsPublished": true,
    "AssociateId": 917,
    "ColorIndex": 247,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 717,
    "PriorityName": "Jacobs, Lockman and Sipes",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1997-01-25T15:05:42.7016678+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2009-12-18T15:05:42.7016678+01:00",
    "RecurringEndDate": "1997-10-02T15:05:42.7016678+02:00",
    "MotherId": 706,
    "AssignedBy": 225,
    "AssignedByFullName": "Mrs. Beau Corwin",
    "RejectReason": "",
    "Location": "tempora",
    "AlarmLeadTime": "officiis",
    "SaleId": 630,
    "SaleName": "Nolan Group",
    "AssociateName": "Sporer, Anderson and Jaskolski",
    "CreatedDate": "2003-03-23T15:05:42.7016678+01:00",
    "CreatedBy": "assumenda",
    "CreatedByFullName": "Mrs. Mona Nienow",
    "CreatedByAssociateId": 628,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 154,
    "Name": "Yundt, Johns and Kuhic",
    "PersonId": 373,
    "Rank": 480,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 614,
    "FullName": "Cedrick Kemmer",
    "FormalName": "Dickens-Koepp",
    "Deleted": true,
    "EjUserId": 424,
    "UserName": "Kozey Group"
  },
  "UpdatedBy": {
    "AssociateId": 222,
    "Name": "Lynch Group",
    "PersonId": 730,
    "Rank": 938,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 467,
    "FullName": "Rogers Windler",
    "FormalName": "Marks-Kling",
    "Deleted": true,
    "EjUserId": 882,
    "UserName": "Durgan LLC"
  },
  "CreatedBy": {
    "AssociateId": 315,
    "Name": "Russel-Kutch",
    "PersonId": 712,
    "Rank": 163,
    "Tooltip": "autem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 216,
    "FullName": "Taylor Kohler",
    "FormalName": "Schoen-Stokes",
    "Deleted": false,
    "EjUserId": 645,
    "UserName": "Mills-McGlynn"
  },
  "Contact": {
    "ContactId": 879,
    "Name": "Brown Inc and Sons",
    "OrgNr": "641674",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quaerat",
    "DirectPhone": "1-021-877-2063 x022",
    "AssociateId": 154,
    "CountryId": 926,
    "EmailAddress": "sanford@metz.ca",
    "Kananame": "tenetur",
    "EmailAddressName": "deontae@damorefeil.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Otilia Bernhard MD",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "est",
    "FullName": "Makayla Bahringer",
    "IsOwnerContact": true,
    "ActiveErpLinks": 485
  },
  "Project": {
    "ProjectId": 627,
    "Name": "Gleichner, Legros and Lowe",
    "Description": "Total web-enabled groupware",
    "URL": "http://www.example.com/",
    "Type": "ullam",
    "AssociateId": 853,
    "AssociateFullName": "Rozella Gutmann",
    "TypeId": 466,
    "Updated": "2003-07-08T15:05:42.7056337+02:00",
    "StatusId": 191,
    "Status": "non",
    "TextId": 130,
    "PublishTo": "2019-06-20T15:05:42.7056337+02:00",
    "PublishFrom": "2000-04-20T15:05:42.7056337+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "372433",
    "ActiveErpLinks": 258
  },
  "SaleText": "accusamus",
  "Person": {
    "Position": "ipsum",
    "PersonId": 207,
    "Mrmrs": "non",
    "Firstname": "Theodore",
    "Lastname": "Monahan",
    "MiddleName": "Hauck, Johnston and Torp",
    "Title": "cumque",
    "Description": "Right-sized demand-driven open architecture",
    "Email": "gabe@hilll.name",
    "FullName": "Claudine Kuhn DVM",
    "DirectPhone": "781-222-0170 x078",
    "FormalName": "Mohr, Hane and Runolfsson",
    "CountryId": 587,
    "ContactId": 172,
    "ContactName": "Halvorson-Leannon",
    "Retired": 91,
    "Rank": 718,
    "ActiveInterests": 904,
    "ContactDepartment": "",
    "ContactCountryId": 211,
    "ContactOrgNr": "341729",
    "FaxPhone": "025-467-1150",
    "MobilePhone": "545-242-6153 x5240",
    "ContactPhone": "1-843-200-7607",
    "AssociateName": "Jast Group",
    "AssociateId": 739,
    "UsePersonAddress": true,
    "ContactFax": "repellat",
    "Kanafname": "illum",
    "Kanalname": "quasi",
    "Post1": "odio",
    "Post2": "facere",
    "Post3": "quo",
    "EmailName": "malachi.walter@keeling.name",
    "ContactFullName": "Rahsaan Hartmann",
    "ActiveErpLinks": 937,
    "TicketPriorityId": 570,
    "SupportLanguageId": 800,
    "SupportAssociateId": 675,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 517,
    "Value": "amet",
    "Tooltip": "placeat"
  },
  "Competitor": {
    "Id": 476,
    "Value": "assumenda",
    "Tooltip": "adipisci"
  },
  "Credited": {
    "Id": 698,
    "Value": "magnam",
    "Tooltip": "aut"
  },
  "Rating": {
    "Id": 941,
    "Value": "sunt",
    "Tooltip": "velit"
  },
  "Reason": {
    "Id": 114,
    "Value": "recusandae",
    "Tooltip": "reiciendis"
  },
  "Source": {
    "Id": 485,
    "Value": "odio",
    "Tooltip": "nam"
  },
  "Status": "Lost",
  "Saledate": "2014-11-11T15:05:42.7066639+01:00",
  "Amount": 27685.755999999998,
  "SaleId": 400,
  "Earning": 30637.984,
  "EarningPercent": 805.438,
  "Heading": "aut",
  "Number": "1146303",
  "Probability": 134,
  "CreatedDate": "1997-02-19T15:05:42.7066639+01:00",
  "UpdatedDate": "1999-11-02T15:05:42.7066639+01:00",
  "Completed": "Completed",
  "ActiveLinks": 378,
  "Links": [
    {
      "EntityName": "Dicki LLC",
      "Id": 708,
      "Description": "Synergistic stable frame",
      "ExtraInfo": "animi",
      "LinkId": 562
    },
    {
      "EntityName": "Dicki LLC",
      "Id": 708,
      "Description": "Synergistic stable frame",
      "ExtraInfo": "animi",
      "LinkId": 562
    }
  ],
  "NextDueDate": "1998-09-02T15:05:42.7066639+02:00",
  "Postit": "sapiente",
  "SaleType": {
    "Id": 898,
    "Value": "quo",
    "Tooltip": "aut"
  },
  "ReasonSold": {
    "Id": 947,
    "Value": "ducimus",
    "Tooltip": "at"
  },
  "ReasonStalled": {
    "Id": 427,
    "Value": "quo",
    "Tooltip": "repellendus"
  },
  "ReopenDate": "1998-07-01T15:05:42.7066639+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Emard Group",
      "Comment": "pariatur",
      "StakeholderRoleId": 950,
      "CountryId": 294,
      "PersonId": 194,
      "EmailDescription": "thomas_simonis@grady.ca",
      "EmailId": 267,
      "EmailAddress": "josiah_bernhard@stark.ca",
      "PhoneId": 339,
      "ContactName": "Reichel Inc and Sons",
      "ContactId": 214,
      "SaleId": 578,
      "Mrmrs": "provident",
      "Firstname": "Evert",
      "MiddleName": "Goyette, Buckridge and White",
      "Lastname": "Wiza",
      "SaleStakeholderId": 520,
      "Rank": 332,
      "Phone": "(115)202-3452"
    }
  ],
  "ActiveErpLinks": 198,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Tevin Kertzmann",
    "SuperOffice:2": "Miss Liana Fritsch"
  },
  "ExtraFields": {
    "ExtraFields1": "facere",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "perspiciatis"
  },
  "PublishEventDate": "2018-01-27T15:05:42.7076711+01:00",
  "PublishTo": "2001-06-14T15:05:42.7076711+02:00",
  "PublishFrom": "1997-10-29T15:05:42.7076711+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 557,
      "Visibility": "All",
      "DisplayValue": "quia"
    },
    {
      "VisibleId": 557,
      "Visibility": "All",
      "DisplayValue": "quia"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "voluptatem",
  "2": "ab"
}
```