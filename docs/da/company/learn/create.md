---
uid: help-da-company-create
title: Opret et nyt firma
description: Opret et nyt firma
keywords: opret firma, tilføj interesse, fanen Interesser, firma
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Opret et nyt firma

I **Firmaskærmbilledet** kan du oprette og administrere firmaoplysninger, herunder tilpassede felter og yderligere data. Se denne [videovejledning om, hvordan du opretter et firma][1].

## Trin til at oprette et firma

1. Klik på **Ny** i toplinjen, og vælg **Firma**.

2. I fanen **Firma**:
    * Indtast **Firmanavn** (obligatorisk, markeret med rød tekst).
    * Udfyld feltet **Land**. Adresseformatet for det valgte land opdateres automatisk. Dit hjemland vælges som standard baseret på dine præferencer. Du kan ændre dette under **Personlige indstillinger** > **Præferencer** > **System**.
    * Udfyld andre felter efter behov, såsom **Postnummer**, **Telefon**, **E-mail** og **Websted**.

    ![Tomt firmakort med obligatoriske og valgfrie felter. -screenshot][img1]

3. Vælg en kategori og en branchetype i felterne **Kategori** og **Branche**. Begge felter er obligatoriske for at gemme posten.

4. (Valgfrit) Tilføj flere oplysninger:
    * Gå til fanen **Mere** for at [indtaste brugerdefinerede felter][12].
    * Gå til fanen **Interesser** for at [tilføje interesser](#interests-tab).
    * Gå til fanen **Notat** for at [tilføje noter][5].

5. Klik på **Gem** for at sikre, at alle oplysninger gemmes.

## <a id="fields"></a>Vigtige felter forklaret

Følgende felter er tilgængelige på firmakortet. Nogle felter udfyldes automatisk, mens andre kræver manuel indtastning.

> [!NOTE]
> Felter og layout kan variere afhængigt af [Skærmdesign][9]-konfigurationer og andre brugerdefinerede tilpasninger.

* **Afdeling:** Angiv en afdeling, hvis firmaet har flere afdelinger eller divisioner.
* **Adressefelter:** Tilpasses automatisk baseret på det valgte land.
* **Postnummer og by:** Hvis du indtaster et postnummer, der findes i SuperOffice-databasen, udfyldes bynavnet automatisk. Du kan også indtaste bynavnet manuelt, hvorefter et postnummer foreslås.
* **Telefon/Fax/E-mail/Websted:** Indtast flere poster med beskrivelser, som f.eks. *Omstilling*. Klik uden for tabellen eller tryk på TAB for at lukke indtastningsfeltet.
* **Vores kontakt:** Dit navn tildeles automatisk. Klik på pilen for at vælge en anden person fra din organisation.
* **Hovedkontakt:** Vælg den person, der skal være hovedkontakt for firmaet. Personer skal først tilføjes til firmaet, før de kan vælges.
* **Kode:** Genereres automatisk efter, at firmaet er gemt. Koden er baseret på firmanavnet, men kan redigeres manuelt.
* **Nummer:** Tildeler automatisk næste ledige firmanummer. Standard startnummer er 10001 og øges med 1 for hvert nyt firma. Denne indstilling kan ændres i **Indstillinger og vedligeholdelse**.
* **CVR-nummer:** Indtast firmaets CVR-nummer eller tilsvarende identifikationsnummer.
* **Stop** og **Ingen udsendelser**-afkrydsningsfelter:
  * **Stop:** Angiver, at firmaet kræver særlig opmærksomhed. Hvis du vælger **Stop**, vises et stopskilt på firmakortet. Du kan også tilføje en bemærkning, der forklarer, hvorfor firmaet er markeret. Kun tilgængelig i redigeringstilstand.
  * **Ingen udsendelser:** Forhindrer, at firmaet modtager direkte markedsføringsmateriale.

[!include[3 udef](../../learn/includes/more-udef.md)]

## Dubletregistrering

Hvis du indtaster et firma, der ligner et, der allerede findes i SuperOffice CRM, vises dialogboksen **Dubletter**. Dette hjælper med at forhindre [utilsigtet registrering af et eksisterende firma][2].

* Gennemgå de foreslåede dubletter for at opretholde datakonsistens og undgå unødvendige poster.
* Vælg, om du vil fortsætte med at oprette det nye firma, eller om du vil skifte til et af de eksisterende firmaer på listen.

## <a id="interests-tab"></a>Tilføj interesser

Interesser kan hjælpe dig med at oprette målrettede udvalg. For eksempel kan du definere *referencekunde* som en interesse og opbygge et udvalg til markedsføringskampagner rettet mod denne kundegruppe.

1. Gå til fanen **Interesser**.

2. I redigeringstilstand skal du markere relevante afkrydsningsfelter. De tilgængelige interesser defineres i **Indstillinger og vedligeholdelse**.

    > [!NOTE]
    > Når fanen er i visningstilstand, vises kun de valgte interesser. I redigeringstilstand kan der være yderligere muligheder.

3. Hvis du vælger én eller flere interesser, vises der en prik ud for fanens navn.

    ![Fanen Interesser med afkrydsningsfelter til valg af firmaets interesser. -screenshot][img2]

4. Klik på **Gem** for at gemme de valgte interesser.

## Relateret indhold

* [Tilføj firma som foretrukken][4]
* [Præferencer-dialog][3] – standardfeltværdier og listeværdier

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
