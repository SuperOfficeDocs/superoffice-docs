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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 395,
    "StartDate": "2001-11-05T09:40:59.6516923+01:00",
    "EndDate": "2006-04-09T09:40:59.6516923+02:00",
    "Type": "BookingForChecklist",
    "Task": "iste",
    "AssociateFullName": "Dane Hilpert Jr.",
    "ContactName": "Jakubowski Group",
    "Description": "Team-oriented executive system engine",
    "PersonFullName": "Dorthy Conn",
    "PersonId": 414,
    "ContactId": 770,
    "ProjectId": 110,
    "ProjectName": "Watsica-Halvorson",
    "IsPublished": false,
    "AssociateId": 697,
    "ColorIndex": 287,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 643,
    "PriorityName": "Lindgren-Volkman",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2006-02-15T09:40:59.6516923+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2008-04-05T09:40:59.6516923+02:00",
    "RecurringEndDate": "2010-09-09T09:40:59.6516923+02:00",
    "MotherId": 479,
    "AssignedBy": 449,
    "AssignedByFullName": "Dr. Tevin Gusikowski",
    "RejectReason": "",
    "Location": "ipsum",
    "AlarmLeadTime": "porro",
    "SaleId": 105,
    "SaleName": "Volkman, Swift and Lemke",
    "AssociateName": "Hodkiewicz-Runolfsdottir",
    "CreatedDate": "2008-10-28T09:40:59.652703+01:00",
    "CreatedBy": "dignissimos",
    "CreatedByFullName": "Cordell Rolfson",
    "CreatedByAssociateId": 408,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 969,
    "Name": "Rutherford LLC",
    "PersonId": 15,
    "Rank": 106,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 780,
    "FullName": "Nash Hayes",
    "FormalName": "Gerhold-Rodriguez",
    "Deleted": false,
    "EjUserId": 748,
    "UserName": "Stroman-Nienow"
  },
  "UpdatedBy": {
    "AssociateId": 928,
    "Name": "Goldner Inc and Sons",
    "PersonId": 541,
    "Rank": 22,
    "Tooltip": "aperiam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 854,
    "FullName": "Jon Kessler DVM",
    "FormalName": "Huels Inc and Sons",
    "Deleted": false,
    "EjUserId": 1001,
    "UserName": "Breitenberg-Witting"
  },
  "CreatedBy": {
    "AssociateId": 758,
    "Name": "Nicolas, Jones and Williamson",
    "PersonId": 87,
    "Rank": 700,
    "Tooltip": "praesentium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 539,
    "FullName": "Alize Wilderman IV",
    "FormalName": "Kovacek Inc and Sons",
    "Deleted": true,
    "EjUserId": 776,
    "UserName": "Walsh LLC"
  },
  "Contact": {
    "ContactId": 232,
    "Name": "Legros, Feil and Heidenreich",
    "OrgNr": "481401",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "provident",
    "DirectPhone": "434.108.3737 x81808",
    "AssociateId": 13,
    "CountryId": 229,
    "EmailAddress": "easter.stokes@homenick.uk",
    "Kananame": "aliquid",
    "EmailAddressName": "hayden_erdman@bogan.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Alan Hahn",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "enim",
    "FullName": "Lavonne Funk",
    "IsOwnerContact": false,
    "ActiveErpLinks": 611
  },
  "Project": {
    "ProjectId": 169,
    "Name": "Jones-Schumm",
    "Description": "Object-based 4th generation complexity",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 51,
    "AssociateFullName": "Laila Nicolas Sr.",
    "TypeId": 987,
    "Updated": "2014-08-07T09:40:59.6566751+02:00",
    "StatusId": 976,
    "Status": "possimus",
    "TextId": 529,
    "PublishTo": "1998-04-21T09:40:59.6566751+02:00",
    "PublishFrom": "2002-11-14T09:40:59.6566751+01:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1200409",
    "ActiveErpLinks": 896
  },
  "SaleText": "necessitatibus",
  "Person": {
    "Position": "exercitationem",
    "PersonId": 785,
    "Mrmrs": "nulla",
    "Firstname": "Rebeca",
    "Lastname": "Parker",
    "MiddleName": "Cole, Miller and Jast",
    "Title": "corrupti",
    "Description": "Visionary national adapter",
    "Email": "okey.dubuque@bernierlynch.biz",
    "FullName": "Candida Russel",
    "DirectPhone": "(508)502-4328 x673",
    "FormalName": "Brown LLC",
    "CountryId": 536,
    "ContactId": 572,
    "ContactName": "Stanton Group",
    "Retired": 808,
    "Rank": 784,
    "ActiveInterests": 100,
    "ContactDepartment": "",
    "ContactCountryId": 764,
    "ContactOrgNr": "913072",
    "FaxPhone": "1-156-012-0571 x1326",
    "MobilePhone": "057.381.1818 x472",
    "ContactPhone": "(027)061-2062 x70664",
    "AssociateName": "Jaskolski, Rogahn and Becker",
    "AssociateId": 215,
    "UsePersonAddress": true,
    "ContactFax": "voluptatibus",
    "Kanafname": "sint",
    "Kanalname": "consequatur",
    "Post1": "in",
    "Post2": "nobis",
    "Post3": "qui",
    "EmailName": "maya_haag@luettgenmorar.com",
    "ContactFullName": "Philip Lindgren",
    "ActiveErpLinks": 547,
    "TicketPriorityId": 890,
    "SupportLanguageId": 463,
    "SupportAssociateId": 390,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 480,
    "Value": "excepturi",
    "Tooltip": "assumenda"
  },
  "Competitor": {
    "Id": 99,
    "Value": "neque",
    "Tooltip": "et"
  },
  "Credited": {
    "Id": 560,
    "Value": "magni",
    "Tooltip": "deleniti"
  },
  "Rating": {
    "Id": 650,
    "Value": "quis",
    "Tooltip": "et"
  },
  "Reason": {
    "Id": 33,
    "Value": "omnis",
    "Tooltip": "amet"
  },
  "Source": {
    "Id": 439,
    "Value": "aut",
    "Tooltip": "odio"
  },
  "Status": "Lost",
  "Saledate": "2004-01-22T09:40:59.6586678+01:00",
  "Amount": 2845.672,
  "SaleId": 621,
  "Earning": 7549.806,
  "EarningPercent": 10000.594,
  "Heading": "non",
  "Number": "1312750",
  "Probability": 25,
  "CreatedDate": "2006-06-08T09:40:59.6586678+02:00",
  "UpdatedDate": "2007-09-09T09:40:59.6586678+02:00",
  "Completed": "Completed",
  "ActiveLinks": 809,
  "Links": [
    {
      "EntityName": "Kub-Murazik",
      "Id": 494,
      "Description": "Customizable zero defect circuit",
      "ExtraInfo": "sed",
      "LinkId": 359
    },
    {
      "EntityName": "Kub-Murazik",
      "Id": 494,
      "Description": "Customizable zero defect circuit",
      "ExtraInfo": "sed",
      "LinkId": 359
    }
  ],
  "NextDueDate": "1998-02-13T09:40:59.6586678+01:00",
  "Postit": "rem",
  "SaleType": {
    "Id": 566,
    "Value": "quia",
    "Tooltip": "sit"
  },
  "ReasonSold": {
    "Id": 884,
    "Value": "non",
    "Tooltip": "excepturi"
  },
  "ReasonStalled": {
    "Id": 371,
    "Value": "eaque",
    "Tooltip": "est"
  },
  "ReopenDate": "2001-09-30T09:40:59.6586678+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kuhlman, Connelly and Bayer",
      "Comment": "assumenda",
      "StakeholderRoleId": 953,
      "CountryId": 347,
      "PersonId": 611,
      "EmailDescription": "iva.bode@gibsonhyatt.ca",
      "EmailId": 140,
      "EmailAddress": "felicity@heidenreichleannon.ca",
      "PhoneId": 234,
      "ContactName": "Hintz, Wolf and Gerhold",
      "ContactId": 335,
      "SaleId": 111,
      "Mrmrs": "atque",
      "Firstname": "Robbie",
      "MiddleName": "Streich-Prosacco",
      "Lastname": "O'Kon",
      "SaleStakeholderId": 236,
      "Rank": 799,
      "Phone": "600.387.4284"
    }
  ],
  "ActiveErpLinks": 902,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "2078820206"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "dicta",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "2018-11-08T09:40:59.6596634+01:00",
  "PublishTo": "1997-06-22T09:40:59.6596634+02:00",
  "PublishFrom": "2014-06-09T09:40:59.6596634+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 398,
      "Visibility": "All",
      "DisplayValue": "et"
    },
    {
      "VisibleId": 398,
      "Visibility": "All",
      "DisplayValue": "et"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "dolor",
  "2": "doloremque"
}
```