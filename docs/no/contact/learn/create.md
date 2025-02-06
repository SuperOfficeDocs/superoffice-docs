---
uid: help-no-contact-create
title: Opprett en ny person
description: Slik oppretter du en ny person i SuperOffice CRM.
keywords: opprett person, interesser, Interesser-fanen, personbilde, foretrukket språk, hjemmel, person, kontakt
author: Bergfrid Dias
date: 01.27.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Opprett en ny person

Du kan legge til en person i SuperOffice CRM på flere måter:

* Fra **toppraden** eller **Firma-bildet** (se trinn nedenfor).
* [Skann et visittkort][1] med SuperOffice Mobile CRM-appen.
* [Masseimporter personer][2] (krever administratorrettigheter).

## Trinn

1. **Åpne Person-bildet:**

    * Klikk på **Ny** i toppraden, og velg **Person**.
    * Eller, gå til ønsket firma i **Firma-bildet**, velg detaljekortet **Personer**, og klikk på **Legg til**-knappen.

1. **Oppgi grunnleggende personopplysninger:**

    * Skriv inn **Fornavn** og/eller **Etternavn** (obligatorisk: minst ett felt må fylles ut).
    * Valgfritt: Velg **Titulering** (***Hr/Fr***).
    * Velg **Firma**:
      * Begynn å skrive for å søke etter et firma, eller velg **(Ingen valgt)** hvis personen ikke er knyttet til et firma.
    * Valgfritt: Legg til et **Personbilde** ved å dra en bildefil til bildefeltet eller høyreklikke for å laste opp.

    ![Tomt personkort med obligatoriske felter Fornavn og Etternavn uthevet og valgfrie felter som Tittel og Firma -screenshot][img1]

1. Fyll ut feltene i **Person-fanen**:

    * Fyll ut **Land**. Dette oppdaterer adresseformatet automatisk basert på landet. Standardland er firmaets registrerte land.
    * Legg inn andre opplysninger som **Mobil** og **E-post**.

1. Legg til ytterligere informasjon i **Detaljer-fanen** (valgfritt):

    * Skriv inn nøkkelopplysninger som **Stilling**, **Fødselsdato** og **Foretrukket språk**.
    * Legg til spesifikke kommunikasjonsdetaljer: **Nettside**, **Chatsamtale** og **Internett-tlf.** (f.eks. Skype eller Microsoft Teams).
    * Hvis relevant, angi Serviceprioritet og velg en "Vår servicekontakt" (krever SuperOffice Service-lisens).

    ![Detaljer-fanen med tilleggsfelter -screenshot][img2]

1. Gå til **Interesser-fanen** for å sette interesser og abonnementer:

    * Merk av for relevante interesser (definert i Innstillinger og vedlikehold).
    * Konfigurer **E-markedsføring/abonnementer** for å sikre lovlig samtykke til e-postkampanjer.

1. **Se gjennom personverninnstillinger:**

    * Klikk på **Hjemmel** nederst på personkortet for å [se gjennom eller oppdatere GDPR-samtykke][7] og personvernsinformasjon. Klikk på **Lukk** når du er ferdig.

1. **Marker som tidligere ansatt** (valgfritt):

    * Merk av for **Tidligere ansatt** hvis personen har forlatt firmaet. Tidligere ansatte vises ikke i kontaktlister eller prosjekter.

1. Klikk på **Lagre** for å lagre personopplysningene.

Opplysningene lagres i databasen og vises på personkortet. Hvis personen er tilknyttet et firma, vises de i detaljkortet **Personer** i Firma-bildet.

## <a id="fields"></a>Forklaring av nøkkelfelt

Nedenfor finner du en oversikt over feltene i personkortet. Enkelte felt fylles ut automatisk, mens andre krever input.

> [!NOTE]
> Felter og layout kan variere avhengig av [Skjermdesigner][9]-konfigurasjon eller andre tilpasninger.

<!-- markdownlint-disable-file MD051 -->
### [Person-fanen](#tab/person)

**Grunnleggende informasjon:**

* **Fornavn/Etternavn:** Minst ett av disse feltene må fylles ut (obligatorisk).
* **Titulering:** Valgfritt. Velg **Hr/Fr** basert på personens preferanser.
* **Tittel:** Skriv inn personens stilling eller jobbtittel.

* **Kontaktinformasjon**

* **E-post:** Legg til flere e-postadresser med beskrivelser som *Arbeid* eller *Privat*.
* **Mobil/Direkte telefon:** Legg til flere telefonnumre med etiketter som *Mobil* eller *Arbeid*.
  * Trykk **TAB** eller klikk utenfor tabellen for å lagre oppføringer.

**Adresse:**

* **Hjemmeadresse:** Fyll ut personens adresseopplysninger.
  * Adresseformatet oppdateres automatisk basert på feltet **Land**.
* **Land:** Angir personens land. Standard er landet firmaet er knyttet til.
* **Bruk som postadresse:** Marker dette feltet hvis post skal sendes til personens adresse i stedet for firmaets.

**Arvede felter:**

