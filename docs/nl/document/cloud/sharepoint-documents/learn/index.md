---
uid: help-nl-sharepoint-documents
title: Integratie SharePoint-documentbibliotheek
description: "Met de invoegtoepassing SuperOffice voor Outlook kunt u moeiteloos werken tussen uw Microsoft 365- en SuperOffice CRM-oplossing, door u rechtstreeks in uw e-mail toegang te geven tot belangrijke informatie en functies van SuperOffice."
author: Bergfrid Dias
so.date: 01.15.2024
keywords: document, Sharepoint
so.topic: concept
language: nl
---

# Integratie SharePoint-documentbibliotheek

Met de SharePoint-documentbibliotheekintegratie van SuperOffice kunt u moeiteloos en veilig documenten en e-mails maken, archiveren en delen.

Met deze integratie kunt u alle documenten en e-mails opslaan in SharePoint Online, waar ze toegankelijk zijn voor iedereen in het bedrijf, zelfs voor degenen die geen SuperOffice CRM gebruiken. De toegang tot uw SuperOffice-documentsite in SharePoint kan worden beheerd via Microsoft Entra domeingroepen (voorheen Azure Active Directory).

![Bij Voorkeuren in Instellingen en onderhoud vindt u de documentbibliotheek waar u de SharePoint-integratie kunt instellen -screenshot][img1]

## Eisen

Als u SharePoint wilt instellen als uw documentbibliotheek in SuperOffice, hebt u het volgende nodig:

* SuperOffice Online tenant
  * [Microsoft Entra-verificatie van SO-beheerder][1]
* Abonnement op Microsoft 365 voor Bedrijven
  * Als u geen Microsoft 365-abonnement hebt, moet u zich aanmelden voor een Microsoft bij Microsoft
* Een SharePoint-documentbibliotheek (voor het opslaan van documenten)
* Als u groepstoegang op SharePoint-documenten wilt inschakelen op basis van de instellingen "Zichtbaar voor" in SuperOffice
  * Toegang nodig hebben tot 'Global Admin'-rechten in Microsoft 365 (om SuperOffice te kunnen verifiëren als een vertrouwde app in uw Microsoft 365-oplossing). Tijdens de installatie of stuur een koppeling naar iemand die dat wel is.

> [!NOTE]
> Als u geen Microsoft 365-abonnement hebt en u zich er niet voor kunt aanmelden, kunt u de standaard SuperOffice-documentbibliotheek gebruiken en moet elke gebruiker WebTools voor Windows OS of Mac OS installeren.

## Aan de slag

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/8mIo3Yac2QI]

## Aanverwant

* [De SharePoint-mappen instellen][2]
* [SharePoint-documentbibliotheek configureren][4]
* [Geniet van effectieve documentsamenwerking en het delen van informatie met SharePoint en SuperOffice CRM][3] -blog

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html
[2]: set-up-folders.md
[3]: https://community.superoffice.com/en/learning/best-practices-tips/standard-crm/sharepoint-integration/
[4]: ../../../../admin/preferences/learn/document-library/change-to-sharepoint.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary.png
