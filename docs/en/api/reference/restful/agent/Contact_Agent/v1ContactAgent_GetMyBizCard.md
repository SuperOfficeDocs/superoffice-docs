---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 547,
  "Name": "Sauer Group",
  "Department": "",
  "OrgNr": "479888",
  "Number1": "875099",
  "Number2": "1185911",
  "UpdatedDate": "2010-09-21T11:24:47.7814202+02:00",
  "CreatedDate": "2018-08-17T11:24:47.7814202+02:00",
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "rem",
      "Description": "Public-key static artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "rem",
      "Description": "Public-key static artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 274
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 704,
      "Name": "Dickinson-Quitzon",
      "ToolTip": "Sed quisquam debitis ut qui qui exercitationem.",
      "Deleted": true,
      "Rank": 811,
      "Type": "deserunt",
      "ColorBlock": 55,
      "IconHint": "tempora",
      "Selected": true,
      "LastChanged": "2018-03-20T11:24:47.7814202+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ex",
      "StyleHint": "id",
      "Hidden": false,
      "FullName": "Dr. Maximilian Bradtke DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "eaque",
      "Description": "Fully-configurable explicit budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "eaque",
      "Description": "Fully-configurable explicit budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ipsam",
      "StrippedValue": "eaque",
      "Description": "Assimilated object-oriented adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "eaque",
      "Description": "Assimilated object-oriented adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 284
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Right-sized bottom-line hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Right-sized bottom-line hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "Description": "Implemented explicit analyzer",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laudantium",
      "PersonId": 350,
      "Mrmrs": "possimus",
      "Firstname": "Kaley",
      "Lastname": "Predovic",
      "MiddleName": "Barton, Gutkowski and Muller",
      "Title": "perspiciatis",
      "Description": "Streamlined zero tolerance moderator",
      "Email": "eldora.brakus@hauck.name",
      "FullName": "Casper Krajcik",
      "DirectPhone": "781-810-3367",
      "FormalName": "Mraz Inc and Sons",
      "CountryId": 878,
      "ContactId": 204,
      "ContactName": "Mueller, Metz and Fadel",
      "Retired": 129,
      "Rank": 28,
      "ActiveInterests": 906,
      "ContactDepartment": "",
      "ContactCountryId": 373,
      "ContactOrgNr": "870717",
      "FaxPhone": "(147)105-9111 x305",
      "MobilePhone": "435.463.0525 x0315",
      "ContactPhone": "1-421-112-2025",
      "AssociateName": "Veum Inc and Sons",
      "AssociateId": 18,
      "UsePersonAddress": false,
      "ContactFax": "nostrum",
      "Kanafname": "rem",
      "Kanalname": "sint",
      "Post1": "temporibus",
      "Post2": "perferendis",
      "Post3": "sed",
      "EmailName": "alexandro@oberbrunner.info",
      "ContactFullName": "Dock Conroy",
      "ActiveErpLinks": 211,
      "TicketPriorityId": 685,
      "SupportLanguageId": 404,
      "SupportAssociateId": 104,
      "CategoryName": "VIP Customer",
      "PersonNumber": "828820",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 660
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 282,
  "GroupId": 105,
  "ActiveStatusMonitorId": 479,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 254,
  "DbiAgentId": 768,
  "DbiLastSyncronized": "2017-02-04T11:24:47.7814202+01:00",
  "DbiKey": "porro",
  "DbiLastModified": "2015-05-01T11:24:47.7814202+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 462,
  "ActiveErpLinks": 234,
  "BounceEmails": [
    "zelda.nader@buckridgeconroy.biz",
    "aglae@grimes.co.uk"
  ],
  "Domains": [
    "sit",
    "et"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "115475912",
    "SuperOffice:2": "1574873185"
  },
  "ExtraFields": {
    "ExtraFields1": "repellat",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "enim"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 635
    }
  }
}
```