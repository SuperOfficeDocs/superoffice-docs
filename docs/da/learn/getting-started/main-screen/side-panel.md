---
uid: help-da-ui-side-panel
title: Brug sidepanelet til at arbejde mere effektivt
description: Sidepanelet giver dig adgang til oplysninger, der er gemt i andre dele af SuperOffice CRM, uden at forlade den skærm, du er på.
keywords: sidepanel
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Sidepanelet

**Sidepanelet** er et multifunktionelt værktøj placeret i højre side af alle skærmbilleder i SuperOffice CRM (undtagen Indbakken). Det giver hurtig adgang til relevante oplysninger og supplerer hovedskærmbilledet.

Brug det til at administrere opgaver, få overblik eller følge op på aktiviteter, salg eller personer. Indholdet i panelet tilpasser sig afhængigt af det aktive skærmbillede, og det husker din seneste visning for hver skærm.

![Sidepanelet vises i højre side af SuperOffice CRM -screenshot][img10]

> [!TIP]
> Du kan minimere sidepanelet for at få mere plads ved at klikke på <i class="ph ph-sidebar-simple" aria-label="Sidebar ikon"></i> i øverste højre hjørne.

## Skift visning i sidepanelet

Som standard viser sidepanelet en forhåndsvisning af den valgte post. Du kan skifte mellem forskellige visninger for at se de oplysninger, der er mest relevante for din opgave.

For eksempel kan du vise månedskalenderen, mens du ser dagskalenderen i skærmbilledet **Dagbog** for et bedre overblik, eller du kan vise medlemmerne af et udvalg, der er tilknyttet et projekt, du ser på i skærmbilledet **Projekt**.

1. Klik på <i class="ph ph-caret-down" aria-label="Pil ned ikon"></i> ved siden af sidepanelets navn.

1. Vælg den ønskede visning fra listen.

> [!NOTE]
> Tilgængelige visninger afhænger af det aktive skærmbillede.

## Standardvisninger

Her er de mest almindelige visninger i sidepanelet, tilpasset det aktive skærmbillede.

> [!TIP]
> Hvis du hurtigt vil se andre poster uden at skifte skærmbillede, kan du klikke på pilen (<i class="ph ph-caret-down" aria-hidden="true"></i>) ved siden af postens navn i sidepanelet. Dette åbner [historiklisten][1], hvor du kan vælge en anden post.

### Forhåndsvisning (standard)

Viser en hurtig forhåndsvisning af valgte poster, såsom personer eller aktiviteter, med links til relaterede data. Klik på et link for at åbne den tilhørende dialog, f.eks. [Opfølgning][6] eller [Dokument][5].

### Kalenderoversigter

Hold styr på din kalender med disse visninger:

* **Dag:** Dagsplan. Samme som fanen **Dag** i [skærmbilledet Dagbog][4].
* **Næste dag:** Viser agendaen for i morgen.
* **Uge:** Ugeoversigt over opfølgninger.
* **Måned:** Månedskalender med infobokse for aktiviteter og en "bar" indikator for daglig arbejdsbyrde. Udvid sidepanelet for at vise flere måneder.

Du kan navigere mellem datoer, uger eller måneder med knapperne **Forrige** og **Næste** (<i class="ph ph-caret-left" aria-hidden="true"></i><i class="ph ph-caret-right" aria-hidden="true"></i>) nederst i sidepanelet.

Hvis du er i **Dagbog**, vil navigering i sidepanelet automatisk opdatere Dagbog-visningen, og omvendt.

> [!NOTE]
> Du kan kun se din egen dagbog i sidepanelet. Brug **Dagbog**-skærmbilledet for at se andres kalendere.

### Firma

Viser en oversigt over det aktuelle firma i skærmbilledet **Firma**.

### Person

Viser detaljer om den markerede person i skærmbilledet **Firma** eller **Udvalg**.

Klik på personens navn for at åbne [personkortet][2].

### Mine foretrukne

Viser alle dine [foretrukne][8].

* Marker afkrydsningsfeltet i bunden for kun at vise foretrukne for det aktive skærmbillede (f.eks. **Kun salg** i skærmbilledet Salg).
* Fjern elementer ved at markere dem og klikke på **Fjern**.
* Klik på <i class="ph ph-arrow-clockwise" aria-label="Opdater"></i> for at opdatere listen.
* Højreklik på en favorit for at åbne genvejsmenuen.

### Projekt

Viser en oversigt over det aktuelle projekt i skærmbilledet **Projekt**.

### Projektdeltagere

Viser en liste over deltagere i det aktuelle projekt i skærmbilledet **Projekt**.

Dobbeltklik på et navn for at åbne [personkortet][2].

### Salg

Viser en oversigt over det aktuelle salg i skærmbilledet **Salg**.

### Udvalg

Viser en oversigt over det aktuelle udvalg i skærmbilledet **Udvalg**.

### Udvalgsmedlemmer

Viser en liste over medlemmer i det aktuelle udvalg i skærmbilledet **Udvalg**.

## Brugerdefinerede visninger

Administratorer kan definere tilpassede visninger for sidepanelet i **Indstillinger og vedligeholdelse**, så det passer til teamets behov.

## Ofte stillede spørgsmål og tips

* Fastgør ofte brugte sidepaneler øverst på listen ved at klikke på **stjerneikonet**.

    ![Eksempel på fastgjorte sidepaneler -screenshot][img1]

* **Hvorfor er sidepanelet tomt?**

  Hvis ingen person er angivet (f.eks. i et dynamisk udvalg uden **Medtag den primære person**), vil oversigten **Personer** i sidepanelet ikke vise nogen oplysninger.

* **Hvorfor ser jeg "Dokument lukket" i sidepanelet?**

  Dette skyldes optimering af systemressourcer, når du bruger InfoBridge Document Viewer. For at se dokumentet igen, gå tilbage til dokumentfanen og vælg det igen. Læs mere i [denne supportartikel][11].

* **Hvordan bruger jeg sidepanelet effektivt til salg?**

  Brug det til at spore salgsmuligheder, overvåge forfaldne aktiviteter og følge op på tilbud uden at skifte skærmbillede. Læs mere i [Sådan bruger du sidepanelet til salg][10].

<!-- Referenced links -->
[1]: ../../basics/history.md
[2]: ../../../contact/learn/create.md
[4]: ../../../diary/learn/index.md
[5]: ../../../document/learn/create.md#fields
[6]: ../../../diary/learn/create-follow-up.md
[8]: ../../basics/fav.md
[11]: https://community.superoffice.com/en/support-faqs/faq/what-to-do-when-i-get-document-closed-in-the-side-panel-of-superoffice-crm-when-document-viewer-is-used/
[10]: ../../../sale/learn/index.md#side-panel

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/learn/pin-side-panel-favs.png
[img10]: ../../../../media/loc/en/learn/getstarted-sidepanel-companypreview.png
