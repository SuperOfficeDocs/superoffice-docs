---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 908,
  "Name": "Jaskolski, Stark and Bauch",
  "Department": "",
  "OrgNr": "1431784",
  "Number1": "943816",
  "Number2": "480433",
  "UpdatedDate": "1996-01-01T15:29:21.1488175+01:00",
  "CreatedDate": "2017-01-07T15:29:21.1488175+01:00",
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "odit",
      "Description": "Persevering real-time Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "odit",
      "Description": "Persevering real-time Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 762
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 107,
      "Name": "Lindgren, Greenfelder and Cummerata",
      "ToolTip": "Natus omnis nostrum nihil incidunt sed.",
      "Deleted": false,
      "Rank": 953,
      "Type": "ratione",
      "ColorBlock": 322,
      "IconHint": "placeat",
      "Selected": true,
      "LastChanged": "2016-12-13T15:29:21.1503258+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Mr. Javier Lyda Nienow",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 890
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "natus",
      "Description": "Virtual uniform adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "natus",
      "Description": "Virtual uniform adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "animi",
      "Description": "Ameliorated transitional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "animi",
      "Description": "Ameliorated transitional data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "facilis",
      "StrippedValue": "et",
      "Description": "Persevering discrete emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "et",
      "Description": "Persevering discrete emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "Description": "Versatile interactive matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ratione",
      "PersonId": 208,
      "Mrmrs": "non",
      "Firstname": "Providenci",
      "Lastname": "Bosco",
      "MiddleName": "Mertz, Zboncak and Mitchell",
      "Title": "accusantium",
      "Description": "Polarised real-time algorithm",
      "Email": "tre@leffler.info",
      "FullName": "Jaylin Kiehn",
      "DirectPhone": "1-396-708-4275",
      "FormalName": "Hackett, Sanford and Schmeler",
      "CountryId": 324,
      "ContactId": 139,
      "ContactName": "Stanton-Hickle",
      "Retired": 193,
      "Rank": 649,
      "ActiveInterests": 550,
      "ContactDepartment": "",
      "ContactCountryId": 186,
      "ContactOrgNr": "1660280",
      "FaxPhone": "290-881-9611",
      "MobilePhone": "766.260.7110 x549",
      "ContactPhone": "342.531.8948 x668",
      "AssociateName": "Barton Group",
      "AssociateId": 767,
      "UsePersonAddress": false,
      "ContactFax": "quaerat",
      "Kanafname": "sint",
      "Kanalname": "quam",
      "Post1": "voluptatibus",
      "Post2": "unde",
      "Post3": "molestias",
      "EmailName": "mazie.kshlerin@prohaskakulas.info",
      "ContactFullName": "Kurtis Gottlieb IV",
      "ActiveErpLinks": 110,
      "TicketPriorityId": 502,
      "SupportLanguageId": 52,
      "SupportAssociateId": 878,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 943
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "doloribus",
  "Xstop": false,
  "ActiveInterests": 937,
  "GroupId": 70,
  "ActiveStatusMonitorId": 630,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 140,
  "DbiAgentId": 575,
  "DbiLastSyncronized": "2016-07-15T15:29:21.1538175+02:00",
  "DbiKey": "itaque",
  "DbiLastModified": "1999-04-25T15:29:21.1538175+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 96,
  "ActiveErpLinks": 710,
  "BounceEmails": [
    "rico.leuschke@wyman.biz",
    "zoila@harrisharris.ca"
  ],
  "Domains": [
    "laboriosam",
    "laudantium"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1283824711",
    "SuperOffice:2": "Gerson Jacobs"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "odio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 777
    }
  }
}
```