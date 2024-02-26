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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=308
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 512,
  "Name": "Hilpert, Wisoky and Von",
  "Department": "",
  "OrgNr": "456571",
  "Number1": "845819",
  "Number2": "963018",
  "UpdatedDate": "2021-11-08T10:30:23.3043168+01:00",
  "CreatedDate": "2022-05-17T10:30:23.3043168+02:00",
  "Emails": [
    {
      "Value": "inventore",
      "StrippedValue": "est",
      "Description": "Persevering interactive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "est",
      "Description": "Persevering interactive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 247
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 758,
      "Name": "Ryan Inc and Sons",
      "ToolTip": "Numquam accusantium exercitationem numquam.",
      "Deleted": false,
      "Rank": 26,
      "Type": "ipsam",
      "ColorBlock": 888,
      "IconHint": "architecto",
      "Selected": false,
      "LastChanged": "2022-07-08T10:30:23.3043168+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "minima",
      "Hidden": true,
      "FullName": "Clyde Kiehn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "enim",
      "Description": "Mandatory intangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 727
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "enim",
      "Description": "Mandatory intangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 727
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Stand-alone high-level application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "molestiae",
      "Description": "Stand-alone high-level application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 488
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "nobis",
      "Description": "Universal context-sensitive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "nobis",
      "Description": "Universal context-sensitive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 209
        }
      }
    }
  ],
  "Description": "Managed dedicated task-force",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ea",
      "PersonId": 699,
      "Mrmrs": "nobis",
      "Firstname": "Bret",
      "Lastname": "Strosin",
      "MiddleName": "Osinski LLC",
      "Title": "consectetur",
      "Description": "Robust 24/7 moratorium",
      "Email": "maximo@reillypfannerstill.com",
      "FullName": "Kitty Dietrich",
      "DirectPhone": "(375)469-9494 x73752",
      "FormalName": "Harris, McKenzie and Dietrich",
      "CountryId": 329,
      "ContactId": 740,
      "ContactName": "Leannon Group",
      "Retired": 832,
      "Rank": 866,
      "ActiveInterests": 156,
      "ContactDepartment": "",
      "ContactCountryId": 225,
      "ContactOrgNr": "951285",
      "FaxPhone": "484-563-4066",
      "MobilePhone": "534-295-6658 x477",
      "ContactPhone": "411.731.4462",
      "AssociateName": "Moore Group",
      "AssociateId": 276,
      "UsePersonAddress": true,
      "ContactFax": "voluptatem",
      "Kanafname": "possimus",
      "Kanalname": "ipsum",
      "Post1": "possimus",
      "Post2": "mollitia",
      "Post3": "et",
      "EmailName": "andreane@adams.us",
      "ContactFullName": "Roderick Kilback",
      "ActiveErpLinks": 933,
      "TicketPriorityId": 236,
      "SupportLanguageId": 544,
      "SupportAssociateId": 449,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 280
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nihil",
  "Xstop": false,
  "ActiveInterests": 536,
  "GroupId": 657,
  "ActiveStatusMonitorId": 565,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 28,
  "DbiAgentId": 486,
  "DbiLastSyncronized": "2010-03-18T10:30:23.3043168+01:00",
  "DbiKey": "excepturi",
  "DbiLastModified": "1996-10-27T10:30:23.3043168+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 711,
  "ActiveErpLinks": 67,
  "BounceEmails": [
    "toney@bergebraun.biz",
    "vladimir.conroy@feest.uk"
  ],
  "Domains": [
    "ab",
    "repellat"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1184832285",
    "SuperOffice:2": "1468807370"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "commodi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 576
    }
  }
}
```