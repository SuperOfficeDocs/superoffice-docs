---
uid: help-da-udef-move
title: "Felter, der kan flyttes"
description: "Felter, der kan flyttes"
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, tilpasset felt
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: da
---

# Placering af felter

> [!NOTE]
> SuperOffice v10 (udgivet oktober 2021) introducerede [Skærmdesigner][1] med skærmlayouts, der kan tilpasses, til bestemte brugergrupper. Alle brugerdefinerede skærmlayout ved hjælp af skærmdesigner kan tilsidesætte de indstillinger, der er beskrevet nedenfor.

Når du tilføjer nye felter, placeres de som standard under hinanden. Hvert felt består af en ledetekst med et datafelt til højre. Du kan bestemme, hvor i gitteret disse felter skal placeres.

## Hvordan markerer jeg felter?

* Klik på et felt i gitteret for at markere det.
* Klik og træk i gitteret for at markere flere felter.
* Klik på et felt på listen **Felt** for at vælge både ledeteksten og datafeltet i gitteret.

## Hvordan flytter jeg felter?

* Klik og træk med musen. Felterne justeres automatisk efter gitteret.
* Klik på et felt, og brug piletasterne på tastaturet.
* Klik på et felt, og brug piletasterne nederst til højre (![ikon][img2] ![ikon][img1] ![ikon][img4] ![ikon][img3]).
* Dobbeltklik på et felt, og angiv positionsværdierne **X** og **Y** i dialogboksen **Felt**.

## Hvordan indstiller jeg position?

1. I felterne til højre for **Ledetekst** skal du angive følgende:

    **X**: Horisontal position for ledeteksten. Jo højere tal, desto længere til højre.

    **Y**: Vertikal position for ledeteksten. Jo højere tal, desto længere ned.

2. I felterne til højre for **Data** skal du angive følgende:

    **X**: Horisontal position for datafeltet. Jo højere tal, desto længere til højre.

    **Y**: Vertikal position for datafeltet. Jo højere tal, desto længere ned.

## Hvordan højre-/venstrejusterer jeg felter?

Marker de felter, du vil justere, og klik på venstre-justering (![ikon][img5]) eller højre-justering (![ikon][img6]) under gitteret.

## Hvordan ændrer jeg bredden på et felt?

1. Dobbeltklik på det relevante felt På listen **Felt** eller gitteret
2. Angiv bredden på ledeteksten i feltet til højre for **Ledetekst**.
3. Angiv bredden på datafeltet i feltet til højre for **Data**.

## Rediger TAB-rækkefølgen på felter på fanen Mere

TAB-rækkefølgen er den rækkefølge, du flytter mellem de forskellige felter, når du trykker på TAB-tasten. Du kan ændre TAB-rækkefølgen, så den afspejler den logiske rækkefølge, som brugerne normalt indtaster data i felter.

TAB-rækkefølgen vises på listen**Navn** til venstre på skærmen. Denne rækkefølge er ikke den samme som felternes fysiske placeringer, som vises i eksempelfeltet øverst til højre.

**Trin:**

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Vælg det ønskede felt under listen.

1. Klik på en af pilene under listen for at flytte feltet enten op (![ikon][img1]) eller ned (![ikon][img2]).

1. Klik på **Udgiv**, hvis ændringerne skal være tilgængelige for SuperOffice CRM-brugere.

## Valg af side 1-felt

> [!NOTE]
> Denne funktion er ikke tilgængelig, hvis din organisation bruger tilpassede skærmlayout.

Blandt de brugerdefinerede felter, der vises under fanen **Mere** i SuperOffice CRM, kan du vælge *tre* der skal fungere som side 1-felter (såkaldte, fordi de vises på "første side" på deres respektive skærmbilleder).

## Hvor kan jeg få vist felterne Side 1?

[!include[List](includes/list-page-1-field-locations.md)]

## Sådan vises et brugerdefineret felt på den første side

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Markér **Tillad forskellige side 1-felter for forskellige brugergrupper** nederst på fanen for at angive forskellige side 1-felter for forskellige brugergrupper. Hvis afkrydsningsfeltet ikke er markeret, bruges de felter, du angiver, til alle brugergrupper.

1. På brugergruppelisten ovenfor skal du vælge den ønskede brugergruppe (hvis du markerede **Tillad forskellige side 1-felter for forskellige brugergrupper** i forrige trin).

1. På listen **Felt 1** skal du vælge det felt, der skal vises øverst. Vælg de felter, der skal vises på de næste placeringer på listerne **Felt 2** og **Felt 3** .

1. Klik på **Gem** for kun at gemme dine ændringer i Indstillinger og vedligeholdelse, eller klik på **Udgiv** for at gøre ændringerne tilgængelige for SuperOffice CRM-brugere.

## Brugergrupper og side 1-felter

Når du vælger et navn på listen **Brugergruppe**, vises de tilgængelige side 1-felter for den valgte brugergruppe**under**felt 1**,**2**og**3**.

> [!NOTE]
> Brugergrupper defineres på skærmbilledet **Lister** og den gruppe, som en bruger tilhører, defineres på skærmbilledet Brugere.

Hvis du vælger **(alle brugergrupper)** på **brugergruppelisten**, vælger et eller flere felter og gemmer opsætningen, gælder det samme valg af felter for alle brugergrupper i SuperOffice CRM. Hvis du derefter vælger en bestemt brugergruppe, kan du tilsidesætte den eksisterende feltopsætning for netop denne gruppe ved hjælp af en anden specifikation. Hvis du ikke angiver noget i et felt, efterlades det tomt – fordi tilsidesættelsen gælder for alle tre felter uanset deres indhold.

> [!NOTE]
> Du skal publicere en tilsidesættelse for en enkelt brugergruppe *når* du har angivet en opsætning for alle brugergrupper. Ellers træder den ikke i kraft.

<!-- Referenced links -->
[1]: ../../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/icons/arrow-up.png
[img4]: ../../../../media/icons/arrow-down.png
[img5]: ../../../../media/icons/admin/align-left.png
[img6]: ../../../../media/icons/admin/align-right.png
