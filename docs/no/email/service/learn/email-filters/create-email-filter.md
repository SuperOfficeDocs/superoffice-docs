---
uid: help-no-email-filter-create
title: Opprette e-postfiltre
description: Opprette e-postfiltre
keywords: e-post, e-postfilter, filter
author: SuperOffice RnD
date: 07.17.2024
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Opprette e-postfilter

1. [!include[Go to email](../includes/goto-email.md)]

1. Velg fanen **E-postfiltre**.

1. Klikk på **Nytt e-postfilter**. Skjermbildet **Egenskaper for e-postfilter** vises.

1. På **Filter**-fanen kan du spesifisere hvilke e-postmeldinger som skal filtreres, ved å skrive inn følgende informasjon:

    * **Beskrivelse**: Skriv inn en kort beskrivelse av e-postfilteret.
    * **Prioritet**: I denne listeboksen velger du filterets prioritet. Verdien 100 gir høyest prioritet, og 1 gir lavest.
    * **Skript**: Her kan du velge et [skript eller en makro][1] som skal kjøres av dette filteret.

1. Velg hva filteret gjelder for:

    * **Alle innkommende e-poster**: Hvis du velger dette alternativet, brukes e-postfilteret for alle innkommende e-postmeldinger.
    * **E-post som inneholder**: Hvis du velger dette alternativet, vil e-postmeldinger som inneholder det faste uttrykket (regexp) som er angitt i feltene til høyre, utløse e-postfilteret. Du kan velge mellom e-postens topptekst og / eller e-postteksten.

1. På fanen **Finn regulære uttrykk** kan du definere regulære uttrykk som finner tekst i e-postmeldinger, og lagre dem som variabler. For å tilordne verdien fra et regulært uttrykk til en variabel kalt myVariable, bruk følgende format: myVariable =&lt;regexp&gt; .

1. I fanen **Angi koblinger** kan du angi hvordan innkommende e-post skal knyttes til en sak og/eller en person på grunnlag av e-postinnholdet:
    * **Koble til person hvor**: For å koble den genererte saken til en person basert på informasjon fra e-posten, velger du et av kontaktfeltene fra listen, og skriv deretter inn et regulært uttrykk som returnerer verdien som identifiserer personen.
    * **Koble til sak hvor**: Her kan du koble e-posten til en eksisterende sak basert på et regulært uttrykk som trekker ut data fra e-posten.

1. I fanen **Angi verdier** kan du legge til eller erstatte verdier for personer, firmaer og saker, basert på innholdet i e-postmeldingen:
    1. I listeboksen til venstre velger du ønsket felt for personen, firmaet eller saken.

    2. I feltet til høyre angir du ett av følgende:
        * det vanlige uttrykket (regular expression) som finner verdien som skal angis
        * en fast verdi (må ha prefikset =)

    3. Hvis du merker av for **Overskriv**, erstatter verdien som eventuelt blir funnet, en eksisterende verdi.

    4. Klikk på **Legg til** for å legge til verdien.

        > [!TIP]
        > Du kan slette en verdi igjen ved å velge den og klikke på <i class="ph ph-x-circle" aria-label="Remove icon"></i>.

1. I fanen **Angi egenskaper** kan du angi bestemte egenskaper for saker som genereres fra e-postmeldinger som samsvarer med det gjeldende filteret:

1. På fanen **E-postsvar** kan du opprette forskjellige e-postmeldinger som skal sendes når filteret utløses. Her kan du angi følgende informasjon:
    * **Send svarmal**: Her kan du velge hvilken [svarmal][2] som skal sendes hvis filteret utløses.
    * **... til person**: Hvis det er merket av, sendes den valgte svarmalen tilbake til personen.
    * **... til**: Hvis merket av, sendes den valgte svarmalen til e-postadressen som er angitt i feltet til høyre.
    * **Foreslå FAQ-oppføringer fra**: Hvis merket av, vil systemet [foreslå FAQ-oppføringer basert på teksten][3] i innkommende e-post. De foreslåtte oppføringene er tilgjengelige som malvariabler, og kan derfor gjentas i den valgte svarmalen. Du kan også angi hvilken gren av FAQ-treet det skal søkes i, ved å angi ønsket mappe.
    * **Ikke send automatisk svar**: Hvis merket av, vil ikke systemet svare automatisk på denne e-posten.

1. I kategorien **E-postbokser** kan du velge hvilke postbokser filteret skal gjelde for.

1. Klikk på **OK**. E-postfilteret opprettes.

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/index.md
[2]: ../../../../request/reply-templates/learn/index.md
[3]: ../../../../request/reply-templates/learn/create.md#faq
