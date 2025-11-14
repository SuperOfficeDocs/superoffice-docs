---
uid: help-nl-role
title: Rol
description: Rol
keywords: rol, gegevensobject, gebruikersniveau
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: /nl/admin/user-management/learn/role/index
language: nl
---

# Rollen

[!include[Requirement](../includes/note-anon-req.md)]

Via op rollen gebaseerde beveiliging in SuperOffice CRM kunt u rollen aanpassen voor verschillende niveaus binnen het bedrijf. De rollen bepalen de toegangsrechten die de verschillende gebruikers hebben in de SuperOffice CRM-modules.

Een rol beschrijft twee zaken:

* Welke **gegevensobjecten** (bedrijf, contactpersoon, project, projectleden, selectie, verkoop, belanghebbende, vervolgactiviteit, document, relatie, dashboards en target) moeten toegankelijk worden gemaakt voor de gebruikers die deze rol hebben.

    Toegankelijkheid wordt gespecificeerd via rechten: geen, lezen, maken, bijwerken en verwijderen.

* Welke **functies** (bijvoorbeeld beheerderstoegang in Instellingen en onderhoud, toestaan van bulksgewijs bijwerken, offertegoedkeuring, samenvoegbewerking, selecties exporteren en publiceren) moeten toegankelijk zijn voor gebruikers met deze rol.

## Vooraf gedefinieerde rollen

SuperOffice CRM bevat een vooraf gedefinieerde rollen. De rollen op **Gebruikersniveau 0-5** komen overeen met de gebruikersniveaus in vorige versies van SuperOffice, waar gebruikersniveau 0 een beheerder betreft. U kunt deze rollen naar wens bewerken.

| Rol | Uitleg |
|---|---|
| Gebruikersniveau 0 | Beheerder: heeft volledige toegang tot alle gegevens. Kan alle onderdelen van het systeem onderhouden. |
| Gebruikersniveau 1 | Supergebruiker: heeft volledige toegang tot alle gegevens, maar kan het systeem niet onderhouden. |
| Gebruikersniveau 2 | Heeft volledige toegang binnen de eigen gebruikersgroep maar heeft buiten deze groep beperkte toegang. |
| Gebruikersniveau 3 | Heeft volledige toegang tot eigen gegevens en kan gegevens lezen binnen de eigen gebruikersgroep maar heeft buiten deze groep beperkte toegang. |
| Gebruikersniveau 4 | Heeft volledige toegang tot eigen gegevens maar beperkte toegang binnen en buiten de eigen gebruikersgroep. |
| Gebruikersniveau 5 | Kan de meeste gegevens lezen maar heeft beperkte toegang tot de gegevens van anderen. Kan activiteiten maken. |
| Lijstbeheerder | Heeft volledige toegang tot gegevens in de SuperOffice CRM-client. Kan Instellingen en onderhoud gebruiken om lijsten te bewerken in het systeem (bijvoorbeeld documentsjablonen en categorieën). |
| Gebruikersbeheerder | Heeft volledige toegang tot gegevens. Kan Instellingen en onderhoud gebruiken om gebruikers in het systeem te maken en te bewerken. |
| Lokale gebruiker | Heeft volledige toegang tot eigen gegevens, maar geen toegang tot gegevens van gebruikers die zijn gekoppeld met andere bedrijven. |
| Externe gebruiker | Adviseur of partner met beperkte toegang tot bedrijfs- en projectgegevens. Heeft alleen toegang tot gepubliceerde gegevens. |
| Anonieme gebruiker | Anonieme gebruiker |
| Systeemgebruiker | Systeemintegratiegebruiker. Heft alle beveiligingsbeheer op. Deze rol is niet zichtbaar en kan niet worden bewerkt. |

### Gebruikers- of beheerdersrol

Wanneer u iemand nieuw toegang geeft, moet u zijn of haar rol opgeven: een gebruiker of een beheerder.

Beheerders hebben toegang tot de sectie Instellingen en onderhoud. Hier kunt u gebruikers maken, toegangsrechten aanpassen en de CRM-oplossing aanpassen aan uw behoeften. Als u wilt dat een gebruiker deze toegang heeft, geeft u hem of haar gebruikersniveau 0.

Als u niet wilt dat gebruikers toegang hebben tot instellingen en onderhoud, wijst u gebruikersniveau 1 of hoger toe, afhankelijk van de toegang die ze nodig hebben.

## Uw rollen beheren

In de sectie Rollen kunt u [bepalen welk type toegang][3] uw gebruikers hebben tot de verschillende onderdelen van SuperOffice CRM. U kunt ook elk gebruikersniveau aanpassen door de gegevensrechten en/of de verschillende [functionele rechten][6] te wijzigen.

![In de sectie Rollen kunt u bepalen welk type toegang uw gebruikers hebben tot de verschillende onderdelen van SuperOffice CRM -screenshot][img1]

U kunt bijvoorbeeld bepalen of een persoon informatie kan verwijderen, bijwerken, maken of lezen op het tabblad Gegevensrechten. Op het tabblad Functionele rechten kunt u verschillende functionele rechten voor de verschillende rollen toestaan, zoals Bulksgewijs bijwerken toestaan of Lijstbeheerder, door ze naar de rechterkolom te verplaatsen voor "Deze rol kan".

| Rol | Uitleg | Geen | Lezen | Maken | Bijwerken | Verwijderen |
|---|---|:-:|:-:|:-:|:-:|:-:|
| Geen | Geen rechten en kan niet zien | X |  |  |  |  |
| Lezen | Kan lezen |  | X |  |  |  |
| Maken | Kan maken |  | X | X |  |  |
| Bijwerken | Kan bijwerken |  | X | X | X |  |
| Verwijderen | Kan verwijderen |  | X | X | X | X |

![Functional rights -screenshot][img4]

## Gerelateerde inhoud

* [Een rol maken][1]
* [Een rol bewerken][2]
* [Gegevensrechten voor een rol instellen][3]

<!-- Referenced links -->
[1]: create-role.md
[2]: update-role.md
[3]: set-data-rights-for-role.md
[6]: functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/manage-user-levels.png
[img4]: ../../../../media/loc/en/admin/functional-rights.png
