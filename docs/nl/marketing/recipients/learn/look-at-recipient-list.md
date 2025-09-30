---
uid: help-nl-mailing-recipient-list
title: Werken met de ontvangerslijst na de mailing
description: Werken met de ontvangerslijst na de mailing
keywords: Marketing, ontvanger
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Bekijk de lijst met ontvangers na de mailing

Nadat uw mailing is verstuurd, is het altijd spannend om te zien hoe goed uw mailing heeft gepresteerd. Het is ook een geweldige kans om de kwaliteit van de informatie die in uw database is geregistreerd, te controleren en te verbeteren. Vooral het aantal teruggestuurde e-mails is een belangrijke indicator. Meer informatie over het filteren van uw lijst met ontvangers vindt u in deze handleiding.

Nadat de mailing is verzonden, verzamelt SuperOffice Marketing gegevens over de status van elke verzonden e-mail. Op het tabblad Ontvangers kunt u de status van elke ontvanger van de mailing weergeven. U kunt de lijst ook filteren en het resultaat exporteren naar selecties en projecten in SuperOffice CRM voor verdere verwerking.

![U kunt de status van de mailing zien in het veld Status -screenshot][img4]

## Stappen

1. Klik op de mailing in het tabblad **Mailings**.

2. Klik in het scherm **Mailing weergeven** op het tabblad **Ontvangers**.

    De lijst toont de 100 eerste ontvangers. Klik op <i class="ph ph-arrow-right" aria-label="Arrow right"></i> om de volgende 100 weer te geven.

3. [Filter de lijst](#filters) met de selectievakjes onder aan de lijst.

    Standaard zijn alle filters actief om alle ontvangers weer te geven. Schakel het selectievakje voor een filter uit om het filter te deactiveren. Er kunnen verschillende filters worden gecombineerd.

4. Gebruik de selectievakjes in de linkerkolom om alle of specifieke ontvangers te selecteren.

5. Klik op de menuknop **Acties**. U hebt hier de volgende opties:
    * De geselecteerde ontvangers naar een Excel-, HTML- of tekstbestand exporteren.
    * [De geselecteerde ontvangers toevoegen aan een nieuw(e) of bestaand(e) selectie of project](#add-recipients).
    * de mailing opnieuw verzenden naar de geselecteerde ontvangers.

6. Klik op **Sluiten** om het scherm **Mailing weergeven** te sluiten.

Als de status **Gereed voor verzending** is, hoeft u niets te doen. SuperOffice verzendt uw mailing naar de ontvangers. De status wordt gewijzigd in **Verzonden** nadat dit is voltooid.

## <a id="filters"></a>Filters

* **Verzonden**: Activeer dit filter om alle ontvangers weer te geven aan wie de mailing is gestuurd.

* **Geretourneerd**: Activeer dit filter om alle ontvangers weer te geven voor wie de [mailing is geretourneerd als niet-bezorgd][3]. Dit kan het gevolg zijn van e-mailadresfouten, spamfilters, problemen met internet of omdat postvakken vol zijn.

* **Gelezen door ontvanger**: Activeer dit filter om alle ontvangers weer te geven die de mailing hebben geopend/gelezen.

* **Gereed voor verzending**: Activeer dit filter om alle ontvangers weer te geven aan wie de mailing nog niet is gestuurd.

* **Geblokkeerd**: Activeer dit filter om de volgende ontvangers weer te geven:

* Ontvangers die nog geen toestemming hebben gegeven om te worden gecontacteerd
* Duplicaatontvangers
* [Ontvangers zonder abonnement][5]

**Ontvanger heeft geklaagd**: Activeer dit filter om ontvangers weer te geven die de mailing hebben gemeld als [spam/ongewenste e-mail][4].

Als de status **Gereed voor verzending** is, hoeft u niets te doen. SuperOffice verzendt uw mailing naar de ontvangers. De status wordt gewijzigd in **Verzonden** nadat dit is gebeurd.

<!-- markdownlint-disable-file MD013 -->
## <a id="add-recipients"></a>Ontvangers toevoegen aan selecties of projecten

Met de **Acties** menuknop kunt u ontvangers en klikkers toevoegen aan een selectie of project.

> [!NOTE]
> Alleen personen die al zijn geregistreerd in de database van SuperOffice, worden toegevoegd aan de selectie of het project. Een contactpictogram (<i class="ph ph-user-circle" aria-hidden="true"></i>) in de kolom **Type** geeft aan dat een persoon is geregistreerd in de database van SuperOffice. Ontvangers die zijn geïmporteerd vanaf externe lijsten, worden niet geregistreerd.

### Klikkers toevoegen aan een nieuw(e) selectie of project

1. Selecteer de desbetreffende personen in de lijst.
2. Klik op de menuknop **Acties**.
3. Klik op **Toevoegen aan nieuwe selectie** of **Toevoegen aan nieuw project**.
4. Voer de naam in van de nieuwe selectie of het nieuwe project.
5. Klik op **OK**.

### Klikkers toevoegen aan een bestaand(e) selectie of project

1. Selecteer de desbetreffende personen in de lijst.
2. Klik op de menuknop **Acties**.
3. Klik op **Toevoegen aan bestaande selectie** of **Toevoegen aan bestaand project**.
4. Zoek de naam van de selectie of het project in te voeren door het begin ervan in te voeren.
5. Klik op de selectie of het project in de lijst.
6. Klik op **OK**.

Open de selectie of het project om te controleren of de personen zijn toegevoegd.

## Gerelateerde inhoud

* [Werken met gevolgde koppelingen na de mailing][1]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/explore-clicks.md
[3]: manage-bounces.md
[4]: spam-complaints.md
[5]: manage-email-subscriptions.md

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/marketing/recipients-tab-status.png
