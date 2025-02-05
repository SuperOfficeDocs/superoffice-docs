---
uid: help-no-company-create
title: Opprett et nytt firma
description: Opprett et nytt firma
keywords: opprett firma, legg til interesse, Interesser-fanen, firma
author: Bergfrid Dias
date: 01.23.2025
version: 10.5.1
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Opprett et nytt firma

I **Firma-bildet** kan du opprette og administrere firmaposter, inkludert brukerdefinerte felt og tilleggsdata. Se denne [videoveiledningen om hvordan du oppretter et firma][1].

## Steg for å opprette et firma

1. Klikk på **Ny** i toppraden, og velg **Firma**.

1. I fanen **Firma**:
    * Fyll ut **Firmanavn** (obligatorisk, markert med rød tekst).
    * Angi **Land**. Dette oppdaterer adresseformatet automatisk for det valgte landet. Standardlandet er forhåndsvalgt basert på preferansene dine, men kan endres i **Personlige innstillinger** > **Preferanser** > **Systemet**.
    * Fyll ut eventuelle andre felter som **Postnummer**, **Telefon**, **E-post** og **Webside**.

    ![Tomt firmakort med obligatoriske og valgfrie felt. -screenshot][img1]

1. Velg kategori og bransjetype i feltene **Kategori** og **Bransje**. Begge er obligatoriske for å kunne lagre posten.

1. (Valgfritt) Legg til flere detaljer:
    * Gå til fanen **Mer** for å [fylle ut brukerdefinerte felt][12].
    * Gå til fanen **Interesser** for å [spesifisere interesser](#interests-tab).
    * Gå til fanen **Notat** for å [legge til notater][5].

1. Klikk på **Lagre** for å sikre at all informasjon blir lagret.

## <a id="fields"></a>Forklaring av nøkkelfelter

Følgende felter er tilgjengelige på firmakortet. Noen felter fylles ut automatisk, mens andre krever input.

> [!NOTE]
> Felter og oppsett kan variere avhengig av konfigurasjoner i [Skjermdesigner][9] og andre tilpasninger i brukergrensesnittet.

* **Avdeling:** Spesifiser en avdeling hvis firmaet har flere grener eller divisjoner.
* **Adressefelt:** Tilpasses automatisk basert på valgt land.
* **Postnummer og sted:** Hvis du skriver inn et postnummer som finnes i SuperOffice-databasen, fylles stedsnavnet ut automatisk hvis feltet er tomt. Du kan også skrive inn et stedsnavn manuelt, og et postnummer blir foreslått.
* **Telefon/Faks/E-post/Webside:** Skriv inn flere oppføringer med beskrivelser, som *Sentralbord*. Klikk utenfor tabellen eller trykk TAB for å lukke innskrivingsfeltet.
* **Vår kontakt:** Tildeler automatisk navnet ditt. Klikk på pilen for å velge en annen person fra organisasjonen din.
* **Hovedkontakt:** Velg personen som skal være primærkontakt for denne klienten. Personer må først legges til firmaet for å kunne velges.
* **Kode:** Genereres automatisk etter at firmaet er lagret, basert på firmanavnet. Koden kan endres manuelt.
* **Nummer:** Tildeler automatisk neste tilgjengelige firmanummer. Standard startnummer er 10001, som øker med 1 for hvert nytt firma. Denne innstillingen kan endres i Innstillinger og vedlikehold.
* **Org.nr.:** Angi firmaets organisasjonsnummer.
* **Stopp** og **Ingen utsendelser**-avmerkingsbokser:
  * **Stopp:** Indikerer at firmaet krever spesiell oppmerksomhet. Hvis du velger **Stopp**, vises et stoppskilt på firmakortet. Du kan også legge til et notat som forklarer hvorfor firmaet er markert. Kun tilgjengelig i redigeringsmodus.
  * **Ingen utsendelser:** Hindrer at firmaet mottar direktepost. Denne innstillingen er kun tilgjengelig i redigeringsmodus.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Duplikatkontroll

Hvis du registrerer et firma som ligner på et som allerede finnes i SuperOffice CRM, vises dialogboksen **Duplikater**. Dette hjelper deg med å unngå [utilsiktet registrering av eksisterende firma][2].

* Gjennomgå de foreslåtte duplikatene for å sikre konsistens og unngå unødvendige poster.
* Velg om du vil fortsette med den nye oppføringen eller bytte til en av de foreslåtte firmaene.

## <a id="interests-tab"></a>Legg til interesser

Interesser hjelper deg med å lage målrettede utvalg. Du kan for eksempel definere *referansekunde* som en interesse og lage et utvalg for markedsføringskampanjer rettet mot denne kundegruppen.

1. Gå til fanen **Interesser**.

1. I redigeringsmodus velger du interesser ved å merke de relevante boksene. Hvilke interesser som er tilgjengelige, defineres i **Innstillinger og vedlikehold**.

    > [!NOTE]
    > Når fanen er i visningsmodus, vises kun de merkede interessene. I redigeringsmodus kan det være flere tilgjengelige alternativer.

1. Hvis du velger én eller flere interesser, vises det en prikk ved siden av fanens navn.

    ![Fanen Interesser med avmerkingsbokser for valg av interesser. -screenshot][img2]

1. Klikk **Lagre** for å lagre de valgte interessene.

## Aktuelle emner

* [Legge til oppføring som favoritt][4]
* [Dialogboksen Preferanser][3] – standardverdier for felt og lister

<!-- Referenced links -->
[1]: https://community.superoffice.com/globalassets/user--admin/learning/user-guide/company--contact/add-company.mp4
[2]: ../../learn/basics/duplicates.md
[3]: ../../learn/getting-started/preferences.md
[4]: ../../learn/basics/fav.md
[5]: ../../learn/basics/notes.md
[9]: ../../ui/screen-designer/learn/index.md
[12]: ../../custom-objects/learn/more-tab.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/new-company.png
[img2]: ../../../media/loc/en/company/interests.png
