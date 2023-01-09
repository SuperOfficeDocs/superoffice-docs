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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=619
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
  "ContactId": 127,
  "Name": "Nolan, Shields and Abernathy",
  "Department": "",
  "OrgNr": "1758056",
  "Number1": "455642",
  "Number2": "890102",
  "UpdatedDate": "2016-02-12T17:37:17.1962419+01:00",
  "CreatedDate": "2022-11-24T17:37:17.1962419+01:00",
  "Emails": [
    {
      "Value": "magnam",
      "StrippedValue": "possimus",
      "Description": "Adaptive context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "possimus",
      "Description": "Adaptive context-sensitive throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 712,
      "Name": "Koch LLC",
      "ToolTip": "Eos qui perspiciatis tempora.",
      "Deleted": false,
      "Rank": 949,
      "Type": "neque",
      "ColorBlock": 779,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2013-06-27T17:37:17.1962419+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "praesentium",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Mrs. Crawford Emmy Ortiz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 539
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "qui",
      "Description": "Up-sized bandwidth-monitored core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "qui",
      "Description": "Up-sized bandwidth-monitored core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nihil",
      "StrippedValue": "hic",
      "Description": "Right-sized static parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "hic",
      "Description": "Right-sized static parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dignissimos",
      "StrippedValue": "dignissimos",
      "Description": "Pre-emptive 5th generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "dignissimos",
      "Description": "Pre-emptive 5th generation analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 82
        }
      }
    }
  ],
  "Description": "Cloned directional strategy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "velit",
      "PersonId": 724,
      "Mrmrs": "dignissimos",
      "Firstname": "Jessika",
      "Lastname": "Runte",
      "MiddleName": "Ondricka LLC",
      "Title": "tempore",
      "Description": "Down-sized multi-tasking pricing structure",
      "Email": "ladarius.zemlak@oharaprice.biz",
      "FullName": "Dr. Daren Lacy Abshire V",
      "DirectPhone": "(441)977-8680 x438",
      "FormalName": "Bernier, Waelchi and Halvorson",
      "CountryId": 351,
      "ContactId": 895,
      "ContactName": "Bahringer-Collier",
      "Retired": 149,
      "Rank": 7,
      "ActiveInterests": 129,
      "ContactDepartment": "",
      "ContactCountryId": 981,
      "ContactOrgNr": "564579",
      "FaxPhone": "902-036-6677 x614",
      "MobilePhone": "332-609-3013 x276",
      "ContactPhone": "1-468-716-2158 x43791",
      "AssociateName": "Romaguera Group",
      "AssociateId": 854,
      "UsePersonAddress": false,
      "ContactFax": "error",
      "Kanafname": "dolores",
      "Kanalname": "dignissimos",
      "Post1": "illo",
      "Post2": "officia",
      "Post3": "est",
      "EmailName": "josefina.wyman@roberts.name",
      "ContactFullName": "Marilou Mueller",
      "ActiveErpLinks": 881,
      "TicketPriorityId": 666,
      "SupportLanguageId": 689,
      "SupportAssociateId": 438,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 98
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": false,
  "ActiveInterests": 211,
  "GroupId": 91,
  "ActiveStatusMonitorId": 400,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 23,
  "DbiAgentId": 415,
  "DbiLastSyncronized": "2016-04-24T17:37:17.2002413+02:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "2007-02-23T17:37:17.2002413+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 401,
  "ActiveErpLinks": 641,
  "BounceEmails": [
    "rita.gerhold@schilleradams.co.uk",
    "mara@trantow.info"
  ],
  "Domains": [
    "libero",
    "voluptates"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Alexandre Quigley"
  },
  "ExtraFields": {
    "ExtraFields1": "commodi",
    "ExtraFields2": "mollitia"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "temporibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 638
    }
  }
}
```