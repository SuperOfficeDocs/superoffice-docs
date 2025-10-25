---
uid: help-nl-users
title: Gebruikers
description: Leer hoe u nieuwe gebruikers toevoegt, hoe u de juiste gebruikersrollen en groepen toewijst en de gebruikers helpt met instellingen en WebTools.
keywords: Scherm Gebruikers, gebruiker, medewerker, onze bedrijven, zichtbaarheid, beschikbaar
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: 
  - /nl/admin/user-management/learn/index
  - /nl/admin/user-management/learn/screen/index
  - /nl/admin/user-management/learn/visibility
  - /nl/admin/user-management/learn/associates-filter-group
language: nl
---

# Gebruikers

Als beheerder bent u verantwoordelijk voor het toevoegen en beheren van uw gebruikers.

SuperOffice CRM gebruikt een op rollen en groepen gebaseerd toegangsrechtensysteem. Dit betekent dat **elke SuperOffice‑gebruiker een rol heeft en behoort tot een primaire groep** (dit zijn verplichte instellingen).

Het volgende diagram toont een model van hoe het toegangsrechtensysteem werkt in SuperOffice CRM.

![Diagram dat het toegangsrechtensysteem toont][img1]

Een [rol][6] heeft een set gegevens‑ en [functionele rechten][7], en een groepsinstelling verleent toegang tot gegevensobjecten, diverse SuperOffice‑lijsten, en helpt bij het efficiënter instellen van systeemvoorkeuren.

Het systeem stelt je in staat om toegang te configureren tot bedrijven, personen, projecten, projectleden, selecties, verkopen, stakeholders (van verkoop), vervolgactiviteiten, documenten (inclusief e‑mails en mailings), relaties (persoon en bedrijf), en dashboards. Al deze verschillende soorten records worden **gegevensobjecten** genoemd.

Elk gegevensobject behoort toe aan een gebruiker die onder u valt zelf (a), gebruikers in uw primaire groep (b), gebruikers die tot uw andere groepen behoren (c), andere medewerkers waarmee u geen groepsverbinding heeft (d), externe gebruikers (e), en anonieme gebruikers (f).

![De rollen‑medewerkers‑scherm, tab Gegevensrechten ‑screenshot][img2]

Het eigenaarschap van verschillende gegevensobjecten wordt ingesteld in verschillende velden. Bijvoorbeeld in de bedrijfskaart geeft het veld **Onze Contactpersoon** de eigenaar van het record aan. Voor opvolgingen is dat het veld **Owner**, in het project **Verantwoordelijke**, enzovoort.

## <a id="visible"></a>Zichtbaarheid

Of u bepaalde documenten, verkopen, vervolgactiviteiten en selecties kunt weergeven, is niet uitsluitend afhankelijk van de rol die aan u is toegewezen. Het kan ook zo zijn dat de relevante informatie voor u niet beschikbaar is. De dialoogvensters voor documenten en vervolgactiviteiten en de schermen Verkoop en Selectie bevatten de keuzelijst **Zichtbaar voor**. U kunt bijvoorbeeld in het scherm Verkoop ervoor kiezen om de verkoop voor iedereen zichtbaar te maken of alleen voor de primaire groep waartoe de eigenaar behoort, of alleen zichtbaar voor de eigenaar.

Hiervoor is de licentie **Vertrouwelijke activiteiten** vereist.

Als u deze licentie wilt instellen, zoekt u de gewenste gebruiker, klikt u op het tabblad **Licenties** en klikt u vervolgens op het selectievakje voor **Vertrouwelijke activiteiten**.

## Soorten gebruikers

* **Medewerkers**: SuperOffice CRM-gebruikers (in uw bedrijf)

* **Andere gebruikers**: Anonieme gebruikers en systeemgebruikers (alleen op locatie)

* **Anonieme gebruikers**: Gebruikers met beperkte rechten die worden gedefinieerd door de [rol voor anonieme gebruikers][4]. Anonieme gebruikers kunnen bijvoorbeeld worden gebruikt om toegang tot webpagina's te bieden. Zo kunnen verkoopmedewerkers relevante gegevens uit SuperOffice CRM beschikbaar stellen op een website waarvoor geen aanmelding nodig is, zodat klanten hier gemakkelijk toegang toe kunnen krijgen.

