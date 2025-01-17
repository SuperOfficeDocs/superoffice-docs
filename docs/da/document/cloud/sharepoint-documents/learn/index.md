---
uid: help-da-sharepoint-documents
title: Integration af SharePoint-dokumentbibliotek
description: Med tilføjelsesprogrammet SuperOffice til Outlook kan du arbejde ubesværet mellem din Microsoft 365- og SuperOffice CRM-løsning ved at give dig adgang til vigtige oplysninger og funktioner fra SuperOffice direkte i din mail.
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, Sharepoint
so.topic: concept
language: da
---

# Integration af SharePoint-dokumentbibliotek

SuperOffices SharePoint-dokumentbiblioteksintegration giver dig mulighed for at oprette, arkivere og dele dokumenter og e-mails ubesværet og sikkert.

Denne integration giver dig mulighed for at gemme alle dokumenter og e-mails i SharePoint Online, hvor de kan tilgås af alle i virksomheden, også dem, der ikke bruger SuperOffice CRM. Adgangen til dit SuperOffice-dokumentwebsted i SharePoint kan styres via Microsoft Entra domænegrupper (tidligere Azure Active Directory).

![Under Indstillinger i Indstillinger og vedligeholdelse finder du dokumentbiblioteket, hvor du kan konfigurere SharePoint-integrationen -screenshot][img1]

## Krav

For at konfigurere SharePoint som dit dokumentbibliotek i SuperOffice skal du bruge:

* SuperOffice Online tenant
  * [Microsoft Entra-godkendelse af SO Admin][1]
* Abonnement på Microsoft 365 for business
  * Hvis du ikke har et Microsoft 365-abonnement, skal du tilmelde dig et hos Microsoft
* Et SharePoint-dokumentbibliotek (til lagring af dokumenter)
* Hvis du vil aktivere gruppeadgang på SharePoint-dokumenter baseret på indstillingerne "Synlig for" i SuperOffice
  * Du skal have adgang til "Global Admin"-rettigheder i Microsoft 365 (for at kunne godkende SuperOffice som en app, der er tillid til, i din Microsoft 365-løsning). Enten under opsætningen eller sende et link til en person, der er.

> [!NOTE]
> Hvis du ikke har et Microsoft 365-abonnement og ikke kan tilmelde dig et, kan du bruge SuperOffice-standarddokumentbiblioteket, og hver bruger skal installere WebTools til Windows OS eller Mac OS.

## Kom godt i gang

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Tilknyttet

* [Sådan konfigureres SharePoint-mapperne][2]
* [Sådan konfigurer du SharePoint-dokumentbibliotek][4]
* [Få effektivt dokumentsamarbejde og informationsdeling med SharePoint og SuperOffice CRM][3] - blog

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
