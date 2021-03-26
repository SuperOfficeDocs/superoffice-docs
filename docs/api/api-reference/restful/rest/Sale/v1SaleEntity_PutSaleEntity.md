---
title: PUT Sale/{id}
id: v1SaleEntity_PutSaleEntity
---

# PUT Sale/{id}

```http
PUT /api/v1/Sale/{id}
```

Updates the existing SaleEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Sale/{id}?$select=name,department,category/id
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

## Request Body: entity  

The SaleEntity to be saved. 

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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 904,
    "StartDate": "2008-12-07T09:40:59.6136921+01:00",
    "EndDate": "2001-04-09T09:40:59.6136921+02:00",
    "Type": "BookingForChecklist",
    "Task": "illum",
    "AssociateFullName": "Chelsie Legros",
    "ContactName": "Becker, Hickle and Ruecker",
    "Description": "Visionary discrete moderator",
    "PersonFullName": "Linnie Boehm",
    "PersonId": 214,
    "ContactId": 437,
    "ProjectId": 986,
    "ProjectName": "Powlowski-Mayer",
    "IsPublished": true,
    "AssociateId": 834,
    "ColorIndex": 876,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 250,
    "PriorityName": "Kshlerin Inc and Sons",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2018-09-19T09:40:59.6146922+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2017-03-21T09:40:59.6146922+01:00",
    "RecurringEndDate": "2013-04-03T09:40:59.6146922+02:00",
    "MotherId": 162,
    "AssignedBy": 78,
    "AssignedByFullName": "Magnus Murazik",
    "RejectReason": "",
    "Location": "sint",
    "AlarmLeadTime": "aperiam",
    "SaleId": 635,
    "SaleName": "Wyman Inc and Sons",
    "AssociateName": "Mitchell-Hane",
    "CreatedDate": "2012-02-25T09:40:59.6146922+01:00",
    "CreatedBy": "soluta",
    "CreatedByFullName": "Dangelo Hintz",
    "CreatedByAssociateId": 648,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 681,
    "Name": "Kerluke Group",
    "PersonId": 88,
    "Rank": 64,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 716,
    "FullName": "Flavio Wunsch",
    "FormalName": "Bahringer Group",
    "Deleted": false,
    "EjUserId": 60,
    "UserName": "Kuvalis Group"
  },
  "UpdatedBy": {
    "AssociateId": 421,
    "Name": "Lindgren LLC",
    "PersonId": 26,
    "Rank": 302,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 936,
    "FullName": "Thora Bins",
    "FormalName": "Braun, Wisoky and Yost",
    "Deleted": false,
    "EjUserId": 973,
    "UserName": "Runolfsdottir-Kiehn"
  },
  "CreatedBy": {
    "AssociateId": 362,
    "Name": "Franecki, Heathcote and Feil",
    "PersonId": 97,
    "Rank": 8,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 142,
    "FullName": "Devan Brakus",
    "FormalName": "Kris, Berge and Ruecker",
    "Deleted": false,
    "EjUserId": 848,
    "UserName": "Satterfield, Welch and Keebler"
  },
  "Contact": {
    "ContactId": 911,
    "Name": "Von Group",
    "OrgNr": "711844",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "velit",
    "DirectPhone": "561.602.4765 x73600",
    "AssociateId": 505,
    "CountryId": 865,
    "EmailAddress": "waylon@powlowski.info",
    "Kananame": "sunt",
    "EmailAddressName": "eliezer@bartonstracke.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ed Kihn",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "veniam",
    "FullName": "Maximillia Gulgowski",
    "IsOwnerContact": true,
    "ActiveErpLinks": 892
  },
  "Project": {
    "ProjectId": 15,
    "Name": "Oberbrunner-Koepp",
    "Description": "Multi-channelled uniform model",
    "URL": "http://www.example.com/",
    "Type": "enim",
    "AssociateId": 61,
    "AssociateFullName": "Dylan Goyette",
    "TypeId": 78,
    "Updated": "1997-05-15T09:40:59.6176955+02:00",
    "StatusId": 387,
    "Status": "aut",
    "TextId": 146,
    "PublishTo": "2016-11-18T09:40:59.6176955+01:00",
    "PublishFrom": "2007-06-13T09:40:59.6176955+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1260770",
    "ActiveErpLinks": 16
  },
  "SaleText": "iste",
  "Person": {
    "Position": "modi",
    "PersonId": 483,
    "Mrmrs": "cum",
    "Firstname": "Juliet",
    "Lastname": "Schneider",
    "MiddleName": "Kuhic-Cummings",
    "Title": "harum",
    "Description": "Expanded multi-tasking emulation",
    "Email": "quinn.cormier@hilll.name",
    "FullName": "Modesto Cremin I",
    "DirectPhone": "260.403.6774",
    "FormalName": "Rolfson LLC",
    "CountryId": 511,
    "ContactId": 386,
    "ContactName": "Gorczany LLC",
    "Retired": 882,
    "Rank": 496,
    "ActiveInterests": 225,
    "ContactDepartment": "",
    "ContactCountryId": 901,
    "ContactOrgNr": "1130422",
    "FaxPhone": "152-374-2327 x045",
    "MobilePhone": "1-838-203-4786 x73261",
    "ContactPhone": "1-675-510-4366",
    "AssociateName": "Beier-Fadel",
    "AssociateId": 569,
    "UsePersonAddress": true,
    "ContactFax": "voluptas",
    "Kanafname": "omnis",
    "Kanalname": "doloribus",
    "Post1": "labore",
    "Post2": "debitis",
    "Post3": "quisquam",
    "EmailName": "jedediah.friesen@funkwitting.co.uk",
    "ContactFullName": "Tod Walsh",
    "ActiveErpLinks": 737,
    "TicketPriorityId": 846,
    "SupportLanguageId": 903,
    "SupportAssociateId": 536,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 494,
    "Value": "earum",
    "Tooltip": "quidem"
  },
  "Competitor": {
    "Id": 339,
    "Value": "aspernatur",
    "Tooltip": "ullam"
  },
  "Credited": {
    "Id": 184,
    "Value": "quia",
    "Tooltip": "officia"
  },
  "Rating": {
    "Id": 121,
    "Value": "voluptas",
    "Tooltip": "debitis"
  },
  "Reason": {
    "Id": 957,
    "Value": "corrupti",
    "Tooltip": "consequatur"
  },
  "Source": {
    "Id": 255,
    "Value": "necessitatibus",
    "Tooltip": "voluptas"
  },
  "Status": "Lost",
  "Saledate": "2001-10-30T09:40:59.6186924+01:00",
  "Amount": 28080.64,
  "SaleId": 457,
  "Earning": 4738.608,
  "EarningPercent": 29791.804,
  "Heading": "velit",
  "Number": "1075159",
  "Probability": 114,
  "CreatedDate": "2010-07-26T09:40:59.6186924+02:00",
  "UpdatedDate": "1999-09-01T09:40:59.6186924+02:00",
  "Completed": "Completed",
  "ActiveLinks": 381,
  "Links": [
    {
      "EntityName": "Oberbrunner, VonRueden and Ondricka",
      "Id": 812,
      "Description": "Customizable tertiary implementation",
      "ExtraInfo": "culpa",
      "LinkId": 134
    },
    {
      "EntityName": "Oberbrunner, VonRueden and Ondricka",
      "Id": 812,
      "Description": "Customizable tertiary implementation",
      "ExtraInfo": "culpa",
      "LinkId": 134
    }
  ],
  "NextDueDate": "1999-05-18T09:40:59.6186924+02:00",
  "Postit": "expedita",
  "SaleType": {
    "Id": 384,
    "Value": "facilis",
    "Tooltip": "est"
  },
  "ReasonSold": {
    "Id": 59,
    "Value": "rem",
    "Tooltip": "aut"
  },
  "ReasonStalled": {
    "Id": 638,
    "Value": "commodi",
    "Tooltip": "asperiores"
  },
  "ReopenDate": "2000-04-28T09:40:59.6196892+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Marquardt-Lesch",
      "Comment": "et",
      "StakeholderRoleId": 608,
      "CountryId": 604,
      "PersonId": 229,
      "EmailDescription": "mathilde@fisherstrosin.name",
      "EmailId": 20,
      "EmailAddress": "jasmin@hagenes.co.uk",
      "PhoneId": 15,
      "ContactName": "Ullrich, Jewess and Sanford",
      "ContactId": 945,
      "SaleId": 28,
      "Mrmrs": "repellendus",
      "Firstname": "Nasir",
      "MiddleName": "Gerlach-Ankunding",
      "Lastname": "Lynch",
      "SaleStakeholderId": 263,
      "Rank": 537,
      "Phone": "1-613-206-2588 x4157"
    }
  ],
  "ActiveErpLinks": 430,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1303862817"
  },
  "ExtraFields": {
    "ExtraFields1": "eum",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "est"
  },
  "PublishEventDate": "2004-07-15T09:40:59.6196892+02:00",
  "PublishTo": "1997-08-01T09:40:59.6196892+02:00",
  "PublishFrom": "2008-09-07T09:40:59.6196892+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 943,
      "Visibility": "All",
      "DisplayValue": "ex"
    },
    {
      "VisibleId": 943,
      "Visibility": "All",
      "DisplayValue": "ex"
    }
  ]
}
```

```http_
HTTP/1.1 200 SaleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 507,
    "StartDate": "2006-09-08T09:40:59.6266934+02:00",
    "EndDate": "1999-12-27T09:40:59.6266934+01:00",
    "Type": "BookingForChecklist",
    "Task": "accusamus",
    "AssociateFullName": "Karolann Thiel",
    "ContactName": "Ryan Inc and Sons",
    "Description": "Enterprise-wide disintermediate open system",
    "PersonFullName": "Dr. Jany Feil",
    "PersonId": 32,
    "ContactId": 786,
    "ProjectId": 221,
    "ProjectName": "Stanton, Gulgowski and Reynolds",
    "IsPublished": true,
    "AssociateId": 281,
    "ColorIndex": 701,
    "IsFree": true,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 347,
    "PriorityName": "Davis, Marks and Connelly",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1994-06-14T09:40:59.6276923+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2012-08-22T09:40:59.6276923+02:00",
    "RecurringEndDate": "2017-10-16T09:40:59.6276923+02:00",
    "MotherId": 776,
    "AssignedBy": 472,
    "AssignedByFullName": "Gilbert Schneider",
    "RejectReason": "",
    "Location": "molestiae",
    "AlarmLeadTime": "consequatur",
    "SaleId": 461,
    "SaleName": "Stamm Group",
    "AssociateName": "Auer Inc and Sons",
    "CreatedDate": "1996-10-15T09:40:59.6276923+02:00",
    "CreatedBy": "cupiditate",
    "CreatedByFullName": "Nichole Stanton",
    "CreatedByAssociateId": 911,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 641
      }
    }
  },
  "Associate": {
    "AssociateId": 89,
    "Name": "Howe Group",
    "PersonId": 575,
    "Rank": 372,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 543,
    "FullName": "Janelle Nolan",
    "FormalName": "Schultz-Stroman",
    "Deleted": false,
    "EjUserId": 974,
    "UserName": "Jones Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 793
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 660,
    "Name": "Mraz LLC",
    "PersonId": 467,
    "Rank": 841,
    "Tooltip": "natus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 427,
    "FullName": "Antonio Goodwin",
    "FormalName": "Hessel Group",
    "Deleted": false,
    "EjUserId": 432,
    "UserName": "Wunsch-Becker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "integrate vertical paradigms"
        },
        "FieldType": "System.String",
        "FieldLength": 998
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 727,
    "Name": "Barton-Kuhic",
    "PersonId": 863,
    "Rank": 176,
    "Tooltip": "aliquid",
    "Type": "AnonymousAssociate",
    "GroupIdx": 615,
    "FullName": "Maybell Konopelski",
    "FormalName": "Hermiston, Douglas and Dach",
    "Deleted": false,
    "EjUserId": 595,
    "UserName": "Tillman, Lind and Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 740
      }
    }
  },
  "Contact": {
    "ContactId": 838,
    "Name": "McGlynn, Mayer and Jast",
    "OrgNr": "895123",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "reprehenderit",
    "DirectPhone": "103.011.1541",
    "AssociateId": 467,
    "CountryId": 927,
    "EmailAddress": "dejon.greenfelder@denesik.uk",
    "Kananame": "voluptatem",
    "EmailAddressName": "arielle@creminbashirian.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Helene Blick",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Ms. Jerel Heaney",
    "IsOwnerContact": false,
    "ActiveErpLinks": 399,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 31
      }
    }
  },
  "Project": {
    "ProjectId": 597,
    "Name": "Wisoky-Reichert",
    "Description": "Fundamental value-added knowledge user",
    "URL": "http://www.example.com/",
    "Type": "est",
    "AssociateId": 803,
    "AssociateFullName": "Zackery Trantow",
    "TypeId": 666,
    "Updated": "2013-08-07T09:40:59.6296932+02:00",
    "StatusId": 559,
    "Status": "dolores",
    "TextId": 318,
    "PublishTo": "1999-06-20T09:40:59.6296932+02:00",
    "PublishFrom": "2018-09-21T09:40:59.6296932+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1064646",
    "ActiveErpLinks": 853,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 246
      }
    }
  },
  "SaleText": "et",
  "Person": {
    "Position": "corrupti",
    "PersonId": 291,
    "Mrmrs": "impedit",
    "Firstname": "Jedediah",
    "Lastname": "Keebler",
    "MiddleName": "Turner, Gusikowski and Kub",
    "Title": "quo",
    "Description": "Streamlined 24/7 open architecture",
    "Email": "anibal.jaskolski@conn.name",
    "FullName": "Heidi Stehr",
    "DirectPhone": "(685)678-0457 x50533",
    "FormalName": "Mitchell-Nienow",
    "CountryId": 236,
    "ContactId": 284,
    "ContactName": "Witting, Conn and Torphy",
    "Retired": 934,
    "Rank": 380,
    "ActiveInterests": 702,
    "ContactDepartment": "",
    "ContactCountryId": 610,
    "ContactOrgNr": "662905",
    "FaxPhone": "(550)867-5674",
    "MobilePhone": "(042)766-3281",
    "ContactPhone": "067.664.2182 x423",
    "AssociateName": "Huel, Kuhic and Schimmel",
    "AssociateId": 809,
    "UsePersonAddress": true,
    "ContactFax": "rem",
    "Kanafname": "rerum",
    "Kanalname": "qui",
    "Post1": "non",
    "Post2": "explicabo",
    "Post3": "sit",
    "EmailName": "barton@larson.co.uk",
    "ContactFullName": "Alivia Bode",
    "ActiveErpLinks": 417,
    "TicketPriorityId": 615,
    "SupportLanguageId": 620,
    "SupportAssociateId": 836,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 853
      }
    }
  },
  "Currency": {
    "Id": 281,
    "Value": "deserunt",
    "Tooltip": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate transparent models"
        },
        "FieldType": "System.Int32",
        "FieldLength": 68
      }
    }
  },
  "Competitor": {
    "Id": 956,
    "Value": "aut",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 480
      }
    }
  },
  "Credited": {
    "Id": 59,
    "Value": "consequatur",
    "Tooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 50
      }
    }
  },
  "Rating": {
    "Id": 640,
    "Value": "rerum",
    "Tooltip": "placeat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 606
      }
    }
  },
  "Reason": {
    "Id": 439,
    "Value": "quibusdam",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 146
      }
    }
  },
  "Source": {
    "Id": 511,
    "Value": "animi",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 830
      }
    }
  },
  "Status": "Lost",
  "Saledate": "2000-07-03T09:40:59.6316922+02:00",
  "Amount": 25833.561999999998,
  "SaleId": 563,
  "Earning": 7643.826,
  "EarningPercent": 783.5,
  "Heading": "quasi",
  "Number": "318537",
  "Probability": 278,
  "CreatedDate": "2006-11-15T09:40:59.6316922+01:00",
  "UpdatedDate": "2014-07-21T09:40:59.6316922+02:00",
  "Completed": "Completed",
  "ActiveLinks": 742,
  "Links": [
    {
      "EntityName": "Robel-Jast",
      "Id": 683,
      "Description": "Operative 4th generation budgetary management",
      "ExtraInfo": "et",
      "LinkId": 961,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 237
        }
      }
    }
  ],
  "NextDueDate": "2017-02-19T09:40:59.6316922+01:00",
  "Postit": "corporis",
  "SaleType": {
    "Id": 526,
    "Value": "nulla",
    "Tooltip": "dolor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 754
      }
    }
  },
  "ReasonSold": {
    "Id": 305,
    "Value": "autem",
    "Tooltip": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 918
      }
    }
  },
  "ReasonStalled": {
    "Id": 293,
    "Value": "eligendi",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 604
      }
    }
  },
  "ReopenDate": "1996-09-01T09:40:59.6316922+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Hamill Group",
      "Comment": "qui",
      "StakeholderRoleId": 974,
      "CountryId": 1001,
      "PersonId": 214,
      "EmailDescription": "abigale@streich.info",
      "EmailId": 732,
      "EmailAddress": "abelardo.hayes@stehr.us",
      "PhoneId": 860,
      "ContactName": "Moore-Spencer",
      "ContactId": 239,
      "SaleId": 207,
      "Mrmrs": "qui",
      "Firstname": "Dorcas",
      "MiddleName": "Kuphal, Keeling and Konopelski",
      "Lastname": "Lind",
      "SaleStakeholderId": 63,
      "Rank": 879,
      "Phone": "067-133-7800 x8827",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    }
  ],
  "ActiveErpLinks": 304,
  "UserDefinedFields": {
    "SuperOffice:1": "342634802",
    "SuperOffice:2": "Shea Medhurst PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "accusantium"
  },
  "PublishEventDate": "2017-02-08T09:40:59.6326921+01:00",
  "PublishTo": "2001-02-25T09:40:59.6326921+01:00",
  "PublishFrom": "2018-03-29T09:40:59.6326921+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 95,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    },
    {
      "VisibleId": 95,
      "Visibility": "All",
      "DisplayValue": "quia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 13
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 760
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```