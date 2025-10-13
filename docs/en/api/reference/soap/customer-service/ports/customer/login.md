---
uid: cs-soap-ports-customer-login
title: login
description: Services SOAP interface port reference - customer login
keywords: customer port, login method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/customer/login
---

# login

## Description

This method is used to log in as a customer. Almost all the other methods require that the user is logged in. The `login` method requires the username and password of the customer. If you do not have the password of the customer, you should use `loginAsCustomer()` instead.

The `login` method returns a **session key**, and this key you have to use for all the other methods to work. The session key identifies the user, and also that it is a valid session. The session key has an idle timeout of 30 minutes, but this can be adjusted in the database. You should call `logout()` when you are finished with a session.

## In parameters

| Parameter | Description |
|---|---|
| username | The SuperOffice username of the customer |
| password | The SuperOffice password of the customer |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | 0 = succsessfull login, 1 = incorrect login |
| sessionKey | The generated session key |

## Example

```csharp
customer.customerService custService = new customer.customerService();
string sessionKey;

string errorCode = custService.login("johndoe","pw",out sessionKey);
```

<!-- Referenced links -->
