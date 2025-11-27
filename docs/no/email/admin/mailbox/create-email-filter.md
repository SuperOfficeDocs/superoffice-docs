---
uid: help-no-email-filter-create
title: E-postfiltre
description: Opprette e-postfiltre
keywords: e-post, e-postfilter, filter
author: digitaldiina
date: 11.27.2025
version: 11.6
content_type: howto
category: email
topic: Service mailbox
license: serviceessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: no
redirect_from:
  - /no/email/service/learn/email-filters/delete-email-filter
  - /no/email/service/learn/email-filters/create-email-filter
---

# E-postfiltre

## Opprette e-postfilter

1. [!include[Go to email](includes/goto-email.md)]

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

1. I fanen **Angi egenskaper** kan du angi bestemte egenskaper for saker som genereres fra e-postmeldinger som samsvarer med det gjeldende filteret. Se egenskaper nedenfor.

1. På fanen **E-postsvar** kan du opprette forskjellige e-postmeldinger som skal sendes når filteret utløses. Her kan du angi følgende informasjon:
    * **Send svarmal**: Her kan du velge hvilken [svarmal][2] som skal sendes hvis filteret utløses.
    * **... til person**: Hvis det er merket av, sendes den valgte svarmalen tilbake til personen.
    * **... til**: Hvis merket av, sendes den valgte svarmalen til e-postadressen som er angitt i feltet til høyre.
    * **Foreslå FAQ-oppføringer fra**: Hvis merket av, vil systemet [foreslå FAQ-oppføringer basert på teksten][3] i innkommende e-post. De foreslåtte oppføringene er tilgjengelige som malvariabler, og kan derfor gjentas i den valgte svarmalen. Du kan også angi hvilken gren av FAQ-treet det skal søkes i, ved å angi ønsket mappe.
    * **Ikke send automatisk svar**: Hvis merket av, vil ikke systemet svare automatisk på denne e-posten.

1. I kategorien **E-postbokser** kan du velge hvilke postbokser filteret skal gjelde for.

1. Klikk på **OK**. E-postfilteret opprettes.

## Egenskaper for genererte saker

* **Angi eier**: Hvis merket av, kan du velge hvilken bruker som skal tildeles e-postmeldinger behandlet av dette filteret.

* **Angi kategori**: Hvis du merker av her og velger en kategori, vil e-post som behandles av dette filteret havne i den angitte kategorien.

* **Saksstype**: Hvis du sjekker her og velger en type, vil e-post som behandles av dette filteret bli tildelt den angitte [sakstypen][4].

* **Angi prioritet**: Hvis du merker av her og velger en prioritet, vil e-post behandlet av dette filteret bli tildelt den angitte prioriteten.

* **Angi tilgangsnivå**: Hvis du merker av her og velger et tilgangsnivå fra listen, vil e-post som behandles av dette filteret, bli tildelt det angitte tilgangsnivået. Hvis du velger **Ekstern,**, vil den genererte saken være tilgjengelig i SuperOffice kundesenter.

* **Sett opp melding**: Hvis du merker av her og velger en svarmal, vil saksmeldingen settes opp i henhold til den valgte malen, sammenslått med alle de faste uttrykkene som ble funnet. Du kan bruke dette til å presentere et skjema, som sendes på e-post, og er mye ryddigere. Denne meldingen vil erstatte den opprinnelige e-posten.

* **Avslutt sak**: Hvis merket av, lukkes saken umiddelbart og tilordnes statusen **Lukket**.

* **Ignorer avsenderadresse**: Hvis dette alternativet er valgt, ignorerer SuperOffice Service den opprinnelige avsenderadressen. Saken blir da ikke koblet til en person med mindre andre regler i e-postfilteret oppretter en kobling til en person.

* **Blokker e-post**: Hvis dette er valgt, importeres ikke e-posten til SuperOffice Service. Den legges i stedet til listen i fanen **Blokkert e-post**.

* **Slett e-post permanent**: Hvis merket av, slettes e-posten permanent.

    > [!NOTE]
    > Det er ikke mulig å gjenopprette e-postmeldinger som er slettet permanent.

* **Videresend til**: Hvis du merker av her og skriver inn en e-postadresse, blir e-posten videresendt til denne adressen.

* **Inkluder feilsøkingsinformasjon i meldingen**: Hvis dette alternativet er valgt, inneholder meldingen feilsøkingsdata som du kan bruke til å kontrollere at e-postfilteret fungerer som det skal.

* **Merk e-post som returnert**: Hvis dette er valgt, vil e-post som behandles av dette filteret bli merket som returnert. Dette kan være relevant for e-postmeldinger mottatt fra postmester, mailer-daemon og så videre.

## <a id="delete"></a>Slett e-postfilter

1. Velg fanen **E-postfiltre**.

1. Klikk på ønsket e-postfilter. Skjermbildet **Egenskaper for e-postfilter** vises.

1. Klikk på **Slett**-knappen nederst i bildet.

1. Klikk på **OK** for å bekrefte. E-postfilteret fjernes fra SuperOffice Service.

<!-- Referenced links -->
[1]: ../../../customization/macros-and-scripts/admin/index.md
[2]: ../../../knowledge-base/learn/reply-templates/index.md
[3]: ../../../knowledge-base/learn/reply-templates/create.md#faq
[4]: ../../../request/admin/type/index.md
