---
uid: quickstart
title: API Quick-start
description: Quick-start for the SuperOffice APIs
author: Eivind Fasting
so.date: 10.05.2023
keywords: API, getting started, REST
so.topic: concept
so.envir: cloud, onsite
so.client: web, service
---

<!-- markdownlint-disable-file MD051 -->

# Quick-start for SuperOffice APIs

SuperOffice provides different ways to communicate with the API. This guide focuses on how you can get up and running using the REST API, which is available for all online tenants and also onsite installations (from [version 8.1][6]).

## Authentication flows

Select flow based on your application's requirements. At the most basic level, choose between the interactive and non-interactive flow:

* In the **interactive flow**, a SuperOffice user inputs their credentials.
* The **non-interactive flow** requires no user interaction.

Examine these [authentication scenarios][1] for a more detailed overview. The process for executing each authentication flow is already well-documented. This article won't delve into the specifics of obtaining the ticket.

After deciding on a flow, [register as a developer][7] and go to our **Developer Portal** to [configure your application][8].

## Language

Write your application in whatever language you want. SuperOffice doesn't recommend one specific language, and there are various examples on our [GitHub page][9].

## Packages

You can choose to use our NPM/NuGet package or your own HTTP client to directly fetch data from the REST API. We don't have a preference; it's entirely your choice based on what suits your workflow best. While our web API package streamlines API interactions, if you're more comfortable with making REST requests directly, that approach works too.

## RESTful REST or RESTful AGENT?

Our REST API documentation covers two variants of REST APIs. You have the freedom to choose which REST API suits your needs, and you're not limited to using only one; they can be used interchangeably.

The [RESTful AGENT API][2] reflects what the underlying NetServer exposes, making it familiar to SuperOffice veterans but potentially confusing for newcomers. It includes agent methods, such as `CreateDefaultAppointmentEntity`.

On the other hand, the [RESTful REST API][3] operates as a standard REST API, allowing you to POST/GET/PATCH entities based on the request body.

## I have my ticket, how do i use it?

### [Interactive](#tab/interactive)

With an interactive flow, put the ticket in the Authorization header as a **BEARER**.

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/User/currentPrincipal HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
```

### [Non-interactive](#tab/non-interactive)

With the non-interactive flow, set the Authorization header as **SOTicket**, AND include your **SO-AppToken** (your client secret):

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/User/currentPrincipal HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

***

## Example

You have your ticket and know how to set the headers - how do you proceed to actually do something towards the API?

In this example, we'll demonstrate how to use the RESTful REST API to perform two key operations. First, we'll [POST a new appointmentEntity][4] linked to a specific contact ID. Then, we'll apply a [JSON MERGE PATCH][5] to associate this appointment with a person ID. Additionally, we'll include a Description in the example to facilitate easy identification of the appointment within SuperOffice, should you need to locate it

When you POST a new appointment to SuperOffice it will automatically create a new AppointmentEntity based on the system settings, and then set any value you pass in as the body of the request. We also add a description to the example, so that it's easier to find the appointment inside SuperOffice (if you want to check that it got created):

When you send a POST request to create a new appointment in SuperOffice, it automatically generates an AppointmentEntity based on the system settings and assigns any values provided in the request body.

> [!NOTE]
> {{environment}} specifies whether you're connecting to sod, stage, or prod.
>
> {{tenant}} identifies the specific tenant you're working with (for example, Cust12345).

### [Interactive](#tab/postappointment-interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: {
  "Contact": {
    "ContactId": 2
  },
  "Description": "Hello world!"
}
```

