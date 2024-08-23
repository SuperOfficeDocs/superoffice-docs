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
Last-Modified: Wed, 05 Dec 2007 13:28:31 G12T

{
  "ContactId": 206,
  "Name": "Hyatt-Wilderman",
  "Department": "",
  "OrgNr": "780370",
  "Number1": "704352",
  "Number2": "220403",
  "UpdatedDate": "2007-12-05T13:28:31.4136779+01:00",
  "CreatedDate": "2002-05-18T13:28:31.4136779+02:00",
  "Emails": [
    {
      "Value": "quisquam",
      "StrippedValue": "aliquam",
      "Description": "Polarised 24/7 knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "aliquam",
      "Description": "Polarised 24/7 knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 156
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 509,
      "Name": "Lynch, Moore and O'Kon",
      "ToolTip": "Rem qui officia ut nobis qui dicta nesciunt.",
      "Deleted": false,
      "Rank": 790,
      "Type": "aspernatur",
      "ColorBlock": 478,
      "IconHint": "vitae",
      "Selected": true,
      "LastChanged": "2014-05-30T13:28:31.4136779+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Lilla Sauer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nostrum",
      "StrippedValue": "laborum",
      "Description": "Multi-layered analyzing methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "laborum",
      "Description": "Multi-layered analyzing methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptas",
      "StrippedValue": "aspernatur",
      "Description": "Organized systemic time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "aspernatur",
      "Description": "Organized systemic time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "ratione",
      "Description": "Multi-layered uniform productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "ratione",
      "Description": "Multi-layered uniform productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 673
        }
      }
    }
  ],
  "Description": "Distributed exuding hub",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 654,
      "Mrmrs": "omnis",
      "Firstname": "Van",
      "Lastname": "Ziemann",
      "MiddleName": "Ortiz LLC",
      "Title": "sed",
      "Description": "Enterprise-wide leading edge help-desk",
      "Email": "alvera@deckow.biz",
      "FullName": "Milford McKenzie",
      "DirectPhone": "1-124-777-8939 x47432",
      "FormalName": "Rowe, Hamill and Yundt",
      "CountryId": 660,
      "ContactId": 239,
      "ContactName": "Stracke Group",
      "Retired": 493,
      "Rank": 286,
      "ActiveInterests": 867,
      "ContactDepartment": "implement enterprise deliverables",
      "ContactCountryId": 301,
      "ContactOrgNr": "1031954",
      "FaxPhone": "(547)657-1663 x47954",
      "MobilePhone": "674.824.2945 x513",
      "ContactPhone": "1-473-732-6208 x7974",
      "AssociateName": "Larkin Inc and Sons",
      "AssociateId": 796,
      "UsePersonAddress": false,
      "ContactFax": "ea",
      "Kanafname": "molestiae",
      "Kanalname": "voluptatibus",
      "Post1": "sit",
      "Post2": "placeat",
      "Post3": "nostrum",
      "EmailName": "ryleigh@ortiz.us",
      "ContactFullName": "Shaniya Jaren Ebert III",
      "ActiveErpLinks": 904,
      "TicketPriorityId": 228,
      "SupportLanguageId": 448,
      "SupportAssociateId": 759,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quasi",
  "Xstop": true,
  "ActiveInterests": 239,
  "GroupId": 799,
  "ActiveStatusMonitorId": 708,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 582,
  "DbiAgentId": 554,
  "DbiLastSyncronized": "2013-09-25T13:28:31.4136779+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2022-10-02T13:28:31.4136779+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 846,
  "ActiveErpLinks": 680,
  "BounceEmails": [
    "fleta@padberg.us",
    "amalia@altenwerthhyatt.name"
  ],
  "Domains": [
    "voluptatibus",
    "possimus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Roy Jacobi"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 366
    }
  }
}
```