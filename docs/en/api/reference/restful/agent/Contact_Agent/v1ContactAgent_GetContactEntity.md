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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=685
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
  "ContactId": 933,
  "Name": "Ratke, Toy and Brakus",
  "Department": "",
  "OrgNr": "1063170",
  "Number1": "1428779",
  "Number2": "1040742",
  "UpdatedDate": "2010-02-28T04:22:26.2153105+01:00",
  "CreatedDate": "2002-08-05T04:22:26.2153105+02:00",
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptas",
      "Description": "Horizontal homogeneous superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "voluptas",
      "Description": "Horizontal homogeneous superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 695,
      "Name": "Langosh Group",
      "ToolTip": "Aut quas eum eveniet non.",
      "Deleted": false,
      "Rank": 679,
      "Type": "rem",
      "ColorBlock": 234,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2003-09-26T04:22:26.2153105+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "ratione",
      "Hidden": true,
      "FullName": "Moshe Hudson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 259
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "esse",
      "Description": "Fully-configurable needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "esse",
      "Description": "Fully-configurable needs-based attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "porro",
      "StrippedValue": "qui",
      "Description": "Customizable heuristic knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "qui",
      "Description": "Customizable heuristic knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 971
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "repellat",
      "Description": "Realigned responsive encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "repellat",
      "Description": "Realigned responsive encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    }
  ],
  "Description": "Multi-tiered asynchronous database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 723,
      "Mrmrs": "dolores",
      "Firstname": "Kyra",
      "Lastname": "Kemmer",
      "MiddleName": "Friesen, Gorczany and Erdman",
      "Title": "sapiente",
      "Description": "Open-source 3rd generation function",
      "Email": "flavie@herman.name",
      "FullName": "Arely Abshire",
      "DirectPhone": "(408)437-2067",
      "FormalName": "Steuber-Bayer",
      "CountryId": 174,
      "ContactId": 330,
      "ContactName": "Wehner-Heidenreich",
      "Retired": 516,
      "Rank": 10,
      "ActiveInterests": 777,
      "ContactDepartment": "",
      "ContactCountryId": 759,
      "ContactOrgNr": "1500945",
      "FaxPhone": "453-622-2548 x72674",
      "MobilePhone": "463-738-7273 x950",
      "ContactPhone": "159.042.4871",
      "AssociateName": "Tremblay, Prohaska and Beatty",
      "AssociateId": 878,
      "UsePersonAddress": false,
      "ContactFax": "debitis",
      "Kanafname": "velit",
      "Kanalname": "esse",
      "Post1": "sed",
      "Post2": "itaque",
      "Post3": "eum",
      "EmailName": "mozell_bernier@hackett.ca",
      "ContactFullName": "Lavern Yesenia Hickle I",
      "ActiveErpLinks": 410,
      "TicketPriorityId": 230,
      "SupportLanguageId": 686,
      "SupportAssociateId": 197,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 3
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 383,
  "GroupId": 266,
  "ActiveStatusMonitorId": 433,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 685,
  "DbiAgentId": 871,
  "DbiLastSyncronized": "1997-01-30T04:22:26.2153105+01:00",
  "DbiKey": "sapiente",
  "DbiLastModified": "2010-04-08T04:22:26.2153105+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 756,
  "ActiveErpLinks": 800,
  "BounceEmails": [
    "boyd_von@schimmel.us",
    "marcus.kunde@streich.us"
  ],
  "Domains": [
    "ut",
    "itaque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Dayne Rigoberto Jones",
    "SuperOffice:2": "Tyrel Kautzer"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "doloribus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 596
    }
  }
}
```