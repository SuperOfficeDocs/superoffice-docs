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
GET /api/v1/Contact/{id}?fk=False
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 08 Oct 2020 11:06:41 G10T

{
  "ContactId": 752,
  "Name": "Torphy, Hessel and Barrows",
  "Department": "",
  "OrgNr": "1355981",
  "Number1": "584937",
  "Number2": "1198423",
  "UpdatedDate": "2020-10-08T11:06:41.707242+02:00",
  "CreatedDate": "2020-08-05T11:06:41.707242+02:00",
  "Emails": [
    {
      "Value": "laborum",
      "StrippedValue": "repellendus",
      "Description": "Customizable composite model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "repellendus",
      "Description": "Customizable composite model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 505,
      "Name": "Mertz, Hettinger and Sawayn",
      "ToolTip": "Aut laborum rerum.",
      "Deleted": true,
      "Rank": 721,
      "Type": "facere",
      "ColorBlock": 312,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2004-01-21T11:06:41.707242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "a",
      "Hidden": false,
      "FullName": "Vinnie Littel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 757
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Automated composite encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "nostrum",
      "Description": "Automated composite encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 240
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quisquam",
      "StrippedValue": "officia",
      "Description": "Fully-configurable discrete flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "officia",
      "Description": "Fully-configurable discrete flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vero",
      "StrippedValue": "natus",
      "Description": "Diverse bi-directional functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "natus",
      "Description": "Diverse bi-directional functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 518
        }
      }
    }
  ],
  "Description": "Total fresh-thinking ability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "necessitatibus",
      "PersonId": 596,
      "Mrmrs": "deserunt",
      "Firstname": "Beau",
      "Lastname": "Brown",
      "MiddleName": "Hane-Kihn",
      "Title": "et",
      "Description": "Multi-tiered encompassing internet solution",
      "Email": "shawn.reinger@gusikowski.us",
      "FullName": "Asha Domenic Hartmann MD",
      "DirectPhone": "569.568.7638 x740",
      "FormalName": "Schmitt LLC",
      "CountryId": 701,
      "ContactId": 496,
      "ContactName": "Stoltenberg, Balistreri and Feest",
      "Retired": 615,
      "Rank": 677,
      "ActiveInterests": 114,
      "ContactDepartment": "",
      "ContactCountryId": 335,
      "ContactOrgNr": "1100401",
      "FaxPhone": "(256)537-8552",
      "MobilePhone": "971-418-7920",
      "ContactPhone": "(295)485-8026 x6300",
      "AssociateName": "Hettinger-Murazik",
      "AssociateId": 505,
      "UsePersonAddress": true,
      "ContactFax": "incidunt",
      "Kanafname": "ut",
      "Kanalname": "repellat",
      "Post1": "non",
      "Post2": "ex",
      "Post3": "consequatur",
      "EmailName": "oswald.schmeler@witting.co.uk",
      "ContactFullName": "Lucinda Shanahan",
      "ActiveErpLinks": 617,
      "TicketPriorityId": 85,
      "SupportLanguageId": 924,
      "SupportAssociateId": 85,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aliquid",
  "Xstop": false,
  "ActiveInterests": 419,
  "GroupId": 311,
  "ActiveStatusMonitorId": 887,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 801,
  "DbiAgentId": 406,
  "DbiLastSyncronized": "2019-08-05T11:06:41.707242+02:00",
  "DbiKey": "sequi",
  "DbiLastModified": "1999-03-12T11:06:41.707242+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 327,
  "ActiveErpLinks": 784,
  "BounceEmails": [
    "keyon.rohan@klein.ca",
    "bennie.mueller@johnson.info"
  ],
  "Domains": [
    "optio",
    "quia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "557960985",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "assumenda",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "temporibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 743
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```