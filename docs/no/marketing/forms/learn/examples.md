---
uid: help-no-forms-examples
title: Hvordan opprette skjemaer (eksempler)
description: Hvordan opprette skjemaer (eksempler)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Skjemaer
so.topic: concept
language: no
---

# Hvordan opprette skjemaer (eksempler)

La oss se på to egendefinerte skjemaer som kan være relevante for firmaet ditt:

* [Påmelding til nyhetsbrev](#newsletter-sign-up): La kundene melde seg på ett eller flere av nyhetsbrevene dine.
* [Kontakt meg](#contact-me): Bruk et "kontakt meg"-skjema til å åpne en ny kommunikasjonskanal med dine kunder eller prospekter. Bruk dette skjemaet til å generere supportsaker eller opprette kundeemner for salgsteamet.

Eksemplene dekker ikke alle felt og alternativer, men du finner omfattende instruksjoner i [Opprette et nytt skjema][1].

## Hva er dobbel opt-in?

Med dobbel opt-in må kundene bekrefte e-postadressen sin ved å klikke på koblingen i en bekreftelses-e-post i tillegg til å sende inn skjemaet.

Dette alternativet legger til et ekstra sikkerhetslag i skjemaet. Hvis du aktiverer dette alternativet, må personen som sender inn skjemaet, også bekrefte e-postadressen sin. Dette gjøres ved å sende dem en e-post når de sender inn skjemaet. E-posten inneholder en kobling de må klikke på for å bekrefte at e-postadressen er riktig.
Koblingen er gyldig i 30 minutter som standard.

## <a id="newsletter-sign-up" />Påmelding til nyhetsbrev

Dette skjemaet lar kundene melde seg på ett eller flere av dine nyhetsbrev. Registreringsprosessen vil også inkludere dobbel opt-in for å eliminere feilaktige eller falske abonnementer.

1. Åpne SuperOffice CRM og opprett et statisk utvalg av firmaer/personer som heter "nyhetsbrevabonnenter (skjema)". Vi vil bruke dette utvalget senere i veiledningen.

1. Åpne SuperOffice Markedsføring og gå til **Skjemaer**-fanen.

1. Velg **Skjema** under **Opprett nytt** på høyre side av skjermbildet. Bildet **Rediger skjema** vises.

1. Skriv inn "nyhetsbrevregistrering" i feltet **Skjemanavn**.

1. Fyll ut relevante alternativer/felt i kategorien **Egenskaper**. IKKE aktiver noen alternativer under **Deaktiver skjema automatisk.**

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. Klikk på ![icon][img1] I **Felt**-kategorien, og legg til følgende felt:

    * For- og etternavn (fjern **Person – Navn-feltet**)
    * **Person - E-post** (gjør dette feltet obligatorisk)
    * Person - abonnement
        * Velg ett eller flere nyhetsbrev som skal være tilgjengelige
        * Angi feltet som **Obligatorisk**.
        * Endre feltnavnet til "Velg abonnementer".

1. Velg **OK**-feltet og endre navnet til "Send", og rediger skrifttype / bakgrunnsfarge og plassering.

1. Rediger navn på de andre feltene etter behov. **Tips**: Fjern "Person -".

1. Klikk ![icon][img2] øverst i et felt, og dra det til ønsket plassering i skjemaet. Feltene bør ha en logisk rekkefølge.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I **Stil**-kategorien redigerer du oppsettet, fargene, størrelsen og skrifttypene i skjemaet. Vurder å involvere dine webdesignkolleger.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I kategorien **Dobbel opt-in** velger du **Aktiver dobbel opt-in**.

1. I fanen**Melding** skriver du inn teksten som skal vises etter at skjemaet er sendt. Denne meldingen skal informere kunden om at de vil motta en e-postbekreftelse. Klikk **Vis/skjul verktøylinje** ![icon][img3] for å vise formateringsalternativer for teksten.

    <details><summary>Eksempel</summary>

    Vi vil nå sende en e-post til adressen du registrerte i skjemaet vårt.

    Klikk på koblingen i e-posten for å bekrefte e-postadressen din og aktivere abonnement(ene) dine.

    Med vennlig hilsen,

    SuperShop
    </details>

1. I **E-post**-fanen oppretter du e-postbekreftelsen som sendes til personene som sender skjemaet.

    <details><summary>Eksempel</summary>

    Hei og takk for din interesse for våre nyhetsbrev

    Klikk på lenken nedenfor for å bekrefte e-postadressen din og starte abonnementet.

    Klikk her for å bekrefte e-postadressen din

    Med vennlig hilsen,

    SuperShop-teamet
    </details>

1. Klikk **Vis/skjul verktøylinje** ![icon][img3] og klikk deretter **Sett inn, bekreftelseskobling** ![icon][img4]. Bekreftelseskoblingen settes inn i brødteksten.

1. Klikk på bekreftelseskoblingen, og velg **Rediger kobling** ![icon][img5], endre deretter koblingsteksten til "Klikk her for å bekrefte e-postadressen din". Koblingen er gyldig i 30 minutter som standard.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I kategorien **Takkeside** kan du enten omdirigere kunden til en webside eller vise en melding (for eksempel "Takk for at du abonnerer"). Dette vises etter at kunden har bekreftet e-postadressen sin.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I **Side for inaktivt skjema**-kategorien, skriver du inn en URL eller en melding. Dette er relevant hvis en kunde åpner skjemaet etter at det er satt til inaktivt.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I kategorien **Handlinger** må du angi hvilke handlinger som skal utføres når skjemaet behandles:

    * Ikke velg **Opprett sak**. Abonnementene vil aktiveres automatisk, slik at ingen handling kreves av kundestøtteteamet.

    * Velg **Manuelt – hvis innsender er ukjent. Automatisk – hvis innsender er kjent**: Hvis e-postadressen som er oppgitt i skjemaet, samsvarer med en e-postadresse i SuperOffice, behandles skjemainnsendingen automatisk. Hvis ikke, behandles den manuelt.

    * **Legg til person i utvalg**: Velg det merkede området du opprettet i trinn 1. Bruk dette valget til å holde orden på kontakter som er lagt til via dette skjemaet.

    * **Legg til interesse for person**: Velg interessen som heter **Nyhetsbrev**. Denne interessen blir lagt til personer som sender dette skjemaet.

    * **E-postsvar**: Velg et skjemasvar som du vil sende til personer når skjemaet deres behandles. Denne e-posten kan for eksempel informere kunden om firmaets personvernpolicy og kan også inneholde en kobling for å administrere abonnementer. [Hvordan oppretter jeg et skjemasvar?][2].

1. Klikk på **Lagre**. Skjemaet lagres og vinduet **Rediger skjema** lukkes.

1. Sett skjemaet til **Aktiv** ![icon][img6] i overskriften.

1. Gå til fanen **Publiser**.

1. Kopier direktekoblingen og/eller JavaScript inn i et nyhetsbrev, en nettside eller et kundesenter for å publisere det til kundene eller prospektene dine.

1. Åpne koblingen til skjemaet, fyll ut skjema og kontroller at alt fungerer som det skal.

## <a id="contact-me" />Kontakt meg

Legg inn et "kontakt meg"-skjema på firmaets nettsider for å tilby en enkel kommunikasjonskanal for eksisterende eller potensielle kunder.

I dette eksempelet vil vi vise deg hvordan du oppretter kortform for kunder som ønsker å komme i kontakt med en kunderepresentant. Skjemainnsendingen vil utløse en ny sak for kundestøtteavdelingen.

1. Åpne SuperOffice Markedsføring og gå til **Skjemaer**-fanen.

1. Velg **Skjema** under **Opprett nytt** på høyre side av skjermbildet. Bildet **Rediger skjema** vises.

1. Skriv inn "kontakt meg (kundestøtte)" i feltet **Skjemanavn**.

1. Fyll ut relevante alternativer/felt i kategorien **Egenskaper**. IKKE aktiver noen alternativer under **Deaktiver skjema automatisk.**

1. Klikk på ![icon][img1] I **Felt**-kategorien, og legg til følgende felt:

    * For- og etternavn. Fjern feltet **Kontakt – Navn**.
    * **Vis elementer** > **Tekstblokk**: Skriv inn teksten under "hvordan kan vi kontakte deg?" med fet skrift.
    * **Kontakt – Mobil**: Skriv inn et eksempel på et riktig formatert telefonnummer for landet ditt (ta med landskoden) i feltet **Plassholder** (eksempel: +47 99 88 77 66).
    * **Person - E-post**
    * **Skjemaelementer** > **Tekstområde**: Endre navnet på feltet til "Kommentar (valgfritt)" og skriv "Hvordan kan vi hjelpe deg i dag?" i **plassholder**-feltet .

1. Velg **OK**-feltet og endre navnet til "Send", og rediger skrifttype / bakgrunnsfarge og plassering.

1. Rediger navn på de andre feltene etter behov. **Tips**: Fjern "Person -".

1. Klikk ![icon][img2] øverst i et felt, og dra det til ønsket plassering i skjemaet. Feltene bør ha en logisk rekkefølge.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. I **Stil**-kategorien redigerer du oppsettet, fargene, størrelsen og skrifttypene i skjemaet. Vurder å involvere dine webdesignkolleger.

1. Klikk **Bruk nå** for å lagre skjemaet og fortsette redigeringen.

1. Valgfritt: For å aktivere dobbel opt-in, bør du også sette **e-postfeltet** til **obligatorisk**.

1. I kategorien **Takkeside** kan du enten omdirigere kunden til en webside eller vise en melding (for eksempel "Takk for at du kontakter oss. Vi tar snart kontakt."). Dette vises etter at kunden har sendt skjemaet.

1. I **Side for inaktivt skjema**-kategorien, skriver du inn en URL eller en melding. Dette er relevant hvis en kunde åpner skjemaet etter at det er merket som inaktivt.

1. I kategorien **Handlinger** må du angi hvilke handlinger som skal utføres når skjemaet behandles:

    * Velg **Opprett sak** og gjør følgende:
        1. Angi en beskrivende tittel for sakene som skal opprettes fra dette skjemaet.
        2. Velg relevant kategori for saken, som for eksempel "Kundestøtte" eller en underkategori kalt "Skjemainnsendinger".
        3. Sett saksprioritet til **Middels**.

    * Velg **Manuelt – hvis innsender er ukjent. Automatisk – hvis innsender er kjent**: Hvis e-postadressen som er oppgitt i skjemaet, samsvarer med en e-postadresse i SuperOffice, behandles skjemainnsendingen automatisk. Hvis ikke, behandles den manuelt.

    * **E-postsvar**: Velg et skjemasvar som du vil sende til personer når skjemaet deres behandles. Denne e-posten kan for eksempel informere kunden om firmaets personvernpolicy og kan også inneholde en kobling for å administrere abonnementer. [Slik oppretter du et skjemasvar][2].

1. Klikk på **Lagre**. Skjemaet lagres og vinduet **Rediger skjema** lukkes.

1. Sett skjemaet til **Aktiv** ![icon][img6] i overskriften.

1. Gå til fanen **Publiser**.

1. Kopier direktekoblingen og/eller JavaScript inn i et nyhetsbrev, en nettside eller et kundesenter for å publisere det til kundene eller prospektene dine.

1. Åpne koblingen til skjemaet, fyll ut skjemaet og kontroller at alt fungerer som det skal.

## Hva skjer nå?

* [Skjemainnsendinger][3]
* [Spore skjemainnsendinger og vise statistikk][4]
* [Behandle skjemainnsendinger][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
