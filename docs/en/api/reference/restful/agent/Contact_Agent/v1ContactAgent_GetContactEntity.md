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







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identifier of the ContactEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=321
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
| InitialUtmParameters | InitalUtmParameters | Initial utm parameters when creating first person, readonly field |
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
  "ContactId": 822,
  "Name": "Orn, Emard and Hamill",
  "Department": "",
  "OrgNr": "537400",
  "Number1": "1303059",
  "Number2": "1097869",
  "UpdatedDate": "2023-07-28T03:46:54.4882666+02:00",
  "CreatedDate": "2022-04-08T03:46:54.4882666+02:00",
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "omnis",
      "Description": "Balanced motivating neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "omnis",
      "Description": "Balanced motivating neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 284
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 221,
      "Name": "O'Reilly-Blick",
      "ToolTip": "Quibusdam et eos.",
      "Deleted": false,
      "Rank": 26,
      "Type": "nesciunt",
      "ColorBlock": 355,
      "IconHint": "totam",
      "Selected": true,
      "LastChanged": "2002-09-17T03:46:54.4882666+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "officiis",
      "Hidden": true,
      "FullName": "Lonie Rowe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quo",
      "StrippedValue": "velit",
      "Description": "Reduced empowering website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 285
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "velit",
      "Description": "Reduced empowering website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 285
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quis",
      "StrippedValue": "exercitationem",
      "Description": "Vision-oriented systematic emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "exercitationem",
      "Description": "Vision-oriented systematic emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "mollitia",
      "Description": "Switchable user-facing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "mollitia",
      "Description": "Switchable user-facing Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "Description": "Horizontal tangible core",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eius",
      "PersonId": 623,
      "Mrmrs": "dolores",
      "Firstname": "Vincenza",
      "Lastname": "Bartoletti",
      "MiddleName": "Parisian-Renner",
      "Title": "optio",
      "Description": "Progressive stable framework",
      "Email": "estel@mcglynngraham.com",
      "FullName": "Dr. Madisen Rath Sr.",
      "DirectPhone": "427-368-0369",
      "FormalName": "Hammes-Heathcote",
      "CountryId": 447,
      "ContactId": 100,
      "ContactName": "Morissette-Greenfelder",
      "Retired": 751,
      "Rank": 530,
      "ActiveInterests": 737,
      "ContactDepartment": "",
      "ContactCountryId": 778,
      "ContactOrgNr": "879849",
      "FaxPhone": "987.214.0921 x55676",
      "MobilePhone": "1-001-643-0755",
      "ContactPhone": "1-478-570-4506 x156",
      "AssociateName": "Hintz, Jast and Maggio",
      "AssociateId": 777,
      "UsePersonAddress": true,
      "ContactFax": "sit",
      "Kanafname": "dolores",
      "Kanalname": "quia",
      "Post1": "recusandae",
      "Post2": "occaecati",
      "Post3": "sit",
      "EmailName": "sunny.schoen@paucek.name",
      "ContactFullName": "Esmeralda Ziemann",
      "ActiveErpLinks": 57,
      "TicketPriorityId": 84,
      "SupportLanguageId": 269,
      "SupportAssociateId": 991,
      "CategoryName": "VIP Customer",
      "PersonNumber": "672413",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 783
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "error",
  "Xstop": false,
  "ActiveInterests": 625,
  "GroupId": 614,
  "ActiveStatusMonitorId": 202,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 548,
  "DbiAgentId": 623,
  "DbiLastSyncronized": "2005-08-12T03:46:54.5038911+02:00",
  "DbiKey": "incidunt",
  "DbiLastModified": "2025-05-07T03:46:54.5038911+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 199,
  "ActiveErpLinks": 353,
  "BounceEmails": [
    "hugh@russel.info",
    "bobby.ondricka@strosinconroy.com"
  ],
  "Domains": [
    "non",
    "praesentium"
  ],
  "InitialUtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Sheila Corwin"
  },
  "ExtraFields": {
    "ExtraFields1": "vero",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "exercitationem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 95
    }
  }
}
```