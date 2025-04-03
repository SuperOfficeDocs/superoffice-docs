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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=718
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 892,
  "Name": "Renner, Jenkins and Murphy",
  "Department": "",
  "OrgNr": "465622",
  "Number1": "1182330",
  "Number2": "791122",
  "UpdatedDate": "2011-01-27T14:28:21.6179108+01:00",
  "CreatedDate": "2018-06-17T14:28:21.6179108+02:00",
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "voluptas",
      "Description": "Down-sized even-keeled approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "voluptas",
      "Description": "Down-sized even-keeled approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 766
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 896,
      "Name": "Huels LLC",
      "ToolTip": "Dignissimos qui quisquam fugiat tempora commodi.",
      "Deleted": false,
      "Rank": 425,
      "Type": "aut",
      "ColorBlock": 543,
      "IconHint": "placeat",
      "Selected": true,
      "LastChanged": "2001-04-04T14:28:21.6179108+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Dr. Kara Schiller PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aperiam",
      "StrippedValue": "nesciunt",
      "Description": "Expanded transitional system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    },
    {
      "Value": "aperiam",
      "StrippedValue": "nesciunt",
      "Description": "Expanded transitional system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "sed",
      "Description": "Vision-oriented asynchronous middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "sed",
      "Description": "Vision-oriented asynchronous middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "temporibus",
      "StrippedValue": "et",
      "Description": "Switchable 24 hour structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "et",
      "Description": "Switchable 24 hour structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    }
  ],
  "Description": "Optional heuristic moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsa",
      "PersonId": 89,
      "Mrmrs": "et",
      "Firstname": "Domenic",
      "Lastname": "Toy",
      "MiddleName": "Kerluke, Hartmann and Kertzmann",
      "Title": "nihil",
      "Description": "Enhanced high-level implementation",
      "Email": "ebony@heidenreich.com",
      "FullName": "Millie Koss",
      "DirectPhone": "(061)125-1773 x519",
      "FormalName": "Kassulke LLC",
      "CountryId": 964,
      "ContactId": 503,
      "ContactName": "Krajcik-Towne",
      "Retired": 410,
      "Rank": 562,
      "ActiveInterests": 950,
      "ContactDepartment": "",
      "ContactCountryId": 359,
      "ContactOrgNr": "731973",
      "FaxPhone": "(977)986-9853 x83553",
      "MobilePhone": "642.546.9098 x74382",
      "ContactPhone": "957-515-5263",
      "AssociateName": "Crooks-Abernathy",
      "AssociateId": 660,
      "UsePersonAddress": true,
      "ContactFax": "error",
      "Kanafname": "et",
      "Kanalname": "tenetur",
      "Post1": "eligendi",
      "Post2": "molestiae",
      "Post3": "illum",
      "EmailName": "frederic.wolf@schinner.ca",
      "ContactFullName": "Prof. Hailey Blanda",
      "ActiveErpLinks": 104,
      "TicketPriorityId": 244,
      "SupportLanguageId": 600,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer",
      "PersonNumber": "504341",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "praesentium",
  "Xstop": false,
  "ActiveInterests": 362,
  "GroupId": 834,
  "ActiveStatusMonitorId": 941,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 529,
  "DbiAgentId": 14,
  "DbiLastSyncronized": "2010-08-19T14:28:21.6179108+02:00",
  "DbiKey": "optio",
  "DbiLastModified": "2005-06-30T14:28:21.6179108+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 980,
  "ActiveErpLinks": 579,
  "BounceEmails": [
    "vernie.hackett@spencer.uk",
    "leo@rath.biz"
  ],
  "Domains": [
    "est",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Jarrod Shanel Dare V",
    "SuperOffice:2": "Pietro Bailey Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "quibusdam",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "dolores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 136
    }
  }
}
```