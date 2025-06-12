---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 523,
  "Name": "Hoeger, Toy and Monahan",
  "Department": "",
  "OrgNr": "1221726",
  "Number1": "935019",
  "Number2": "1789145",
  "UpdatedDate": "1999-02-27T17:54:02.8670938+01:00",
  "CreatedDate": "2006-08-14T17:54:02.8670938+02:00",
  "Emails": [
    {
      "Value": "minus",
      "StrippedValue": "occaecati",
      "Description": "Re-engineered fault-tolerant paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "occaecati",
      "Description": "Re-engineered fault-tolerant paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 232,
      "Name": "Kunze-Hilpert",
      "ToolTip": "Alias nihil pariatur architecto praesentium qui pariatur.",
      "Deleted": false,
      "Rank": 637,
      "Type": "reprehenderit",
      "ColorBlock": 833,
      "IconHint": "facilis",
      "Selected": false,
      "LastChanged": "2000-01-31T17:54:02.8670938+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mrs. Pedro Durward Bechtelar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "aut",
      "Description": "Universal non-volatile ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "aut",
      "Description": "Universal non-volatile ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "et",
      "Description": "Multi-tiered attitude-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "et",
      "Description": "Multi-tiered attitude-oriented throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 443
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "quaerat",
      "Description": "Up-sized encompassing help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quaerat",
      "Description": "Up-sized encompassing help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    }
  ],
  "Description": "Quality-focused responsive infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "tempore",
      "PersonId": 715,
      "Mrmrs": "numquam",
      "Firstname": "Efren",
      "Lastname": "Reinger",
      "MiddleName": "Dicki-Leffler",
      "Title": "nemo",
      "Description": "Compatible composite project",
      "Email": "layla_marquardt@zemlak.ca",
      "FullName": "Jimmie Kovacek MD",
      "DirectPhone": "1-672-039-7427",
      "FormalName": "Glover-Gutmann",
      "CountryId": 946,
      "ContactId": 858,
      "ContactName": "Mayert Inc and Sons",
      "Retired": 761,
      "Rank": 715,
      "ActiveInterests": 851,
      "ContactDepartment": "",
      "ContactCountryId": 481,
      "ContactOrgNr": "1164585",
      "FaxPhone": "1-218-096-0217",
      "MobilePhone": "1-002-652-7663 x180",
      "ContactPhone": "1-211-668-1684",
      "AssociateName": "Weber-Waelchi",
      "AssociateId": 812,
      "UsePersonAddress": false,
      "ContactFax": "reprehenderit",
      "Kanafname": "ipsam",
      "Kanalname": "iusto",
      "Post1": "qui",
      "Post2": "in",
      "Post3": "aut",
      "EmailName": "mollie@boyle.us",
      "ContactFullName": "Sofia Shields",
      "ActiveErpLinks": 909,
      "TicketPriorityId": 730,
      "SupportLanguageId": 633,
      "SupportAssociateId": 115,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1079289",
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
  "NoMailing": false,
  "Kananame": "at",
  "Xstop": false,
  "ActiveInterests": 614,
  "GroupId": 428,
  "ActiveStatusMonitorId": 752,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 244,
  "DbiAgentId": 625,
  "DbiLastSyncronized": "2018-07-06T17:54:02.8670938+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2001-04-04T17:54:02.8670938+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 108,
  "ActiveErpLinks": 833,
  "BounceEmails": [
    "diego.pouros@kuphal.info",
    "ada@orn.info"
  ],
  "Domains": [
    "nihil",
    "modi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Larue Cassin",
    "SuperOffice:2": "Kiley Osinski"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "assumenda"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 754
    }
  }
}
```