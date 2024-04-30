---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 421
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 61,
  "Name": "Reichert-Emmerich",
  "Department": "",
  "OrgNr": "1119506",
  "Number1": "1298773",
  "Number2": "1121110",
  "UpdatedDate": "2016-10-12T11:44:33.0723422+02:00",
  "CreatedDate": "2022-02-23T11:44:33.0723422+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "quis",
      "Description": "Open-source tertiary benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quis",
      "Description": "Open-source tertiary benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 694,
      "Name": "McCullough, Yundt and Quitzon",
      "ToolTip": "Fuga sapiente nesciunt neque.",
      "Deleted": false,
      "Rank": 830,
      "Type": "tempora",
      "ColorBlock": 421,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "1997-12-18T11:44:33.0723422+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "expedita",
      "StyleHint": "accusantium",
      "Hidden": false,
      "FullName": "Jodie Bayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "excepturi",
      "StrippedValue": "corrupti",
      "Description": "Reverse-engineered systematic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 100
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "corrupti",
      "Description": "Reverse-engineered systematic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 100
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "tempore",
      "Description": "Self-enabling high-level parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "tempore",
      "Description": "Self-enabling high-level parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "in",
      "StrippedValue": "adipisci",
      "Description": "Multi-lateral bandwidth-monitored focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "adipisci",
      "Description": "Multi-lateral bandwidth-monitored focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "Description": "Open-architected responsive portal",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "mollitia",
      "PersonId": 211,
      "Mrmrs": "corporis",
      "Firstname": "Sylvester",
      "Lastname": "Schaden",
      "MiddleName": "West-Ernser",
      "Title": "sequi",
      "Description": "Multi-tiered hybrid ability",
      "Email": "serenity_glover@kulasrippin.name",
      "FullName": "Jevon Hickle",
      "DirectPhone": "1-702-471-3496 x7074",
      "FormalName": "Hackett-Ferry",
      "CountryId": 540,
      "ContactId": 235,
      "ContactName": "Dickens, Russel and Dooley",
      "Retired": 937,
      "Rank": 383,
      "ActiveInterests": 934,
      "ContactDepartment": "transform mission-critical applications",
      "ContactCountryId": 166,
      "ContactOrgNr": "697436",
      "FaxPhone": "365-117-8169 x43545",
      "MobilePhone": "(668)532-3471 x88884",
      "ContactPhone": "1-164-833-1659 x584",
      "AssociateName": "Schmidt, Wuckert and Zulauf",
      "AssociateId": 855,
      "UsePersonAddress": false,
      "ContactFax": "reiciendis",
      "Kanafname": "voluptas",
      "Kanalname": "repudiandae",
      "Post1": "dolor",
      "Post2": "dolorum",
      "Post3": "sint",
      "EmailName": "wade.damore@kilback.com",
      "ContactFullName": "Prof. Macey Shanahan I",
      "ActiveErpLinks": 964,
      "TicketPriorityId": 607,
      "SupportLanguageId": 172,
      "SupportAssociateId": 58,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "iste",
  "Xstop": false,
  "ActiveInterests": 202,
  "GroupId": 360,
  "ActiveStatusMonitorId": 65,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 109,
  "DbiAgentId": 315,
  "DbiLastSyncronized": "2006-09-30T11:44:33.0723422+02:00",
  "DbiKey": "veniam",
  "DbiLastModified": "2013-01-02T11:44:33.0723422+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 372,
  "ActiveErpLinks": 21,
  "BounceEmails": [
    "muhammad.runolfsdottir@zboncak.us",
    "jeramie_schinner@windler.uk"
  ],
  "Domains": [
    "quidem",
    "in"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Kenyatta Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "animi",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "totam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 956
    }
  }
}
```