* **Systeemgebruikers**: De systeemgebruiker is bedoeld voor integratie en kan worden gebruikt om processen volledige toegang te geven tot de SuperOffice-database voor het repliceren van bijvoorbeeld agenda's.

## Medewerkers

**Medewerkers** zijn gebruikers van SuperOffice in uw bedrijf (of een gerelateerd bedrijf, zoals een dochteronderneming).

Op het tabblad **Medewerkers** in het scherm Gebruikers kunt u gebruikers van het type **Medewerker** toevoegen en rollen, groepen en licenties aan hen toewijzen, of bestaande gebruikers bewerken en verwijderen.

Een persoon kan alleen worden geregistreerd als een SuperOffice CRM-gebruiker als deze is geregistreerd bij een bedrijf dat wordt weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers. Een bedrijf wordt alleen weergegeven in de keuzelijst **Bedrijf** in het scherm Gebruikers als het bedrijf wordt weergegeven in de lijst met bedrijven op het tabblad **Onze bedrijven**.

> [!NOTE]
> In het scherm Gebruikers geeft u aan welke licenties kunnen worden gebruikt door de verschillende gebruikers. Als u nieuwe systeemlicenties wilt toevoegen of het aantal licenties voor een of meer modules wilt verhogen/verminderen, neemt u contact op met SuperOffice om [de licentiegegevensbij te werken][16].

## Gebruikersgroepen

Een **groep** wordt toegewezen aan de gebruiker en geeft toegang tot gegevensobjecten (4 in het vorige diagram). Een gebruiker moet één **primaire groep** hebben en kan meerdere **andere groepen** hebben.

![Groepslidmaatschap‑diagram][img5]

In dit voorbeeld heeft gebruiker A Marketing als andere groep en gebruiker B heeft Marketing als primaire groep. In dit geval, als gebruiker A gegevens wil zien die door gebruiker B zijn gemaakt, moet de rol van gebruiker A de rechten "Lezen" hebben naast alle gegevensobjecten in de kolom *Andere groep*. Dit komt doordat Marketing‑groep de andere groep is voor gebruiker A en hen verbindt met de records die gebruiker B aanmaakt.

Een groep kan ook toegang geven tot lijstitems (5 in het diagram) in SuperOffice CRM. Dit is alleen van toepassing als u de instelling **Groepering en filtering** (a) op uw lijsten gebruikt. Als deze instelling niet geactiveerd is, hebben alle gebruikers toegang tot alle lijsten in SuperOffice CRM. Groepering en filtering zijn bijzonder handig wanneer veel gebruikers met verschillende verantwoordelijkheden toegang hebben tot het systeem. Op deze manier kunt u voorkomen dat bepaalde gebruikers toegang krijgen tot informatie die zij niet zouden moeten zien.

![Groepering en filtering op basis van gebruikersgroep voor document‑sjabloonlijst –screenshot][img6]

Bijvoorbeeld, als u een specifiek lijstitem alleen zichtbaar wilt maken voor bepaalde gebruikers, moet u naar de lijst gaan die deze items bevat (a), het item selecteren (b) en in het vak "Zichtbaar voor gebruikersgroepen", een vinkje zetten bij de gebruikersgroepen die het lijstitem moeten zien (c).

![Selecteer voorkeur‑niveau groep voor opvolging –screenshot][img7]

Het organiseren van uw gebruikers in groepen is ook handig als u de SuperOffice‑instellingen wilt personaliseren, wat wij [voorkeuren][15] (6) noemen. Elke voorkeur kan ingesteld worden voor één gebruiker, gebruikersgroep of voor het hele systeem.

![Voorkeuren voor Verkoop‑groep –screenshot][img8]

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
| Rol | De [rol][6] die aan de medewerker is toegewezen. De rol bepaalt de toegangsniveaus van de gebruiker voor gegevens in SuperOffice CRM. |
| Gebruikersplan | het gebruikersplan dat aan de gebruiker is toegewezen, |
| Bedrijf eigenaar | De naam van de organisatie waartoe de gebruiker behoort (gedefinieerd als database-eigenaar). |

