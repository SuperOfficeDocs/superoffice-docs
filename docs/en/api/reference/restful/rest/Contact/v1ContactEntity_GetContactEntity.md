---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 04 Sep 2000 03:31:32 G9T

{
  "ContactId": 511,
  "Name": "Kemmer Group",
  "Department": "",
  "OrgNr": "410708",
  "Number1": "1641084",
  "Number2": "1218612",
  "UpdatedDate": "2000-09-04T03:31:32.4258286+02:00",
  "CreatedDate": "2017-06-05T03:31:32.4258286+02:00",
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "est",
      "Description": "Expanded exuding toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "est",
      "Description": "Expanded exuding toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 714,
      "Name": "Ortiz, Lubowitz and Gutkowski",
      "ToolTip": "Molestias assumenda rerum provident iste.",
      "Deleted": true,
      "Rank": 178,
      "Type": "deserunt",
      "ColorBlock": 966,
      "IconHint": "tenetur",
      "Selected": false,
      "LastChanged": "2003-06-11T03:31:32.4258286+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Jewell Kuphal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Distributed disintermediate instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "ut",
      "Description": "Distributed disintermediate instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "architecto",
      "Description": "Reverse-engineered logistical support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "architecto",
      "Description": "Reverse-engineered logistical support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corrupti",
      "StrippedValue": "non",
      "Description": "Total national adapter",
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
      "Value": "corrupti",
      "StrippedValue": "non",
      "Description": "Total national adapter",
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
  "Description": "Public-key asynchronous implementation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "blanditiis",
      "PersonId": 588,
      "Mrmrs": "sunt",
      "Firstname": "Hailie",
      "Lastname": "Stehr",
      "MiddleName": "Zboncak, Doyle and Rodriguez",
      "Title": "amet",
      "Description": "Enhanced attitude-oriented contingency",
      "Email": "yadira@millshuel.us",
      "FullName": "Meggie Kautzer",
      "DirectPhone": "563.755.7485 x6107",
      "FormalName": "Lesch, Kuhic and Keebler",
      "CountryId": 288,
      "ContactId": 938,
      "ContactName": "Collier, Roberts and Feeney",
      "Retired": 895,
      "Rank": 545,
      "ActiveInterests": 775,
      "ContactDepartment": "",
      "ContactCountryId": 12,
      "ContactOrgNr": "552219",
      "FaxPhone": "181.444.2585 x1180",
      "MobilePhone": "330.648.8563 x81987",
      "ContactPhone": "(230)336-6278 x3745",
      "AssociateName": "Leuschke-Bashirian",
      "AssociateId": 711,
      "UsePersonAddress": false,
      "ContactFax": "ut",
      "Kanafname": "quam",
      "Kanalname": "inventore",
      "Post1": "omnis",
      "Post2": "ut",
      "Post3": "numquam",
      "EmailName": "gabrielle@lueilwitz.info",
      "ContactFullName": "Miss Lonnie Rogahn II",
      "ActiveErpLinks": 218,
      "TicketPriorityId": 607,
      "SupportLanguageId": 225,
      "SupportAssociateId": 956,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 896
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "est",
  "Xstop": false,
  "ActiveInterests": 385,
  "GroupId": 344,
  "ActiveStatusMonitorId": 44,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 256,
  "DbiAgentId": 238,
  "DbiLastSyncronized": "2019-09-19T03:31:32.4258286+02:00",
  "DbiKey": "rem",
  "DbiLastModified": "2012-08-31T03:31:32.4258286+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 944,
  "ActiveErpLinks": 432,
  "BounceEmails": [
    "ulises@wyman.biz",
    "lysanne@marvin.info"
  ],
  "Domains": [
    "ut",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Zoie Aufderhar II",
    "SuperOffice:2": "Emmalee Bernhard"
  },
  "ExtraFields": {
    "ExtraFields1": "similique",
    "ExtraFields2": "consequatur"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 709
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```