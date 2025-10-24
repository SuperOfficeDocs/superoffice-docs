---
uid: help-nl-our-companies-manage
title: Onze bedrijven beheren
description: Bedrijven toevoegen aan en verwijderen van het tabblad Onze bedrijven
keywords: gebruiker, onze bedrijven
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
platform: web
index: true
redirect_from: 
  - /nl/admin/user-management/learn/move-user
  - /nl/admin/user-management/learn/our-companies
language: nl
---

# Onze bedrijven beheren

Je kunt "Onze bedrijven" beheren en gebruikers tussen hen verplaatsen via het scherm Gebruikers onder Instellingen en onderhoud.

## Bedrijf toevoegen in het tabblad Onze bedrijven

Voorwaarden: Als u een bedrijf wilt toevoegen aan het tabblad **Onze bedrijven**, moet dit eerst worden geregistreerd als bedrijf in SuperOffice.

1. Selecteer het tabblad **Onze bedrijven**.

1. Klik op de knop **Toevoegen** onder de lijst met bedrijven.

1. Het scherm Zoeken wordt geopend. Als in dit dialoogvenster als zoekcriteria zijn ingevoerd die u niet wilt gebruiken, kunt u deze verwijderen door op de knop **Alles deactiveren** te klikken of door de vinkjes uit de selectievakjes voor de betreffende criteria te verwijderen.

1. Zoek naar een bedrijf. Zie details hieronder.

1. Zodra u het gewenste bedrijf hebt geselecteerd en op **OK** hebt geklikt, wordt het bedrijf in de lijst weergegeven.

## Bedrijf verwijderen in het tabblad Onze bedrijven

1. Controleer of aan de criteria is voldaan:

    * Er mogen geen medewerkers zijn geregistreerd bij het bedrijf. Het aantal medewerkers wordt weergegeven in de kolom **Medewerkers** in de bedrijvenlijst. Als u een bedrijf wilt verwijderen, moet u eerst [de geregistreerde medewerkers verwijderen][2].
    * Het bedrijf mag niet geregistreerd staan als een actieve satelliet. Controleer of het bedrijf wordt vermeld in de kolom **Actieve satelliet** in de bedrijvenlijst.

1. Selecteer het tabblad **Onze bedrijven**.

1. Selecteer het betreffende bedrijf in de lijst.

1. Klik op de knop **Verwijderen** onder de lijst met bedrijven. Het bedrijf wordt verwijderd uit de lijst.

> [!NOTE]
> U kunt het bedrijf niet verwijderen als het is geregistreerd als eigenaar van een database. Als u de eigenaar van een database hebt geselecteerd, kunt u de knop **Verwijderen** niet gebruiken.

## <a id="move"></a>Gebruiker van het ene bedrijf naar het andere verplaatsen

U kunt een gebruiker van het ene bedrijf naar het andere verplaatsen als uw organisatie bestaat uit meerdere bedrijven die zijn geregistreerd op het tabblad Onze bedrijven. Als een gebruiker is ingesteld onder het verkeerde bedrijf, of als een gebruiker van positie /functie binnen uw organisatie is veranderd, kan deze worden verplaatst, inclusief de bijbehorende activiteiten en verkopen.

1. Ga naar het tabblad **Medewerkers** en selecteer de gewenste gebruiker in de lijst.

1. Klik op **Taak** en selecteer **Gebruiker verplaatsen**.

1. Selecteer in het dialoogvenster **Verplaatsen naar** en kies het bedrijf waarnaar de persoon moet worden verplaatst.

1. Selecteer een van de volgende opties bij **Actie op alle bestaande activiteiten en verkopen**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > Als u de resultaten wilt bekijken voordat u de actie bevestigt, klikt u op <i class="ph ph-info" aria-label="Resultaten weergeven"></i>.

1. Klik op **Verplaatsen**. De gebruiker wordt verplaatst naar het opgegeven bedrijf.

## Hoe zoek ik naar een bedrijf?

1. In de keuzelijst rechts van het veld waarop u wilt zoeken, kunt u opgeven of u wilt zoeken naar een bedrijf dat **Begint met**, **Bevat** of **Gelijk is aan** de zoekcriteria die u invoert.

2. U kunt meerdere zoekcriteria opgeven, bijvoorbeeld naam, code, telefoonnummer of e-mailadres. Als u meerdere zoekcriteria opgeeft, wordt gezocht naar bedrijven die aan alle criteria voldoen.

3. Wanneer u alle benodigde criteria hebt opgegeven, klikt u op de knop **Zoeken**.

4. De zoekbewerking kan de volgende resultaten opleveren:

    * **Eén treffer**: het bedrijf dat aan de zoekcriteria voldoet, wordt in de lijst weergegeven.

    * **Twee of meer treffers**: In het scherm Zoeken wordt een lijst met overeenkomsten weergegeven. Hier kunt u het gewenste bedrijf in de lijst selecteren en op **OK** klikken om naar dat bedrijf te gaan.

    * **Geen treffers**: er wordt een bericht weergegeven met de mededeling dat er geen records zijn gevonden die overeenkomen met de door u opgegeven zoekcriteria. Klik op **OK** en zoek opnieuw, met andere criteria.

### <a id="criteria"></a> De zoekcriteria

Onderstaande velden komen overeen met de velden op de bedrijfskaart.

* Naam: Typ de bedrijfsnaam, of het begin ervan.
* Nummer: Typ de bedrijfsnaam, of het begin ervan.
* Code: Typ de code, of het begin ervan.
* BTW-nr.: Typ het BTW-nr., of het begin ervan.
* Voornaam: Typ de voornaam van een contactpersoon bij het bedrijf, of een deel ervan.
* Achternaam: Typ de achternaam van een contactpersoon bij het bedrijf, of een deel ervan.
* Telefoon: Typ het telefoonnummer voor het bedrijf, of een deel ervan.
* E-mailadres: Typ het e-mailadres voor het bedrijf, of een deel ervan.
* Zoekcriteria: Hier kunt u nadere [zoekcriteria][1] opgeven.

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
