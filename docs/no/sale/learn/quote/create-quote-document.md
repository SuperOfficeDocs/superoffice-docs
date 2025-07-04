---
uid: help-no-quote-create-document
title: Opprette tilbudsdokument
description: Lag et tilbudsdokument for tilbudet i SuperOffice, som kan sendes til kunden.
keywords: opprette tilbudsdokument, endre tilbudsdokument, tilbudsdokument, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/quote/learn/create-quote-document
---

# Opprette tilbudsdokument

Etter at du har opprettet tilbudet og lagt til produktene, kan du generere tilbudsdokumentet. Dette er "brevet" som sendes til kunden. Produktlisten legges automatisk til når tilbudet sendes til kunden.

Du kan opprette dokumentet enten fra detaljkortet **Tilbud** i salget, eller fra dialogboksen **Rediger tilbud**.

> [!TIP]
> Bruk [en mal med tilbudsspesifikke flettefelt][3] for å inkludere tilbudsdetaljer i dokumentet.

## Opprette tilbudsdokumentet

1. Hvis du allerede redigerer tilbudet, klikker du på **Klikk for å opprette tilbudsdokument** øverst i dialogboksen **Rediger tilbud**.

    *Alternativt* går du til detaljkortet **Tilbud** i salget og klikker på **Klikk for å opprette tilbudsdokument**.

    > [!NOTE]
    > Tilbudet må ha status **Utkast**. Hvis det allerede er sendt, må du først [opprette en ny versjon][1].

1. Fyll ut nødvendige felter i dialogboksen **Dokument**. Se [veiledning for dokumentfeltene][2].

1. Klikk på **Opprett** for å generere dokumentet basert på den valgte malen.

1. Rediger innholdet i Word (eller annet standard redigeringsprogram), og lagre og lukk filen.

    Dokumentet vises i detaljkortet **Tilbud** og er koblet til tilbudet. Det legges også til i detaljkortet **Aktiviteter** i salget (og vises også i Firma og Dagbok).

## <a id="replace"></a>Erstatte tilbudsdokumentet

Hvis du vil endre innholdet eller malen for tilbudsdokumentet, kan du velge én av følgende metoder:

### Alternativ 1: Erstatt kun filen

Bruk denne metoden hvis du vil beholde dokumentets metadata, men laste opp en oppdatert fil fra datamaskinen.

1. Klikk på dokumentet i detaljkortet **Tilbud**.

2. Fjern merkingen for **Fullført**.

3. Klikk på **Erstatt**, velg den nye filen og last opp.

4. Klikk på **Lagre**.

### Alternativ 2: Slett og opprett nytt dokument

Bruk denne metoden hvis du vil slette det gamle dokumentet og starte helt på nytt.

1. Klikk på dokumentet i detaljkortet **Tilbud**.

2. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> og velg **Slett** i menyen **Oppgave**.

3. Klikk på **Klikk for å opprette tilbudsdokument** for å generere en ny fil.

### Alternativ 3: Opprett og koble et nytt dokument

Bruk denne metoden for å opprette et nytt dokument manuelt med ønsket mal, og deretter koble det til tilbudet. Det gamle dokumentet beholdes.

1. Klikk på **Ny** i toppmenyen og velg **Dokument**.

2. I dialogboksen **Dokument** velger du en tilbudsmal og salget som dokumentet skal kobles til, og klikker deretter **Opprett**.

3. Gå til detaljkortet **Tilbud** og klikk på **Åpne**.

4. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> og velg **Endre tilbudsdokument** fra menyen **Oppgave**.

5. Velg det nye dokumentet fra listen.

    Listen viser alle dokumenter som er registrert som tilbudsdokumenter for det aktuelle salget.

> [!TIP]
> Ved mindre justeringer kan du åpne eksisterende dokument, gjøre endringer og lagre. Det er ikke nødvendig å erstatte filen eller slette dokumentet.

## Hvordan tilbudsmaler fungerer

Maler for tilbudsdokumenter, tilbudsdetaljer og ordrebekreftelser fungerer litt annerledes enn vanlige dokumentmaler. De bruker **flettefelt** i tillegg til standardmalvariabler.

* Hvis flettefeltet `<<QuoteDetails>>` finnes i hoveddokumentet, settes tilbudsdetaljene inn på det stedet.
* Hvis flettefeltet `<<QuoteDetails>>` ikke finnes, legges tilbudsdetaljene til på slutten av dokumentet.

## Relatert innhold

* [Sende tilbud][4]
* [Registrere ordre][5]
* [Redigere dokument][2]
* [Maler for tilbudsdokumenter][6]
* [Malvariabler og flettefelt][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[4]: send.md
[5]: place-order.md
[6]: ../../../document/templates/learn/quote-templates.md
