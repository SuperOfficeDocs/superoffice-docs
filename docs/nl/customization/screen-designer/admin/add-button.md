---
uid: help-nl-screen-designer-button
title: Knop of koppeling toevoegen
description: Hoe u een knop of link toevoegt aan een opmaak met behulp van de Schermontwerper in Instellingen en onderhoud.
keywords: knop toevoegen, nieuwe knop, link toevoegen, nieuwe link, label
author: Bergfrid Dias
date: 10.09.2025
version: 10.3.7
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: screen designer
language: nl
index: true
redirect_from: /nl/customization/screen-designer/add-button
---

# Knop of koppeling toevoegen

[!include[Vereiste](../../../includes/req-dev-tools.md)]

Aangepaste knoppen en koppelingen worden toegevoegd aan het **Voorbeeldweergave**-venster bij het bewerken van een opmaak. De URL wordt gebruikt om een webpagina in het huidige of een nieuw tabblad te openen, een CRMScript uit te voeren vanaf het scherm of te navigeren naar andere delen van SuperOffice met behulp van [SoProtocol][3].

Knoppen en koppelingen werken op vergelijkbare manier. Het verschil is dat u een knop kunt stijlen, maar een koppeling niet.

> [!TIP]
> U kunt [sjabloonvariabelen][1] in de URL's gebruiken.

De onderstaande instructies gaan ervan uit dat u al bezig bent met [het bewerken van de opmaak][4].

## Knop toevoegen

1. Selecteer het tabblad dat u wilt bewerken.

1. Selecteer de sectie **Elementen** aan de linkerkant.

1. Klik en sleep het element **Knop** naar de opmaak.

1. Klik om de nieuwe knop te selecteren.

1. Vervang in de sectie **Instellingen** de tekst "Knop" door de nieuwe knopnaam.

    ![Schermontwerper, instellingen voor knopelement -screenshot][img1]

    > [!TIP]
    > U kunt de knopnaam ook in andere talen toevoegen.

1. Selecteer in de lijst **Actie** de actie die moet worden uitgevoerd bij het klikken op de knop. Raadpleeg de referentie aan het einde van deze pagina voor meer details over elke actie.

    * Website openen: Selecteer deze optie om een koppeling naar een website toe te voegen. Selecteer de URL-codering en het doel indien nodig.

    * CRMScript uitvoeren: Selecteer deze optie om een [CRMScript][2] toe te voegen om specifieke acties in SuperOffice uit te voeren.

    * Snelkoppeling ([SoProtocol][3]): Selecteer deze optie om een besturingselement toe te voegen waarmee wordt genavigeerd naar een ander gebied of scherm in SuperOffice.

1. Selecteer in de lijst **Modus** of de knop altijd beschikbaar moet zijn, of alleen in lees- of bewerkingsmodus.

1. Selecteer in de lijst **Stijl** de stijl van de knop.

## <a id="link"></a>Koppelingen toevoegen

1. Selecteer het tabblad dat u wilt bewerken.

1. Selecteer de sectie **Elementen** aan de linkerkant.

1. Klik en sleep het element **Koppeling** naar de opmaak.

1. Klik om het nieuwe veld te selecteren.

1. Vervang in de sectie **Instellingen** de tekst "koppeling" door de nieuwe koppelingnaam.

    > [!TIP]
    > U kunt de koppelingnaam ook in andere talen toevoegen.

1. Selecteer in de lijst **Actie** de actie die moet worden uitgevoerd bij het klikken op de koppeling. (Zelfde lijst als voor knoppen.)

1. Selecteer in de lijst **Modus** of de koppeling altijd beschikbaar moet zijn, of alleen in lees- of bewerkingsmodus.

## Labels vertalen

De naam en tooltip-tekst kunnen in andere talen worden vertaald.

Als het element is geselecteerd:

1. Klik op <i class="ph ph-translate" aria-label="Translate"></i> naast het label.
1. Klik op **Toevoegen** en selecteer een taal uit de lijst.
1. Voer de tekst in voor de nieuwe taal.

    ![Schermontwerper, label vertalen -screenshot][img2]

1. Herhaal stappen 2-3 voor extra talen.
1. Klik op **Sluiten** om de vertaaldialog te verlaten.

Vergeet niet de opmaak opnieuw te publiceren.

## Referentie

| Instelling | Beschrijving | Opmerking |
|---|---|---|
| Naam | Tekst | Kan worden vertaald |
| Actie | Wat er gebeurt bij klikken: Website openen, CRMScript, SoProtocol | |
| URL | URL | HTTP-prefix wordt automatisch toegevoegd. U moet zelf 'https://' toevoegen indien van toepassing. |
| Modus | Wanneer het element wordt weergegeven: Altijd, leesmodus, bewerkingsmodus | |
| Tooltip | Tekst | Kan worden vertaald |
| Stijl | Actie, Normaal, Verwijderen, OK, Bewerken | Niet van toepassing op koppelingen |

Sommige instellingen zijn afhankelijk van de gekozen actie.

### Website openen

* URL-codering: geen, ANSI of Unicode
* Doel: nieuw tabblad of hetzelfde tabblad

![Schermontwerper, website openen op knop -screenshot][img4]

> [!NOTE]
> Het wordt aanbevolen om het protocol op te geven, bijvoorbeeld `https://www.superoffice.com`; anders is HTTP de standaard.

### CRMScript uitvoeren

* CRMScript: Selecteer het specifieke script dat moet worden uitgevoerd.

![Schermontwerper, CRMScript uitvoeren op knop -screenshot][img3]

[Meer informatie over CRMScript][2]

### Snelkoppeling (SoProtocol)

* SoProtocol: Het navigatie- en inhoudsdeel van de URL zonder het voorvoegsel `superoffice:`.

![Schermontwerper, SoProtocol op knop -screenshot][img5]

[Meer informatie over SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/customization/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/customization/new-button.png
[img2]: ../../../../media/loc/en/customization/translate-button-label.png
[img3]: ../../../../media/loc/en/customization/button-script.png
[img4]: ../../../../media/loc/en/customization/button-website.png
[img5]: ../../../../media/loc/en/customization/button-soprotocol.png
