---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 867,
  "Name": "Pollich, Reilly and Emmerich",
  "Department": "",
  "OrgNr": "560433",
  "Number1": "1296031",
  "Number2": "1208935",
  "UpdatedDate": "2001-09-07T17:54:02.835846+02:00",
  "CreatedDate": "2005-03-29T17:54:02.835846+02:00",
  "Emails": [
    {
      "Value": "exercitationem",
      "StrippedValue": "officia",
      "Description": "Profound needs-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "officia",
      "Description": "Profound needs-based task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 833
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 258,
      "Name": "Reynolds LLC",
      "ToolTip": "Et aperiam magni tenetur sed.",
      "Deleted": false,
      "Rank": 927,
      "Type": "maxime",
      "ColorBlock": 6,
      "IconHint": "voluptate",
      "Selected": false,
      "LastChanged": "2008-05-29T17:54:02.835846+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Shawn Shanahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Cross-platform optimal product",
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
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Cross-platform optimal product",
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
  "Phones": [
    {
      "Value": "eius",
      "StrippedValue": "quis",
      "Description": "User-centric needs-based projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "quis",
      "Description": "User-centric needs-based projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptates",
      "StrippedValue": "aliquam",
      "Description": "Open-source motivating hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "aliquam",
      "Description": "Open-source motivating hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    }
  ],
  "Description": "Quality-focused coherent service-desk",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloremque",
      "PersonId": 177,
      "Mrmrs": "impedit",
      "Firstname": "Marian",
      "Lastname": "Price",
      "MiddleName": "Murazik, Gulgowski and Homenick",
      "Title": "est",
      "Description": "Right-sized analyzing local area network",
      "Email": "jerad@windler.com",
      "FullName": "Fredy Harris",
      "DirectPhone": "1-368-405-2710",
      "FormalName": "Windler Inc and Sons",
      "CountryId": 128,
      "ContactId": 769,
      "ContactName": "McLaughlin, Johnston and Roberts",
      "Retired": 972,
      "Rank": 795,
      "ActiveInterests": 401,
      "ContactDepartment": "",
      "ContactCountryId": 946,
      "ContactOrgNr": "681984",
      "FaxPhone": "997-937-7452 x287",
      "MobilePhone": "1-577-659-1871 x9465",
      "ContactPhone": "954-626-6549 x921",
      "AssociateName": "Brown, Kunze and Kihn",
      "AssociateId": 21,
      "UsePersonAddress": true,
      "ContactFax": "distinctio",
      "Kanafname": "mollitia",
      "Kanalname": "nulla",
      "Post1": "eum",
      "Post2": "ut",
      "Post3": "omnis",
      "EmailName": "icie_kiehn@batzcassin.ca",
      "ContactFullName": "Derick Bailey Jr.",
      "ActiveErpLinks": 40,
      "TicketPriorityId": 15,
      "SupportLanguageId": 886,
      "SupportAssociateId": 344,
      "CategoryName": "VIP Customer",
      "PersonNumber": "917208",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eos",
  "Xstop": false,
  "ActiveInterests": 111,
  "GroupId": 381,
  "ActiveStatusMonitorId": 972,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 75,
  "DbiAgentId": 416,
  "DbiLastSyncronized": "1998-03-13T17:54:02.835846+01:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2006-05-27T17:54:02.835846+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 259,
  "ActiveErpLinks": 550,
  "BounceEmails": [
    "sammie@predovicboyer.info",
    "charley_dietrich@aufderhar.info"
  ],
  "Domains": [
    "repudiandae",
    "totam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Sonny Linnie Kuvalis DDS",
    "SuperOffice:2": "Philip Lemke"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "perspiciatis",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 273
    }
  }
}
```