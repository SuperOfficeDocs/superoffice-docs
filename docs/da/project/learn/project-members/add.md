---
uid: help-da-project-member-add
title: Tilføj projektdeltagere
description: Sådan tilføjer du en projektdeltager i SuperOffice
keywords: tilføj projektdeltager, ny projektdeltager, dialogboksen Tilføj/rediger projektdeltagere, projektdeltager, projekt
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Tilføj projektdeltagere

For at knytte et projekt til en firma skal mindst én projektdeltager specificeres. Dette kan gøres på Projektskærmen eller [via detaljekorterne](#from-section-tab) for personer i Firma-, Udvalg- eller Salgsskærmene.

Når du tilføjer deltagere til et projekt, kan du tildele funktioner individuelt, mens du tilføjer personer/firmaer, tildele funktioner efterfølgende, eller bruge en kombination af begge metoder.

## Trin

1. Åbn projektet (se [Brug skærmbilledet Søg][1]) og gå til detaljekortet **Projektdeltagere**.

1. Klik på **Tilføj** under detaljekortet. Dialogen **Tilføj/rediger projektdeltagere** åbnes.

1. Klik på listen **Firma/person** for at tilføje deltagere. Du har flere muligheder:

    * **Søg**: Skriv mindst to tegn for at søge efter en person eller firma.

    * **Historik/Favoritter**: Vælg fra historiklisten eller favoritter.

      ![Tilføj/rediger projektdeltagere dialog, historik -screenshot][img5]

    * **Brugergruppe**: Klik på <i class="ph ph-users" aria-label="Associate icon"></i> for at gennemse medarbejdere efter gruppe.

      ![Tilføj/rediger projektdeltagere dialog, gruppe -screenshot][img6]

    * **Firma**: Klik på <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> for at gennemse personer i en firma eller tilføje en firma som deltager.

      ![Tilføj/rediger projektdeltagere dialog, firma -screenshot][img7]

1. **Tildel funktioner**: Vælg en projektdeltager og tildel en funktion. For at tildele samme funktion til flere deltagere på én gang, brug **Mærk alle** eller hold **Ctrl/Shift** nede, mens du vælger.

    ![Tilføj/rediger projektdeltagere dialog, funktion -screenshot][img8]

    Valgfrit: Tilføj en kommentar for at beskrive projektdeltagerens funktion i mere detalje.

1. Klik på **OK**.

## <a id="from-section-tab"></a>Tilføj projektdeltagere og interessenter fra detaljekort

Du kan tilføje projektdeltagere og interessenter fra personoversigterne på forskellige detaljekort, for eksempel **Firma** (**Personer**), **Udvalg** (**Firma/person**), **Salg** (**Interessenter**) og **Projekter** (**Projektdeltagere**). Nedenstående fremgangsmåde kan således også udføres fra fanen **Resultat** i skærmbilledet [Søg][1].

**Trin:**

1. Gå til den ønskede fane eller til skærmbilledet **Søg**.

2. Vælg den ønskede person på listen.

    > [!NOTE]
    > Hvis du vil tilføje flere personer som interessenter/projektdeltagere, skal du bruge **Shift** eller **Ctrl** + klik.

3. Højreklik på personerne, og vælg **Tilføj til salg** eller **Tilføj til projekt** i den menu, der vises.

4. I feltet **Salg** eller **Projekt** angiver du, hvilket salg/projekt firmaet skal tilføjes til. Gør dette enten ved at klikke på pilen og vælge det nødvendige salg/projekt på den viste liste eller ved at skrive hele eller begyndelsen af salgs-/projektnavnet.

5. I feltet **Salgsrolle** eller **Funktion** angiver du, hvilken salgsrolle/funktion hver af personerne har i salget/projektet. Hvis du klikker på pilen, åbnes en liste over de foruddefinerede valgmuligheder.

6. Klik på **Gem**.

## Fejlfinding

* **Manglende person:** Hvis en person ikke er opført, skal du først [oprette personen][3].

* **Manglende roller:** Tilgængelige [funktioner][5] defineres i Indstillinger og Vedligeholdelse.

## Tips

* **Tilføj kommentarer**

    Hvis der er tilføjet en kommentar, vises der et papirclip (<i class="ph ph-paperclip" aria-hidden="true"></i>) ved siden af kolonnen **Projektdeltagerinformation** i detaljekortet **Projektdeltagere**. Hold musen over clipsen for at se kommentartipset.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[3]: ../../../contact/learn/create.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/project/add-project-member-from-history.png
[img6]: ../../../../media/loc/en/project/add-project-member-from-group.png
[img7]: ../../../../media/loc/en/project/add-project-member-from-company.png
[img8]: ../../../../media/loc/en/project/set-project-member-function.png
