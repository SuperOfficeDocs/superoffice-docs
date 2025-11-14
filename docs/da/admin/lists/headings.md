---
uid: help-da-list-headings
title: Listeoverskrifter
description: Brug overskrifter til at gruppere elementer i lange lister i Indstillinger og vedligeholdelse.
keywords: overskrift, organisere liste
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from:
  - /da/admin/lists/learn/organize/index
  - /da/admin/lists/learn/organize/headings
  - /da/admin/lists/learn/organize/adding-headings
  - /da/admin/lists/learn/organize/headings-editing-and-deleting
  - /da/admin/lists/learn/organize/grouping-items-under-headings
language: da
---

# Listeoverskrifter

Listeelementer kan vises på to niveauer. Det højere niveau kaldes elementets **overskrift**. En overskrift indeholder grupper af elementer, som kan vises under det valgte element i SuperOffice CRM. De samme elementer kan vises under flere overskrifter.

Listen **Overskrifter** (nederst til højre på skærmbilledet **Lister**) viser, hvilke overskrifter de enkelte elementer vises under. Du kan også gå til fanen **Overskrifter** for at se, hvilke elementer der vises under en bestemt overskrift.

## Hvornår er det en god idé at bruge overskrifter i lister?

Hvis en liste er meget lang (indeholder mange elementer), kan du bruge overskrifter til at gruppere elementerne logisk. For eksempel er elementerne i listen **Dokumentskabeloner** grupperet under overskrifterne **Brev**, **Fax**, **E-mail** og så videre.

## Arbejde med overskrifter i lister

For at administrere overskrifter skal du åbne skærmbilledet **Lister** og vælge den ønskede liste fra dropdown-menuen i øverste venstre hjørne.

> [!NOTE]
> Overskrifter er kun tilgængelige for lister, hvor **Brug gruppering og brugergruppefiltrering for denne liste** er aktiveret (afkrydsningsfelt øverst til højre).
>
> Grupperingsfunktionen er ikke tilgængelig for visse foruddefinerede lister (for eksempel **Generelt – Brugergruppe**). Hvis en liste ikke understøtter gruppering, vil afkrydsningsfeltet være deaktiveret.

Der er to måder at knytte overskrifter til listeelementer:

* **Fra fanen Elementer**: Vælg et element og tildel en eller flere overskrifter fra panelet **Overskrifter**.
* **Fra fanen Overskrifter**: Vælg en overskrift og angiv, hvilke elementer der skal vises under den.

Du kan også tilføje, redigere eller slette overskrifter efter behov.

## <a id="add"></a>Tilføj en overskrift

Før du kan knytte en overskrift til et element, skal du tilføje de nødvendige overskrifter.

1. Gå til fanen **Overskrifter**.

1. Klik på **Tilføj** under listen **Overskrifter**.

1. Indtast det ønskede navn på overskriften *(obligatorisk)* og en beskrivelse *(valgfri)*.

    * Feltet **Beskrivelse** kan bruges til at forklare formålet med overskriften og kan vises som tooltiptekst i brugergrænsefladen.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

Overskriften føjes til listen **Overskrifter**. Gentag processen for at tilføje flere overskrifter.

Når du har tilføjet overskrifterne, kan du [vælge, hvilke overskrifter hvert element skal vises under](#group).

## <a id="group"></a>Gruppér elementer under overskrifter

Hvis du vil bruge to niveauer i en liste, skal du vælge overskrifter for hvert element i listen **Elementer**. Alternativt kan du bruge fanen **Overskrifter** til at angive, hvilke elementer der hører til hver overskrift.

> [!NOTE]
> Listen skal indeholde et minimumsantal elementer for at kunne vises med overskrifter. Dette antal defineres i [Præferencer][3].

### Vælg overskrifter for et listeelement

Eventuelle overskrifter, der allerede er defineret for den valgte liste, vises i panelet **Overskrifter** nederst til højre. Hvis feltet er tomt, skal du [tilføje overskrifter først](#add).

1. Vælg det ønskede element på listen **Elementer**.
1. Marker afkrydsningsfeltet ud for den relevante overskrift i listen **Overskrifter**. Boksen markeres med et flueben (<i class="ph ph-check" aria-hidden="true"></i>), og elementet vises under denne overskrift.
    Ændringerne gemmes automatisk.

> [!TIP]
> Du kan vælge flere overskrifter for det samme element.

### Vælg elementer til en overskrift

1. Gå til fanen **Overskrifter**.

1. Vælg en overskrift på listen.

1. I listen **Elementer under denne overskrift** skal du klikke på feltet ud for hvert element, der skal vises under den valgte overskrift.

1. Gentag for hver overskrift.

    Ændringerne gemmes automatisk.

## <a id="update"></a>Rediger overskrifter

Du redigerer en overskrift ved at dobbeltklikke på den relevante overskrift i listen **Overskrifter** og ændre oplysningerne.

## Slet overskrifter

Du sletter overskrifter ved at markere den relevante overskrift og klikke på **Slet**.

> [!NOTE]
> Sletning af en overskrift fjerner **ikke** de tilknyttede listeelementer. Du kan [gendanne slettede overskrifter][2].

<!-- Refererede links -->
[2]: restore.md
[3]: ../preferences/index.md
