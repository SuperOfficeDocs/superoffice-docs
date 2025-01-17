---
uid: help-no-sharepoint-documents
title: Integrering av SharePoint-dokumentbibliotek
description: Med SuperOffice for Outlook-tillegget kan du arbeide uanstrengt mellom Microsoft 365- og SuperOffice CRM-løsningen ved å få tilgang til viktig informasjon og funksjoner fra SuperOffice direkte i e-posten din.
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, SharePoint
so.topic: concept
language: no
---

# Integrering av SharePoint-dokumentbibliotek

SuperOffices integrering av SharePoint-dokumentbibliotek lar deg opprette, arkivere og dele dokumenter og e-postmeldinger enkelt og sikkert.

Denne integrasjonen lar deg lagre alle dokumenter og e-poster i SharePoint Online, hvor de kan nås av alle i firmaet, også de som ikke bruker SuperOffice CRM. Tilgangen til SuperOffice-dokumentområdet i SharePoint kan styres gjennom Microsoft Entra domenegrupper (tidligere Azure Active Directory).

![På Preferanser i Innstillinger og vedlikehold finner du Dokumentbiblioteket hvor du kan konfigurere SharePoint-integrasjonen -screenshot][img1]

## Krav

Hvis du vil konfigurere SharePoint som ditt dokumentbibliotek i SuperOffice, trenger du:

* SuperOffice Online-leier
  * [Microsoft Entra-autentisering av SO Admin][1]
* Abonnement på Microsoft 365 for bedrifter
  * Hvis du ikke har et Microsoft 365-abonnement, må du registrere deg for et hos Microsoft
* Et SharePoint-dokumentbibliotek (for lagring av dokumenter)
* Hvis du vil aktivere gruppetilgang til SharePoint-dokumenter basert på "Synlig for"-innstillinger i SuperOffice
  * Trenger tilgang til Globale administratorrettigheter i Microsoft 365 (for å kunne godkjenne SuperOffice som en klarert app i Microsoft 365-løsningen din). Enten under installasjonen eller sende en kobling til noen som er det.

> [!NOTE]
> Hvis du ikke har et Microsoft 365-abonnement og ikke kan registrere deg for et, kan du bruke standard SuperOffice-dokumentbibliotek, og hver bruker må installere WebTools for Windows OS eller Mac OS.

## Komme i gang

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Relatert

* [Slik konfigurerer du SharePoint-mappene][2]
* [Slik konfigurerer du SharePoint-dokumentbibliotek][4]
* [Gled deg over effektivt dokumentsamarbeid og informasjonsdeling med SharePoint og SuperOffice CRM][3]-blogg

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
