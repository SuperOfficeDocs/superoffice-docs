---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Loading default values into a new ContactEntity.








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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 954,
  "Name": "Dare-Ullrich",
  "Department": "",
  "OrgNr": "849935",
  "Number1": "246479",
  "Number2": "515830",
  "UpdatedDate": "1999-10-17T03:46:54.4726424+02:00",
  "CreatedDate": "2000-10-20T03:46:54.4726424+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "aspernatur",
      "Description": "Centralized needs-based emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aspernatur",
      "Description": "Centralized needs-based emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 87,
      "Name": "Carter LLC",
      "ToolTip": "Consequatur praesentium rerum expedita voluptatem.",
      "Deleted": true,
      "Rank": 164,
      "Type": "repellat",
      "ColorBlock": 943,
      "IconHint": "odit",
      "Selected": true,
      "LastChanged": "2025-04-02T03:46:54.4726424+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Miss Sienna Fisher",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Triple-buffered system-worthy frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 503
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Triple-buffered system-worthy frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 503
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "id",
      "Description": "Intuitive tertiary flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "id",
      "Description": "Intuitive tertiary flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 449
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "deserunt",
      "Description": "Optional object-oriented workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "deserunt",
      "Description": "Optional object-oriented workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Description": "Integrated 5th generation adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "optio",
      "PersonId": 718,
      "Mrmrs": "est",
      "Firstname": "Alia",
      "Lastname": "Larkin",
      "MiddleName": "Abernathy-DuBuque",
      "Title": "odit",
      "Description": "Automated holistic customer loyalty",
      "Email": "candace.monahan@hanehyatt.info",
      "FullName": "Katlyn Rice",
      "DirectPhone": "1-558-374-3894 x82915",
      "FormalName": "Herman, Marvin and Toy",
      "CountryId": 700,
      "ContactId": 323,
      "ContactName": "Luettgen-Gerhold",
      "Retired": 82,
      "Rank": 11,
      "ActiveInterests": 772,
      "ContactDepartment": "",
      "ContactCountryId": 408,
      "ContactOrgNr": "999491",
      "FaxPhone": "1-391-668-0307",
      "MobilePhone": "(693)256-6700 x4699",
      "ContactPhone": "836-301-9565 x923",
      "AssociateName": "Wiegand, Murazik and Schowalter",
      "AssociateId": 115,
      "UsePersonAddress": false,
      "ContactFax": "distinctio",
      "Kanafname": "iure",
      "Kanalname": "et",
      "Post1": "quod",
      "Post2": "voluptatem",
      "Post3": "nesciunt",
      "EmailName": "quentin@rathgerlach.biz",
      "ContactFullName": "Harmon Denesik",
      "ActiveErpLinks": 961,
      "TicketPriorityId": 138,
      "SupportLanguageId": 669,
      "SupportAssociateId": 550,
      "CategoryName": "VIP Customer",
      "PersonNumber": "286535",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 382
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "non",
  "Xstop": true,
  "ActiveInterests": 804,
  "GroupId": 863,
  "ActiveStatusMonitorId": 322,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 385,
  "DbiAgentId": 239,
  "DbiLastSyncronized": "2003-02-23T03:46:54.4726424+01:00",
  "DbiKey": "esse",
  "DbiLastModified": "2009-10-02T03:46:54.4726424+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 975,
  "ActiveErpLinks": 609,
  "BounceEmails": [
    "maudie_lind@frami.ca",
    "jamey@mueller.us"
  ],
  "Domains": [
    "sequi",
    "libero"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Elsa Zackery O'Hara IV",
    "SuperOffice:2": "1195584085"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "consectetur"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "quo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 515
    }
  }
}
```