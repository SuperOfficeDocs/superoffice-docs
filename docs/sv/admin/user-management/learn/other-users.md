---
uid: help-sv-user-other
title: Hantera andra användare
description: Hantera anonyma användare och systemanvändare (lokalt)
author: Bergfrid
date: 03.15.2023
keywords: user, anonym, systemanvändare
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
envir: onsite
---

# Hantera anonyma användare och systemanvändare (lokalt)

* **Systemanvändare**: [!include[Access rights](includes/def-system-user.md)]
* **Anonym**: [!include[Access rights](includes/def-anon-user.md)]

> [!NOTE]
> Anonyma användare och systemanvändare kräver systemlicens för **SuperOffice Expander Services**. [Läs mer][1].

## Lägg till anonym användare eller systemanvändare

1. [!include[Click Users](includes/goto-users.md)]

2. [!include[Select Other users](includes/select-other-users.md)]

3. Klicka på **Lägg till** under listan.

4. Ange ett ID i fältet **Användar-ID**.

5. I fältet **Lösenord** anger du ett lösenord för användaren om det krävs.

6. Lägg eventuellt till en beskrivning av användaren i rutan **Beskrivning**.

7. Välj **Typ**: **Systemanvändare** eller **Anonym**

8. **Välj**Aktiv**till höger om**Inloggning för att aktivera användaren.

9. Klicka på **Spara**. Användaren läggs till i listan.

## Redigera anonym användare eller systemanvändare

1. [!include[Click Users](includes/goto-users.md)]

2. [!include[Select Other users](includes/select-other-users.md)]

3. Dubbelklicka på den användare du vill redigera i listan.

4. Gör önskade ändringar i dialogrutan som visas.

5. Klicka på **Spara** för att avsluta.

## Ändra inloggningsbehörighet för andra användare

Om en anonym användare eller systemanvändare inte längre ska kunna logga in i systemet kan du ta bort användarens inloggningsbehörigheter. Den externa användaren tas inte bort, men definieras som inaktiv och kan alltid återaktiveras vid behov.

### Inaktivera en användare

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Välj den aktiva användare som du vill ta bort inloggningsbehörigheterna för i listan och klicka på **Ta bort inloggning** under listan.

    Användaren kan då inte längre logga in i systemet.

### Aktivera en användare

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Dubbelklicka på den användare du vill aktivera i listan.
4. Välj **Aktiv** till höger om **Inloggning** för att aktivera användaren.
5. Klicka på **Spara**. Användaren kan nu logga in i systemet.

## Ta bort anonyma användare eller systemanvändare

1. [!include[Click Users](includes/goto-users.md)]
2. [!include[Select Other users](includes/select-other-users.md)]
3. Markera den användare du vill ta bort.
4. Klicka på knappen **Ta bort**. Användaren tas bort från listan.

<!-- Referenced links -->
[1]: ../../../../en/admin/license/expander-services/index.md

<!-- Referenced images -->
