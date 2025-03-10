---
uid: help-da-contact-create
title: Opret en ny person
description: Sådan opretter du en ny person i SuperOffice CRM.
keywords: opret person, tilføj interesse, fanen Interesser, kontaktbillede, foretrukket sprog, retsgrundlag, person
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opret en ny person

Du kan tilføje en person i SuperOffice CRM på flere måder:

* Fra **toplinjen** eller **skærmbilledet Firma** (trin nedenfor).
* [Scan et visitkort][1] ved hjælp af SuperOffice Mobile CRM-appen.
* [Masseimportér personer][2] (kræver administratorrettigheder).

## Trin

1. **Åbn skærmbilledet Person**:

    * Klik på **Ny** i **toplinjen**, og vælg **Person**.
    * Eller gå til det ønskede firma i **skærmbilledet Firma**, vælg detaljekortet **Personer**, og klik på knappen **Tilføj**.

1. **Indtast personens grundlæggende oplysninger**:

    * Indtast **Fornavn** og/eller **Efternavn** (obligatorisk: mindst ét af felterne skal udfyldes).
    * Valgfrit: Vælg titulering (***Hr/Fr***).
    * Vælg **Firma**:
      * Begynd at skrive for at søge efter et firma, eller vælg **(Ingen valgt)**, hvis personen ikke er tilknyttet et firma.
    * Valgfrit: Tilføj et **Personbillede** ved at trække en billedfil til billedfeltet eller højreklikke for at uploade et billede.

    ![Tomt personkort med obligatoriske felter markeret og valgfrie felter som titel og firma. -screenshot][img1]

1. Udfyld felterne i fanen **Person**.

    * Udfyld feltet **Land**. Dette opdaterer adresseformatet for det valgte land automatisk. Standardlandet er det land, som firmaet er registreret i.
    * Udfyld eventuelle yderligere felter som **Mobilnummer** og **E-mail**.

1. Tilføj yderligere oplysninger i **fanen Detaljer** (valgfrit):

    * Indtast vigtige oplysninger som **Stilling**, **Fødselsdato** og **Foretrukket sprog**.
    * Tilføj personens kommunikationsoplysninger: **Websted**, **Chat** og **Internettelefon** (for eksempel Skype eller Microsoft Teams).
    * Hvis relevant, angiv serviceprioritet, og vælg en servicekontaktperson (kræver en SuperOffice Service- eller Customer Centre-licens).

    ![Fanen Detaljer med yderligere felter -screenshot][img2]

1. Gå til fanen **Interesser** for at angive interesser og abonnementer:

    * Marker afkrydsningsfelterne for relevante interesser (defineres i Indstillinger og vedligeholdelse).
    * Konfigurer **E-markedsføring/abonnement** for at administrere juridisk samtykke til e-mailkampagner.

1. **Gennemgå privatlivsindstillinger**:

    * Klik på **Retsgrundlag** nederst på personkortet for at [gennemgå eller opdatere GDPR-samtykke][7] og privatlivsoplysninger. Klik på **Luk**, når du er færdig.

1. **Marker som fratrådt** (valgfrit):

    * Marker **Fratrådt**, hvis personen ikke længere arbejder i firmaet. Fratrådte personer vises ikke i lister over personer eller projektdeltagere.

1. Klik på **Gem** for at gemme personens oplysninger.

Personoplysningerne gemmes derefter i databasen og vises på personkortet. Hvis personen er knyttet til et firma, vises de også i fanen **Personer** i skærmbilledet Firma.

## <a id="fields"></a>Vigtige felter forklaret

Følgende felter er tilgængelige i personkortet. Nogle felter udfyldes automatisk, mens andre kræver input.

> [!NOTE]
> Felter og layout kan variere afhængigt af konfigurationer i [Skærmdesigner][9] og andre UI-tilpasninger.

<!-- markdownlint-disable-file MD051 -->
### [Fanen Person](#tab/contacts)

**Grundlæggende oplysninger:**

* **Fornavn** / **Efternavn**: Mindst ét af disse felter skal udfyldes (obligatorisk).
* **Titulering**: Valgfrit. Vælg **Hr/Fr** afhængigt af personens præference.
* **Titel**: Angiv personens jobtitel eller stilling.

**Kontaktoplysninger:**

* **E-mail**: Tilføj flere e-mailadresser med beskrivelser, såsom *Arbejde* eller *Privat*.
* **Mobil** / **Direkte telefon**: Tilføj flere telefonnumre med etiketter, såsom *Mobil* eller *Arbejde*.
  * Tryk på **TAB** eller klik uden for tabellen for at gemme indtastningerne.

**Adresse:**

* **Privat adresse**: Udfyld personens adresseoplysninger.
  * Adresseformatet opdateres automatisk baseret på feltet **Land**.
* **Land**: Angiver personens land. Standardværdien er firmaets registrerede land.
* **Brug som postadresse**: Markér dette felt, hvis du vil sende post direkte til personens adresse i stedet for firmaets adresse.

