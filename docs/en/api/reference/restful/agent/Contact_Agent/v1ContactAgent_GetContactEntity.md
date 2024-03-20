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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=677
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
  "ContactId": 424,
  "Name": "Hauck-Reinger",
  "Department": "",
  "OrgNr": "1193822",
  "Number1": "65256",
  "Number2": "964771",
  "UpdatedDate": "2002-09-24T12:19:44.8985943+02:00",
  "CreatedDate": "2016-11-15T12:19:44.8985943+01:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Streamlined value-added data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "consequatur",
      "Description": "Streamlined value-added data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 690,
      "Name": "Mills LLC",
      "ToolTip": "Vel fugit ut repellat.",
      "Deleted": true,
      "Rank": 247,
      "Type": "voluptatum",
      "ColorBlock": 60,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2003-02-24T12:19:44.8985943+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "maiores",
      "Hidden": false,
      "FullName": "Aric Kris PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 511
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "amet",
      "StrippedValue": "modi",
      "Description": "Fully-configurable holistic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "modi",
      "Description": "Fully-configurable holistic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "voluptatem",
      "Description": "Persevering radical matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "voluptatem",
      "Description": "Persevering radical matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 222
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "officiis",
      "Description": "Multi-tiered global array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "officiis",
      "Description": "Multi-tiered global array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 558
        }
      }
    }
  ],
  "Description": "Diverse bottom-line website",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "cumque",
      "PersonId": 857,
      "Mrmrs": "qui",
      "Firstname": "Eduardo",
      "Lastname": "Steuber",
      "MiddleName": "Heaney-Heaney",
      "Title": "inventore",
      "Description": "Balanced mobile Graphic Interface",
      "Email": "greyson@leuschke.uk",
      "FullName": "Jerod Ortiz",
      "DirectPhone": "093-646-9900 x6130",
      "FormalName": "Nienow Inc and Sons",
      "CountryId": 252,
      "ContactId": 584,
      "ContactName": "Fadel LLC",
      "Retired": 238,
      "Rank": 359,
      "ActiveInterests": 566,
      "ContactDepartment": "",
      "ContactCountryId": 909,
      "ContactOrgNr": "1066247",
      "FaxPhone": "448-418-0618",
      "MobilePhone": "1-636-200-3972 x574",
      "ContactPhone": "(857)962-4395",
      "AssociateName": "Parker Group",
      "AssociateId": 912,
      "UsePersonAddress": true,
      "ContactFax": "nihil",
      "Kanafname": "quia",
      "Kanalname": "rerum",
      "Post1": "hic",
      "Post2": "nihil",
      "Post3": "distinctio",
      "EmailName": "marquis@rogahnroberts.ca",
      "ContactFullName": "Scot Waelchi",
      "ActiveErpLinks": 736,
      "TicketPriorityId": 436,
      "SupportLanguageId": 918,
      "SupportAssociateId": 821,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 27
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "cumque",
  "Xstop": true,
  "ActiveInterests": 226,
  "GroupId": 840,
  "ActiveStatusMonitorId": 17,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 217,
  "DbiAgentId": 416,
  "DbiLastSyncronized": "2008-11-26T12:19:44.8985943+01:00",
  "DbiKey": "dolorem",
  "DbiLastModified": "2013-07-23T12:19:44.8985943+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 797,
  "ActiveErpLinks": 248,
  "BounceEmails": [
    "lorena@lowe.name",
    "khalid@streich.name"
  ],
  "Domains": [
    "exercitationem",
    "voluptatibus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Aidan Justus Wintheiser",
    "SuperOffice:2": "Milford Wiegand"
  },
  "ExtraFields": {
    "ExtraFields1": "quisquam",
    "ExtraFields2": "corporis"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "a"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 68
    }
  }
}
```