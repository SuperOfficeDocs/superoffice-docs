---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
content_type: reference
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.
NsApiSlow threshold: 2000 ms.






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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 784,
  "Name": "Sipes Inc and Sons",
  "Department": "",
  "OrgNr": "882056",
  "Number1": "1105262",
  "Number2": "620820",
  "UpdatedDate": "2023-11-19T03:40:46.421242+01:00",
  "CreatedDate": "2013-08-30T03:40:46.421242+02:00",
  "Emails": [
    {
      "Value": "atque",
      "StrippedValue": "reprehenderit",
      "Description": "Advanced empowering definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "reprehenderit",
      "Description": "Advanced empowering definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 743,
      "Name": "Schmeler, Gerhold and Hickle",
      "ToolTip": "Illo ratione nihil et minus nam.",
      "Deleted": false,
      "Rank": 248,
      "Type": "amet",
      "ColorBlock": 321,
      "IconHint": "nam",
      "Selected": false,
      "LastChanged": "2004-01-21T03:40:46.421242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Brandt Auer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 524
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "error",
      "Description": "Monitored grid-enabled migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "error",
      "Description": "Monitored grid-enabled migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "eos",
      "Description": "Networked even-keeled installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "eos",
      "Description": "Networked even-keeled installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 742
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptate",
      "StrippedValue": "et",
      "Description": "Devolved zero administration projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "et",
      "Description": "Devolved zero administration projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "Description": "Devolved value-added matrices",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ratione",
      "PersonId": 260,
      "Mrmrs": "asperiores",
      "Firstname": "Lenna",
      "Lastname": "Volkman",
      "MiddleName": "Champlin-Cassin",
      "Title": "dignissimos",
      "Description": "Centralized content-based knowledge user",
      "Email": "neva@weimannrussel.uk",
      "FullName": "Percy Considine",
      "DirectPhone": "752.090.9898 x87085",
      "FormalName": "Leannon, Schaefer and Becker",
      "CountryId": 591,
      "ContactId": 674,
      "ContactName": "Goldner Inc and Sons",
      "Retired": 806,
      "Rank": 645,
      "ActiveInterests": 249,
      "ContactDepartment": "",
      "ContactCountryId": 621,
      "ContactOrgNr": "515960",
      "FaxPhone": "(665)240-7365 x259",
      "MobilePhone": "704.530.3297",
      "ContactPhone": "100-214-3671 x7061",
      "AssociateName": "Haley Inc and Sons",
      "AssociateId": 635,
      "UsePersonAddress": false,
      "ContactFax": "sit",
      "Kanafname": "mollitia",
      "Kanalname": "natus",
      "Post1": "possimus",
      "Post2": "rerum",
      "Post3": "tempora",
      "EmailName": "milan@hartmann.co.uk",
      "ContactFullName": "Barton Carter",
      "ActiveErpLinks": 155,
      "TicketPriorityId": 385,
      "SupportLanguageId": 892,
      "SupportAssociateId": 966,
      "CategoryName": "VIP Customer",
      "PersonNumber": "401544",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 865
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "atque",
  "Xstop": false,
  "ActiveInterests": 403,
  "GroupId": 134,
  "ActiveStatusMonitorId": 185,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 600,
  "DbiAgentId": 60,
  "DbiLastSyncronized": "1998-09-17T03:40:46.436868+02:00",
  "DbiKey": "sequi",
  "DbiLastModified": "2011-10-19T03:40:46.436868+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 704,
  "ActiveErpLinks": 85,
  "BounceEmails": [
    "dalton_funk@schulistconn.ca",
    "maud.wyman@purdy.com"
  ],
  "Domains": [
    "repellendus",
    "beatae"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorum",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 997
    }
  }
}
```