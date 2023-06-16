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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
  "ContactId": 578
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 925,
  "Name": "Reinger, Predovic and Gusikowski",
  "Department": "",
  "OrgNr": "641422",
  "Number1": "1723570",
  "Number2": "1353746",
  "UpdatedDate": "2016-10-02T16:00:40.3831405+02:00",
  "CreatedDate": "2008-04-11T16:00:40.3831405+02:00",
  "Emails": [
    {
      "Value": "adipisci",
      "StrippedValue": "vitae",
      "Description": "Horizontal modular success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "vitae",
      "Description": "Horizontal modular success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 872,
      "Name": "Vandervort, O'Keefe and Gerlach",
      "ToolTip": "Dolor enim totam mollitia ducimus quis aut quidem.",
      "Deleted": false,
      "Rank": 351,
      "Type": "quis",
      "ColorBlock": 299,
      "IconHint": "optio",
      "Selected": false,
      "LastChanged": "2012-11-30T16:00:40.398769+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sunt",
      "StyleHint": "odit",
      "Hidden": true,
      "FullName": "Johnny Fadel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "commodi",
      "StrippedValue": "iste",
      "Description": "Synchronised cohesive leverage",
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
      "Value": "commodi",
      "StrippedValue": "iste",
      "Description": "Synchronised cohesive leverage",
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
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "tempore",
      "Description": "Centralized web-enabled open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "tempore",
      "Description": "Centralized web-enabled open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 468
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quisquam",
      "StrippedValue": "autem",
      "Description": "Decentralized explicit open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "autem",
      "Description": "Decentralized explicit open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    }
  ],
  "Description": "Organized system-worthy protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eveniet",
      "PersonId": 612,
      "Mrmrs": "omnis",
      "Firstname": "Micah",
      "Lastname": "Graham",
      "MiddleName": "Lubowitz LLC",
      "Title": "quia",
      "Description": "Sharable regional application",
      "Email": "loma_toy@christiansen.info",
      "FullName": "Jody Jast MD",
      "DirectPhone": "480.706.0647 x4567",
      "FormalName": "Fay-Wilkinson",
      "CountryId": 713,
      "ContactId": 614,
      "ContactName": "Funk LLC",
      "Retired": 494,
      "Rank": 205,
      "ActiveInterests": 136,
      "ContactDepartment": "",
      "ContactCountryId": 881,
      "ContactOrgNr": "1072765",
      "FaxPhone": "162.495.1328",
      "MobilePhone": "991-074-8452 x9696",
      "ContactPhone": "(507)743-2799",
      "AssociateName": "Kohler Group",
      "AssociateId": 119,
      "UsePersonAddress": false,
      "ContactFax": "libero",
      "Kanafname": "debitis",
      "Kanalname": "sint",
      "Post1": "magni",
      "Post2": "aliquam",
      "Post3": "ut",
      "EmailName": "vicente_schowalter@roob.us",
      "ContactFullName": "Shawn Telly Feeney V",
      "ActiveErpLinks": 653,
      "TicketPriorityId": 813,
      "SupportLanguageId": 495,
      "SupportAssociateId": 867,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aspernatur",
  "Xstop": false,
  "ActiveInterests": 147,
  "GroupId": 321,
  "ActiveStatusMonitorId": 609,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 241,
  "DbiAgentId": 134,
  "DbiLastSyncronized": "2012-03-14T16:00:40.398769+01:00",
  "DbiKey": "accusantium",
  "DbiLastModified": "2019-07-06T16:00:40.398769+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 266,
  "ActiveErpLinks": 371,
  "BounceEmails": [
    "kiel_littel@heller.info",
    "lee_bednar@rempel.co.uk"
  ],
  "Domains": [
    "quod",
    "laboriosam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1000568026",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "id",
    "ExtraFields2": "adipisci"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 171
    }
  }
}
```