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
  "ContactId": 951,
  "Name": "Simonis Inc and Sons",
  "Department": "",
  "OrgNr": "1105823",
  "Number1": "204301",
  "Number2": "509396",
  "UpdatedDate": "2001-10-15T16:32:38.3990594+02:00",
  "CreatedDate": "2001-05-11T16:32:38.3990594+02:00",
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Centralized client-server concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "non",
      "Description": "Centralized client-server concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 484
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 345,
      "Name": "Nikolaus Inc and Sons",
      "ToolTip": "Minima ut est fugit qui dolor architecto velit.",
      "Deleted": false,
      "Rank": 315,
      "Type": "voluptatibus",
      "ColorBlock": 961,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "2012-06-16T16:32:38.3990594+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Alta Shields",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cumque",
      "StrippedValue": "cupiditate",
      "Description": "Virtual 5th generation methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "cupiditate",
      "Description": "Virtual 5th generation methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 940
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "hic",
      "Description": "Mandatory content-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "hic",
      "Description": "Mandatory content-based hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tenetur",
      "StrippedValue": "sunt",
      "Description": "Assimilated background portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "sunt",
      "Description": "Assimilated background portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "Description": "Cross-platform holistic task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 187,
      "Mrmrs": "cum",
      "Firstname": "Sam",
      "Lastname": "Gutkowski",
      "MiddleName": "Walsh LLC",
      "Title": "non",
      "Description": "Adaptive even-keeled Graphical User Interface",
      "Email": "damion@wymanstiedemann.info",
      "FullName": "Ova Weimann",
      "DirectPhone": "(235)970-8480",
      "FormalName": "Gleichner-Carter",
      "CountryId": 646,
      "ContactId": 319,
      "ContactName": "Jenkins, Marvin and Hamill",
      "Retired": 338,
      "Rank": 223,
      "ActiveInterests": 826,
      "ContactDepartment": "",
      "ContactCountryId": 349,
      "ContactOrgNr": "1159863",
      "FaxPhone": "726.960.6460",
      "MobilePhone": "1-393-092-0211 x43224",
      "ContactPhone": "1-416-600-7821 x83853",
      "AssociateName": "Langworth-Schmidt",
      "AssociateId": 961,
      "UsePersonAddress": false,
      "ContactFax": "voluptatum",
      "Kanafname": "consequatur",
      "Kanalname": "est",
      "Post1": "sint",
      "Post2": "accusantium",
      "Post3": "et",
      "EmailName": "maiya_boehm@thompsondavis.biz",
      "ContactFullName": "Junior Zulauf",
      "ActiveErpLinks": 185,
      "TicketPriorityId": 325,
      "SupportLanguageId": 358,
      "SupportAssociateId": 303,
      "CategoryName": "VIP Customer",
      "PersonNumber": "772172",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eum",
  "Xstop": false,
  "ActiveInterests": 359,
  "GroupId": 657,
  "ActiveStatusMonitorId": 534,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 566,
  "DbiAgentId": 460,
  "DbiLastSyncronized": "1998-04-19T16:32:38.3990594+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "2010-06-05T16:32:38.3990594+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 854,
  "ActiveErpLinks": 401,
  "BounceEmails": [
    "yessenia@schimmel.com",
    "jacky.mayer@feest.info"
  ],
  "Domains": [
    "ut",
    "eius"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Eliseo Nitzsche",
    "SuperOffice:2": "Ms. Aletha Waino Bayer Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "facilis",
    "CustomFields2": "ratione"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 395
    }
  }
}
```