### [Non-interactive](#tab/postappointment-non-interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: {
  "Contact": {
    "ContactId": 2
  },
  "Description": "Hello world!"
}
```

***

The returned JSON string looks something like this:

```json
{
  "Associate": {
    "AssociateId": 18,
    ...
  },
  "Contact": {
    "ContactId": 2,
    ...
  },
  "CreatedBy": {
    "AssociateId": 18,
    ...
  },
  "AppointmentId": 591,
  "Description": "Hello world!",
  "Person": null,
  ...
}
```

It also includes other information that provides insight into the available fields for appointments. In this particular case, we aim to establish a connection between the Appointment and a Person. Referring to the JSON data above, we observe that the "Person" attribute is currently set to NULL. To modify this attribute for our Appointment with AppointmentId = 591, we employ JSON PATCH.

### [Interactive](#tab/patchappointment-interactive)

```http
PATCH https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: [
  {
    "op": "replace",
    "path": "/Person",
    "value": {
      "PersonId": 1
    }
  }
]
```

### [Non-interactive](#tab/patchappointment-non-interactive)

```http
PATCH https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: [
  {
    "op": "replace",
    "path": "/Person",
    "value": {
      "PersonId": 1
    }
  }
]
```

***

The returned JSON is the complete, updated, AppointmentEntity:

```json
{
  "Associate": {
    "AssociateId": 18,
    ...
  },
  "Contact": {
    "ContactId": 2,
    ...
  },
  "CreatedBy": {
    "AssociateId": 18,
    ...
  },
  "AppointmentId": 591,
  "Description": "Hello world!",
  "Person": {
    "PersonId": 1,
    ...
  },
  ...
}
```

> [!NOTE]
> JSON MERGE PATCH does NOT update `null` properties, like "Person" in our example. We use JSON PATCH for this purpose. However, if a property already contains a value, you can still opt to use JSON MERGE PATCH.

## What is an MDOList and how do I find the correct ID?

Earlier, we didn't specify the **task** for the appointment, which defines the type of activity in SuperOffice, such as a phone call or meeting. Task is represented by `TaskListItem`, and you can access the list items using the MDO List name "task."

In our scenario, we have two options. We can either use the `/api/v1/List/Task/MDOItems` endpoint or take a more general approach by using the `/api/v1/List/MDO/{listname}` endpoint. In our case, {listname} should be "task," as per the documentation's instructions, which will specify the required MDO List.

For the sake of this example, we will opt for the general approach, which can be applied to all lists in SuperOffice.

### [Interactive](#tab/getmdolist-interactive)

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/MDOList/task HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
```

### [Non-interactive](#tab/getmdolist-non-interactive)

```http
GET https://{{environment}}.superoffice.com/{{tenant}}/api/v1/MDOList/task HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
```

***

The returned JSON looks something like this:

```json
[
  {
    "Id": 1,
    "Name": "Meeting (Internal)",
    ...
  },
  {
    "Id": 2,
    "Name": "Meeting (External)",
    ...
  },
  {
    "Id": 3,
    "Name": "Phone-Out",
    ...
  },
  {
    "Id": 4,
    "Name": "Phone-In",
    ...
  },
  {
    "Id": 5,
    "Name": "Follow-up",
    ...
  },
  {
    "Id": 6,
    "Name": "Planning",
    ...
  },
  {
    "Id": 7,
    "Name": "Visit",
    ...
  },
  {
    "Id": 8,
    "Name": "Lunch",
    ...
  },
  {
    "Id": 9,
    "Name": "Proposal",
    ...
  },
  {
    "Id": 10,
    "Name": "Service",
    ...
  },
  {
    "Id": 11,
    "Name": "Private",
    ...
  },
  {
    "Id": 12,
    "Name": "Other",
    ...
  }
]
```

From this JSON, we determine the task to assign to our appointment, such as "Meeting (External)", and proceed to update it using JSON MERGE PATCH.

### [Interactive](#tab/mergepatchappointment-interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: Bearer {{ticket}}
Accept: application/json
Body: {
  "Task": {
    "TaskListItemId": 2
  }
}
```

### [Non-Interactive](#tab/mergepatchappointment-non-interactive)

```http
POST https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591 HTTP/1.1
Authorization: SOTicket {{ticket}}
SO-AppToken: {{client_secret}}
Accept: application/json
Body: {
  "Task": {
    "TaskListItemId": 2
  }
}
```

***

## Optimization

In our example, we received an extensive dataset with surplus information that isn't essential. You can filter the payload by incorporating query parameters in your URI. Here, we're interested only in the fields AppointmentId, Contact, Description, and Person. Consequently, when PATCHing the entity, it's advisable to narrow the response down to only include these essential fields:

`https://{{environment}}.superoffice.com/{{tenant}}/api/v1/Appointment/591$select=AppointmentId,Contact,Description,Person`

While there's no strict requirement to return the entire payload, this approach aligns with best practices for more efficient data retrieval.

## Summary

This example illustrated:

* Creating a new AppointmentEntity
* Using JSON PATCH with a contactId
* Locating the MDList for the Task
* Applying JSON MERGE PATCH to the AppointmentEntity with the correct TaskListItem.

If you encounter difficulties in communicating with our API, we highly value your feedback to enhance clarity.

<!-- Referenced links -->

[1]: ../authentication/online/which-flow-to-use.md
[2]: ../reference/restful/agent/index.md
[3]: ../reference/restful/rest/index.md
[4]: ../reference/restful/rest/Appointment/v1AppointmentEntity_PostAppointmentEntity.md
[5]: ../reference/restful/rest/Appointment/v1AppointmentEntity_PatchAppointmentEntity.md
[6]: ../../onsite/install/netserver/setup-rest.md
[7]: ../../developer-portal/getting-started/get-access-to-sod.md
[8]: ../../developer-portal/create-app/index.md
[9]: https://github.com/SuperOffice
