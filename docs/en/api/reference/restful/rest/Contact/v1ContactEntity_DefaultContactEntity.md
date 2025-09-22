---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
content_type: reference
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 12 May 2023 11:24:53 G5T

{
  "ContactId": 4,
  "Name": "Stokes, Lindgren and Parker",
  "Department": "",
  "OrgNr": "215696",
  "Number1": "672869",
  "Number2": "730790",
  "UpdatedDate": "2023-05-12T11:24:53.0780792+02:00",
  "CreatedDate": "2016-10-04T11:24:53.0780792+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "labore",
      "Description": "Programmable regional implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "labore",
      "Description": "Programmable regional implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 964,
      "Name": "Legros LLC",
      "ToolTip": "Aut et.",
      "Deleted": false,
      "Rank": 314,
      "Type": "autem",
      "ColorBlock": 104,
      "IconHint": "quaerat",
      "Selected": true,
      "LastChanged": "2008-12-29T11:24:53.0780792+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "rem",
      "Hidden": false,
      "FullName": "Selena Bosco Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Stand-alone assymetric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "voluptas",
      "Description": "Stand-alone assymetric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "eligendi",
      "Description": "Programmable empowering access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "eligendi",
      "Description": "Programmable empowering access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "earum",
      "StrippedValue": "ut",
      "Description": "Multi-lateral non-volatile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "ut",
      "Description": "Multi-lateral non-volatile migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 243
        }
      }
    }
  ],
  "Description": "Fully-configurable demand-driven groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellendus",
      "PersonId": 914,
      "Mrmrs": "cumque",
      "Firstname": "Damian",
      "Lastname": "Sauer",
      "MiddleName": "Kilback Inc and Sons",
      "Title": "vel",
      "Description": "Diverse responsive application",
      "Email": "anahi.ernser@osinski.uk",
      "FullName": "Mr. Lottie Martine Fay",
      "DirectPhone": "1-360-615-9600 x5817",
      "FormalName": "Schoen LLC",
      "CountryId": 18,
      "ContactId": 458,
      "ContactName": "Kling Group",
      "Retired": 854,
      "Rank": 774,
      "ActiveInterests": 255,
      "ContactDepartment": "",
      "ContactCountryId": 295,
      "ContactOrgNr": "1278476",
      "FaxPhone": "(495)680-6418 x521",
      "MobilePhone": "(075)914-9067 x104",
      "ContactPhone": "1-321-222-6271 x67293",
      "AssociateName": "Thompson Inc and Sons",
      "AssociateId": 723,
      "UsePersonAddress": false,
      "ContactFax": "debitis",
      "Kanafname": "maiores",
      "Kanalname": "ut",
      "Post1": "molestias",
      "Post2": "exercitationem",
      "Post3": "repudiandae",
      "EmailName": "kennith@jewessbrakus.biz",
      "ContactFullName": "Prof. Jimmy Madyson Carroll Jr.",
      "ActiveErpLinks": 178,
      "TicketPriorityId": 955,
      "SupportLanguageId": 10,
      "SupportAssociateId": 580,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1555156",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 154
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "cumque",
  "Xstop": false,
  "ActiveInterests": 129,
  "GroupId": 36,
  "ActiveStatusMonitorId": 186,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 224,
  "DbiAgentId": 450,
  "DbiLastSyncronized": "2013-05-30T11:24:53.0780792+02:00",
  "DbiKey": "amet",
  "DbiLastModified": "2022-09-28T11:24:53.0780792+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 578,
  "ActiveErpLinks": 572,
  "BounceEmails": [
    "santos@leuschkeroberts.co.uk",
    "vanessa@corkeryosinski.biz"
  ],
  "Domains": [
    "non",
    "et"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1238336126",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "recusandae"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "quaerat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 533
    }
  }
}
```