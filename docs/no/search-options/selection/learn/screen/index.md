---
uid: help-no-selection-screen
title: Detaljkortene i Utvalg-skjermbildet
description: Detaljkortene i Utvalg-skjermbildet
keywords: utvalg
author: Bergfrid Dias
date: 09.17.2024
version: 10.3.9
topic: reference
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Utvalg-skjermbildet

Den første fanen i et utvalg inneholder en liste over medlemmer (poster, data) i det aktive utvalget. Utvalgsmedlemmer kan være firmaer eller personer, prosjekter, salg, dokumenter, oppfølginger, skjemainnleveringer, chat-samtaler, utsendelser eller produkter.

Medlemslisten ser litt ulik ut avhengig av hva utvalget inneholder. Alle utvalgstyper unntatt **Firma/person** har to faner som inneholder utvalgsdata.

> [!TIP]
> Hvis du dobbeltklikker på en post i medlemslisten, vises den aktuelle posten.

## Detaljkortene i Utvalg-skjermbildet

| Fane | Beskrivelse |
|---|---|
| Medlemslisten | Inneholder utvalgsdata. |
| Firma/person | Inneholder firmaer og personer knyttet til medlemslisten. Eksempel: Alle personer eller firmaer som er knyttet til salg i et utvalg. Hvis utvalget er et utvalg av firmaer/personer, er dette den eneste fanen med medlemmer. |
| Kriterier | Vis og [rediger kriteriene][3] for et dynamisk utvalg. |
| Detaljer | Vis og rediger [generell informasjon for et utvalg][1]. |
| Diagrammer | [Vis dataene fra utvalget i et diagram.][5] Diagrammer over utvalg kan også brukes i [dashbord][6]. |
| Utsendelser | Opprett en utsendelse til personer i et utvalg. [Vis masseutsendelsene](#mailing) som er arkivert på dette utvalget. |

> [!TIP]
> Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene i et utvalg for å gruppere og filtrere poster, legge til/fjerne kolonner, og spesifisere beregninger. Disse innstillingene kan lagres for det aktive utvalget ved å velge **Lagre kolonner bare for gjeldende utvalg**. Se også [Detaljkortfanene][9] for flere funksjoner.

Hvis du vil flytte mellom utvalg, klikker du på forrige/neste-knappene (<i class="ph ph-arrow-left" aria-hidden="true"></i><i class="ph ph-arrow-right" aria-hidden="true"></i>) øverst til høyre på skjermbildet.

### <a id="filter"></a>Filtrere medlemslisten

> [!NOTE]
> Før du filtrerer medlemslisten (for eksempel salg eller oppfølginger), må du klikke på **Vis alle** i fanens bunntekst. Dette sørger for at fanen viser alle postene i utvalget. For å optimere ytelsen når du jobber med store utvalg, lastes vanligvis bare de første 100 postene inn i medlemslisten.

Hvis du vil aktivere kolonnefilteret, klikker du på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene og klikker på **Aktiver filter**. Filterknappen (<i class="ph ph-funnel" aria-hidden="true"></i>) vises nå på kolonnen som kan [filtreres][8].

### Oppgave-knappen <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>

Bruk **Oppgave**-knappen til å utføre ulike oppgaver for medlemmene eller noen av medlemmene i utvalget. Eksempler: sending av e-post, masseredigering og eksport. Hvilke aktiviteter som vises, avhenger av hvilken type poster utvalget består av (hva som er valgt i feltet **Utvalg av**).

### Andre knapper

* **Fjern medlemmer**. Dette alternativet er bare tilgjengelig for statiske utvalg. Hvis du vil [fjerne bestemte medlemmer av utvalget][2], velger du de relevante medlemmene, høyreklikker og velger **Fjern**.

* **Antall: nummer**, Antall medlemmer i det aktive utvalget.

* **Vis alle**. Brukes til å vise alle utvalgsmedlemmer.

    > [!NOTE]
    > Som standard viser listen bare de 100 første postene i utvalget. Hvis du vil endre denne verdien, kan du gå til <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige innstillinger** > **Preferanser** > **Funksjoner** > **Arkivsidestørrelse**.

* <i class="ph ph-arrow-clockwise" aria-label="Refresh"></i>: Oppdaterer dataene i listen.

### <a id="mailing"></a> Vise utsendelser arkivert på utvalg

Bruk fanen **Utsendelser** i skjermbildet Utvalg til å holde oversikt over alle utsendelser som er relatert til et utvalg.

Dobbeltklikk på en utsendelse for å åpne den.

**Opprett en utsendelse**: Klikk for å [opprette en ny utsendelse][7] til personene i dette utvalget.

**Eksporter**: Brukes til å eksportere listen til et regneark.

## Aktuelle emner

* [Utfør oppgaver ved å bruke utvalg][4]
* [Bruke filtre i detaljkortene][8]
* [Opprett utvalg][1]

<!-- Referenced links -->
[1]: ../create/index.md
[2]: ../update/add-remove-members-static.md
[5]: ../howto/display-as-charts.md
[3]: ../../../learn/search-criteria.md
[6]: ../../../../dashboard/learn/create.md
[7]: ../../../../marketing/mailing/learn/create/index.md
[8]: ../../../../learn/section-tabs/filter.md
[9]: ../../../../learn/section-tabs/index.md
[4]: ../../../../learn/getting-started/index.md

<!-- Referenced images -->
