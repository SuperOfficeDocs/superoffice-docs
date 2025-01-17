---
uid: help-no-sharepoint-documents-folders
title: Slik konfigurerer du SharePoint-mappene
description: Slik konfigurerer du SharePoint-mappene
author: Bergfrid Dias
so.date: 01.15.2024
keywords: dokument, SharePoint
so.topic: howto
language: no
---

# Slik konfigurerer du SharePoint-mappene

Oppsettet av SharePoint-området og dokumentbibliotekene er ganske fleksibelt, men vi anbefaler å opprette et eget **SharePoint-område** for SuperOffice-dokumentene dine, og **to dokumentbiblioteker**: ett for dokumenter og ett for dokumentmaler.

* I SharePoint kan du gi tillatelse på områdenivå eller på dokumentbiblioteknivå:
Dokumentbiblioteker arver automatisk tillatelsen fra områdenivået.
Dokumenter i biblioteket arver tillatelsen fra selve biblioteket.

* SharePoint-brukergrupper:
  * I SharePoint kan du opprette og vedlikeholde SharePoint-brukergrupper, noe som gir direkte tilgang til dokumentene for brukerne (som standard har du en eiergruppe, en medlemsgruppe og en besøksgruppe).
  * Du kan ikke bruke SharePoint-brukergrupper til å angi tillatelser på dokumentnivå med SuperOffice SharePoint-dokumenter. Integrasjonen må bruke Microsoft Entra domenegrupper. Så du må gi tillatelser til disse gruppene.

* Eiergruppe for SharePoint-område:
  * Når du oppretter et område i SharePoint, får du automatisk en *eiergruppe*. Medlemmer av denne eiergruppen vil ha tilgang til alle dokumenter på dette området.
  * Denne tilgangen kan ikke fjernes.
  * Derfor må du bruke en upersonlig konto for å opprette et SharePoint-område for SuperOffice-dokumenter.

![Gi de forskjellige tillatelsene på områdenivå i SharePoint, husk at dokumenteierne trenger Full kontroll -screenshot][img1]

## Relatert

* [Krav][1]
* [Slik konfigurerer du SharePoint-dokumentbibliotek][3]
* [Behandle dokumentmaler][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary-sharepoint-permissions.png
