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
  "ContactId": 592,
  "Name": "Kassulke LLC",
  "Department": "",
  "OrgNr": "1116142",
  "Number1": "641724",
  "Number2": "932704",
  "UpdatedDate": "2005-02-27T14:23:46.1418327+01:00",
  "CreatedDate": "2021-12-02T14:23:46.1418327+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Monitored zero tolerance methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "qui",
      "Description": "Monitored zero tolerance methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 808,
      "Name": "Schulist-Walker",
      "ToolTip": "Earum dolorem.",
      "Deleted": false,
      "Rank": 684,
      "Type": "quae",
      "ColorBlock": 939,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2011-08-24T14:23:46.1418327+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "maiores",
      "Hidden": false,
      "FullName": "Tara Gulgowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Switchable multi-tasking Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 7
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "dolores",
      "Description": "Switchable multi-tasking Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 7
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "iusto",
      "Description": "Mandatory background algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "iusto",
      "Description": "Mandatory background algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 218
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "consequuntur",
      "Description": "Synchronised zero tolerance protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "consequuntur",
      "Description": "Synchronised zero tolerance protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 293
        }
      }
    }
  ],
  "Description": "Horizontal secondary collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "molestiae",
      "PersonId": 646,
      "Mrmrs": "illo",
      "Firstname": "Jensen",
      "Lastname": "Walker",
      "MiddleName": "Carroll-VonRueden",
      "Title": "laboriosam",
      "Description": "Re-contextualized optimal policy",
      "Email": "genevieve.turcotte@schmidt.co.uk",
      "FullName": "Nikolas Leffler DDS",
      "DirectPhone": "862-206-3227 x1508",
      "FormalName": "Gutmann-Mueller",
      "CountryId": 490,
      "ContactId": 543,
      "ContactName": "Torphy, Orn and Hammes",
      "Retired": 337,
      "Rank": 572,
      "ActiveInterests": 438,
      "ContactDepartment": "",
      "ContactCountryId": 280,
      "ContactOrgNr": "1054797",
      "FaxPhone": "818-403-1506 x9915",
      "MobilePhone": "430-315-1259",
      "ContactPhone": "(006)859-1025",
      "AssociateName": "Carroll-Boyer",
      "AssociateId": 379,
      "UsePersonAddress": false,
      "ContactFax": "inventore",
      "Kanafname": "ratione",
      "Kanalname": "saepe",
      "Post1": "commodi",
      "Post2": "voluptas",
      "Post3": "eos",
      "EmailName": "zelma@ryanfisher.ca",
      "ContactFullName": "Mr. Rudolph Krajcik Sr.",
      "ActiveErpLinks": 317,
      "TicketPriorityId": 120,
      "SupportLanguageId": 130,
      "SupportAssociateId": 390,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 758
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 251,
  "GroupId": 565,
  "ActiveStatusMonitorId": 82,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 709,
  "DbiAgentId": 553,
  "DbiLastSyncronized": "2014-04-19T14:23:46.1418327+02:00",
  "DbiKey": "expedita",
  "DbiLastModified": "2020-01-31T14:23:46.1418327+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 570,
  "ActiveErpLinks": 381,
  "BounceEmails": [
    "ariane.fahey@friesen.com",
    "katelynn@kuvalis.uk"
  ],
  "Domains": [
    "id",
    "enim"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1589869905",
    "SuperOffice:2": "Mrs. Ed Cleora Anderson"
  },
  "ExtraFields": {
    "ExtraFields1": "omnis",
    "ExtraFields2": "molestias"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 144
    }
  }
}
```