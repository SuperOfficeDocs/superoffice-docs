---
uid: help-no-sale-create
title: Registrer et salg
description: Registrer salg i SuperOffice Salg for å ha alle muligheter og kundeinformasjon på ett sted. Denne veiledningen viser deg hvordan du registrerer salg.
keywords: opprett salg, nytt salg, legg til salg, registrer salg, salg
author: Bergfrid Dias
date: 02.03.2025
version: 10.5.2
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Registrer et salg

Du kan opprette et salg i SuperOffice CRM ved å bruke **Ny**-knappen i toppraden. Se denne videoen eller følg trinnene nedenfor for å registrere et salg:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/7Am9pqMyHSA]

(videolengde – 2:10)

## Trinn

1. Klikk på **Ny** i toppraden og velg **Salg**.

1. Skriv inn en **salgstittel** (obligatorisk, markert i rødt). Dette er hovedidentifikatoren for salget.

    ![Salg-fanen som viser grunnleggende felter i salgskortet -screenshot][img1]

1. Angi **Beløp og valuta** for å estimere salgsverdien.

1. Velg **Salgstype** fra nedtrekkslisten (obligatorisk). Salgstyper definerer prosessen og kan inkludere faser eller guider. Verdiene er forhåndsdefinerte i **Innstillinger og vedlikehold**.

1. (Valgfritt) Legg til mer informasjon i **Salg**-fanen, for eksempel:
    * Knytt salget til et **Firma**.
    * Koble salget til et pågående **Prosjekt**.
    * Juster forventet salgsdato.
    * Bruk tekstfeltet for å gi en beskrivelse av salget.
    * Velg gjeldende **Fase** for salget. Faser viser fremdriften i salget.

    > [!NOTE]
    > Hvis salgstypen ikke har noen tilknyttede faser, vil salget ha status **Åpent**.

1. Velg fanen **Detaljer** for å legge til økonomiske opplysninger som kostnad, fortjeneste og konkurrenter.

1. **Legg til flere detaljer:**
    * Gå til fanen **Mer** for å [legge inn brukerdefinerte felt][12].
    * Gå til fanen **Notat** for å [legge til notater][11].
    * Gå til fanen **Koblinger** for å [knytte aktiviteter, dokumenter eller nettsider][10] til salget.

1. Klikk på **Lagre** for å lagre salget. Salgskortet er nå opprettet.

## <a id="fields"></a>Viktige felter forklart

Følgende felter er tilgjengelige i salgskortet. Noen fylles inn automatisk, mens andre krever manuell inndata.

> [!NOTE]
> Felt og oppsett kan variere basert på **Skjermdesigner**-konfigurasjoner og andre UI-tilpasninger.

<!-- markdownlint-disable MD051 -->
### [Salg-fanen](#tab/sale)

* **Tittel:** Obligatorisk felt for å identifisere salget.
* **Beskrivelse:** Valgfritt tekstfelt for oppsummering av salget.
* **Salgstype:** Forhåndsdefinerte typer som definerer prosessen, potensielt koblet til faser eller salgsguider. Angis i **Innstillinger og vedlikehold**.
* **Fase:** Viser fremdriften i salget. Tilgjengelige faser avhenger av valgt salgstype.
* **Beløp og valuta:** Estimert verdi av salget. *(Valuta må aktiveres i Innstillinger og vedlikehold for å være tilgjengelig.)*
* **Sannsynlighet:** Sannsynlighet for at salget lykkes. Basert på gjeldende fase, men kan oppdateres manuelt.
* **Firma:** Firmaet tilknyttet salget.
* **Person:** Kontaktpersonen hos firmaet som er knyttet til salget.
* **Prosjekt:** Kobler salget til et pågående prosjekt.
* **Eier:** Brukeren som er ansvarlig for salget. Standardverdi er innlogget bruker, men kan endres.
* **Salgsdato:** Forventet avslutningsdato for salget.
* **Neste aktivitet:** Automatisk fylt med den eldste ufullførte oppfølgingen. Datoer før dagens dato vises i rødt.
* **Utsatt avkrysningsboks:** Merker salget som satt på vent og aktiverer feltene for **Gjenåpningsdato** og **Årsak (utsatt)**.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Detaljer-fanen](#tab/details)

Fanen **Detaljer** fokuserer på økonomiske detaljer for salget.

* **Nummer:** Automatisk generert salgs-ID.
* **Kilde:** Viser kilden til salget.
* **Konkurrent:** Velg en forhåndsdefinert konkurrent knyttet til salget. Du kan bare angi én konkurrent.
* **Total kostnad:** Kostnad forbundet med salget (i samme valuta som beløpet). Oppdaterer fortjenesten automatisk.
* **Fortjeneste:** Fortjeneste beregnet basert på salgsbeløp og kostnad.
* **Kreditert:** Tildeler salget til en avdeling som er ansvarlig for det.

Verdier for *Konkurrent* og *Kreditert* defineres i Innstillinger og vedlikehold.

### [Koblinger- og Notat-fanene](#tab/other)

* **Koblinger-fanen:** Knytt relevante aktiviteter, dokumenter eller andre salg.
* **Notat-fanen:** Legg til fritekstnotater for å spore ekstra informasjon.

***
<!-- markdownlint-enable MD051 -->

## Relatert innhold

* [Opprett et tilbud][4]
* [Oppdater et salg][1]
* [Arbeide med salgsguider][2]

<!-- Refererte lenker -->
[1]: update.md
[2]: sales-guides.md
[4]: ../../quote/learn/create.md
[10]: ../../learn/basics/links.md
[11]: ../../learn/basics/notes.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Refererte bilder -->
[img1]: ../../../media/loc/en/sale/create-sale.png
