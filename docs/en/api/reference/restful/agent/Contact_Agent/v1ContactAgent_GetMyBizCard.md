---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
```


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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 443,
  "Name": "Pacocha-Gottlieb",
  "Department": "",
  "OrgNr": "891639",
  "Number1": "1069329",
  "Number2": "805638",
  "UpdatedDate": "2012-04-28T16:54:54.985754+02:00",
  "CreatedDate": "2020-09-18T16:54:54.985754+02:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "eius",
      "Description": "Upgradable composite secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "eius",
      "Description": "Upgradable composite secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 421,
      "Name": "Mitchell Group",
      "ToolTip": "Et cupiditate iure veniam autem architecto enim fugiat.",
      "Deleted": false,
      "Rank": 836,
      "Type": "officia",
      "ColorBlock": 867,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2008-03-18T16:54:54.985754+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "expedita",
      "Hidden": true,
      "FullName": "Melyssa Jammie Ortiz V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 477
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "enim",
      "Description": "Networked hybrid paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "enim",
      "Description": "Networked hybrid paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 55
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "occaecati",
      "Description": "Focused homogeneous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "occaecati",
      "Description": "Focused homogeneous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facere",
      "StrippedValue": "quae",
      "Description": "Proactive even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "facere",
      "StrippedValue": "quae",
      "Description": "Proactive even-keeled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    }
  ],
  "Description": "Realigned discrete artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "odio",
      "PersonId": 513,
      "Mrmrs": "et",
      "Firstname": "Wanda",
      "Lastname": "Toy",
      "MiddleName": "Veum Group",
      "Title": "voluptatem",
      "Description": "Profit-focused holistic encryption",
      "Email": "fae_cole@deckow.info",
      "FullName": "Haley Paucek",
      "DirectPhone": "686.040.9750",
      "FormalName": "Watsica-Ullrich",
      "CountryId": 348,
      "ContactId": 32,
      "ContactName": "Halvorson Inc and Sons",
      "Retired": 672,
      "Rank": 80,
      "ActiveInterests": 390,
      "ContactDepartment": "",
      "ContactCountryId": 860,
      "ContactOrgNr": "791426",
      "FaxPhone": "107-975-4703",
      "MobilePhone": "(992)987-6349 x18154",
      "ContactPhone": "(314)349-2417 x450",
      "AssociateName": "Fahey-Gleason",
      "AssociateId": 42,
      "UsePersonAddress": true,
      "ContactFax": "beatae",
      "Kanafname": "voluptatem",
      "Kanalname": "qui",
      "Post1": "qui",
      "Post2": "id",
      "Post3": "sit",
      "EmailName": "ericka@schulist.ca",
      "ContactFullName": "Icie Wiza PhD",
      "ActiveErpLinks": 647,
      "TicketPriorityId": 700,
      "SupportLanguageId": 33,
      "SupportAssociateId": 482,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": false,
  "ActiveInterests": 776,
  "GroupId": 226,
  "ActiveStatusMonitorId": 678,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 192,
  "DbiAgentId": 118,
  "DbiLastSyncronized": "1996-11-10T16:54:54.9897522+01:00",
  "DbiKey": "asperiores",
  "DbiLastModified": "2019-05-30T16:54:54.9897522+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 866,
  "ActiveErpLinks": 568,
  "BounceEmails": [
    "janae@hirthe.us",
    "garrett_nikolaus@marks.us"
  ],
  "Domains": [
    "itaque",
    "quibusdam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "813790618",
    "SuperOffice:2": "Leta Turner"
  },
  "ExtraFields": {
    "ExtraFields1": "quos",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 232
    }
  }
}
```