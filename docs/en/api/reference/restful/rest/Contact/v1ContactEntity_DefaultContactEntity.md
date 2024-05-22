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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 30 Jul 2002 12:57:42 G7T

{
  "ContactId": 287,
  "Name": "Torphy-Fisher",
  "Department": "",
  "OrgNr": "875965",
  "Number1": "1057457",
  "Number2": "1652995",
  "UpdatedDate": "2002-07-30T12:57:42.1983139+02:00",
  "CreatedDate": "2003-04-14T12:57:42.1983139+02:00",
  "Emails": [
    {
      "Value": "consectetur",
      "StrippedValue": "consequatur",
      "Description": "Optimized tertiary data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 628
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "consequatur",
      "Description": "Optimized tertiary data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 628
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 411,
      "Name": "Hand, Hermann and Ward",
      "ToolTip": "Ipsam harum fugiat.",
      "Deleted": false,
      "Rank": 253,
      "Type": "eveniet",
      "ColorBlock": 626,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2024-01-30T12:57:42.1983139+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "facere",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Davon Ward",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ipsam",
      "StrippedValue": "et",
      "Description": "User-centric full-range flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 902
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "et",
      "Description": "User-centric full-range flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 902
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "optio",
      "StrippedValue": "corporis",
      "Description": "Customizable national structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "corporis",
      "Description": "Customizable national structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Multi-layered mobile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Multi-layered mobile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 363
        }
      }
    }
  ],
  "Description": "Profit-focused attitude-oriented productivity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 469,
      "Mrmrs": "debitis",
      "Firstname": "Vern",
      "Lastname": "Roberts",
      "MiddleName": "Williamson Inc and Sons",
      "Title": "aut",
      "Description": "User-centric full-range product",
      "Email": "tiana.schimmel@waelchiebert.biz",
      "FullName": "Beulah Wilburn Blick V",
      "DirectPhone": "394.403.0808",
      "FormalName": "Botsford, Pfeffer and Hagenes",
      "CountryId": 155,
      "ContactId": 134,
      "ContactName": "Bins Inc and Sons",
      "Retired": 21,
      "Rank": 287,
      "ActiveInterests": 610,
      "ContactDepartment": "",
      "ContactCountryId": 327,
      "ContactOrgNr": "1244403",
      "FaxPhone": "1-490-203-5689 x53084",
      "MobilePhone": "247.520.7927",
      "ContactPhone": "324.154.9529 x04110",
      "AssociateName": "Conroy-Herzog",
      "AssociateId": 592,
      "UsePersonAddress": true,
      "ContactFax": "quia",
      "Kanafname": "beatae",
      "Kanalname": "quis",
      "Post1": "odit",
      "Post2": "qui",
      "Post3": "quis",
      "EmailName": "kaci@lockman.biz",
      "ContactFullName": "Christophe Pfannerstill",
      "ActiveErpLinks": 964,
      "TicketPriorityId": 866,
      "SupportLanguageId": 773,
      "SupportAssociateId": 719,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "reprehenderit",
  "Xstop": false,
  "ActiveInterests": 601,
  "GroupId": 231,
  "ActiveStatusMonitorId": 946,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 432,
  "DbiAgentId": 352,
  "DbiLastSyncronized": "2020-02-16T12:57:42.2139348+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2008-06-04T12:57:42.2139348+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 859,
  "ActiveErpLinks": 679,
  "BounceEmails": [
    "darryl.reynolds@volkmanlangosh.biz",
    "bailee@schroeder.uk"
  ],
  "Domains": [
    "et",
    "iure"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Wellington Deckow",
    "SuperOffice:2": "Ms. Darius Lavon Pouros III"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "incidunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 416
    }
  }
}
```