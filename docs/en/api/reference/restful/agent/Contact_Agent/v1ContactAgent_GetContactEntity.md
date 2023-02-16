---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=721
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "ContactId": 245,
  "Name": "Williamson, Braun and Collier",
  "Department": "",
  "OrgNr": "857987",
  "Number1": "1206193",
  "Number2": "1211918",
  "UpdatedDate": "1997-08-20T14:19:02.9792785+02:00",
  "CreatedDate": "2006-06-01T14:19:02.9792785+02:00",
  "Emails": [
    {
      "Value": "ad",
      "StrippedValue": "saepe",
      "Description": "Front-line dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "saepe",
      "Description": "Front-line dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 121
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 176,
      "Name": "Champlin-Thompson",
      "ToolTip": "Iure vitae.",
      "Deleted": true,
      "Rank": 14,
      "Type": "fugiat",
      "ColorBlock": 676,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2008-06-08T14:19:02.9792785+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Charlene Coy Bogan III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "temporibus",
      "StrippedValue": "rerum",
      "Description": "Customer-focused bifurcated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "rerum",
      "Description": "Customer-focused bifurcated hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Front-line multimedia customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "sunt",
      "Description": "Front-line multimedia customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "ex",
      "Description": "Operative needs-based policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ex",
      "Description": "Operative needs-based policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "Description": "Progressive stable middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "iste",
      "PersonId": 603,
      "Mrmrs": "a",
      "Firstname": "Stephan",
      "Lastname": "Reinger",
      "MiddleName": "Rosenbaum, Stanton and Koepp",
      "Title": "et",
      "Description": "Intuitive even-keeled implementation",
      "Email": "odie_bailey@harber.ca",
      "FullName": "Mrs. Misael Bogisich",
      "DirectPhone": "941-885-9343 x055",
      "FormalName": "Rodriguez-Bernhard",
      "CountryId": 39,
      "ContactId": 587,
      "ContactName": "Lehner-Johnson",
      "Retired": 75,
      "Rank": 29,
      "ActiveInterests": 43,
      "ContactDepartment": "",
      "ContactCountryId": 703,
      "ContactOrgNr": "386698",
      "FaxPhone": "(214)295-7399 x827",
      "MobilePhone": "673.045.2622 x160",
      "ContactPhone": "795-020-5677 x989",
      "AssociateName": "Spencer Group",
      "AssociateId": 526,
      "UsePersonAddress": true,
      "ContactFax": "optio",
      "Kanafname": "cupiditate",
      "Kanalname": "eum",
      "Post1": "numquam",
      "Post2": "expedita",
      "Post3": "a",
      "EmailName": "otis@kuhlmanlindgren.ca",
      "ContactFullName": "Billy Batz",
      "ActiveErpLinks": 285,
      "TicketPriorityId": 40,
      "SupportLanguageId": 779,
      "SupportAssociateId": 732,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quos",
  "Xstop": true,
  "ActiveInterests": 686,
  "GroupId": 350,
  "ActiveStatusMonitorId": 469,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 125,
  "DbiAgentId": 499,
  "DbiLastSyncronized": "2013-08-27T14:19:02.9792785+02:00",
  "DbiKey": "optio",
  "DbiLastModified": "2017-02-28T14:19:02.9792785+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 853,
  "ActiveErpLinks": 843,
  "BounceEmails": [
    "verdie.funk@kohler.uk",
    "gillian@vonrueden.ca"
  ],
  "Domains": [
    "sed",
    "eaque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jamaal O'Keefe",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 478
    }
  }
}
```