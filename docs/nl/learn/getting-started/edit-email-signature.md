---
uid: help-nl-edit-email-signature
title: Handtekening bewerken
description: E-mail-handtekening of Verzoekhandtekening bewerken
keywords: e-mail, handtekening
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: nl
---

# Handtekeningen bewerken

De standaard sjablonen bevatten sjabloonvariabelen die worden vervangen door gegevens uit SuperOffice, zodat uw handtekeningen altijd worden bijgewerkt met de juiste informatie.

* **Handtekening E-mail:** Het sjabloon bevat variabelen voor uw naam, bedrijf, adres, telefoonnummers, e-mailadres, website, enzovoort [uit uw persoonskaart][3].

* **Handtekening Verzoek:** Het sjabloon bevat variabelen voor uw naam, bedrijf, e-mailadres, enzovoort, specifiek voor [antwoordsjablonen][2].

> [!NOTE]
> U kunt deze twee sets sjabloonvariabelen niet combineren. Daarnaast kunnen persoonlijke handtekeningen niet worden overschreven door beheerders.

## Stappen

1. Klik op de knop **Persoonlijke instellingen** (<i class="ph ph-user-circle" aria-hidden="true"></i>) in de bovenste balk.

1. Selecteer **Persoonlijke handtekening bewerken**.

1. Selecteer in het dialoogvenster het tabblad **Handtekening E-mail** of het tabblad **Handtekening Verzoek**.

1. Teksten bewerken en extra inhoud toevoegen.

    ![Persoonlijke handtekening bewerken -screenshot][img1]

    * Klik op **[v]** in de werkbalk om variabelen toe te voegen, of ga naar de hierboven gelinkte referenties voor de volledige lijst van beschikbare variabelen.

    * Voeg afbeeldingen en links toe met behulp van de knoppen in de werkbalk. U kunt ook links en afbeeldingen slepen en neerzetten. Selecteer **Link invoegen** om links naar relevante bronnen of sociale media toe te voegen.

1. Klik op **Opslaan** wanneer u klaar bent.

1. Optioneel: Test de handtekening door een e-mail naar uzelf te sturen (voor e-mailhandtekeningen) of door een nieuw verzoek aan te maken (voor verzoekhandtekeningen). Controleer of alle informatie correct wordt weergegeven, de links werken en de afbeeldingen zoals bedoeld worden weergegeven.

## Voorbeeld

Dit is een voorbeeld van een handtekening die door iedereen in uw bedrijf kan worden gebruikt.

**Sjabloon:**

```text
Met vriendelijke groet,
{auth}
{atit}
{onam}
Adres:{opad}, {ozip}{ocit}
Phone: {audp}
Mobiel nummer: {aupc}
{auem}
{owww}
```

**Resultaat:**

```text
Met vriendelijke groet,
John Jones
Verkoopmanager
SuperShop
Adres: High Street 12, 223-344, Springfield
Telefoon: 22334455
Mobiel nummer: 99887766
jj@supershop.com
supershop.com
```

## Gerelateerde inhoud

* [Standaard-e-mailclient wijzigen in SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../knowledge-base/learn/reply-templates/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
