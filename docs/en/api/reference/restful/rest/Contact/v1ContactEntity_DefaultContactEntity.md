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
NsApiSlow threshold: 2000 ms.







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
Last-Modified: Mon, 09 Jan 2017 03:40:55 G1T

{
  "ContactId": 312,
  "Name": "Nikolaus-Kihn",
  "Department": "enhance efficient initiatives",
  "OrgNr": "1061871",
  "Number1": "1311576",
  "Number2": "444464",
  "UpdatedDate": "2017-01-09T03:40:55.428689+01:00",
  "CreatedDate": "2008-05-14T03:40:55.428689+02:00",
  "Emails": [
    {
      "Value": "minima",
      "StrippedValue": "inventore",
      "Description": "User-friendly tangible task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "inventore",
      "Description": "User-friendly tangible task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 234
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 143,
      "Name": "Spinka-Smith",
      "ToolTip": "Sit alias velit voluptas.",
      "Deleted": false,
      "Rank": 553,
      "Type": "nesciunt",
      "ColorBlock": 203,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2000-08-08T03:40:55.4443154+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Lacey Kling I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 753
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repudiandae",
      "StrippedValue": "fugit",
      "Description": "Exclusive static success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "fugit",
      "Description": "Exclusive static success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quisquam",
      "StrippedValue": "corrupti",
      "Description": "Exclusive mission-critical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "corrupti",
      "Description": "Exclusive mission-critical capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "possimus",
      "StrippedValue": "quae",
      "Description": "Open-source directional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "quae",
      "Description": "Open-source directional core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "Description": "Right-sized actuating capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 472,
      "Mrmrs": "aperiam",
      "Firstname": "Marietta",
      "Lastname": "Connelly",
      "MiddleName": "Cummings-Wolff",
      "Title": "placeat",
      "Description": "Re-contextualized incremental synergy",
      "Email": "mckenzie@bashiriankuhic.us",
      "FullName": "Adaline Koss",
      "DirectPhone": "583.190.2367 x4314",
      "FormalName": "Borer LLC",
      "CountryId": 349,
      "ContactId": 654,
      "ContactName": "Yost-Zemlak",
      "Retired": 677,
      "Rank": 439,
      "ActiveInterests": 122,
      "ContactDepartment": "",
      "ContactCountryId": 689,
      "ContactOrgNr": "799007",
      "FaxPhone": "1-229-779-1156",
      "MobilePhone": "293-748-0331 x347",
      "ContactPhone": "(824)197-5333 x4341",
      "AssociateName": "Sipes Group",
      "AssociateId": 415,
      "UsePersonAddress": true,
      "ContactFax": "aperiam",
      "Kanafname": "occaecati",
      "Kanalname": "non",
      "Post1": "corrupti",
      "Post2": "blanditiis",
      "Post3": "est",
      "EmailName": "domenick@keelingwolf.info",
      "ContactFullName": "Mossie Mills",
      "ActiveErpLinks": 632,
      "TicketPriorityId": 710,
      "SupportLanguageId": 782,
      "SupportAssociateId": 538,
      "CategoryName": "VIP Customer",
      "PersonNumber": "923058",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 289
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "pariatur",
  "Xstop": true,
  "ActiveInterests": 962,
  "GroupId": 660,
  "ActiveStatusMonitorId": 862,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 282,
  "DbiAgentId": 909,
  "DbiLastSyncronized": "2007-12-06T03:40:55.4443154+01:00",
  "DbiKey": "tempore",
  "DbiLastModified": "2021-06-12T03:40:55.4443154+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 484,
  "ActiveErpLinks": 610,
  "BounceEmails": [
    "kory_strosin@heller.name",
    "elenora.abbott@hickle.name"
  ],
  "Domains": [
    "repudiandae",
    "voluptatum"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "facilis",
    "ExtraFields2": "incidunt"
  },
  "CustomFields": {
    "CustomFields1": "quibusdam",
    "CustomFields2": "aperiam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 566
    }
  }
}
```