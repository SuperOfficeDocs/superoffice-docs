---
uid: help-no-udef-layout
title: Grensesnitttilpasning
description: Grensesnitttilpasning
keywords: udef, egendefinert felt, side-1, TAB-rekkefølge, justere felt
author: Bergfrid Dias
date: 01.29.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Grensesnitttilpasning

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

SuperOffice versjon 10 (utgitt oktober 2021) introduserte [Skjermdesigner][1] med skjermlayouter som kan tilpasses for bestemte brukergrupper. Eventuelle egendefinerte skjermlayouter som bruker skjermdesigner kan overstyre innstillingene som er beskrevet nedenfor.

Når du [legger til nye felt][2], plasseres de som standard under hverandre. Hvert felt består av en ledetekst med et datafelt til høyre. Du kan bestemme hvor i rutenettet disse feltene skal plasseres.

## Hvor du skal begynne

1. [!include[Gå til Felt og velg fane](includes/goto-fields.md)]

**Hvordan velge felt:**

* Klikk på et felt i rutenettet for å velge det.
* Klikk og dra i ruten for å velge flere felt.
* Klikk på et felt i listen **Felt** for å velge både ledeteksten og datafeltet i rutenettet.

## Flytte felt

* Klikk og dra med musen. Feltene vil automatisk tilpasses rutenettet.
* Klikk på et felt og bruk piltastene på tastaturet.
* Klikk på et felt og bruk piltastene nederst til høyre (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Dobbeltklikk på et felt og angi posisjonsverdiene **X** og **Y** i dialogboksen **Felt**

## Angi posisjon

1. Angi følgende i feltene til høyre for **Ledetekst**:

    **X**: Horisontal posisjon for ledeteksten. Jo høyere nummeret, jo lengre til høyre.

    **Y**: Vertikal posisjon for ledeteksten. Jo høyere nummeret, jo lenger ned.

2. Angi følgende i feltene til høyre for **Data**:

    **X**: Horisontal posisjon for datafeltet. Jo høyere nummeret, jo lengre til høyre.

    **Y**: Vertikal posisjon for datafeltet. Jo høyere nummeret, jo lenger ned.

## Justere felt (høyre/venstre)

Merk de feltene du vil justere, og klikk på venstrejuster (<i class="ph ph-text-align-left" aria-hidden="true"></i>) eller høyrejuster (<i class="ph ph-text-align-right" aria-hidden="true"></i>) under rutenettet.

## Endre bredden på et felt

1. Dobbeltklikk på det relevante feltet i listen **Felt** eller rutenettet.
2. Spesifiser bredden på ledeteksten i feltet til høyre for **Ledeteksten**.
3. Spesifiser bredden på datafeltet i feltet til høyre for **Data**.

## Redigere TAB-rekkefølgen for felt i Mer-fanen

TAB-rekkefølge er den rekkefølgen du beveger deg mellom de ulike feltene når du trykker på tabulatortasten. Du kan endre rekkefølgen for å gjenspeile den logiske sekvensen brukere normalt skriver inn data i feltene.

TAB-rekkefølgen vises i listen **Navn** til venstre i bildet. Denne rekkefølgen er ikke den samme som feltenes fysiske posisjon, som vises i forhåndsvisningsfeltet øverst til høyre.

**Trinn:**

1. Merk ønsket felt under listen.

1. Klikk på <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> under listen for å flytte feltet enten opp eller ned.

1. Klikk på **Publiser** for å gjøre endringene tilgjengelige for SuperOffice CRM-brukere.

## <a id="page-1"></a>Vis et brukerdefinert felt på første side

1. Merk av for **Tillat forskjellige side 1-felter for forskjellige brukergrupper** nederst på fanen for å angi ulike side 1-felter for ulike brukergrupper. Hvis det ikke er merket av for dette alternativet, brukes feltene du angir for alle brukergrupper.

1. I brukergruppelisten ovenfor, velg den ønskede brukergruppen (hvis du merket av for **Tillat forskjellige side 1-felter for forskjellige brukergrupper** i forrige trinn).

1. I listen **Felt 1**, velg feltet du vil vise øverst. Velg feltene som skal vises på de neste plassene fra **Felt 2** og **Felt 3**.

1. Klikk på **Lagre** for å lagre endringene dine bare i Innstillinger og vedlikehold, eller klikk på **Publiser** for å gjøre endringene tilgjengelige for SuperOffice CRM-brukere.

### Brukergrupper og side 1-felt

Brukergrupper defineres i skjermbildet **Lister**, og hvilken gruppe en bruker tilhører, defineres i skjermbildet **Brukere**.

Når du merker et navn i listen **Brukergruppe**, vises tilgjengelige side 1-felt for den aktuelle brukergruppen under **Felt 1**, **2** og **3**.

Hvis du velger **(alle brukergrupper)** på listen **Brukergruppe**, velger felt eller felt og lagrer oppsettet, vil samme feltvalg gjelde for alle brukergrupper i SuperOffice CRM. Hvis du deretter merker en spesifikk brukergruppe, kan du overstyre det eksisterende oppsettet for akkurat denne gruppen ved å angi noe annet. Hvis du ikke angir noe i et felt, blir det stående tomt – fordi overstyringen gjelder for alle tre felt uavhengig av innholdet deres.

> [!NOTE]
> Du må publisere en overstyring for en enkelt brukergruppe *etter* at du har angitt oppsett for alle brukergrupper. Ellers vil den ikke tre i kraft.

<!-- Referenced links -->
[1]: ../../ui/screen-designer/learn/index.md
[2]: add-udef.md
