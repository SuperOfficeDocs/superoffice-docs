---
uid: help-nl-request-relation-rules
title: Relatieregels
description: Leer hoe u relatieregels configureert om het gedrag bij het aanmaken en sluiten van verzoeken te automatiseren op basis van bovenliggende-onderliggende relaties in SuperOffice Service.
keywords: relatieregels, verzoekrelatie, bovenliggend-onderliggend, relatieregel, automatisering, verzoek sluiten, tabblad Relatieregels
author: digitaldiina
date: 04.08.2026
version: 11.12
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: nl
index: true
---

# Relatieregels

Relatieregels definiëren automatisch gedrag dat wordt toegepast wanneer verzoeken worden aangemaakt of gesloten, op basis van bovenliggende-onderliggende relaties tussen specifieke verzoektypen. Ze helpen u consistentie in uw ondersteuningsproces te handhaven — bijvoorbeeld door te voorkomen dat een bovenliggend verzoek wordt gesloten totdat alle onderliggende verzoeken zijn opgelost, of door agenten te vragen gerelateerde verzoeken samen te sluiten.

> [!NOTE]
> Regels leiden alleen in de gebruikersinterface voor verzoeken tot automatische acties. API- en CRMScript-bewerkingen worden hierdoor niet beïnvloed.

## Wat is een relatieregel?

Een relatieregel bestaat uit:

* **Voorwaarde:** voor welke verzoektypen de regel van toepassing is (bron en ontvanger).
* **Gedrag:** wat er automatisch gebeurt wanneer overeenkomende verzoeken worden aangemaakt of gesloten.

## Voorbeeld: Incidentbeheer

Een grote servicestoring genereert meerdere individuele probleemmeldingen van getroffen klanten. Elk klantrapport wordt geregistreerd als een onderliggend verzoek, gekoppeld aan een gedeeld incident als het bovenliggende verzoek.

* **Voorkomen dat bovenliggende wordt gesloten als nog niet alle onderliggende verzoeken zijn gesloten** — houdt het incident open totdat elke probleemmelding is afgehandeld, zodat niets over het hoofd wordt gezien.
* **Aanbieden om bovenliggende te sluiten als alle onderliggende verzoeken worden gesloten** — wanneer de laatste probleemmelding is opgelost, wordt de agent gevraagd ook het incident te sluiten.
* **Aanbieden om onderliggende verzoeken te sluiten en bericht te sturen als bovenliggende wordt gesloten** — wanneer het incident is opgelost, kan de agent alle resterende onderliggende verzoeken tegelijk sluiten en elke getroffen klant rechtstreeks antwoorden dat het probleem is verholpen.

## Waar vind ik relatieregels?

Selecteer in **Instellingen en onderhoud** de optie **Verzoeken** in de navigator en ga naar het tabblad **Relatieregels**.

![Instellingen en onderhoud, Relatieregels -screenshot][img1]

[!include[Beperkte toegang](../../learn/includes/note-insufficient-rights.md)]

## Instellingen

### Voorwaarde

| Veld | Beschrijving |
|---|---|
| Uit (bron) | Een of meer bronverzoektypen. |
| Relatie | Het relatietype (Bovenliggend of Onderliggend). |
| Aan (ontvanger) | Een of meer doelverzoektypen. |

De samenvattingsregel onder de voorwaarde bevestigt de volledige reikwijdte van de regel in gewone taal. Er wordt een waarschuwing weergegeven als de voorwaarde overlapt met een bestaande regel.

### Gedrag: Bij maken

| Optie | Beschrijving |
|---|---|
| **Bovenliggende moet zijn ingesteld** | Voorkomt het opslaan van een nieuw verzoek tenzij een bovenliggend verzoek is opgegeven. Alleen van toepassing als het veld **Bovenliggend** is toegevoegd aan het verzoekscherm in de [Screen Designer][3]. |

### Gedrag: Bij sluiten

| Optie | Beschrijving |
|---|---|
| **Voorkomen dat bovenliggende wordt gesloten als nog niet alle onderliggende verzoeken zijn gesloten** | Blokkeert het sluiten van het bovenliggende verzoek zolang er nog onderliggende verzoeken open zijn. |
| **Aanbieden om bovenliggende te sluiten als alle onderliggende verzoeken worden gesloten** | Wanneer het laatste onderliggende verzoek wordt gesloten, wordt de agent gevraagd ook het bovenliggende verzoek te sluiten. |
| **Aanbieden om onderliggende verzoeken te sluiten en bericht te sturen als bovenliggende wordt gesloten** | Wanneer het bovenliggende verzoek wordt gesloten, wordt de agent gevraagd alle open onderliggende verzoeken te sluiten en aan elk een antwoordbericht toe te voegen dat naar hun ontvangers wordt verzonden. |

## Relatieregel toevoegen

1. Selecteer in **Instellingen en onderhoud** de optie **Verzoeken** in de navigator en ga naar het tabblad **Relatieregels**.

1. Klik op de knop **Toevoegen**.

    ![Relatieregel toevoegen -screenshot][img2]

1. Voer een **Regelnaam** in en optioneel een **Beschrijving**.

1. Selecteer in het gedeelte **Voorwaarde** het **Relatie**-type en selecteer vervolgens een of meer verzoektypen in de velden **Uit (bron)** en **Aan (ontvanger)**. De samenvattingsregel onder de voorwaarde bevestigt waarop de regel van toepassing is.

    > [!NOTE]
    > Als de voorwaarde overlapt met een bestaande regel, wordt een conflictwaarschuwing weergegeven. Pas de verzoektypen aan om het conflict op te lossen voordat u opslaat.

1. Schakel in het gedeelte **Gedrag** de gewenste opties in voor **Bij maken** en **Bij sluiten**.

1. Klik op **Opslaan**.

## Relatieregel bewerken

1. Klik in het tabblad **Relatieregels** op de regel in de lijst aan de linkerkant.

1. Breng uw wijzigingen aan.

1. Klik op **Opslaan**.

## Relatieregel verwijderen

1. Selecteer in het tabblad **Relatieregels** de regel in de lijst aan de linkerkant.

1. Klik op de knop **Verwijderen** onderaan de lijst.

## Gerelateerde inhoud

* [Verzoekrelaties][1]
* [Verzoektypen][2]

<!-- Referenced links -->
[1]: ../learn/request-relations.md
[2]: type/index.md
[3]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/relation-rules.png
[img2]: ../../../../media/loc/en/request/add-relation-rule.png
