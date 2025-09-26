---
uid: help-nl-form-field-options
title: Veldopties
description: Veldopties
keywords: formulier, veld, veldoptie, formulierelement
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: reference
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Veldopties

Dit is een overzicht van speciale opties in sommige beschikbare velden.

## SuperOffice-elementen

* **Vervangen:** Selecteer deze optie om een bestaande waarde in SuperOffice te vervangen door de waarde in het formulier. Dit is relevant voor land, functie en Dhr./Mw.

* **Persoon - toestemming**

  * **Doel:** Selecteer waarom de persoon zijn toestemming moet geven.

  * **Koppeling naar privacyverklaring weergeven:** Selecteer deze optie om de koppeling naar de privacyverklaring op te nemen.

    [Privacy-instellingen][4] voor de GDPR zijn gedefinieerd in Instellingen en onderhoud.

* **Persoon - Abonnement:** Selecteer de [abonnementen][3] die zichtbaar moeten zijn in het formulier.

* **Bedrijfsnaam: Gebruik bestaand bedrijf indien gevonden.**

  * Als deze optie AAN staat: Als een persoon een formulier verzendt waarin de bedrijfsnaam overeenkomt met een bedrijf in SuperOffice, wordt de persoon automatisch toegevoegd aan het bedrijf als een nieuwe persoon.

  * Als deze optie UIT staat: Zowel de persoon als het bedrijf worden toegevoegd aan SuperOffice.

  > [!NOTE]
  > Normaalgesproken staat deze instelling UIT om te voorkomen dat mensen "willekeurig" worden toegevoegd aan bedrijven waartoe ze niet behoren.

## Formulierelementen

* **Tekstveld:** Een eenvoudig tekstveld van 1 rij.

* **Tekstgebied:** Een groot tekstveld van meerdere rijen.

* **Keuzerondjes:** Een selectieveld waarin u een of meerdere waarden kunt selecteren.

  * **Verticaal:** Geef de waarden horizontaal of verticaal weer.

  * **Gegevens:** Hier geeft u de waarden op voor elk keuzerondje. Geef een waarde op in dit veld en klik op **+**. Herhaal dit om meer waarden toe te voegen.

* **Selectievakje:** Een selectieveld waarin u meerdere waarden kunt selecteren.

  * **Verticaal:** Geef de waarden horizontaal of verticaal weer.

  * **Gegevens:** Hier geeft u de waarden op voor elk selectievakje. Geef een waarde op in dit veld en klik op **+**. Herhaal dit om meer waarden toe te voegen.

* **Vervolgkeuze:** Een selectieveld waarin u een waarde kunt selecteren uit een lijst.

  * **Gegevens:** Hier geeft u de lijstwaarden op. Geef een waarde op in dit veld en klik op **+**. Herhaal dit om meer waarden toe te voegen.

* **Verborgen:** Een veld dat niet zichtbaar is in het gepubliceerde formulier. In het veld **Standaardwaarde** kunt u een code, een projectnaam/nummer of andere informatie opgeven die moet worden gekoppeld aan dit formulier.

* **Datum:** Een datumveld.

* **Bestand uploaden:** Een veld om bestanden te uploaden.

  * **Meerdere bestanden toestaan:** Selecteer deze optie om het uploaden van meerdere bestanden toe te staan.

  * **Maximale bestandsgrootte (kb):** Geef een bestandsgrootte in kilobytes op om te voorkomen dat er grote bestanden worden geüpload. Laat dit veld leeg om alle bestandsgrootten toe te staan.

  * **Toegestane bestandstypen:** Geef de bestandstypen op die kunnen worden geüpload. Gebruik het formaat *jpg,gif,png,bmp* (gescheiden door komma's, geen spatie). Laat dit veld leeg om alle bestandstypen toe te staan.

* **Waardering:** Een veld waarin klanten bijvoorbeeld de service die ze hebben ontvangen kunnen beoordelen, met behulp van verschillende beoordelingstypen (sterren, dobbelstenen, schaal 1-10 en dergelijke).

* **Google reCAPTCHA:** De [reCAPTCHA-functie][1] ("Ik ben geen robot" selectievakje) is een gratis Google-service die ervoor zorgt dat alleen echte gebruikers webformulieren kunnen insturen. Dit voorkomt dat spam en geautomatiseerde bots uw gegevensverzameling saboteren.

## Elementen weergeven

* **Tekstblok:** Voer een tekst in om op het formulier weer te geven, zoals een korte introductie of gedetailleerde beschrijving.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

* **Afbeelding:** Voeg een afbeelding toe aan het formulier. Klik op de koppeling om een afbeelding te selecteren of sleep een afbeelding naar het veld **Afbeelding**. Gebruik de keuzerondjes **Positie** om de afbeelding op het formulier te plaatsen.

* **Sectie:** Voeg een sectie toe tussen de velden om [een formulier met meerdere pagina's te maken][2]. Handig als uw formulier veel velden bevat en u niet wilt scrollen.

<!-- Referenced links -->
[1]: recaptcha.md
[2]: create.md#multi-page
[3]: ../../recipients/learn/manage-email-subscriptions.md
[4]: ../../../security/privacy/admin/add-purpose.md
