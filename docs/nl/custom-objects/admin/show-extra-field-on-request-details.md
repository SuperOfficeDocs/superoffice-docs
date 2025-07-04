---
uid: help-nl-extra-field-display
title: Toon extra veld op het tabblad Details
description: Toon extra veld op het tabblad Details
keywords: extra field, custom field, request, layout, screen designer
author: Bergfrid Dias
date: 01.30.2024
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
---

# Toon extra veld op het tabblad Details

Scenario: U heeft een extra veld toegevoegd aan het bedrijf (`contact` tabel) dat aangeeft of een bedrijf een ondersteuningscontract heeft, en u wilt die informatie weergeven bij het bekijken van een verzoek.

<!-- markdownlint-disable-file MD051 -->
## Stappen

### [In het nieuwe scherm voor verzoeken met Screen Designer](#tab/screen-designer)

1. Ga naar **Instellingen en onderhoud** > **Screen Designer** en selecteer het tabblad **Verzoeken**.
1. Klik onderaan op **Indeling bewerken**.
1. Zoek de instelling **Velden**.
1. Selecteer uw veld.
1. Selecteer indien gewenst de passende opmaakopties.
1. Klik op **Opslaan** om de instellingen op te slaan.

> [!TIP]
> U kunt ook velden groeperen, koppen toevoegen voor groepen en de grootte van kolommen wijzigen. [Lees meer over de Screen Designer][1].

### [In de klassieke Service](#tab/service)

In Service moet je een gemeenschappelijk elementprofiel maken.

1. Ga naar **Instellingen en onderhoud** > **Systeemontwerp** en selecteer het tabblad **Profiel**.

1. Selecteer **Systeemschermen**. Klik vervolgens op **Ticket weergeven**, wijs de cursor toe aan **ticketinfo** en klik op **Nieuw gemeenschappelijk profiel**.

1. Voer een **naam** in voor het nieuwe profiel.

1. Klik op de knop **Criteria toevoegen** en doe het volgende:

    1. Voer een UI-label in voor het extra veld.
    1. Selecteer welk veld in de database u gegevens wilt ophalen.
    1. Klik op **OK**. Het nieuwe criterium wordt toegevoegd onder de anderen.
    1. Voeg eventueel meer criteria toe.

1. Klik op **OK**. Het nieuwe profiel is aangemaakt.

1. Klik opnieuw op het hamburgermenu en selecteer **Rollen**.

1. Selecteer een rol (wie het veld op het verzoekscherm mag zien).

1. In het dialoogvenster selecteer je het tabblad **Profiel**.

1. Uit de lijst **Nieuw elementprofiel** selecteer je het profiel dat je zojuist hebt aangemaakt.

1. Klik op **OK** om de instellingen op te slaan.

Alle gebruikers met deze rol kunnen nu het extra veld zien op het tabblad **Details** in al hun verzoeken.

***

<!-- Referenced links -->
[1]: ../../../en/ui/screen-designer/configurable-screens/working-with-fields.md
