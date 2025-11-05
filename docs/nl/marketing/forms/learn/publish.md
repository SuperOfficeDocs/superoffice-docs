---
uid: help-nl-form-publish
title: Formulieren publiceren
description: Formulieren publiceren
keywords: formulier, publiceren, formulieren publiceren, vooraf ingevulde velden, formulier insluiten, scriptcode, UTM-builder, UTM-tracking toevoegen
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Formulieren publiceren

Nadat u een formulier en (indien relevant) de formulierantwoord hebt gemaakt, kunt u het formulier publiceren.

> [!NOTE]
> Het tabblad **Publiceren** is een hier-en-nu-werkruimte. Alle waarden die je op deze pagina invoert – zoals vooraf ingevulde velden of UTM-parameters – worden alleen gebruikt om de link of script te genereren die je nu kopieert.
> SuperOffice slaat deze waarden **niet** permanent op. Als een andere gebruiker de pagina later bewerkt, worden je eerdere waarden overschreven.

## Stappen

1. Ga naar het tabblad **Formulieren**.

1. Klik op het formulier om het te openen in voorbeeldweergave.

1. Stel het formulier in als **Actief** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> in de koptekst.

1. Ga naar het tabblad **Publiceren**.

1. (optioneel) Selecteer **Vooraf invullen met contactgegevens** om veld-ID's toe te voegen aan de koppeling/JavaScript. Handig voor [het vooraf invullen van velden in de formulieren][1] met bestaande klantgegevens van SuperOffice.

1. Selecteer aan de linkerkant van het scherm een publicatieoptie voor het formulier:

    * **Directe koppeling**: een directe koppeling naar het formulier.
    * **Inline insluiten**: een scriptcode die wordt gebruikt om het formulier op een webpagina toe te voegen.
    * **Als pop-up insluiten**: een knop om het formulier te openen in een pop-upvenster op de webpagina.
    * **Insluiten als zijtabblad**: een zijtabblad met een knop om het formulier te verbergen/weer te geven.

1. Kopieer de koppelingen/codes naar een nieuwsbrief, website of Customer Centre om deze te publiceren naar uw klanten of prospects.

![Formulier publiceren, directe koppeling -screenshot][img3]

## <a id="utm"></a>UTM-tracking toevoegen (Marketing Premium)

De ingebouwde **UTM-builder** maakt een formulierlink met [UTM-parameters][4], zodat SuperOffice kan vastleggen waar je leads vandaan komen wanneer een bezoeker het formulier verzendt.

### Vereisten en beperkingen

* Je hebt een **Marketing Premium**-gebruikersplan.
* Een beheerder heeft [de overdracht van UTM-gegevens voor formulierinzendingen ingeschakeld][6].
* UTM-tracking is alleen beschikbaar voor de optie **Directe link**. Het is niet van toepassing op ingesloten formulieren.

### Stappen

1. Selecteer op het tabblad **Publiceren** de optie **Directe link** als publicatiemethode.

1. Voer in de sectie **UTM-tracking toevoegen** één of meer UTM-waarden in, zoals **bron**, **medium** en **campagne**.

    ![Velden voor UTM-tracking toevoegen in de formulierpublicatie – screenshot][img4]

    Zie [UTM-parameters][4] voor meer informatie over elke parameter en naamgevingsconventies.

1. Kopieer de gegenereerde link uit het veld hieronder.

1. Plak de link in je advertentie, e-mail of socialmediabericht.

> [!TIP]
> Kopieer en bewaar de link direct nadat je deze hebt gemaakt. Latere wijzigingen in de velden genereren een nieuwe link.

## Wat gebeurt er nu?

Een melding op het tabblad **Formulierverzendingen** geeft aan dat je [formulierverzendingen hebt ontvangen][2], die mogelijk [handmatig verwerkt moeten worden][3].

Formulieren kunnen handmatig gedeactiveerd worden, of worden automatisch gedeactiveerd op een specifieke datum of wanneer een specifiek aantal verzendingen is ontvangen.

## Gerelateerde inhoud

* [Overzicht van conversietracking][5]
* [UTM-tracking instellen][6] - in Instellingen en onderhoud

<!-- Referenced links -->
[1]: form-prefilled.md
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png