* **Vår kontakt:** Tildeler automatisk navnet ditt. Klikk på pilen for å velge noen andre i organisasjonen.
* **Kategori:** Velg fra en forhåndsdefinert liste. Standard er firmaets kategori, hvis det er tilknyttet.
* **Bransje:** Velg den relevante bransjetypen. Standard er firmaets bransjetype, hvis det er tilknyttet.

**Systemfelter:**

* **Nummer:** Genereres automatisk som neste ledige personnummer hvis det er konfigurert i **Innstillinger og vedlikehold**. Du kan redigere dette manuelt om nødvendig.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Detaljer-fanen](#tab/details)

**Personlige opplysninger:**

* **Posisjon:** Velg personens stilling eller jobbtittel fra en forhåndsdefinert liste (konfigurert i **Innstillinger og vedlikehold**).
* **Fødselsdato:** Legg til personens fødselsdato.

**Kommunikasjonsopplysninger:**

* **Webside:** Skriv inn en URL til personens nettside, LinkedIn, Facebook eller andre sider. Inkluder en tittel for tydelighet.
* **Chatsamtale:** Legg til adresser for chatteprogrammer (for eksempel Microsoft Teams, Google Chat). Velg en tjenesteleverandør fra listen.
* **Internett-tlf.:** Legg til en VOIP-adresse, som Skype eller en annen internettbasert telefontjeneste.
* **Direkte faks:** Skriv inn personens faksnummer.

**Service-spesifikke felter** *(krever SuperOffice Service- eller Kundesenter-lisens)*

* **Foretrukket språk:** Velg personens foretrukne språk for alle svarmaler.
* **Serviceprioritet:** Angi prioriteten for nye saker (for eksempel Lav, Middels, Høy eller egendefinert). Standard er firmaets prioritet hvis den ikke er angitt.
* **Vår servicekontakt:** Velg en serviceansvarlig for å håndtere denne personens saker.

**Private felter:**

* **Privat**: Legg til private telefonnumre eller kontaktopplysninger som ikke er tilknyttet firmaet.

### [Mer-fanen](#tab/more)

Legg inn eventuelle [brukerdefinerte felter][12] som er spesifikke for CRM-oppsettet ditt.

### [Interesser-fanen](#tab/interests)

**Interesser og abonnementer:**

* **Interesser:** Marker personens interesser ved å krysse av for relevante bokser. Interesser brukes til å lage målrettede utvalg, for eksempel til utsendelser eller kampanjer.

  * Interesser er forhåndsdefinert i **Innstillinger og vedlikehold**.
  * En prikk vises ved siden av fanen **Interesser** når én eller flere interesser er valgt.

* **E-markedsføring/abonnementer:** Administrer samtykke til å sende e-postkampanjer.

  * Hvis personen har gitt samtykke, aktiveres **E-markedsføring** for å bekrefte lovlig samtykke. Dette angir automatisk hjemmel som **Berettiget interesse**.
  * Spesifiser abonnementsformer for å bestemme hvilke typer e-markedsføring personen ønsker å motta.
  * Abonnementsinnstillinger kan også justeres av personen via en kundeportal.

### [Notat-fanen](#tab/note)

[Legg til fritekstnotater][5] om personen.

***

## <a id="interests-tab"></a>Legg til interesser

Interesser er nyttige for å opprette målrettede utvalg, for eksempel markedsføringskampanjer for spesifikke grupper. Hvis du for eksempel definerer *referansekunde* som en interesse, kan du raskt opprette et utvalg med alle referansekunder.

1. Gå til fanen **Interesser**.

1. I redigeringsmodus velger du relevante interesser ved å krysse av i boksene. Tilgjengelige valg er definert i **Innstillinger og vedlikehold**.

1. Hvis du velger én eller flere interesser, vises en prikk ved siden av fanens navn.

1. Klikk på **Lagre** for å lagre endringene.

## Tips

* Du kan legge til flere telefonnumre, e-poster og andre oppføringer med beskrivelser (for eksempel Sentralbord).

    Hvis du klikker på personens e-postadresse i fanen **Person**, kan du velge den ønskede e-postadressen fra listen som vises. En tom e-post med valgt adresse i feltet **Til** åpnes.

* Bruk telefonikonet for å ringe direkte, hvis systemet ditt er konfigurert for det.

* Hvis personen er knyttet til et firma, arver felter som **Kategori**, **Bransje** og **Vår kontakt** verdier fra firmaet og kan ikke redigeres.

* Gå til detaljkortet [Relasjoner][8] for å knytte denne personen til andre firmaer eller personer.

## Aktuelle emner

* [Skann et visittkort][1] med SuperOffice Mobile CRM-appen
* [Legg til som favoritt][4]

<!-- Referenced links -->
[1]: ../../../en/mobile/superoffice-mobile/company-contact/scan-business-card.md
[2]: ../../admin/import/learn/index.md
[4]: ../../learn/basics/fav.md
[7]: ../../security/privacy/learn/edit-legal-base.md
[8]: ../../learn/basics/relations.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/new-contact.png
[img2]: ../../../media/loc/en/contact/contact-details.png
