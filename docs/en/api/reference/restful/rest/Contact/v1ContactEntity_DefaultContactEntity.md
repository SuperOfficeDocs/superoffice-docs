---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 08 Jan 2019 11:44:41 G1T

{
  "ContactId": 605,
  "Name": "Mueller, Beatty and Wunsch",
  "Department": "",
  "OrgNr": "1039420",
  "Number1": "144831",
  "Number2": "988695",
  "UpdatedDate": "2019-01-08T11:44:41.7421561+01:00",
  "CreatedDate": "2022-07-03T11:44:41.7421561+02:00",
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "repellat",
      "Description": "Inverse methodical alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "repellat",
      "Description": "Inverse methodical alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 324,
      "Name": "Luettgen LLC",
      "ToolTip": "Ratione rerum.",
      "Deleted": true,
      "Rank": 491,
      "Type": "vitae",
      "ColorBlock": 654,
      "IconHint": "error",
      "Selected": false,
      "LastChanged": "2010-06-02T11:44:41.7421561+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "eos",
      "Hidden": true,
      "FullName": "Isac Stiedemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 807
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "earum",
      "StrippedValue": "sed",
      "Description": "Adaptive mission-critical orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    },
    {
      "Value": "earum",
      "StrippedValue": "sed",
      "Description": "Adaptive mission-critical orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 772
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "excepturi",
      "Description": "Devolved eco-centric framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "excepturi",
      "Description": "Devolved eco-centric framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 126
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "voluptatem",
      "Description": "Multi-lateral didactic secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "voluptatem",
      "Description": "Multi-lateral didactic secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 868
        }
      }
    }
  ],
  "Description": "Inverse client-server support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laboriosam",
      "PersonId": 141,
      "Mrmrs": "et",
      "Firstname": "Franz",
      "Lastname": "Krajcik",
      "MiddleName": "Wolf-Turcotte",
      "Title": "est",
      "Description": "De-engineered neutral architecture",
      "Email": "trent_emard@grimes.com",
      "FullName": "Jalon Zieme",
      "DirectPhone": "1-738-328-6271",
      "FormalName": "Senger, Turner and Ritchie",
      "CountryId": 704,
      "ContactId": 702,
      "ContactName": "Wintheiser, Dickens and Mraz",
      "Retired": 866,
      "Rank": 763,
      "ActiveInterests": 560,
      "ContactDepartment": "",
      "ContactCountryId": 647,
      "ContactOrgNr": "701377",
      "FaxPhone": "057.853.5895 x1000",
      "MobilePhone": "(579)408-0695 x4299",
      "ContactPhone": "1-600-825-8417",
      "AssociateName": "Torp, Harris and Stark",
      "AssociateId": 374,
      "UsePersonAddress": false,
      "ContactFax": "repellendus",
      "Kanafname": "non",
      "Kanalname": "et",
      "Post1": "laudantium",
      "Post2": "vitae",
      "Post3": "unde",
      "EmailName": "lilyan.barrows@handwest.ca",
      "ContactFullName": "Geovanny O'Hara",
      "ActiveErpLinks": 247,
      "TicketPriorityId": 2,
      "SupportLanguageId": 805,
      "SupportAssociateId": 534,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 260
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "recusandae",
  "Xstop": false,
  "ActiveInterests": 515,
  "GroupId": 186,
  "ActiveStatusMonitorId": 247,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 165,
  "DbiAgentId": 954,
  "DbiLastSyncronized": "2007-01-05T11:44:41.7421561+01:00",
  "DbiKey": "quaerat",
  "DbiLastModified": "2003-08-10T11:44:41.7421561+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 744,
  "ActiveErpLinks": 882,
  "BounceEmails": [
    "jonathan.grady@kuhlmanschoen.info",
    "verona.beatty@hansenhoeger.uk"
  ],
  "Domains": [
    "non",
    "impedit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "680763850",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quia",
    "ExtraFields2": "quo"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "corrupti"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 154
    }
  }
}
```