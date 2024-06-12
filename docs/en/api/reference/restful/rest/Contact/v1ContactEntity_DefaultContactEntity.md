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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 17 May 2007 04:22:34 G5T

{
  "ContactId": 830,
  "Name": "Rau-Ondricka",
  "Department": "",
  "OrgNr": "656184",
  "Number1": "760030",
  "Number2": "1741401",
  "UpdatedDate": "2007-05-17T04:22:34.7652204+02:00",
  "CreatedDate": "2009-11-21T04:22:34.7652204+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Managed dynamic access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Managed dynamic access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 981
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 369,
      "Name": "Dooley Inc and Sons",
      "ToolTip": "Laborum quod quisquam vel dolores iste assumenda iure.",
      "Deleted": false,
      "Rank": 332,
      "Type": "qui",
      "ColorBlock": 854,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2006-11-23T04:22:34.7652204+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "eligendi",
      "Hidden": false,
      "FullName": "Vernon Breitenberg",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 669
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "fuga",
      "Description": "Future-proofed multi-state neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "fuga",
      "Description": "Future-proofed multi-state neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nemo",
      "StrippedValue": "laboriosam",
      "Description": "Down-sized foreground superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 285
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "laboriosam",
      "Description": "Down-sized foreground superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 285
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "suscipit",
      "StrippedValue": "perferendis",
      "Description": "Sharable next generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "perferendis",
      "Description": "Sharable next generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "Description": "Secured logistical project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vitae",
      "PersonId": 61,
      "Mrmrs": "deserunt",
      "Firstname": "Bonita",
      "Lastname": "Trantow",
      "MiddleName": "Hane, Rutherford and Emard",
      "Title": "porro",
      "Description": "Ameliorated composite architecture",
      "Email": "donavon@bayer.co.uk",
      "FullName": "Ms. Preston Berge",
      "DirectPhone": "160.752.9169 x208",
      "FormalName": "Romaguera-Christiansen",
      "CountryId": 794,
      "ContactId": 423,
      "ContactName": "Ondricka-Kutch",
      "Retired": 974,
      "Rank": 651,
      "ActiveInterests": 478,
      "ContactDepartment": "",
      "ContactCountryId": 445,
      "ContactOrgNr": "902716",
      "FaxPhone": "1-589-807-5595 x4320",
      "MobilePhone": "(898)105-9075 x4802",
      "ContactPhone": "1-590-113-4050 x3977",
      "AssociateName": "Mayer-Howell",
      "AssociateId": 952,
      "UsePersonAddress": true,
      "ContactFax": "non",
      "Kanafname": "praesentium",
      "Kanalname": "voluptatem",
      "Post1": "corrupti",
      "Post2": "cupiditate",
      "Post3": "voluptatibus",
      "EmailName": "ila@jacobi.uk",
      "ContactFullName": "Therese Hirthe",
      "ActiveErpLinks": 532,
      "TicketPriorityId": 887,
      "SupportLanguageId": 868,
      "SupportAssociateId": 11,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sint",
  "Xstop": true,
  "ActiveInterests": 90,
  "GroupId": 975,
  "ActiveStatusMonitorId": 962,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 261,
  "DbiAgentId": 273,
  "DbiLastSyncronized": "2006-02-27T04:22:34.7652204+01:00",
  "DbiKey": "velit",
  "DbiLastModified": "2008-11-13T04:22:34.7652204+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 466,
  "ActiveErpLinks": 648,
  "BounceEmails": [
    "baylee@schiller.name",
    "berry.kunde@romaguera.us"
  ],
  "Domains": [
    "dolore",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1742566",
    "SuperOffice:2": "Estelle Ullrich"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "doloremque"
  },
  "CustomFields": {
    "CustomFields1": "quae",
    "CustomFields2": "error"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 913
    }
  }
}
```