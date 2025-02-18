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
  "ContactId": 790,
  "Name": "Cassin, Waelchi and Pollich",
  "Department": "",
  "OrgNr": "1736841",
  "Number1": "527995",
  "Number2": "1577743",
  "UpdatedDate": "2001-09-21T14:32:02.3430311+02:00",
  "CreatedDate": "2011-12-30T14:32:02.3430311+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "asperiores",
      "Description": "Quality-focused context-sensitive monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "asperiores",
      "Description": "Quality-focused context-sensitive monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 220,
      "Name": "Schamberger Inc and Sons",
      "ToolTip": "Odit aut amet quaerat.",
      "Deleted": true,
      "Rank": 226,
      "Type": "dolores",
      "ColorBlock": 602,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "2003-01-05T14:32:02.3430311+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsam",
      "StyleHint": "libero",
      "Hidden": false,
      "FullName": "Mr. Dahlia Abby Franecki III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "vero",
      "Description": "Fully-configurable fault-tolerant benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "vero",
      "Description": "Fully-configurable fault-tolerant benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 241
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "aut",
      "Description": "Re-contextualized full-range matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 735
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "aut",
      "Description": "Re-contextualized full-range matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 735
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quidem",
      "StrippedValue": "consequuntur",
      "Description": "Decentralized even-keeled methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "consequuntur",
      "Description": "Decentralized even-keeled methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    }
  ],
  "Description": "Monitored multi-state artificial intelligence",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "corporis",
      "PersonId": 107,
      "Mrmrs": "veritatis",
      "Firstname": "Providenci",
      "Lastname": "Borer",
      "MiddleName": "Murray-Graham",
      "Title": "itaque",
      "Description": "Mandatory zero administration interface",
      "Email": "earline.hessel@kilback.biz",
      "FullName": "John Gutmann MD",
      "DirectPhone": "514-686-4512 x846",
      "FormalName": "Feeney Inc and Sons",
      "CountryId": 426,
      "ContactId": 260,
      "ContactName": "Glover Inc and Sons",
      "Retired": 764,
      "Rank": 501,
      "ActiveInterests": 249,
      "ContactDepartment": "",
      "ContactCountryId": 255,
      "ContactOrgNr": "1658043",
      "FaxPhone": "1-803-883-1514 x456",
      "MobilePhone": "1-762-056-0708",
      "ContactPhone": "1-113-722-6173 x42684",
      "AssociateName": "Stiedemann, Kessler and Beatty",
      "AssociateId": 566,
      "UsePersonAddress": true,
      "ContactFax": "modi",
      "Kanafname": "animi",
      "Kanalname": "maiores",
      "Post1": "expedita",
      "Post2": "voluptate",
      "Post3": "ullam",
      "EmailName": "chad@reichelullrich.co.uk",
      "ContactFullName": "Berta Erika Feil Sr.",
      "ActiveErpLinks": 225,
      "TicketPriorityId": 955,
      "SupportLanguageId": 685,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer",
      "PersonNumber": "566265",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "odio",
  "Xstop": true,
  "ActiveInterests": 331,
  "GroupId": 847,
  "ActiveStatusMonitorId": 454,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 120,
  "DbiAgentId": 368,
  "DbiLastSyncronized": "2021-05-01T14:32:02.3430311+02:00",
  "DbiKey": "eos",
  "DbiLastModified": "2020-10-15T14:32:02.3430311+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 606,
  "ActiveErpLinks": 358,
  "BounceEmails": [
    "wilbert.kerluke@kozeykunde.co.uk",
    "keara_wuckert@walker.ca"
  ],
  "Domains": [
    "doloribus",
    "repudiandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Novella Bartell DVM",
    "SuperOffice:2": "249558012"
  },
  "ExtraFields": {
    "ExtraFields1": "modi",
    "ExtraFields2": "nesciunt"
  },
  "CustomFields": {
    "CustomFields1": "eaque",
    "CustomFields2": "laboriosam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 191
    }
  }
}
```