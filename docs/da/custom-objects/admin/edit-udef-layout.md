---
uid: help-da-udef-layout
title: Placering af felter
description: Placering af felter
author: Bergfrid Dias
date: 01.26.2024
version: 9
keywords: udef, tilpasset felt
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Placering af felter

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

SuperOffice version 10 (udgivet i oktober 2021) introducerede [Skærmdesigner][1] med tilpasselige skærmlayouts for specifikke brugergrupper. Eventuelle brugerdefinerede skærmlayouts ved hjælp af skærmdesigneren kan tilsidesætte de nedenfor beskrevne indstillinger.

Når du [tilføjer nye felter][2], placeres de som standard under hinanden. Hvert felt består af en ledetekst med et datafelt til højre. Du kan beslutte, hvor i gitteret disse felter skal placeres.

## Hvor skal du begynde

1. [!include[Gå til Felt og vælg fane](includes/goto-fields.md)]

**Sådan vælger du felter:**

* Klik på et felt i gitteret for at markere det.
* Klik og træk i gitteret for at markere flere felter.
* Klik på et felt i listen **Felt** for at vælge både ledeteksten og datafeltet i gitteret.

## Flyt felt

* Klik og træk med musen. Felterne tilpasses automatisk gitteret.
* Klik på et felt og brug piletasterne på tastaturet.
* Klik på et felt og brug piletasterne nederst til højre (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Dobbeltklik på et felt og angiv positionsværdierne **X** og **Y** i dialogen **Felt**.

## Angiv position

1. Angiv følgende i felterne til højre for **Ledetekst**:

    **X**: Horisontal position for ledeteksten. Jo højere tal, jdesto længere mod højre.

    **Y**: Vertikal position for ledeteksten. Jo højere tal, desto længere ned.

2. Angiv følgende i felterne til højre for **Data**:

    **X**: Horisontal position for datafeltet. Jo højere tal, desto længere mod højre.

    **Y**: Vertikal position for datafeltet. Jo højere tal, desto længere ned.

## Justér felter (højre/venstre)

Vælg de felter, du vil justere, og klik på venstrejustér (<i class="ph ph-text-align-left" aria-hidden="true"></i>) eller højrejustér (<i class="ph ph-text-align-right" aria-hidden="true"></i>) under gitteret.

## Ændr bredden på et felt

1. Dobbeltklik på det relevante felt i **Felt**-listen eller gitteret.
2. Angiv bredden på ledeteksten i feltet til højre for **Ledetekst**.
3. Angiv bredden på datafeltet i feltet til højre for **Data**.

## Redigér TAB-rækkefølgen af felterne på fanen Mere

TAB-rækkefølgen er den rækkefølge, du bevæger dig mellem de forskellige felter, når du trykker på TAB-tasten. Du kan ændre TAB-rækkefølgen for at afspejle den logiske sekvens, brugere normalt indtaster data i felterne.

TAB-rækkefølgen vises i listen **Navn** til venstre på skærmen. Denne rækkefølge er ikke den samme som felternes fysiske positioner, som vises i forhåndsvisningsfeltet øverst til højre.

**Trin:**

1. Vælg det ønskede felt under listen.

1. Klik på <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> under listen for at flytte feltet enten op eller ned.

1. Klik på **Udgiv** for at gøre ændringerne tilgængelige for SuperOffice CRM-brugere.

## <a id="page-1"></a>Vis et brugerdefineret felt på første side

1. Marker af for **Tillad forskellige side 1-felter for forskellige brugergrupper** nederst på fanen for at angive forskellige side 1-felter for forskellige brugergrupper. Hvis afkrydsningsfeltet ikke er markeret, bruges de felter, du angiver, for alle brugergrupper.

1. I brugergruppelisten ovenfor skal du vælge den ønskede brugergruppe (hvis du markerede **Tillad forskellige side 1-felter for forskellige brugergrupper** i det forrige trin).

1. I listen **Felt 1** skal du vælge feltet, der skal vises øverst. Vælg felterne, der skal vises på de næste positioner i listerne **Felt 2** og **Felt 3**.

1. Klik på **Gem** for at gemme dine ændringer kun i Indstillinger og vedligeholdelse eller klik på **Udgiv** for at gøre ændringerne tilgængelige for SuperOffice CRM-brugere.

### Brugergrupper og side 1-felter

Brugergrupper er defineret i skærmen **Lister**, og den gruppe, som en bruger tilhører, er defineret i skærmen **Brugere**. Når du vælger et navn i listen **Brugergruppe**, vises de tilgængelige side 1-felter for den valgte brugergruppe under **Felt 1**, **2** og **3**.

Hvis du vælger **(alle brugergrupper)** i listen **Brugergruppe**, vælger et felt eller felter og gemmer opsætningen, gælder det samme valg af felter for alle brugergrupper i SuperOffice CRM. Hvis du derefter vælger en bestemt brugergruppe, kan du tilsidesætte den eksisterende feltopsætning for netop denne gruppe ved hjælp af en anden specifikation. Hvis du ikke angiver noget i et felt, efterlades det tomt – fordi tilsidesættelsen gælder for alle tre felter uanset deres indhold.

> [!NOTE]
> Du skal publicere en tilsidesættelse for en enkelt brugergruppe *når* du har angivet en opsætning for alle brugergrupper. Ellers træder den ikke i kraft.

<!-- Referenced links -->
[1]: ../../ui/screen-designer/learn/index.md
[2]: add-udef.md
