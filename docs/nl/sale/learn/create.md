---
uid: help-nl-sale-create
title: Een verkoop registreren
description: Registreer verkopen in SuperOffice Sales om al uw verkoopkansen en klantinformatie op één plek te beheren. Deze gids laat u zien hoe u verkopen kunt registreren.
keywords: verkoop aanmaken, nieuwe verkoop, verkoop toevoegen, verkoop registreren, verkoop
author: Bergfrid Dias
date: 06.26.2025
version: 10.5.5
content_type: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Een verkoop registreren

U kunt een verkoop registreren in SuperOffice CRM met de knop **Nieuw** in de bovenste balk.

## Stappen

1. Klik op **Nieuw** in de bovenste balk en selecteer **Verkoop**.

1. Voer een **verkooptitel** in (verplicht, gemarkeerd in rood). Dit is de belangrijkste identificatie van de verkoop.

    ![Tabblad Verkoop met basisvelden in de verkoopkaart -screenshot][img1]

1. Voer het **bedrag en de valuta** in om de geschatte waarde van de verkoop vast te leggen.

1. Selecteer het **Verkooptype** in de keuzelijst (verplicht). Verkooptypen bepalen het proces en kunnen fasen of verkoopgidsen bevatten. Waarden worden vooraf gedefinieerd en ingesteld in **Instellingen en onderhoud**.

1. **Optioneel:** Vul aanvullende informatie in op het tabblad **Verkoop**, zoals:
    * Koppel de verkoop aan een **bedrijf**.
    * Koppel de verkoop aan een lopend **project**.
    * Pas de verwachte sluitingsdatum van de verkoop aan.
    * Gebruik het grote tekstvak om een optionele beschrijving van de verkoop toe te voegen.
    * Selecteer de huidige **Fase** van de verkoop (indien van toepassing). Fasen volgen de voortgang van de verkoop.

    > [!NOTE]
    > Als aan het verkooptype geen fasen zijn gekoppeld, heeft de verkoop de status **Open**.

1. Ga naar het tabblad **Details** om financiële informatie toe te voegen, zoals kosten, winst en concurrenten.

1. **Voeg extra details toe:**
    * Ga naar het tabblad **Meer** om [aangepaste velden in te vullen][12].
    * Ga naar het tabblad **Opmerking** om [notities toe te voegen][11].
    * Ga naar het tabblad **Koppelingen** om [activiteiten, documenten of websites][10] te koppelen aan de verkoop.

1. Klik op **Opslaan** om de verkoop op te slaan. De verkoopkaart is nu aangemaakt.

## <a id="fields"></a>Belangrijke velden uitgelegd

De volgende velden zijn beschikbaar op de verkoopkaart. Sommige velden worden automatisch ingevuld, terwijl andere handmatig moeten worden ingevoerd.

> [!NOTE]
> Velden en lay-out kunnen variëren op basis van **Schermontwerper**-configuraties en andere UI-aanpassingen.

<!-- markdownlint-disable-file MD051 -->
### [Tabblad Verkoop](#tab/sale)

* **Titel:** Een verplicht veld om de verkoop te identificeren.
* **Beschrijving:** Optioneel tekstvak voor een samenvatting van de verkoop.
* **Verkooptype:** Voorgedefinieerde typen die het proces bepalen, mogelijk gekoppeld aan fasen of verkoopgidsen. Ingesteld in **Instellingen en onderhoud**.
* **Fase:** Volgt de voortgang van de verkoop. Beschikbare fasen zijn afhankelijk van het geselecteerde verkooptype.
* **Bedrag en valuta:** Geschatte waarde van de verkoop. *(Valuta moet worden geactiveerd in Instellingen en onderhoud om deze optie te gebruiken.)*
* **Kans:** De waarschijnlijkheid dat de verkoop succesvol is. Gebaseerd op de huidige fase, maar kan handmatig worden bijgewerkt.
* **Bedrijf:** Het bedrijf dat aan de verkoop is gekoppeld.
* **Persoon:** De contactpersoon bij het bedrijf die is gekoppeld aan de verkoop.
* **Project:** Koppelt de verkoop aan een lopend project.
* **Eigenaar:** De gebruiker die verantwoordelijk is voor de verkoop. Standaard wordt de huidige gebruiker ingesteld, maar dit kan worden gewijzigd.
* **Verkoopdatum:** De verwachte sluitingsdatum van de verkoop.
* **Volgende activiteit:** Wordt automatisch gevuld met de oudste onvoltooide vervolgactiviteit. Datums vóór vandaag worden rood gemarkeerd.
* **Vastgelopen selectievakje:** Markeert de verkoop als gepauzeerd en activeert de velden **Datum heropening** en **Reden (vastgelopen)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Tabblad Details](#tab/details)

Het **Details** tabblad richt zich op de financiële informatie van de verkoop.

* **Nummer:** Automatisch gegenereerd verkoop-ID.
* **Bron:** Toont de herkomst van de verkoop.
* **Concurrent:** Selecteer een voorgedefinieerde concurrent die aan de verkoop is gekoppeld (slechts één mogelijk).
* **Totale kosten:** Kosten die aan de verkoop zijn verbonden. Past automatisch de winst aan.
* **Winst:** Winst berekend op basis van verkoopbedrag en kosten.
* **Gecrediteerd:** Wijs de verkoop toe aan een afdeling die hiervoor verantwoordelijk is.

De waarden voor *Concurrent* en *Gecrediteerd* worden gedefinieerd in Instellingen en onderhoud.

### [Tabbladen Koppelingen en Opmerking](#tab/other)

* **Tabblad Koppelingen**: Koppel relevante activiteiten, documenten of andere verkopen.
* **Tabblad Opmerking**: Voeg vrije-tekstnotities toe om extra informatie bij te houden.

***

## Gerelateerde inhoud

* [Een offerte maken][4]
* [Een verkoop bijwerken][1]
* [Werken met verkoopgidsen][2]

<!-- Referenced links -->
[1]: update.md
[2]: sales-guides.md
[4]: quote/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/create-sale.png
