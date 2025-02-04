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
Last-Modified: Sat, 28 Jul 2001 13:13:31 G7T

{
  "ContactId": 876,
  "Name": "Langosh, Ondricka and Kessler",
  "Department": "",
  "OrgNr": "1349289",
  "Number1": "1198779",
  "Number2": "551908",
  "UpdatedDate": "2001-07-28T13:13:31.4801667+02:00",
  "CreatedDate": "2000-10-06T13:13:31.4801667+02:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Future-proofed regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Future-proofed regional application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 825,
      "Name": "Trantow-Considine",
      "ToolTip": "Veritatis perspiciatis incidunt repudiandae.",
      "Deleted": false,
      "Rank": 953,
      "Type": "non",
      "ColorBlock": 197,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2022-03-19T13:13:31.4801667+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "incidunt",
      "Hidden": false,
      "FullName": "Boyd Schaden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "laudantium",
      "StrippedValue": "aspernatur",
      "Description": "Balanced dynamic internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "aspernatur",
      "Description": "Balanced dynamic internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 944
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cum",
      "StrippedValue": "assumenda",
      "Description": "Ameliorated 24/7 adapter",
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
      "Value": "cum",
      "StrippedValue": "assumenda",
      "Description": "Ameliorated 24/7 adapter",
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
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "porro",
      "Description": "Front-line executive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 794
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "porro",
      "Description": "Front-line executive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 794
        }
      }
    }
  ],
  "Description": "Optional bottom-line open architecture",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 176,
      "Mrmrs": "et",
      "Firstname": "Deborah",
      "Lastname": "Dare",
      "MiddleName": "Ullrich Group",
      "Title": "perferendis",
      "Description": "Monitored intermediate hardware",
      "Email": "cleo.jerde@damoremarks.co.uk",
      "FullName": "Roberto Cummings",
      "DirectPhone": "(357)355-7891 x3755",
      "FormalName": "Stracke-Bernhard",
      "CountryId": 920,
      "ContactId": 364,
      "ContactName": "Howell, Weber and Nienow",
      "Retired": 222,
      "Rank": 719,
      "ActiveInterests": 356,
      "ContactDepartment": "",
      "ContactCountryId": 364,
      "ContactOrgNr": "702329",
      "FaxPhone": "1-203-504-3342",
      "MobilePhone": "1-545-373-3031 x92693",
      "ContactPhone": "(650)804-5646 x785",
      "AssociateName": "Rempel Inc and Sons",
      "AssociateId": 669,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "qui",
      "Kanalname": "iure",
      "Post1": "unde",
      "Post2": "vero",
      "Post3": "minus",
      "EmailName": "camille@cronin.name",
      "ContactFullName": "Dan Brook O'Hara PhD",
      "ActiveErpLinks": 382,
      "TicketPriorityId": 59,
      "SupportLanguageId": 843,
      "SupportAssociateId": 412,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 19
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "dolore",
  "Xstop": true,
  "ActiveInterests": 917,
  "GroupId": 441,
  "ActiveStatusMonitorId": 79,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 413,
  "DbiAgentId": 173,
  "DbiLastSyncronized": "2006-09-24T13:13:31.4801667+02:00",
  "DbiKey": "numquam",
  "DbiLastModified": "2018-03-09T13:13:31.4801667+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 26,
  "ActiveErpLinks": 523,
  "BounceEmails": [
    "jammie@hilll.biz",
    "scotty@beckercrist.com"
  ],
  "Domains": [
    "velit",
    "non"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ida Jerde",
    "SuperOffice:2": "Miss Cathy Liam Buckridge"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 319
    }
  }
}
```