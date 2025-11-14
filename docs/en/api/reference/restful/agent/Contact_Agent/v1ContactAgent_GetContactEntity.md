---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identifier of the ContactEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=323
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 333,
  "Name": "Johnson, Witting and Bradtke",
  "Department": "facilitate transparent communities",
  "OrgNr": "1054427",
  "Number1": "803040",
  "Number2": "1352875",
  "UpdatedDate": "2013-10-27T02:30:46.9600922+01:00",
  "CreatedDate": "2016-01-31T02:30:46.9600922+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "rerum",
      "Description": "Face to face attitude-oriented alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "rerum",
      "Description": "Face to face attitude-oriented alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 687
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 59,
      "Name": "Armstrong, Douglas and Hermiston",
      "ToolTip": "Consequatur repudiandae aliquid officiis voluptate totam.",
      "Deleted": true,
      "Rank": 842,
      "Type": "similique",
      "ColorBlock": 903,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2009-04-06T02:30:46.9600922+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "voluptatum",
      "Hidden": true,
      "FullName": "Miss Amanda Kihn II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "ratione",
      "Description": "Re-engineered multimedia throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "ratione",
      "Description": "Re-engineered multimedia throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "assumenda",
      "StrippedValue": "quos",
      "Description": "Pre-emptive hybrid flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    },
    {
      "Value": "assumenda",
      "StrippedValue": "quos",
      "Description": "Pre-emptive hybrid flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 718
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "debitis",
      "StrippedValue": "consectetur",
      "Description": "Profit-focused even-keeled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "consectetur",
      "Description": "Profit-focused even-keeled policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "Description": "De-engineered systematic support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "accusamus",
      "PersonId": 467,
      "Mrmrs": "occaecati",
      "Firstname": "Tommie",
      "Lastname": "Kuhic",
      "MiddleName": "Frami Inc and Sons",
      "Title": "dolores",
      "Description": "Persevering coherent interface",
      "Email": "brenna@nader.info",
      "FullName": "Orlando Adams IV",
      "DirectPhone": "1-203-133-8290",
      "FormalName": "Pacocha-Jones",
      "CountryId": 437,
      "ContactId": 323,
      "ContactName": "Kassulke-Braun",
      "Retired": 281,
      "Rank": 31,
      "ActiveInterests": 951,
      "ContactDepartment": "",
      "ContactCountryId": 310,
      "ContactOrgNr": "587689",
      "FaxPhone": "432-326-4334",
      "MobilePhone": "564-792-0974 x11731",
      "ContactPhone": "(988)349-4169",
      "AssociateName": "Ankunding, Harber and Hermann",
      "AssociateId": 898,
      "UsePersonAddress": false,
      "ContactFax": "doloribus",
      "Kanafname": "ullam",
      "Kanalname": "aspernatur",
      "Post1": "et",
      "Post2": "laborum",
      "Post3": "saepe",
      "EmailName": "nicolas@kirlinthiel.co.uk",
      "ContactFullName": "Melyna Bosco",
      "ActiveErpLinks": 907,
      "TicketPriorityId": 302,
      "SupportLanguageId": 638,
      "SupportAssociateId": 597,
      "CategoryName": "VIP Customer",
      "PersonNumber": "977922",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 884
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "labore",
  "Xstop": false,
  "ActiveInterests": 438,
  "GroupId": 328,
  "ActiveStatusMonitorId": 473,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 289,
  "DbiAgentId": 384,
  "DbiLastSyncronized": "2005-12-17T02:30:46.9600922+01:00",
  "DbiKey": "qui",
  "DbiLastModified": "2012-06-23T02:30:46.9600922+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 677,
  "ActiveErpLinks": 776,
  "BounceEmails": [
    "zetta.wilkinson@hackett.info",
    "herminia@durgan.biz"
  ],
  "Domains": [
    "commodi",
    "vel"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Prof. Peter Tracy West"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "deserunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 827
    }
  }
}
```