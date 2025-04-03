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
Last-Modified: Sun, 10 May 1998 14:28:26 G5T

{
  "ContactId": 370,
  "Name": "Flatley-Shanahan",
  "Department": "",
  "OrgNr": "978088",
  "Number1": "1075875",
  "Number2": "1704945",
  "UpdatedDate": "1998-05-10T14:28:26.8051995+02:00",
  "CreatedDate": "2005-08-04T14:28:26.8051995+02:00",
  "Emails": [
    {
      "Value": "natus",
      "StrippedValue": "atque",
      "Description": "User-centric multi-state strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    },
    {
      "Value": "natus",
      "StrippedValue": "atque",
      "Description": "User-centric multi-state strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 955
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 69,
      "Name": "Wilderman, Koch and Koch",
      "ToolTip": "At voluptate veniam repellendus aut.",
      "Deleted": true,
      "Rank": 987,
      "Type": "enim",
      "ColorBlock": 640,
      "IconHint": "occaecati",
      "Selected": true,
      "LastChanged": "2018-09-18T14:28:26.8051995+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "at",
      "StyleHint": "laborum",
      "Hidden": false,
      "FullName": "Charles Russel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "voluptatem",
      "Description": "Persevering analyzing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "voluptatem",
      "Description": "Persevering analyzing parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "iure",
      "StrippedValue": "aut",
      "Description": "Future-proofed intermediate productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 444
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "aut",
      "Description": "Future-proofed intermediate productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 444
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "quasi",
      "Description": "Compatible stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "quasi",
      "Description": "Compatible stable projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    }
  ],
  "Description": "Cross-platform 6th generation matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellendus",
      "PersonId": 964,
      "Mrmrs": "ratione",
      "Firstname": "Gianni",
      "Lastname": "Mertz",
      "MiddleName": "Welch, Koss and Harris",
      "Title": "quaerat",
      "Description": "Total even-keeled capacity",
      "Email": "emil@muellercremin.biz",
      "FullName": "Delphine Harber",
      "DirectPhone": "917-161-5251",
      "FormalName": "Corwin-Legros",
      "CountryId": 538,
      "ContactId": 898,
      "ContactName": "Hintz, Schamberger and Yost",
      "Retired": 228,
      "Rank": 820,
      "ActiveInterests": 314,
      "ContactDepartment": "envisioneer open-source markets",
      "ContactCountryId": 996,
      "ContactOrgNr": "1461791",
      "FaxPhone": "(206)903-2071",
      "MobilePhone": "371-792-7155",
      "ContactPhone": "240-178-4774 x89305",
      "AssociateName": "Lehner LLC",
      "AssociateId": 145,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "eos",
      "Kanalname": "repellat",
      "Post1": "at",
      "Post2": "error",
      "Post3": "iusto",
      "EmailName": "denis.denesik@lemke.info",
      "ContactFullName": "Miss Gonzalo Russell Welch",
      "ActiveErpLinks": 217,
      "TicketPriorityId": 409,
      "SupportLanguageId": 988,
      "SupportAssociateId": 886,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1044169",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": false,
  "ActiveInterests": 280,
  "GroupId": 139,
  "ActiveStatusMonitorId": 948,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 729,
  "DbiAgentId": 514,
  "DbiLastSyncronized": "2023-02-17T14:28:26.8051995+01:00",
  "DbiKey": "sapiente",
  "DbiLastModified": "2019-04-28T14:28:26.8051995+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 619,
  "ActiveErpLinks": 865,
  "BounceEmails": [
    "elody_weber@lockmanbecker.ca",
    "lorna.effertz@legros.uk"
  ],
  "Domains": [
    "voluptatum",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "567930273",
    "SuperOffice:2": "Leta Orn"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 727
    }
  }
}
```