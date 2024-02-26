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
  "ContactId": 505,
  "Name": "Lubowitz Group",
  "Department": "",
  "OrgNr": "186952",
  "Number1": "1450547",
  "Number2": "930023",
  "UpdatedDate": "2002-07-03T10:30:23.3355689+02:00",
  "CreatedDate": "2009-11-05T10:30:23.3355689+01:00",
  "Emails": [
    {
      "Value": "culpa",
      "StrippedValue": "sed",
      "Description": "Re-engineered exuding Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "sed",
      "Description": "Re-engineered exuding Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 442,
      "Name": "Wintheiser Inc and Sons",
      "ToolTip": "Alias aliquid et velit consequatur laudantium voluptates est.",
      "Deleted": false,
      "Rank": 119,
      "Type": "aut",
      "ColorBlock": 170,
      "IconHint": "distinctio",
      "Selected": false,
      "LastChanged": "2004-11-29T10:30:23.3355689+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "perspiciatis",
      "Hidden": true,
      "FullName": "Dr. Llewellyn Fadel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 652
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "blanditiis",
      "StrippedValue": "vel",
      "Description": "Optional optimal firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "vel",
      "Description": "Optional optimal firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 793
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "officia",
      "StrippedValue": "est",
      "Description": "Reactive optimal capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "est",
      "Description": "Reactive optimal capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "earum",
      "Description": "Reduced grid-enabled knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "earum",
      "Description": "Reduced grid-enabled knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 507
        }
      }
    }
  ],
  "Description": "Devolved 5th generation implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloribus",
      "PersonId": 953,
      "Mrmrs": "voluptate",
      "Firstname": "Willard",
      "Lastname": "Reilly",
      "MiddleName": "Gusikowski, Hettinger and Ferry",
      "Title": "est",
      "Description": "Universal 3rd generation emulation",
      "Email": "joana_roberts@mrazwunsch.name",
      "FullName": "Ms. Modesta Makenzie Pacocha DDS",
      "DirectPhone": "(693)808-1709",
      "FormalName": "Auer-Marvin",
      "CountryId": 488,
      "ContactId": 67,
      "ContactName": "Heaney Group",
      "Retired": 80,
      "Rank": 363,
      "ActiveInterests": 81,
      "ContactDepartment": "",
      "ContactCountryId": 678,
      "ContactOrgNr": "216831",
      "FaxPhone": "(424)251-4896 x0388",
      "MobilePhone": "(365)918-9552 x75945",
      "ContactPhone": "366-073-6102",
      "AssociateName": "Lueilwitz, Walter and Kutch",
      "AssociateId": 421,
      "UsePersonAddress": true,
      "ContactFax": "iure",
      "Kanafname": "alias",
      "Kanalname": "deleniti",
      "Post1": "ullam",
      "Post2": "ea",
      "Post3": "nostrum",
      "EmailName": "joany_pacocha@littel.us",
      "ContactFullName": "Rozella Wolff",
      "ActiveErpLinks": 816,
      "TicketPriorityId": 650,
      "SupportLanguageId": 358,
      "SupportAssociateId": 448,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "modi",
  "Xstop": false,
  "ActiveInterests": 683,
  "GroupId": 300,
  "ActiveStatusMonitorId": 286,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 150,
  "DbiAgentId": 830,
  "DbiLastSyncronized": "2003-01-02T10:30:23.3511906+01:00",
  "DbiKey": "quaerat",
  "DbiLastModified": "2002-04-06T10:30:23.3511906+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 923,
  "ActiveErpLinks": 394,
  "BounceEmails": [
    "domenick.mitchell@pfannerstill.biz",
    "jairo@collier.ca"
  ],
  "Domains": [
    "eveniet",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1306788211",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quae",
    "ExtraFields2": "culpa"
  },
  "CustomFields": {
    "CustomFields1": "harum",
    "CustomFields2": "esse"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 308
    }
  }
}
```