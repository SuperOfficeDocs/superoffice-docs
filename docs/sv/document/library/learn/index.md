---
uid: help-sv-document-library
title: Dokumentbibliotek
description: Introduktion till var dokument lagras (SO_Arc eller SharePoint).
keywords: dokumentbibliotek, dokument, SharePoint, SO_Arc
author: Bergfrid Dias
date: 08.02.2024
version: 10.3
topic: concept
language: sv
---

# Dokumentbibliotek

Ett **dokumentbibliotek** är där alla filer, mallar och e-postmeddelanden lagras.

Som standard är din SuperOffice-webbplats kopplad till SuperOffice-dokumentbiblioteket. Om din organisation använder SharePoint kan en administratör konfigurera SuperOffice att använda SharePoint som det föredragna dokumentbiblioteket.

![Under Inställningar i Inställningar och underhåll hittar du dokumentbiblioteket, där du kan konfigurera SharePoint-integrationen -screenshot][img1]

## SuperOffice dokumentbibliotek

Standardinställningen för SuperOffice är **SO_Arc**-dokumentbiblioteket. Alla filer, mallar och e-postmeddelanden lagras i detta bibliotek.

## SharePoint dokumentbiblioteksintegration

SuperOffice's SharePoint-dokumentbiblioteksintegration låter dig öppna, redigera och lagra dokument i Microsoft 365 SharePoint direkt från SuperOffice.

Denna integration gör att du kan lagra alla dokument och e-postmeddelanden i SharePoint Online, där de kan nås av alla i företaget, även de som inte använder SuperOffice CRM. Åtkomsten till din SuperOffice-dokumentsida i SharePoint kan styras genom Microsoft Entra-domängrupper (tidigare Azure Active Directory).

### Komma igång

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI?t=672]

<!-- markdownlint-disable-next-line MD028 -->
> [!NOTE]
> Innan du kan starta den här konfigurationen måste du ställa in webbplats- och biblioteksbehörigheter i SharePoint. Alla användare måste autentisera sig med Microsoft 365.

## Relaterade ämnen

* [Om SuperOffice molndokumentintegrationer][2]
* [Krav för SharePoint dokumentbibliotek][3]
* [Hur man ställer in Microsoft 365 SharePoint][4]
* [Konfigurera SharePoint dokumentbibliotek (5-stegs guide)][5]

<!-- Referenced links -->
[2]: https://docs.superoffice.com/en/document/cloud/overview.html
[3]: https://docs.superoffice.com/en/document/cloud/sharepoint-documents/requirements.html
[4]: https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[5]: https://docs.superoffice.com/en/document/cloud/sharepoint-documents/configure-superoffice.html

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/admin-preferences-documentlibrary.png