**Arvede felter:**

* **Vores kontakt**: Tildeles automatisk dit navn. Klik på pilen for at vælge en anden person fra din organisation.
* **Kategori**: Vælg en kategori fra en foruddefineret liste. Standardværdien er firmaets kategori, hvis personen er tilknyttet et firma.
* **Branche**: Vælg den relevante branchetype. Standardværdien er firmaets branche, hvis personen er tilknyttet et firma.

**Systemfelter:**

* **Nummer**: Genereres automatisk som det næste ledige personnummer, hvis dette er konfigureret i **Indstillinger og vedligeholdelse**. Du kan redigere dette manuelt om nødvendigt.

[!include[3 udef](../../learn/includes/more-udef.md)]

### [Fanen Detaljer](#tab/details)

**Personlige oplysninger:**

* **Stilling:** Vælg personens stilling fra en foruddefineret liste (konfigureret i Indstillinger og vedligeholdelse).
* **Fødselsdato:** Tilføj personens fødselsdato.

**Kommunikationsoplysninger:**

* **Websted:** Indtast en URL til personens hjemmeside, LinkedIn, Facebook eller andre sider. Tilføj en titel for tydelighed.
* **Chat**: Tilføj chatapplikationer (såsom Microsoft Teams, Google Chat). Vælg en tjenesteudbyder fra listen.
* **Internettelefon:** Tilføj en VOIP-adresse, såsom Skype eller en anden internetbaseret telefontjeneste.
* **Direkte fax:** Indtast personens faxnummer.

**Service-specifikke felter** *(kræver SuperOffice Service eller Customer Centre-licens)*

* **Foretrukket sprog:** Vælg personens foretrukne sprog for alle svarskabeloner.
* **Tjenesteprioritet:** Angiv prioriteten for nye sager (for eksempel Lav, Middel, Høj eller brugerdefineret). Hvis ikke angivet, arves firmaets prioritet.
* **Vores servicekontakt:** Vælg en servicekontaktperson, der skal håndtere denne persons anmodninger.

**Private felter:**

* **Privat:** Tilføj private telefonnumre eller kontaktoplysninger, der ikke er knyttet til firmaet.

### [Fanen Mere](#tab/more)

Indtast eventuelle [brugerdefinerede felter][12], der er specifikke for din CRM-opsætning.

### [Fanen Interesser](#tab/interests)

**Interesser og abonnementer:**

* **Interesser**: Vælg personens interesser ved at markere de relevante afkrydsningsfelter. Interesser bruges til at oprette målrettede udvalg, f.eks. til udsendelser eller kampagner.

  * Interesser er foruddefinerede i **Indstillinger og vedligeholdelse**.
  * En prik vises ud for fanen **Interesser**, når én eller flere interesser er valgt.

* **E-markedsføring/abonnement**: Administrer samtykke til at sende e-mailkampagner.

  * Hvis personen har givet samtykke, skal du aktivere **E-markedsføring** for at bekræfte juridisk samtykke til at sende udsendelser. Dette sætter automatisk retsgrundlaget til **Berettiget interesse**.
  * Angiv abonnementsmuligheder for at specificere, hvilke typer e-markedsføring personen accepterer at modtage.
  * Abonnementsindstillinger kan også justeres af personen via en kundeportal.

### [Fanen Bemærkning](#tab/note)

[Tilføj fritekstnoter][5] om personen.

***

## <a id="interests-tab"></a>Tilføj interesser

Interesser er nyttige til at oprette målrettede udvalg, f.eks. markedsføringskampagner for specifikke kundegrupper. For eksempel kan du definere *referencekunde* som en interesse og hurtigt oprette et udvalg af alle referencekunder.

1. Gå til fanen **Interesser**.

1. I redigeringstilstand skal du vælge relevante interesser ved at markere afkrydsningsfelterne. De tilgængelige interesser defineres i **Indstillinger og vedligeholdelse**.

1. Hvis du vælger én eller flere interesser, vises en prik ud for fanens navn.

1. Klik på **Gem** for at gemme ændringerne.

## Tips

* Du kan tilføje flere telefonnumre, e-mailadresser og andre poster med beskrivelser (for eksempel *Omstilling*).

    Hvis du klikker på personens e-mailadresse i fanen **Person**, kan du vælge den ønskede e-mailadresse i listen, der vises. En tom e-mailmeddelelse åbnes, hvor e-mailadressen er indsat i **Til**-feltet.

* Brug telefonikonet til at ringe direkte, hvis dit system er konfigureret til det.

* Hvis personen er tilknyttet et firma, arver felter som **Kategori**, **Branche** og **Vores kontakt** firmaets værdier og kan ikke redigeres.

* Gå til [detaljekortet Relationer][8] for at knytte denne person til andre firmaer eller personer.

## Relateret indhold

* [Tilføj person som foretrukken][4]
* [Scan et visitkort][1]

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
