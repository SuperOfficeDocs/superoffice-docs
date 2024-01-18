---
uid: help-no-udef-layout
title: Flytte felt
description: Flytte felt
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, egendefinert felt
so.topic: howto
so.audience: admin
so.audience.tooltip: Settings and maintenance
language: no
---

# Plassere felt

> [!NOTE]
> SuperOffice versjon 10 (utgitt oktober 2021) introduserte [Skjermdesigner][1] med skjermutseender som kan tilpasses for bestemte brukergrupper. Eventuelle egendefinerte skjermlayouter som bruker skjermdesigner kan overstyre innstillingene som er beskrevet nedenfor.

Når du legger til nye felt, blir de plassert under hverandre som standard. Hvert felt består av en ledetekst med et datafelt til høyre. Du kan bestemme hvor i rutenettet disse feltene skal plasseres.

## Hvordan merker jeg felt?

* Klikk på et felt i rutenettet for å merke det.
* Klikk og dra i rutenettet for å merke flere felt.
* Klikk på et felt i listen **Felt** for å velge både ledeteksten og datafeltet i rutenettet.

## Hvordan flytter jeg felt?

* Klikk og dra med musen. Feltene justeres automatisk etter rutenettet.
* Klikk på et felt og bruk piltastene på tastaturet.
* Klikk på et felt, og bruk piltastene nederst til høyre (![ikon][img2] ![ikon][img1] ![ikon][img4] ![ikon][img3]).
* Dobbeltklikk på et felt og angi posisjonsverdiene **X** og **Y** i dialogboksen **Felt**.

## Hvordan angir jeg posisjonen?

1. I feltene til høyre for **Ledetekst** angir du følgende:

    **X**: Horisontal posisjon for ledeteksten. Jo høyere tall, jo lenger til høyre.

    **Y**: Vertikal posisjon for ledeteksten. Jo høyere tall, jo lenger ned.

2. I feltene til høyre for **Data** angir du følgende:

    **X**: Horisontal posisjon for datafeltet. Jo høyere tall, jo lenger til høyre.

    **Y**: Vertikal posisjon for datafeltet. Jo høyere tall, jo lenger ned.

## Hvordan høyre-/venstrejusterer jeg felt?

Merk feltene du vil justere, og klikk på venstrejuster (![ikon][img5]) eller høyrejuster (![ikon][img6]) under rutenettet.

## Hvordan endrer jeg bredden på et felt?

1. Dobbeltklikk på det aktuelle feltet i listen **Felt** eller rutenettet
2. Angi bredden på ledeteksten i feltet til høyre for **Ledetekst**.
3. Angi bredden på datafeltet i feltet til høyre for **Data**.

## Redigere TAB-rekkefølgen for felt i Mer-fanen

Med TAB-rekkefølge mener vi i hvilken rekkefølge du kommer til de ulike feltene når du trykker på tabulatortasten. Du kan endre TAB-rekkefølgen for å gjenspeile den logiske rekkefølgen som brukere normalt angir data i felt i.

TAB-rekkefølgen vises på **Navn**-listen til venstre i bildet. Denne rekkefølgen er ikke det samme som feltenes posisjon, som vises i forhåndsvisningsfeltet øverst til høyre.

**Trinn:**

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Merk ønsket felt under listen.

1. Klikk på en av pilene under listen for å flytte feltet enten opp (![ikon][img1]) eller ned (![ikon][img2]).

1. Klikk på **Publiser** hvis du vil at endringene skal være tilgjengelige for SuperOffice CRM-brukere.

## Velge side 1-felt

> [!NOTE]
> Denne funksjonen er ikke tilgjengelig hvis organisasjonen bruker tilpassede skjermlayouter.

Blant de brukerdefinerte feltene som vises i **Mer**-fanene i SuperOffice CRM, kan du velge ut *tre* felt som skal fungere som såkalte side 1-felt (fordi de vises på "førstesiden" i sine respektive bilder eller dialogbokser).

## Hvor kan jeg vise side 1-felt?

[!include[List](includes/list-page-1-field-locations.md)]

## Slik viser du et brukerdefinert felt på første side

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Merk av for **Tillat forskjellige side 1-felt for forskjellige brukergrupper** nederst i fanen for å angi ulike side 1-felt for ulike brukergrupper. Hvis det ikke er merket av for dette alternativet, brukes feltene du angir, for alle brukergrupper.

1. På brukergruppelisten over merker du ønsket brukergruppe (hvis du merket av for **Tillat forskjellige side 1-felt for forskjellige brukergrupper** i forrige trinn).

1. I listeboksen **Felt 1** velger du hvilket felt du vil vise øverst. I listeboksene **Felt 2** og **Felt 3** velger du hvilke felt som skal vises på de neste plassene.

1. Klikk på **Lagre** hvis du vil lagre endringene bare i Innstillinger og vedlikehold, eller klikk på **Publiser** hvis du vil at endringene skal bli tilgjengelig for SuperOffice CRM-brukerne.

## Brukergrupper og side 1-felt

Når du merker et navn i listen **Brukergruppe**, vises de tilgjengelige side 1-feltene for den aktuelle brukergruppen under **Felt 1**, **2** og **3**.

> [!NOTE]
> Brukergrupper defineres i **Lister**-bildet, og hvilken gruppe en bruker tilhører, defineres i Brukere-bildet.

Hvis du velger **(alle brukergrupper)** på listen **Brukergruppe**, velger felt og lagrer oppsettet, vil samme feltvalg gjelde for alle brukergrupper i SuperOffice CRM. Men hvis du deretter merker en bestemt brukergruppe, kan du overstyre det eksisterende feltoppsettet for akkurat denne gruppen ved å angi noe annet. Hvis du ikke angir noe i et felt, blir det stående tomt, siden overstyringen gjelder alle tre felt uansett om du har angitt noe i dem eller ikke.

> [!NOTE]
> Du må publisere en overstyring for én brukergruppe *etter* at du har angitt oppsett for alle brukergrupper. Ellers vil den ikke tre i kraft.# Velge side 1-felt

<!-- Referenced links -->
[1]: ../../ui/screen-designer/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/arrow-right.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../../../media/icons/arrow-up.png
[img4]: ../../../media/icons/arrow-down.png
[img5]: ../../../media/icons/admin/align-left.png
[img6]: ../../../media/icons/admin/align-right.png
