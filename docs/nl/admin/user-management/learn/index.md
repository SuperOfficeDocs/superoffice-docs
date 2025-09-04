---
uid: help-nl-users
title: Gebruikers
description: Leer hoe u nieuwe gebruikers toevoegt, hoe u de juiste gebruikersrollen en groepen toewijst en de gebruikers helpt met instellingen en WebTools.
keywords: Scherm Gebruikers, gebruiker, medewerker, onze bedrijven
author: SuperOffice Product and Engineering
date: 02.21.2023
version: 10.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/admin/user-management/learn/screen/index
---

# Gebruikers

Als beheerder bent u verantwoordelijk voor het toevoegen en beheren van uw gebruikers. In deze sectie leert u hoe u nieuwe gebruikers toevoegt, hoe u de juiste gebruikersrollen en groepen toewijst en de gebruikers helpt met instellingen en WebTools.

## Soorten gebruikers

* **Medewerkers**: SuperOffice CRM-gebruikers (in uw bedrijf)

* **Andere gebruikers**: Anonieme gebruikers en systeemgebruikers (alleen op locatie)

* **Anonieme gebruikers**: Gebruikers met beperkte rechten die worden gedefinieerd door de [rol voor anonieme gebruikers][4]. Anonieme gebruikers kunnen bijvoorbeeld worden gebruikt om toegang tot webpagina's te bieden. Zo kunnen verkoopmedewerkers relevante gegevens uit SuperOffice CRM beschikbaar stellen op een website waarvoor geen aanmelding nodig is, zodat klanten hier gemakkelijk toegang toe kunnen krijgen.

* **Systeemgebruikers**: [!include[Access rights](includes/def-system-user.md)]

    De systeemgebruiker is bedoeld voor integratie en kan worden gebruikt om processen volledige toegang te geven tot de SuperOffice-database voor het repliceren van bijvoorbeeld agenda's.

## Medewerkers

**Medewerkers** zijn gebruikers van SuperOffice in uw bedrijf (of een gerelateerd bedrijf, zoals een dochteronderneming).

Op het tabblad **Medewerkers** in het scherm Gebruikers kunt u gebruikers van het type **Medewerker** toevoegen en rollen, groepen en licenties aan hen toewijzen, of bestaande gebruikers bewerken en verwijderen.

Een persoon kan alleen worden geregistreerd als een SuperOffice CRM-gebruiker als deze is geregistreerd bij een bedrijf dat wordt weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers. Een bedrijf wordt alleen weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers als het bedrijf wordt weergegeven in de lijst met bedrijven op het tabblad **Onze bedrijven**.

> [!NOTE]
> In het scherm Gebruikers geeft u aan welke licenties kunnen worden gebruikt door de verschillende gebruikers. Als u nieuwe systeemlicenties wilt toevoegen of het aantal licenties voor een of meer modules wilt verhogen/verminderen, neemt u contact op met SuperOffice om [de licentiegegevensbij te werken][6].

## <a id="screen"></a>Scherm Gebruikers

In het scherm Gebruikers kunt u verschillende typen gebruikers toevoegen en bewerken.

![Een overzicht van het gebruikersscherm in Instellingen en onderhoud -screenshot][img3]

[**Onze bedrijven:**][2] Een persoon kan alleen worden geregistreerd als een SuperOffice CRM-gebruiker als deze is geregistreerd bij een bedrijf dat wordt weergegeven in de lijst **Bedrijf** in het scherm Gebruikers. Een bedrijf wordt alleen weergegeven in de lijst **Bedrijf** in het scherm Gebruikers als het bedrijf wordt weergegeven in de lijst met bedrijven op het tabblad **Onze bedrijven**.

> [!NOTE]
> Wijzigingen die u in het scherm Gebruikers aanbrengt, worden pas van kracht wanneer u onder aan het scherm op **Opslaan** klikt en vervolgens in het dialoogvenster dat wordt weergegeven, bevestigt dat u de wijzigingen wilt opslaan. Als u op **Annuleren** klikt, raakt u alle wijzigingen kwijt die u in het scherm hebt aangebracht sinds de laatste keer dat u de gegevens hebt opgeslagen.

### <a id="associates"></a>De medewerkerlijst

De lijst op het tabblad **Medewerkers** bestaat standaard uit de volgende kolommen:

