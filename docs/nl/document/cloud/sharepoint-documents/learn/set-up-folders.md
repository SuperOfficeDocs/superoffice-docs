---
uid: help-nl-sharepoint-documents-folders
title: De SharePoint-mappen instellen
description: De SharePoint-mappen instellen
author: Bergfrid Dias
so.date: 01.15.2024
keywords: document, Sharepoint
so.topic: howto
language: nl
---

# De SharePoint-mappen instellen

De installatie van de SharePoint-site en documentbibliotheken is vrij flexibel, maar we raden u aan een **afzonderlijke SharePoint-site** te maken voor uw SuperOffice-documenten en **twee documentbibliotheken**: een voor documenten en een voor documentsjablonen.

* In SharePoint kunt u machtigingen geven op siteniveau of op documentbibliotheekniveau:
Documentbibliotheken nemen automatisch de machtiging over van het siteniveau.
Documenten in de bibliotheek nemen de machtiging over van de bibliotheek zelf.

* SharePoint-gebruikersgroepen:
  * In SharePoint kunt u SharePoint-gebruikersgroepen maken en onderhouden, waardoor de gebruikers direct toegang hebben tot de documenten (standaard hebt u een eigenaarsgroep, een ledengroep en een bezoekersgroep).
  * U kunt geen SharePoint-gebruikersgroepen gebruiken om machtigingen op documentniveau in te stellen met SuperOffice SharePoint-documenten. De integratie moet Microsoft Entra domeingroepen gebruiken. U moet dus machtigingen verlenen aan deze groepen.

* Sharepoint-site-eigenaarsgroep:
  * Wanneer u een site maakt in SharePoint, krijgt u automatisch een *eigenaarsgroep*. Leden van deze eigenaarsgroep hebben toegang tot alle documenten op die site.
  * Deze toegang kan niet worden verwijderd.
  * Om die reden moet u een onpersoonlijk account gebruiken om uw SharePoint-site voor SuperOffice-documenten te maken.

![Verleen de verschillende machtigingen op siteniveau in SharePoint, onthoud dat de documenteigenaren volledig beheer nodig hebben -screenshot][img1]

## Aanverwant

* [Eisen][1]
* [SharePoint-documentbibliotheek configureren][3]
* [Uw documentsjablonen beheren][2]

<!-- Referenced links -->
[1]: index.md
[2]: ../../../../admin/lists/learn/add-template.md
[3]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/set-up.html

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/document/admin-preferences-documentlibrary-sharepoint-permissions.png
