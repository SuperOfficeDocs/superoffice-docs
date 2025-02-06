---
uid: help-no-sale-update
title: Oppdater et salg
description: Hvordan oppdatere eksisterende salgsinformasjon, endre salgsfase (inkludert å merke det som utsatt, vunnet eller tapt), eller slette et salg hvis det ikke lenger er relevant.
keywords: oppdatere salg, redigere salg, slette salg, satt på vent, utsatt, tapt, vunnet, salg
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Oppdater et salg

Du kan oppdatere eksisterende salgsinformasjon, endre salgsfase (inkludert å merke det som utsatt, vunnet eller tapt), eller slette et salg hvis det ikke lenger er relevant.

## Rediger salg

1. Åpne **Salg**-bildet for salget du vil oppdatere. Se [Bruk søkeskjermen][5].

1. Klikk på <i class="ph ph-pencil-simple" aria-label="Rediger"></i> øverst til høyre på salgsbildet for å gå til redigeringsmodus.

1. Gjør nødvendige endringer. Du kan bytte mellom faner mens du er i redigeringsmodus.

    * **Totalkostnad, fortjeneste og prosentfelt:** Endring av ett felt vil automatisk oppdatere de andre for å sikre konsistens.

    * **Endre fase:** Oppdatering av fasen justerer automatisk **Sannsynlighet**-feltet. Du kan fortsatt overstyre denne verdien manuelt. Hvis salgstypen er koblet til en [salgsguide][1], blir tidligere faser i guiden merket som fullført med en hake.

    > [!CAUTION]
    > Hvis du bytter **salgstype** som er koblet til en salgsguide, vil guiden fjernes. Aktiviteter og dokumenter forblir i detaljekortet **Aktiviteter** og vil bli knyttet tilbake hvis du gjenoppretter den opprinnelige salgstypen.

1. Klikk **Lagre** for å bruke endringene, eller **Avbryt** for å forkaste dem. Begge handlingene avslutter redigeringsmodus.

    > [!NOTE]
    > Hvis **Lagre**-knappen er nedtonet, må du sjekke at alle obligatoriske felt er fylt ut.

## <a id="stalled"></a>Merk et salg som utsatt

Denne statusen kan brukes når en kunde for eksempel utsetter sin kjøpsbeslutning til et senere tidspunkt.

1. Merk av for **Utsatt** i **Salg**-bildet.

1. Fyll ut følgende tilleggsfelt:
    * **Gjenåpningsdato:** Datoen når salget skal vurderes på nytt.
    * **Årsak (utsatt):** Forklaring på hvorfor salget ikke kan fortsette.

    ![Utsatt salg -screenshot][img1]

1. Klikk **Lagre**. Dialogboksen **Oppfølging** åpnes, slik at du kan planlegge et fremtidig møte eller en samtale for oppfølging av salget.

> [!NOTE]
> Feltene **Gjenåpningsdato** og **Årsak** erstatter feltet **Neste aktivitet**.

## Merk et salg som vunnet

1. Velg **Vunnet** i **Fase**-listen.

1. Oppdater **Dato**-feltet (standard er dagens dato) til faktisk avslutningsdato hvis forskjellig.

1. Velg **Årsak** for at salget ble vunnet.

    ![Vunnet salg -screenshot][img2]

1. Juster salgsbeløpet og oppdater økonomiske detaljer i **Detaljer**-fanen.

1. Klikk **Lagre**.

## Merk et salg som tapt

1. Velg **Tapt** i **Fase**-listen.

1. Velg **Årsak** for at salget gikk tapt.

    ![Tapt salg -screenshot][img3]

1. Oppdater eventuelle andre felt.

1. Klikk **Lagre**.

Hvis salget har status **Vunnet** eller **Tapt**, kan du merke av for **Fullført**.

## <a id="delete"></a>Slett et salg

1. Åpne **Salg**-bildet for salget du vil slette.

1. Klikk på **Oppgave**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) øverst til høyre på salgskortet og velg **Slett**.

1. I dialogboksen **Slett salg**, gjennomgå salgsdetaljene for å sikre at du sletter riktig salg. Denne handlingen kan ikke angres.

    > [!NOTE]
    > Hvis alternativet **Slett** ikke er tilgjengelig, har du kanskje ikke de nødvendige tillatelsene til å slette salget. Du kan ikke slette salg som ikke tilhører deg med mindre du har spesielle rettigheter.

1. Klikk **Ja** for å bekrefte slettingen.

## Relatert innhold

* [Opprett et salg][2]
* [Salgsguider][1]
* [Forklaring av feltene][3]

<!-- Refererte lenker -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png
