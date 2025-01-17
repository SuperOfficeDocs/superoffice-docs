---
uid: help-sv-sharepoint-documents
title: Integration för SharePoint dokumentbibliotek
description: Med SuperOffice för Outlook-tillägget kan du enkelt arbeta med både Microsoft 365 och din SuperOffice CRM-lösning genom att du får tillgång till viktiga uppgifter och funktioner från SuperOffice direkt i din e-post.
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, Sharepoint
so.topic: concept
language: sv
---

# Integration för SharePoint dokumentbibliotek

Med SuperOffices integration för SharePoint dokumentbibliotek kan du skapa, arkivera och dela dokument och e-postmeddelanden smidigt och säkert.

Med den här integrationen kan du spara alla dokument och e-postmeddelanden i SharePoint Online, där de är åtkomliga för alla som jobbar på företaget, även för dem som inte använder SuperOffice CRM. Åtkomsten till dina SuperOffice-dokument i SharePoint kan styras genom Microsoft Entra domängrupper (tidligare Azure Active Directory).

![Under Inställningar i Inställningar och underhåll hittar du dokumentbiblioteket, där du kan konfigurera SharePoint-integrationen -screenshot][img1]

## Krav

För att konfigurera SharePoint som ditt dokumentbibliotek i SuperOffice behöver du följande:

* SuperOffice Online-licens
  * [Microsoft Entra-autentisering av SO-administratör][1]
* Prenumeration på Microsoft 365 för företag
  * Om du inte har en Microsoft 365-prenumeration måste du teckna en hos Microsoft
* Ett SharePoint dokumentbibliotek (för lagring av dokument)
* Om du vill aktivera gruppåtkomst för SharePoint-dokument baserat på "Synlig för"-inställningarna i SuperOffice
  * Du behöver "global administratörsbehörighet" i Microsoft 365 (för att kunna autentisera SuperOffice som betrodd app i din Microsoft 365-lösning). Antingen under installationen eller skicka en länk till någon som är.

> [!NOTE]
> Om du inte har en Microsoft 365-prenumeration och inte kan teckna en kan du använda SuperOffice dokumentbibliotek och varje användare måste installera WebTools för Windows OS eller Mac OS.

## Komma igång

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Relaterat

* [Så konfigurerar du SharePoint-mapparna][2]
* [Så konfigurerar du SharePoint dokumentbibliotek][4]
* [Upplev ett effektivt dokumentsamarbete och informationsutbyte med SharePoint och SuperOffice CRM][3] – blogg

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
