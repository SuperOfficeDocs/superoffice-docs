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
Last-Modified: Thu, 10 Apr 2008 16:55:29 G4T

{
  "ContactId": 686,
  "Name": "Flatley, Luettgen and Steuber",
  "Department": "",
  "OrgNr": "912433",
  "Number1": "724596",
  "Number2": "1715581",
  "UpdatedDate": "2008-04-10T16:55:29.4053266+02:00",
  "CreatedDate": "2023-05-12T16:55:29.406315+02:00",
  "Emails": [
    {
      "Value": "molestias",
      "StrippedValue": "magnam",
      "Description": "Re-contextualized impactful challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "magnam",
      "Description": "Re-contextualized impactful challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 276
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 726,
      "Name": "Kunze, Johnson and Harris",
      "ToolTip": "Accusamus accusamus sit et qui.",
      "Deleted": false,
      "Rank": 547,
      "Type": "ratione",
      "ColorBlock": 907,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2001-10-31T16:55:29.406315+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "nostrum",
      "Hidden": true,
      "FullName": "Abbigail Earnestine Watsica I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "maiores",
      "Description": "Multi-channelled zero defect application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "maiores",
      "Description": "Multi-channelled zero defect application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "suscipit",
      "StrippedValue": "voluptatibus",
      "Description": "Reactive actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "voluptatibus",
      "Description": "Reactive actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "minus",
      "StrippedValue": "nobis",
      "Description": "Programmable actuating process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "nobis",
      "Description": "Programmable actuating process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "Description": "Enterprise-wide assymetric support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsam",
      "PersonId": 253,
      "Mrmrs": "dolores",
      "Firstname": "Anika",
      "Lastname": "Halvorson",
      "MiddleName": "Prosacco-Oberbrunner",
      "Title": "dolorem",
      "Description": "Public-key bi-directional groupware",
      "Email": "liliana@powlowski.info",
      "FullName": "Prof. Dorothy Jeanie Bechtelar",
      "DirectPhone": "(299)618-0661",
      "FormalName": "Senger, Kirlin and Brakus",
      "CountryId": 453,
      "ContactId": 979,
      "ContactName": "Kshlerin, Paucek and Wisoky",
      "Retired": 460,
      "Rank": 679,
      "ActiveInterests": 600,
      "ContactDepartment": "",
      "ContactCountryId": 24,
      "ContactOrgNr": "840707",
      "FaxPhone": "972.326.0955 x0420",
      "MobilePhone": "1-293-908-7391 x216",
      "ContactPhone": "1-173-627-2228",
      "AssociateName": "Gerhold-Wehner",
      "AssociateId": 651,
      "UsePersonAddress": false,
      "ContactFax": "sint",
      "Kanafname": "qui",
      "Kanalname": "sed",
      "Post1": "eum",
      "Post2": "quisquam",
      "Post3": "occaecati",
      "EmailName": "ahmad@haag.uk",
      "ContactFullName": "Dewayne Sipes",
      "ActiveErpLinks": 25,
      "TicketPriorityId": 476,
      "SupportLanguageId": 799,
      "SupportAssociateId": 681,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 85
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "vitae",
  "Xstop": false,
  "ActiveInterests": 89,
  "GroupId": 206,
  "ActiveStatusMonitorId": 49,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 721,
  "DbiAgentId": 549,
  "DbiLastSyncronized": "2010-09-08T16:55:29.4103357+02:00",
  "DbiKey": "voluptatum",
  "DbiLastModified": "2007-12-26T16:55:29.4103357+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 661,
  "ActiveErpLinks": 514,
  "BounceEmails": [
    "kurtis@grimes.us",
    "lacey@schoen.biz"
  ],
  "Domains": [
    "labore",
    "autem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Mavis Sim McClure IV"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "cum"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 287
    }
  }
}
```