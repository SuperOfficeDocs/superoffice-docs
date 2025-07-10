---
uid: help-nl-licenses
title: SuperOffice en licenties
description: SuperOffice en licenties
keywords: licentie, gebruikersplan, gemeten service, database-eigenaar, tabblad Status
author: SuperOffice Product and Engineering
date: 07.10.2025
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/admin/license/learn/screen/index
---

# SuperOffice en licenties

Toegang tot SuperOffice CRM vanuit een webclient vereist aanmeldrechten voor SuperOffice CRM en een Essential- of Premium-gebruikersplan.

## Licentie-informatie weergeven

1. Ga in Instellingen en onderhoud naar het scherm Licenties.
1. Selecteer het tabblad **SuperOffice**.
1. De lijst toont de licenties die u hebt [gekocht en geactiveerd][1]. Klik op een licentienaam om meer informatie over de licentienaam weer te geven.

[!include[Tip](includes/tip-user-licenses.md)]

## Het scherm Licenties

### Het tabblad SuperOffice

In het tabblad **SuperOffice** in het scherm Licenties kunt u de licentiegegevens voor uw versie van SuperOffice CRM en de bijbehorende modules weergeven en bijwerken.

> [!NOTE]
> Als een uitbreiding van derden is geïnstalleerd, worden hier verschillende tabbladen weergegeven.

#### Gegevens van eigenaar

Bovenaan vindt u de bedrijfsnaam (uw bedrijf/organisatie) en het serienummer. Als het een tijdsgebonden licentie betreft, zal de vervaldatum onder het serienummer worden weergegeven.

De lijst onderin toont welke licenties in gebruik zijn en hoeveel er beschikbaar zijn. Klik op een licentienaam om informatie over een licentie weer te geven.

#### Licentielijst

### Het tabblad Status

U vindt bijgewerkte informatie over het systeem in het tabblad **Status** op het scherm Licenties. Het scherm **Status** is verdeeld in de volgende hoofdonderdelen:

#### Database

Geeft informatie over de eigenaar, het serienummer en het type van de database (opgegeven tijdens de installatie). Hier wordt ook aangegeven of het gaat om een centrale database of een satellietdatabase. U kunt de volgende vervaldatum en de naam van de aangemelde gebruiker zien.

#### Diensten met datalimiet

Klik op deze knop om het dashboard voor uw diensten met een datalimiet te openen.

Diensten met een datalimiet zijn diensten die worden gefactureerd nadat u een bepaald(e) niveau/hoeveelheid hebt overschreden van de

* gebruikte opslagruimte
* E-mails verzonden via mailings
* Aanmeldingen bij het klantencentrum
* Gestarte chatsessies
* Formulierverzendingen

Beheerders kunnen precies bijhouden hoeveel van elke dienst per maand is gebruikt. Wanneer uw bedrijf de drempelwaarde overschrijdt, wordt u automatisch gefactureerd voor deze diensten op uw volgende maandfactuur. De drempelwaarde is afhankelijk van het aantal gebruikers. Hoe meer gebruikers u hebt, hoe hoger de drempelwaarde is.

#### Systeemmeldingen

In deze lijst worden de statusberichten van het systeem en toegevoegde [gebeurtenissen][3] vermeld. Meldingen van actieve imports, SAINT of vrije-tekstindexering, etc. Selecteer een melding in de lijst om een beschrijving ervan weer te geven. U kunt gebeurtenissen bijhouden die actief zijn in het systeem.

Het tabblad **Systeemgebeurtenissen** bestaat uit twee gedeelten:

* **Gebeurtenissen**.
* **Beschrijving**, waarin detailinformatie wordt vermeld over de gebeurtenis die momenteel is geselecteerd onder **Gebeurtenissen**.

Onder **Systeemmeldingen** vindt u de volgende kolommen:

| Kolom | Beschrijving |
|---|---|
| Event | Vermeldt de naam van de gebeurtenis. |
| Status | Vermeldt de status van de gebeurtenis. |
| Bericht | Vermeldt de beschrijving van de gebeurtenis. |
| Geactiveerd | Geeft aan wanneer de gebeurtenis van start is gegaan. |
| Geactiveerd door | Toont wie de gebeurtenis initieerde (Gebruikers-ID en portret). |
| Voltooid | Geeft aan wanneer de gebeurtenis naar verwachting voltooid zal zijn. |
| Type | Geeft aan of de gebeurtenis van toepassing is op het hele systeem. |

## <a id="types"></a>Licentietypes

### Systeemlicenties

| Licentie | Beschrijving |
|---|---|
| Systeem | Geeft aan tot welke systemen u toegang heeft. |
| SuperOffice Server | Vereist voor het gebruik van SuperOffice CRM. |
| Online Web Services | Vereist voor toegang tot SuperOffice CRM vanaf een webclient. |
| Sales Intelligence | Hiermee kunnen [SAINT-statusmonitors worden toegestaan][2]. |
| Exchange Synchronizer | Maakt het gebruik van SuperOffice Synchronizer mogelijk. |
| SuperOffice Expander Services | Maakt onder meer het anonieme en externe gebruikers mogelijk via SuperOffice Audience of toepassingen van derden de functionaliteit te gebruiken. |
| Customer Centre | Maakt gebruik van het Customer Centre mogelijk. |
| Verkoopoffertebeheer | Maakt het gebruik van offertes mogelijk. |

### Gebruikerslicenties (abonnementen)

Ten slotte zijn er gebruikerslicenties voor SuperOffice CRM, die worden aangeschaft voor een specifiek aantal gebruikers. Dit geldt onder andere voor de volgende producten:

* Sales-Essentials
* Sales-Premium
* Service-Essentials
* Service-Premium
* Marketing-Essentials
* Marketing-Premium

Lees meer over [SuperOffice gebruikersplannen en abonnementen][6].

### Site- en gebruikerslicenties (Windows - verouderd)

Licenties voor SuperOffice CRM voor Windows (laatste release [SuperOffice G8 8.5 R17][5]) worden aangeschaft voor een specifiek aantal gebruikers.

Lees meer over licenties in [eerdere versies van SuperOffice][7].

## Gerelateerde inhoud

* [Licenties kopen activeren][1]
* [Systeemgebeurtenissen][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../../saint/learn/index.md
[3]: ../../learn/system-events.md
[5]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[6]: ../../../../en/admin/license/user-plans.md
[7]: https://help.superoffice.com/Documentation/Help/NL/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm

<!-- Referenced images -->
