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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 21 Apr 2024 03:46:59 G4T

{
  "ContactId": 87,
  "Name": "Hansen LLC",
  "Department": "",
  "OrgNr": "497089",
  "Number1": "564245",
  "Number2": "1311629",
  "UpdatedDate": "2024-04-21T03:46:59.8161962+02:00",
  "CreatedDate": "2010-10-09T03:46:59.8161962+02:00",
  "Emails": [
    {
      "Value": "dolorum",
      "StrippedValue": "a",
      "Description": "Balanced zero tolerance emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "a",
      "Description": "Balanced zero tolerance emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 9,
      "Name": "Murazik Inc and Sons",
      "ToolTip": "Deserunt officia delectus ut aut assumenda voluptate.",
      "Deleted": false,
      "Rank": 686,
      "Type": "ea",
      "ColorBlock": 604,
      "IconHint": "fugiat",
      "Selected": false,
      "LastChanged": "2019-06-18T03:46:59.8161962+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "consequatur",
      "Hidden": true,
      "FullName": "Karli Predovic",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 977
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "commodi",
      "Description": "Reduced analyzing artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "commodi",
      "Description": "Reduced analyzing artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 658
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Balanced upward-trending methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Balanced upward-trending methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 105
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ipsa",
      "StrippedValue": "aperiam",
      "Description": "Managed full-range capability",
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
      "Value": "ipsa",
      "StrippedValue": "aperiam",
      "Description": "Managed full-range capability",
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
  "Description": "Balanced zero tolerance orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 336,
      "Mrmrs": "sit",
      "Firstname": "Lucio",
      "Lastname": "Lakin",
      "MiddleName": "Hermann-Bayer",
      "Title": "sint",
      "Description": "Automated regional product",
      "Email": "audie.quigley@carter.name",
      "FullName": "Quinn Lang",
      "DirectPhone": "1-329-927-1811",
      "FormalName": "Green-Bogisich",
      "CountryId": 799,
      "ContactId": 859,
      "ContactName": "Goldner-Stanton",
      "Retired": 397,
      "Rank": 721,
      "ActiveInterests": 512,
      "ContactDepartment": "revolutionize back-end e-commerce",
      "ContactCountryId": 746,
      "ContactOrgNr": "1385033",
      "FaxPhone": "1-940-763-4825",
      "MobilePhone": "(458)262-5918 x570",
      "ContactPhone": "902-146-4789 x98317",
      "AssociateName": "Torp, Hand and Wolff",
      "AssociateId": 412,
      "UsePersonAddress": false,
      "ContactFax": "eos",
      "Kanafname": "veritatis",
      "Kanalname": "nostrum",
      "Post1": "hic",
      "Post2": "praesentium",
      "Post3": "ad",
      "EmailName": "millie@eberthudson.co.uk",
      "ContactFullName": "Helga Hudson",
      "ActiveErpLinks": 950,
      "TicketPriorityId": 155,
      "SupportLanguageId": 997,
      "SupportAssociateId": 84,
      "CategoryName": "VIP Customer",
      "PersonNumber": "830214",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 873
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "harum",
  "Xstop": true,
  "ActiveInterests": 804,
  "GroupId": 245,
  "ActiveStatusMonitorId": 46,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 820,
  "DbiAgentId": 436,
  "DbiLastSyncronized": "2006-01-27T03:46:59.8318192+01:00",
  "DbiKey": "quo",
  "DbiLastModified": "2008-01-17T03:46:59.8318192+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 233,
  "ActiveErpLinks": 23,
  "BounceEmails": [
    "nasir.hahn@murraysauer.info",
    "brown.hand@gibson.info"
  ],
  "Domains": [
    "officiis",
    "voluptas"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Alfonzo Stroman",
    "SuperOffice:2": "Wyman Connelly"
  },
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 747
    }
  }
}
```