---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=898
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 785,
  "Name": "Gleason LLC",
  "Department": "",
  "OrgNr": "447428",
  "Number1": "1638554",
  "Number2": "1284288",
  "UpdatedDate": "2014-12-29T10:17:55.2540178+01:00",
  "CreatedDate": "2010-08-05T10:17:55.2540178+02:00",
  "Emails": [
    {
      "Value": "quam",
      "StrippedValue": "et",
      "Description": "Diverse upward-trending project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "et",
      "Description": "Diverse upward-trending project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 688
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 472,
      "Name": "Kessler-Hegmann",
      "ToolTip": "Esse voluptates.",
      "Deleted": false,
      "Rank": 814,
      "Type": "id",
      "ColorBlock": 105,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "2022-07-12T10:17:55.2540178+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Abagail Aufderhar DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 874
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "officia",
      "StrippedValue": "sit",
      "Description": "Proactive value-added task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "sit",
      "Description": "Proactive value-added task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 849
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sapiente",
      "StrippedValue": "in",
      "Description": "Fully-configurable impactful application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "in",
      "Description": "Fully-configurable impactful application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "dolores",
      "Description": "Organized static standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "dolores",
      "Description": "Organized static standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "Description": "Enhanced impactful structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nulla",
      "PersonId": 652,
      "Mrmrs": "culpa",
      "Firstname": "Russel",
      "Lastname": "Torp",
      "MiddleName": "Tillman, Pacocha and Feeney",
      "Title": "quae",
      "Description": "Diverse multi-tasking extranet",
      "Email": "carleton_hayes@gutkowskihilpert.name",
      "FullName": "Elian Bashirian",
      "DirectPhone": "727-133-2279 x087",
      "FormalName": "Lowe, Koepp and Dickens",
      "CountryId": 555,
      "ContactId": 50,
      "ContactName": "Paucek, Macejkovic and Blanda",
      "Retired": 56,
      "Rank": 620,
      "ActiveInterests": 837,
      "ContactDepartment": "",
      "ContactCountryId": 852,
      "ContactOrgNr": "503819",
      "FaxPhone": "933.555.4023 x61422",
      "MobilePhone": "1-532-662-6449 x81803",
      "ContactPhone": "032.752.4975",
      "AssociateName": "Shields, Parker and Bernhard",
      "AssociateId": 400,
      "UsePersonAddress": true,
      "ContactFax": "repellat",
      "Kanafname": "a",
      "Kanalname": "soluta",
      "Post1": "excepturi",
      "Post2": "cum",
      "Post3": "alias",
      "EmailName": "kaylah@herman.co.uk",
      "ContactFullName": "Florence Leopoldo Glover IV",
      "ActiveErpLinks": 26,
      "TicketPriorityId": 606,
      "SupportLanguageId": 625,
      "SupportAssociateId": 214,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 13,
  "GroupId": 614,
  "ActiveStatusMonitorId": 42,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 674,
  "DbiAgentId": 845,
  "DbiLastSyncronized": "2001-04-20T10:17:55.2540178+02:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2013-05-04T10:17:55.2540178+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 943,
  "ActiveErpLinks": 445,
  "BounceEmails": [
    "corene@herzog.ca",
    "winnifred@murphy.biz"
  ],
  "Domains": [
    "non",
    "dicta"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Devin O'Keefe",
    "SuperOffice:2": "Nathen Elisha Harvey MD"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "recusandae",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 951
    }
  }
}
```