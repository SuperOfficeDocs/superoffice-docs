---
uid: help-sv-webtools-install-mac
title: Install WebTools for Mac
description: If you are using macOS, you need WebTools for Mac to integrate your Microsoft 365 document applications with SuperOffice CRM.
author: Kirsti Aakerholt
date: 05.19.2023
keywords: WebTools, Mac, macOS, document, contact
content_type: howto
language: sv
---

# Install WebTools for Mac

This procedure connects Microsoft 365 and SuperOffice CRM so that you can open and edit Microsoft 365 documents directly in SuperOffice CRM on your Mac.

> [!NOTE]
> For macOS, WebTools consists of only one component: WebTools.
>
> To integrate your email, please [configure your SuperOffice Inbox][1].

## Pre-requisites

[!include[Requirements](includes/pre-req.md)]

> [!NOTE]
> SuperOffice provides integration for Microsoft 365 document applications only, and not for Apple applications Pages, Numbers and Keynote. You need the Office package to have documents integrated.

## Installera WebTools för macOS

1. Gå till huvudmenyn i SuperOffice och välj **Ladda ner** > **SuperOffice WebTools**.

1. Öppna filen i **DiskImage** och dra och släpp applikationsfilen i mappen *appar* på din Mac

    ![Dra och släpp SuperOffice-ikonen i mappen appar -screenshot][img2]

1. Du är färdig.

## Valfri inställning för standardstart

Lägg till "SuperOffice WebTools" till din användares "Startobjekt", så att det startas tillsammans med din Mac.

![Lägg till SuperOffice WebTools i dina startobjekt så att programmet startas automatiskt -screenshot][img3]

## Preferenser

Ställ in inställningarna så att de passar dina behov:

* Öppna och redigera dokument direkt från SuperOffice
  * Be att få checka in när redigeringen är klar
  * Ladda endast upp vid dokumentstängning
* Visa larm för bokningar i SuperOffice
* Kopiera aktiviteter till iCal
  * Kopiera aktiviteter var [x minutes]
  * Kopiera deltagare till adressbok
* Kopiera kontakter till adressbok
  * Kopiera kontakter var [x hours]
  * Kopiera kontakter från ett specifikt urval i SuperOffice

![Ställ in inställningarna så att de passar dina behov -screenshot][img4]

## Related content

* [Connect your email, document and diary][2]

<!-- Referenced links -->
[1]: ../../email/inbox/learn/setup.md
[2]: ../../learn/getting-started/connect-email-doc/index.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/webtools/webtools-mac-install.jpg
[img3]: ../../../media/loc/en/webtools/webtools-mac-login-items.jpg
[img4]: ../../../media/loc/en/webtools/webtools-mac-preferences.jpg
