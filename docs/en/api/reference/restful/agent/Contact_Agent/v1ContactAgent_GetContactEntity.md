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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=177
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
  "ContactId": 464,
  "Name": "Kling Group",
  "Department": "",
  "OrgNr": "133578",
  "Number1": "1585182",
  "Number2": "1298207",
  "UpdatedDate": "2021-05-03T03:31:25.8697058+02:00",
  "CreatedDate": "2010-03-25T03:31:25.8697058+01:00",
  "Emails": [
    {
      "Value": "fuga",
      "StrippedValue": "maiores",
      "Description": "Horizontal scalable circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "maiores",
      "Description": "Horizontal scalable circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 445,
      "Name": "Graham Group",
      "ToolTip": "Molestias et vero nesciunt nam sit.",
      "Deleted": true,
      "Rank": 613,
      "Type": "vel",
      "ColorBlock": 98,
      "IconHint": "tempora",
      "Selected": true,
      "LastChanged": "2007-10-31T03:31:25.8697058+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "iusto",
      "Hidden": false,
      "FullName": "Prof. Otho Carlo Doyle Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 872
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "sed",
      "Description": "Streamlined client-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "sed",
      "Description": "Streamlined client-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "alias",
      "StrippedValue": "debitis",
      "Description": "Reactive dedicated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "debitis",
      "Description": "Reactive dedicated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "cum",
      "Description": "Object-based coherent application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "cum",
      "Description": "Object-based coherent application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "Description": "De-engineered uniform extranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 624,
      "Mrmrs": "nesciunt",
      "Firstname": "Maurice",
      "Lastname": "Kihn",
      "MiddleName": "Predovic-Herzog",
      "Title": "dolor",
      "Description": "Distributed even-keeled hub",
      "Email": "ramon_champlin@kihn.com",
      "FullName": "Cristina Mitchell",
      "DirectPhone": "067.947.4713",
      "FormalName": "Parisian, Morissette and Franecki",
      "CountryId": 200,
      "ContactId": 814,
      "ContactName": "Friesen LLC",
      "Retired": 42,
      "Rank": 842,
      "ActiveInterests": 539,
      "ContactDepartment": "",
      "ContactCountryId": 403,
      "ContactOrgNr": "1169583",
      "FaxPhone": "078.319.9849 x5067",
      "MobilePhone": "805.698.8503",
      "ContactPhone": "672.340.2860",
      "AssociateName": "Ondricka Group",
      "AssociateId": 114,
      "UsePersonAddress": false,
      "ContactFax": "repudiandae",
      "Kanafname": "ut",
      "Kanalname": "praesentium",
      "Post1": "aliquam",
      "Post2": "laudantium",
      "Post3": "non",
      "EmailName": "friedrich@zieme.ca",
      "ContactFullName": "Jody Quigley",
      "ActiveErpLinks": 379,
      "TicketPriorityId": 662,
      "SupportLanguageId": 228,
      "SupportAssociateId": 364,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "est",
  "Xstop": true,
  "ActiveInterests": 117,
  "GroupId": 1000,
  "ActiveStatusMonitorId": 311,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 130,
  "DbiAgentId": 219,
  "DbiLastSyncronized": "2022-04-03T03:31:25.8697058+02:00",
  "DbiKey": "quia",
  "DbiLastModified": "1996-12-02T03:31:25.8697058+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 837,
  "ActiveErpLinks": 526,
  "BounceEmails": [
    "vernice@kohler.us",
    "elnora@sporer.biz"
  ],
  "Domains": [
    "quia",
    "ratione"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Quincy Macejkovic",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "quasi",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 482
    }
  }
}
```