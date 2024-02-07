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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=735
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 844,
  "Name": "Pollich Group",
  "Department": "",
  "OrgNr": "784301",
  "Number1": "1057203",
  "Number2": "85656",
  "UpdatedDate": "2009-03-06T16:54:54.9441753+01:00",
  "CreatedDate": "2004-04-17T16:54:54.9441753+02:00",
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "non",
      "Description": "Monitored systematic toolset",
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
      "Value": "sint",
      "StrippedValue": "non",
      "Description": "Monitored systematic toolset",
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
      "Id": 118,
      "Name": "Effertz-Stiedemann",
      "ToolTip": "Ducimus et quibusdam necessitatibus.",
      "Deleted": true,
      "Rank": 343,
      "Type": "voluptatem",
      "ColorBlock": 711,
      "IconHint": "saepe",
      "Selected": false,
      "LastChanged": "1999-02-03T16:54:54.9441753+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "cupiditate",
      "Hidden": true,
      "FullName": "Prof. Samanta Hildegard Beatty IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 234
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "sit",
      "Description": "Cloned analyzing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "sit",
      "Description": "Cloned analyzing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quasi",
      "StrippedValue": "non",
      "Description": "Ameliorated solution-oriented matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "non",
      "Description": "Ameliorated solution-oriented matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugiat",
      "StrippedValue": "iusto",
      "Description": "Face to face regional leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "iusto",
      "Description": "Face to face regional leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    }
  ],
  "Description": "Configurable asynchronous product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "commodi",
      "PersonId": 447,
      "Mrmrs": "rerum",
      "Firstname": "Kaya",
      "Lastname": "Cormier",
      "MiddleName": "Kuphal-Stokes",
      "Title": "qui",
      "Description": "Versatile explicit functionalities",
      "Email": "lavinia@baumbach.info",
      "FullName": "Miss Ottis Oda Schuppe III",
      "DirectPhone": "121-218-5253 x29469",
      "FormalName": "Reichel-Zemlak",
      "CountryId": 63,
      "ContactId": 512,
      "ContactName": "Koepp LLC",
      "Retired": 379,
      "Rank": 645,
      "ActiveInterests": 556,
      "ContactDepartment": "",
      "ContactCountryId": 691,
      "ContactOrgNr": "1080316",
      "FaxPhone": "1-369-950-0168 x16304",
      "MobilePhone": "1-181-644-9583 x144",
      "ContactPhone": "(167)968-2885 x9056",
      "AssociateName": "Harber Inc and Sons",
      "AssociateId": 257,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "quo",
      "Kanalname": "iste",
      "Post1": "deleniti",
      "Post2": "soluta",
      "Post3": "rerum",
      "EmailName": "micah@beckerreilly.us",
      "ContactFullName": "Ottis Kozey",
      "ActiveErpLinks": 228,
      "TicketPriorityId": 877,
      "SupportLanguageId": 537,
      "SupportAssociateId": 41,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "distinctio",
  "Xstop": false,
  "ActiveInterests": 568,
  "GroupId": 202,
  "ActiveStatusMonitorId": 431,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 65,
  "DbiAgentId": 453,
  "DbiLastSyncronized": "2014-02-26T16:54:54.9471756+01:00",
  "DbiKey": "sit",
  "DbiLastModified": "1999-04-05T16:54:54.9471756+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 431,
  "ActiveErpLinks": 221,
  "BounceEmails": [
    "emma.padberg@wolf.biz",
    "rubie@streich.com"
  ],
  "Domains": [
    "aspernatur",
    "doloribus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "665192700",
    "SuperOffice:2": "Kennith Schaefer"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "deserunt"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "aliquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 63
    }
  }
}
```