> [!TIP]
> U kunt aangeven welke kolommen in de lijst moeten worden weergegeven. Klik met de rechtermuisknop op een kolomkop en selecteer de relevante kolommen in de kolomlijst. Als u de volgorde van de kolommen wilt wijzigen, klikt u op en sleept u een kolomkop.

* **Zoeken naar gebruikers:** Gebruik deze dynamische zoekfunctie om specifieke gebruikers snel te vinden op naam of gebruikers-ID, of om alle gebruikers te vinden die behoren tot specifieke rollen, groepen of gebruikersplannen. Voer gewoon tekst in het zoekveld in om de lijst bij te werken met overeenkomende gebruikers.

* **Alleen gebruikers weergeven die zich kunnen aanmelden:** Selecteer deze optie om alleen gebruikers weer te geven die actief zijn (die niet zijn gedeactiveerd).

#### De lijst filteren <i class="ph ph-funnel" aria-hidden="true"></i>

U kunt de lijst met gebruikers filteren op een van de kolomkoppen.

> [!NOTE]
> Klik met de rechtermuisknop op een kolom om extra kolommen toe te voegen waarop u wilt filteren.

1. Ga naar het tabblad **Medewerkers**.
1. Klik met de rechtermuisknop op een kolomkop of klik op <i class="ph ph-gear" aria-label="Gear"></i> in de rechterbovenhoek van de lijst.
1. Selecteer **Filter inschakelen**.
1. Klik op **OK.** Aan elke kolomkop worden filterknoppen toegevoegd.
1. Klik op <i class="ph ph-funnel" aria-label="Filter icon"></i> in de kolom die u wilt filteren.
1. Selecteer de relevante waarden in de lijst. Gebruik de zoekfunctie als de lijst lang is.
1. Klik op **Filter**.
1. Herhaal de stappen 5-7 om op extra kolommen te filteren.

#### De lijst groeperen

U kunt de lijst met gebruikers groeperen op rol, gebruikersplan, primaire groep en soortgelijke. Bovendien kunt u op meerdere niveaus groeperen.

> [!NOTE]
> Klik met de rechtermuisknop op een kolom om extra kolommen toe te voegen waarop u wilt groeperen (zie ook [Weergaven aanpassen][14]).

1. Ga naar het tabblad **Medewerkers**.
1. Klik met de rechtermuisknop op een kolomkop of klik op <i class="ph ph-gear" aria-label="Gear"></i> in de rechterbovenhoek van de lijst.
1. Selecteer **Groepering inschakelen**.
1. Klik op **OK**.
1. Klik op de kolomkop voor de waarde waarmee wilt groeperen en sleep deze naar het gebied boven de kolommen ("Sleep een kolomkop en ..."). De lijst is gegroepeerd op deze waarde.
1. Als u wilt groeperen op extra waarden, klikt u op een andere kolomkop en sleept u deze naar hetzelfde gebied.
1. Klik en sleep de groepswaarden om de volgorde van de groeperingsniveaus te wijzigen.
1. Klik op een groepswaarde om de sorteervolgorde te wijzigen.

> [!NOTE]
> Als u naar een ander tabblad navigeert, wordt de groepering opnieuw ingesteld.

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

* [Uw rollen beheren][6]
* [Een nieuwe gebruiker toevoegen][2]
* [Gebruikersgroepen maken][3]
* [Gebruikersplannen voor actieve gebruikers wijzigen][17]

<!-- Referenced links -->
[2]: add-associate.md
[3]: user-groups.md
[4]: onsite/other-users.md#rights
[6]: role/index.md
[7]: role/functional-rights.md
[14]: ../adjusting-views.md
[15]: ../preferences/index.md
[16]: ../license/activate.md
[17]: ../license/change-user-plan.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../media/loc/en/admin/user-access-level.png
[img3]: ../../../media/loc/en/admin/admin-users-overview.png
[img5]: ../../../media/loc/en/admin/groups.png
[img6]: ../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../media/loc/en/admin/sales-group.png