| Kolom | Beschrijving |
|---|---|
| Gebruikers-ID | de gebruikersnaam die aan de medewerker is toegewezen. |
| Voornaam | de voornaam van de gebruiker. |
| Achternaam | De achternaam van de gebruiker. |
| Primaire groep | De primaire groep van de gebruiker. |
| Rol | De [rol][7] die aan de medewerker is toegewezen. De rol bepaalt de toegangsniveaus van de gebruiker voor gegevens in SuperOffice CRM. |
| Gebruikersplan | het gebruikersplan dat aan de gebruiker is toegewezen, |
| Bedrijf eigenaar | De naam van de organisatie waartoe de gebruiker behoort (gedefinieerd als database-eigenaar). |

> [!TIP]
> U kunt aangeven welke kolommen in de lijst moeten worden weergegeven. Klik met de rechtermuisknop op een kolomkop en selecteer de relevante kolommen in de kolomlijst. Als u de volgorde van de kolommen wilt wijzigen, klikt u op en sleept u een kolomkop.

#### Gebruikersgegevens

Aan de uiterste rechterkant van het venster wordt gedetailleerde informatie weergegeven over de gebruiker die is geselecteerd in de lijst met medewerkers.

Bovenaan staan de volledige naam, het e-mailadres en het bedrijf dat eigenaar is. Onderaan deze sectie kunt u de gebruiker in SuperOffice activeren/deactiveren met de knop **Kan aanmelden**. Klik op de knop **Taak** om toegang te krijgen tot functies zoals **Gebruiker verplaatsen** en voor de verzending van welkomst-e-mails en e-mails voor het opnieuw instellen van wachtwoorden.

Er zijn verschillende tabbladen in het gebruikersoverzicht:

* **Details** - hoofdoverzicht van gebruikersinformatie zoals **Gebruikers-ID,**, **Rol**, **Gebruikersplan**, **Primaire groep** en **Servicecategorieën**.
* **Licenties** - extra licentie-informatie zoals **Vertrouwelijke activiteiten** die de gebruiker de mogelijkheid geven om **zichtbaarvoor** in te stellen voor vervolgactiviteiten, documenten en selecties .
* **Meer** - het tabblad laat zien of er extra velden op een persoon zijn.

### <a id="other-users"></a>Andere gebruikers (lokaal)

Op het tabblad **Andere gebruikers** in het scherm Gebruikers kunt u aanmeldrechten voor en anonieme gebruikers en systeemgebruikers toevoegen.

### <a id="our-companies"></a>Onze bedrijven

Via de bedrijvenlijst op het tabblad **Onze bedrijven** in het scherm Gebruikers kunt u het volgende opgeven:

* De personen die kunnen worden gedefinieerd als gebruikers van SuperOffice CRM. Een persoon kan alleen worden geregistreerd als een SuperOffice CRM-gebruiker als deze is geregistreerd bij een bedrijf dat wordt weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers. Een bedrijf wordt alleen weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers als het bedrijf wordt weergegeven in de lijst met bedrijven op het tabblad **Onze bedrijven**.

* De bedrijven die kunnen worden gedefinieerd als eigenaar van een satelliet.

#### Kolommen in de bedrijvenlijst

| Kolom | Beschrijving |
|---|---|
| Bedrijfsnaam | Naam van bedrijf. |
| Afdeling | De naam van de afdeling in het bedrijf. |
| Postadres | De plaats waar het bedrijf is gevestigd. |
| Medewerkers | Hoeveel medewerkers zijn gemaakt voor het bedrijf. |
| Actieve satelliet | Of het bedrijf is geregistreerd als een actieve satelliet. |

### Gebruikerslicenties

Op het tabblad **Gebruikerslicenties** in het scherm Gebruikers kunt u zien hoeveel gebruikerslicenties er in gebruik zijn en welke gebruikers de verschillende licenties gebruiken.

* Klik op een licentie in de lijst **Gebruikerslicenties** voor een lijst van gebruikers die momenteel deze licentie gebruiken.

* Plaats de muisaanwijzer op een licentienaam voor gedetailleerde informatie over de licentie.

### Gebruikersgroepen

Op het tabblad **Gebruikersgroepen** in het scherm Gebruikers, kunt u een overzicht krijgen van de gebruikers en gebruikersgroepen. Klik op een groepsnaam in de lijst **Beschikbare groepen** voor een lijst van gebruikers die momenteel zijn toegewezen aan de groep.

## Gerelateerde inhoud

* [Uw rollen beheren][1]
* [Een nieuwe gebruiker toevoegen][2]
* [Gebruikersplannen voor actieve gebruikers wijzigen][3]
* [Installeer WebTools voor uw gebruikers][7]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: change-user-plan.md
[4]: role/edit-rights-for-anonymous-users.md
[6]: ../../license/learn/activate.md
[7]: ../../../../../integrations/webtools/install.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/admin/admin-users-overview.png
