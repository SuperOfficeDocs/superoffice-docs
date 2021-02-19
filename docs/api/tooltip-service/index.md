---
title: tooltip_service       
description: Tooltip service
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept
---

# Tooltip service

The **Tooltip services** are used by JavaScripts on the web-client to provide detailed tooltips at run-time. Using the tooltip agent, we can retrieve a constructed tooltip for various business objects of SuperOffice for example contact and person.

The different tooltips given for each business object will be different depending on the business need of the object.

Below are some typical tooltips that will be given for each business object. Each tooltip gives us fairly detailed data for each business object.

## Tooltip for contact

```text
{contact_id=5}
Bjørge AS, BAvdeling
B-gaten 45
04
Kunde
Admin Adminson
```

## Person tooltip

```text
{person_id=9}
Admin Adminson
(ADMIN - Administrasjon)
StateZeroDatabase
Norway
qa.testbruker@superoffice.com
```

## Project tooltip

```text
{project_id=15}
Prasjaakt
DM/Kampanje - Planlagt
This is text....
{person_id=10}
[IMG:person_id=10]Arne Arnesen
(AA - Administrasjon)
StateZeroDatabase
A-veien 23
N-0245 OSLO
Norway
qa.testbruker@superoffice.com
```

## Appointment tooltip

```text
{appointment_id=59}
Yngve Yssen (Yngve'S Fisk & Vilt, YAvdeling)
Prösjöökt
Telefon ut
[SR_DONE]: [DT:08/07/2002 14:39:56.0000000]
BTelefon utBBB
([DT:03/31/2002 18:00:00.0000000] - [DT:03/31/2002 18:15:00.0000000])
Brede Bredesen  [DT:08/07/2002 12:39:47.0000000], Brede Bredesen [DT:08/07/2002 12:39:56.0000000]
```

## Sale tooltip

```text
{sale_id=5}
Yngve Yssen (Yngve'S Fisk & Vilt, YAvdeling)
Pr"sj""kt
SalgWAAW
Sendt tilbud - 100%
([DT:12/31/2002 00:00:00.0000000])
[M:15000] - [M:1399.5] = [M:13600.5]
Arne Arnesen  [DT:07/31/2002 11:13:58.0000000]
```
