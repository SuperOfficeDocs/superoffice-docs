---
uid: help-da-mailing-recipient-list
title: Arbejde med modtagerlisten efter udsendelsen
description: Arbejde med modtagerlisten efter udsendelsen
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Marketing, modtager
so.topic: howto
language: da
---

# Se på modtagerlisten efter mailudsendelsen

Når din mail er sendt ud, er det altid spændende at se, hvor godt den klarede sig. Det er også en fantastisk mulighed for at kontrollere og forbedre kvaliteten af de oplysninger, der er registreret i din database. Især antallet af afviste e-mails er en nøgleindikator. I denne vejledning får du flere oplysninger om, hvordan du filtrerer listen over modtagere.

De første par gange, du sendte din mail ud, fik du måske et stort antal afviste e-mails tilbage. Det er gode nyheder, for det betyder, at du kan opdatere alle e-mailadresser, der er stavet forkert eller ikke længere er i brug.

Ved at opdatere afviste e-mailadresser kan du øge succesraten for dine fremtidige mailudsendelser.

Når mailen er sendt ud, indsamler SuperOffice Marketing data om status for hver enkelt afsendt e-mail. I fanen Modtagere kan du se status for hver modtager af mailen. Du kan også filtrere listen og eksportere resultaterne til udvalg og projekter for at arbejde videre med dem i SuperOffice CRM.

![Du kan se status for mailudsendelsen i feltet Status -screenshot][img4]

## Trin

1. Klik på mailudsendelsen i fanen **Udsendelser**.

2. På skærmbilledet **Vis udsendelse** skal du klikke på **fanen Modtagere**.

    Listen viser de første 100 modtagere. Klik på ![ikonet][img1] for at få vist de næste 100.

3. [Filtrér listen](#filters)ved hjælp af afkrydsningsfelterne nederst på listen.

    Som standard er alle filtre aktive og viser alle modtagere. Fjern markeringen i filtreringsfelt for at deaktivere filteret. Flere filtre kan kombineres.

4. Brug afkrydsningsfelterne i venstre kolonne til at vælge alle eller bestemte modtagere.

5. Klik på ![ikonet][img2] for menuknap. Her har du følgende alternativer:
    * Eksportér de valgte modtagere eksport til en Excel-, HTML- eller tekstfil.
    * Tilføj de valgte modtagere til et nyt eller eksisterende udvalg eller projekt.
    * Send igen udsendelsen til de valgte modtagere.

6. Klik på **Luk** for at lukke skærmbilledet **Vis udsendelse** .

Hvis status er **Klar til at blive sendt**, behøver du ikke gøre noget. SuperOffice sender din e-mail til modtagerne. Status ændres til **Sendt,** når dette er gjort.

## <a id="filters" />Filtre

* **Sendt**: Aktiver dette filter for at vise alle modtagere, som udsendelsen blev sendt til.

* **Returneret**: Aktivér dette filter for at vise alle modtagere, hvor [mailudsendelsen blev returneret uden at blive leveret][3]. Det kan skyldes fejl i e-mailadresser, spamfiltre, problemer med internettet, eller at modtagerens indbakke er fuld.

  * Midlertidige problemer: leveringsforsinkelser, e-mail-server midlertidigt utilgængelig
  * Permanente problemer: forkert adresse, ukendt domæne. I sidstnævnte tilfælde bør du tilføje modtagerne til et nyt udvalg og forsøge at finde årsagen til problemet.

* **Læst af modtager**: Klik på dette filter for at vise alle modtagere, som har åbnet/læst mailudsendelsen.

* **Klar til afsendelse**: Aktiver dette filter for at vise alle modtagere, som udsendelsen endnu ikke er afsendt til.

* **Blokeret**: Aktivér dette filter for at få vist følgende modtagere:

* Modtager, der ikke har givet sit samtykke til at blive kontaktet.
* Dupliker modtagere.
* Modtagere uden abonnement.

**Modtager klagede**: Aktivér dette filter for at få vist modtagere, der har rapporteret udsendelsen som spam/uønsket mail.

Hvis status er **Klar til afsendelse**, behøver du ikke gøre noget. SuperOffice sender din e-mail til modtagerne. Status ændres til **Sendt**, når det er gjort.

<!-- markdownlint-disable-next-line MD013 -->
## <a id="add-recipients-to-selections-or-projects" />Tilføj modtagere til udvalg eller projekter

Ved at bruge ![ikonet][img2] menuknappen kan du tilføje modtagere og klikkere til et udvalg eller projekt.

> [!NOTE]
> Kun personer, der allerede er registreret i SuperOffice-databasen, vil blive tilføjet til udvalget eller projektet. ![Ikonet][img3] Kontaktikon i kolonnen **Type** angiver, at kontakten er registreret i SuperOffice-databasen. Modtagere der er importeret fra eksterne lister vil normalt ikke blive registreret.

### Tilføje klikkere til ny markering eller projekt

[!include[How to](../../../learn/includes/howto-add-person-to-selection-new.md)]

### Tilføje klikkere til eksisterende markering eller projekt

[!include[How to](../../../learn/includes/howto-add-person-to-selection-existing.md)]

## Relaterede emner

* [Arbejde med sporede links efter udsendelsen][1]

<!-- Referenced links -->
[1]: ../../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/arrow-right.png
[img2]: ../../../../../media/icons/btn-menu.png
[img3]: ../../../../../../common/icons/nav-contact.png
[img4]: ../../../../../media/loc/en/marketing/recipients-tab-status.png
