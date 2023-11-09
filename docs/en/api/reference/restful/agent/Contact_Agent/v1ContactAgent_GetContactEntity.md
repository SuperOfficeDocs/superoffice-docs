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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=395
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
  "ContactId": 890,
  "Name": "Kuhlman-Tromp",
  "Department": "",
  "OrgNr": "179840",
  "Number1": "802765",
  "Number2": "728526",
  "UpdatedDate": "2016-06-13T11:06:34.1433524+02:00",
  "CreatedDate": "2001-12-26T11:06:34.1433524+01:00",
  "Emails": [
    {
      "Value": "explicabo",
      "StrippedValue": "debitis",
      "Description": "Adaptive client-driven secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "debitis",
      "Description": "Adaptive client-driven secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 728,
      "Name": "Gibson, Dicki and Schiller",
      "ToolTip": "Non quia quia omnis cum atque explicabo.",
      "Deleted": true,
      "Rank": 775,
      "Type": "ratione",
      "ColorBlock": 793,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2021-02-08T11:06:34.1433524+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "quo",
      "Hidden": false,
      "FullName": "Liana Dion Buckridge I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "User-friendly transitional synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "User-friendly transitional synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 23
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "expedita",
      "Description": "Open-source dynamic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "expedita",
      "Description": "Open-source dynamic throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 481
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Innovative needs-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Innovative needs-based data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 198
        }
      }
    }
  ],
  "Description": "Optimized assymetric solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "autem",
      "PersonId": 296,
      "Mrmrs": "fuga",
      "Firstname": "Adele",
      "Lastname": "Lubowitz",
      "MiddleName": "Medhurst-Dickens",
      "Title": "quae",
      "Description": "Fully-configurable transitional core",
      "Email": "kenton.dubuque@jastcarroll.us",
      "FullName": "Aletha Koepp",
      "DirectPhone": "1-229-862-8870 x386",
      "FormalName": "Walker, Mayert and Gusikowski",
      "CountryId": 828,
      "ContactId": 807,
      "ContactName": "Hirthe, Gerhold and Wilkinson",
      "Retired": 615,
      "Rank": 195,
      "ActiveInterests": 532,
      "ContactDepartment": "",
      "ContactCountryId": 797,
      "ContactOrgNr": "921092",
      "FaxPhone": "276.034.8592 x00587",
      "MobilePhone": "1-374-584-6349 x49882",
      "ContactPhone": "1-400-461-5679",
      "AssociateName": "Gleichner, Crona and Smitham",
      "AssociateId": 632,
      "UsePersonAddress": false,
      "ContactFax": "aut",
      "Kanafname": "mollitia",
      "Kanalname": "rerum",
      "Post1": "repellat",
      "Post2": "repellendus",
      "Post3": "qui",
      "EmailName": "heidi.harris@terrydickinson.co.uk",
      "ContactFullName": "Frieda Lehner DDS",
      "ActiveErpLinks": 629,
      "TicketPriorityId": 424,
      "SupportLanguageId": 157,
      "SupportAssociateId": 822,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 72
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "odio",
  "Xstop": false,
  "ActiveInterests": 629,
  "GroupId": 565,
  "ActiveStatusMonitorId": 583,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 498,
  "DbiAgentId": 990,
  "DbiLastSyncronized": "2013-07-03T11:06:34.1433524+02:00",
  "DbiKey": "quo",
  "DbiLastModified": "2021-10-03T11:06:34.1433524+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 871,
  "ActiveErpLinks": 222,
  "BounceEmails": [
    "maurine@metzfisher.name",
    "keely@lindohara.name"
  ],
  "Domains": [
    "perferendis",
    "consectetur"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ms. Easton O'Kon Jr."
  },
  "ExtraFields": {
    "ExtraFields1": "provident",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "quas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 972
    }
  }
}
```