---
uid: help-nl-licenses
title: SuperOffice en licenties
description: SuperOffice en licenties
keywords: licentie, gebruikersplan, gemeten service, database-eigenaar, tabblad Status
author: digitaldiina, xt1
date: 10.22.2025
version: 11.5
content_type: concept
category: Settings and maintenance
topic: licenses
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: nl
redirect_from: 
  - /nl/admin/license/learn/screen/index
  - /nl/admin/license/learn/index
  - /nl/learn/administration
---

# SuperOffice en licenties

Toegang tot SuperOffice CRM vanuit een webclient vereist aanmeldrechten voor SuperOffice CRM en een Essential- of Premium-gebruikersplan.

## Licentie-informatie weergeven

1. Ga in Instellingen en onderhoud naar het scherm Licenties.
1. Selecteer het tabblad **SuperOffice**.
1. De lijst toont de licenties die u hebt [gekocht en geactiveerd][1]. Klik op een licentienaam om meer informatie over de licentienaam weer te geven.

## Het scherm Licenties

### Het tabblad SuperOffice

In het tabblad **SuperOffice** in het scherm Licenties kunt u de licentiegegevens voor uw versie van SuperOffice CRM en de bijbehorende modules weergeven en bijwerken.

> [!NOTE]
> Als een uitbreiding van derden is geïnstalleerd, worden hier verschillende tabbladen weergegeven.

#### Gegevens van eigenaar

Bovenaan vindt u de bedrijfsnaam (uw bedrijf/organisatie) en het serienummer. Als het een tijdsgebonden licentie betreft, zal de vervaldatum onder het serienummer worden weergegeven.

#### Licentielijst

De lijst onderin toont welke licenties in gebruik zijn en hoeveel er beschikbaar zijn. Klik op een licentienaam om informatie over een licentie weer te geven.

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

### Site- en gebruikerslicenties (Windows - verouderd)

Licenties voor SuperOffice CRM voor Windows (laatste release [SuperOffice G8 8.5 R17][6]) worden aangeschaft voor een specifiek aantal gebruikers.

## <a id="dev"></a>Achter de schermen – het licentiesysteem

Het licentiesysteem heeft een eigen set databasetabellen:

* [ModuleOwner][11] – een uitgever van licenties
  * Meestal slechts één rij (SuperOffice).
  * Bevat globale vervaldatums.

* [ModuleLicense][12] – één rij per licentie
  * Er zijn meer licenties dan zichtbaar in de GUI – sommige zijn verborgen.
  * Meerdere typen: Systeem, locatie, gebruiker; aan/uit of met een vastgesteld aantal.
  * Zichtbare licenties (zoals gebruikersplannen) zijn zichtbaar in de Admin-interface. Gebruikersplannen hebben `ExtraFlags = 1`.
  * Verborgen licenties (zoals **user** login of **web** webclientlicentie) worden niet weergegeven in de GUI, maar gecontroleerd in de code om functies te activeren.

| Licentietype | ModuleLicense.Type | Beschrijving |
|---|---|---|
| **Systeemlicenties** | 1 | Bepalen welke functies beschikbaar zijn in het hele systeem. <br />Voorbeeld: De **saint**-licentie is aanwezig als Sales Intelligence is ingeschakeld. Deze licentie is verborgen (niet op de prijslijst) en wordt impliciet geactiveerd. De SuperOffice-client controleert op deze licentie om SAINT-functies in te schakelen. |
| **Locatielicenties** | 2 | Worden tegenwoordig zelden gebruikt. In het verleden gebruikt in satellietomgevingen waarbij licenties aan specifieke locaties werden toegewezen. |
| **Gebruikerslicenties** | 3 | Licenties die direct aan gebruikers worden toegewezen. Het aantal toewijzingen mag het beschikbare aantal niet overschrijden. <br />Sommige gebruikerslicenties zijn verborgen om de gebruikersinterface te vereenvoudigen. Deze worden geactiveerd via gebruikersplannen. <br />Gebruikersplannen hebben `ModuleLicense.ExtraFlags = 1` en bepalen impliciete licenties via het veld `ExtraInfo`, bijvoorbeeld:<br>`"set=user,web,chat-cal"` wijst automatisch de licenties **user**, **web** en **chat-cal** toe. |

### Gebruikerslicenties toewijzen

[LicenseAssocLink][13] – wijst een specifieke `moduleLicense` toe aan een gebruiker. Zo wordt “Jan” een gebruiker en Windows-clientgebruiker: dit levert twee records op.

Het aantal toegekende licenties mag het aantal in `moduleLicense` niet overschrijden. Een nieuw licentiepakket van SuperLicense wordt geweigerd als het maximum al is bereikt.

### Licentieondertekening

Licenties worden ondertekend met een publieke/private sleutel.

De private sleutel is strikt beveiligd. Zonder deze sleutel is het onmogelijk om een geldige keycodegenerator te maken.

Elke rij in `moduleLicense` wordt ondertekend, en alle rijen worden geverifieerd met een hash om manipulatie te voorkomen.

**Samenvatting:** Als je ze aanpast, werken ze niet meer. Alleen SoAdmin en NetServer kunnen ze bewerken.
Hackers kunnen DLL-bestanden aanpassen, maar geen geldige licentiegenerator maken voor onaangetaste code.

### Gebruikers tellen

Er zijn twee methodes:

#### 1: Licentie ophalen en aantal user/web-licenties lezen

Gebruikers hebben zowel **user** als **web** nodig om in te loggen op de SuperOffice Web-client. Dit aantal is de bovengrens – het geeft niet aan hoeveel er in gebruik zijn.

Sommige klanten hebben grote aantallen licenties omdat ze op gebruik betalen via SCIM. Tel daarom het werkelijke aantal actieve gebruikers, niet het totaal aantal beschikbare licenties.

#### 2: Licentie ophalen en aantal actieve ExtraFlags = 1-licenties optellen

Gebruikersplannen zijn waarvoor klanten betalen. Ze bevatten meerdere impliciete, verborgen licenties.

Zelfde SCIM-uitzondering: tel het aantal actieve gebruikersplannen – niet het totaal beschikbare aantal.

## Gerelateerde inhoud

* [SuperOffice gebruikersplannen en abonnementen][4]
* [Licenties kopen activeren][1]
* [Licenties in eerdere versies van SuperOffice][7]
* [Systeemgebeurtenissen][3]

<!-- Referenced links -->
[1]: activate.md
[2]: ../../saint/learn/index.md
[3]: ../onsite/add-system-event.md
[4]: user-plans.md
[6]: https://community.superoffice.com/en/product-releases/release-notes/release-details/?release=SuperOffice_8.5_-_R17
[7]: https://help.superoffice.com/Documentation/Help/EN/CRM/WebHelpAdmin/index.htm#t=chap03%2FCRM_and_licences.htm
[11]: ../../database/tables/ModuleOwner.md
[12]: ../../database/tables/ModuleLicense.md
[13]: ../../database/tables/LicenseAssocLink.md
